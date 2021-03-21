//=============================================================================
// Siemens AG
// (c)Copyright (2018) All Rights Reserved
//----------------------------------------------------------------------------- 
// Tested with: Windows 10 Enterprise x64
// Engineering: Visual Studio 2013
// Functionality: Wrapps up important classes/methods of the OPC UA .NET Stack to help
// with simple client implementations
//-----------------------------------------------------------------------------
// Change log table:
// Version Date Expert in charge Changes applied
// 01.00.00 31.08.2016 (Siemens) First released version
// 01.01.00 22.02.2017 (Siemens) Implements user authentication, SHA256 Cert, Basic256Rsa256 connection,
// Basic256Rsa256 connections, read/write structs/UDTs
// 01.02.00 14.12.2017 (Siemens) Implements method calling
// 01.03.00 27.11.2018 (Siemens) Updated UAClientHelperAPI V1.4, Improved endpoint handling
//=============================================================================


using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using Opc.Ua;
using Opc.Ua.Client;
using Siemens.UAClientHelper;

namespace UA_Client_1500
{
    public partial class UAClientForm : Form
    {
        /// <summary>
        /// Fields
        /// </summary>
        #region Fields
        private Session mySession;
        private List<Subscription> mySubscriptions = new List<Subscription>();
        private UAClientHelperAPI myClientHelperAPI;
        private EndpointDescription mySelectedEndpoint;
        private MonitoredItem myMonitoredItem;
        private List<String> myRegisteredNodeIdStrings;
        private ReferenceDescriptionCollection referenceDescriptionCollection;
        private ReferenceDescriptionCollection myReferenceDescriptionCollection;
        private List<string[]> myStructList;
        private UAClientCertForm myCertForm;

        private string heatingStartAnywayNodeId = "";
        private string heatingSpeedNodeId = "";
        private string coolingStartAnywayNodeId = "";
        private string coolingSpeedNodeId = "";
        private List<int> chartValues = new List<int>();
        private int numberOfPoints = 50;
        #endregion

        /// <summary>
        /// Form Construction
        /// </summary>
        #region Construction
        public UAClientForm()
        {
            InitializeComponent();
            myClientHelperAPI = new UAClientHelperAPI();
            myRegisteredNodeIdStrings = new List<String>();
            browsePage.Enabled = true;
            monitoringPage.Enabled = true;
            for(var i=0; i< numberOfPoints; i++) chartValues.Add(0); //initialize chart with zeroes
            this.updateChart(0.ToString());
        }
        #endregion

        /// <summary>
        /// Event handlers called by the UI
        /// </summary>,
        #region UserInteractionHandlers
        private void EndpointButton_Click(object sender, EventArgs e)
        {
            bool foundEndpoints = false;
            endpointListView.Items.Clear();
            //The local discovery URL for the discovery server
            string discoveryUrl = discoveryTextBox.Text;
            try
            {
                ApplicationDescriptionCollection servers = myClientHelperAPI.FindServers(discoveryUrl);
                foreach (ApplicationDescription ad in servers)
                {
                    foreach (string url in ad.DiscoveryUrls)
                    {

                        try
                        {
                            EndpointDescriptionCollection endpoints = myClientHelperAPI.GetEndpoints(url);
                            foundEndpoints = foundEndpoints || endpoints.Count > 0;
                            foreach (EndpointDescription ep in endpoints)
                            {
                                string securityPolicy = ep.SecurityPolicyUri.Remove(0, 42);
                                string key = "[" + ad.ApplicationName + "] " + " [" + ep.SecurityMode + "] " + " [" + securityPolicy + "] " + " [" + ep.EndpointUrl + "]";
                                if (!endpointListView.Items.ContainsKey(key))
                                {
                                    endpointListView.Items.Add(key, key, 0).Tag = ep;
                                }

                            }
                        }
                        catch (ServiceResultException sre)
                        {
                            //If an url in ad.DiscoveryUrls can not be reached, myClientHelperAPI will throw an Exception
                            MessageBox.Show(sre.Message, "Error");
                        }

                    }
                    if (!foundEndpoints)
                    {
                        MessageBox.Show("Could not get any Endpoints", "Error");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }   
        private void EpConnectButton_Click(object sender, EventArgs e)
        {
            //Check if sessions exists; If yes > delete subscriptions and disconnect
            if (mySession != null && !mySession.Disposed)
            {
                try
                {
                    //mySubscription.Delete(true);
                }
                catch
                {
                    ;
                }

                myClientHelperAPI.Disconnect();
                mySession = myClientHelperAPI.Session;

                ResetUI();
            }
            else
            {
                try
                {
                    //Register mandatory events (cert and keep alive)
                    myClientHelperAPI.KeepAliveNotification += new KeepAliveEventHandler(Notification_KeepAlive);
                    myClientHelperAPI.CertificateValidationNotification += new CertificateValidationEventHandler(Notification_ServerCertificate);

                    //Check for a selected endpoint
                    if (mySelectedEndpoint != null)
                    {
                        //Call connect
                        myClientHelperAPI.Connect(mySelectedEndpoint, userPwButton.Checked, userTextBox.Text, pwTextBox.Text).Wait();
                        //Extract the session object for further direct session interactions
                        mySession = myClientHelperAPI.Session;

                        //UI settings
                        epConnectServerButton.Text = "Disconnect from server";
                        browsePage.Enabled = true;
                        monitoringPage.Enabled = true;
                        myCertForm = null;
                    }
                    else
                    {
                        MessageBox.Show("Please select an endpoint before connecting", "Error");
                        return;
                    }
                }
                catch (Exception ex)
                {
                    myCertForm = null;
                    ResetUI();
                    MessageBox.Show(ex.InnerException.Message, "Error");
                }
            }

        }
 
        private void NodeTreeView_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            descriptionGridView.Rows.Clear();

            try
            {
                ReferenceDescription refDesc = (ReferenceDescription)e.Node.Tag;
                Node node = myClientHelperAPI.ReadNode(refDesc.NodeId.ToString());
                VariableNode variableNode = new VariableNode();

                string[] row1 = new string[] { "Node Id", refDesc.NodeId.ToString() };
                string[] row2 = new string[] { "Namespace Index", refDesc.NodeId.NamespaceIndex.ToString() };
                string[] row3 = new string[] { "Identifier Type", refDesc.NodeId.IdType.ToString() };
                string[] row4 = new string[] { "Identifier", refDesc.NodeId.Identifier.ToString() };
                string[] row5 = new string[] { "Browse Name", refDesc.BrowseName.ToString() };
                string[] row6 = new string[] { "Display Name", refDesc.DisplayName.ToString() };
                string[] row7 = new string[] { "Node Class", refDesc.NodeClass.ToString() };
                string[] row8 = new string[] { "Description", "null" };
                try { row8 = new string[] { "Description", node.Description.ToString() }; }
                catch { row8 = new string[] { "Description", "null" }; }
                string[] row9 = new string[] { "Type Definition", refDesc.TypeDefinition.ToString() };
                string[] row10 = new string[] { "Write Mask", node.WriteMask.ToString() };
                string[] row11 = new string[] { "User Write Mask", node.UserWriteMask.ToString() };
                if (node.NodeClass == NodeClass.Variable)
                {
                    variableNode = (VariableNode)node.DataLock;
                    List<NodeId> nodeIds = new List<NodeId>();
                    List<string> displayNames = new List<string>();
                    List<ServiceResult> errors = new List<ServiceResult>();
                    NodeId nodeId = new NodeId(variableNode.DataType);
                    nodeIds.Add(nodeId);
                    mySession.ReadDisplayName(nodeIds, out displayNames, out errors);

                    string[] row12 = new string[] { "Data Type", displayNames[0] };
                    string[] row13 = new string[] { "Value Rank", variableNode.ValueRank.ToString() };
                    string[] row14 = new string[] { "Array Dimensions", variableNode.ArrayDimensions.Capacity.ToString() };
                    string[] row15 = new string[] { "Access Level", variableNode.AccessLevel.ToString() };
                    string[] row16 = new string[] { "Minimum Sampling Interval", variableNode.MinimumSamplingInterval.ToString() };
                    string[] row17 = new string[] { "Historizing", variableNode.Historizing.ToString() };

                    object[] rows = new object[] { row1, row2, row3, row4, row5, row6, row7, row8, row9, row10, row11, row12, row13, row14, row15, row16, row17 };
                    foreach (string[] rowArray in rows)
                    {
                        descriptionGridView.Rows.Add(rowArray);
                    }
                }
                else
                {
                    object[] rows = new object[] { row1, row2, row3, row4, row5, row6, row7, row8, row9, row10, row11 };
                    foreach (string[] rowArray in rows)
                    {
                        descriptionGridView.Rows.Add(rowArray);
                    }
                }

                descriptionGridView.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

        }
        private void ClientForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                myClientHelperAPI.Disconnect();
            }
            catch
            {
                ;
            }
        }

        private void NodeTreeView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            e.Node.Nodes.Clear();

            ReferenceDescriptionCollection referenceDescriptionCollection;
            var tag = e.Node.Tag;
            ReferenceDescription refDesc = (ReferenceDescription)tag;

            try
            {
                referenceDescriptionCollection = myClientHelperAPI.BrowseNode(refDesc);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                return;
            }

            foreach (ReferenceDescription tempRefDesc in referenceDescriptionCollection)
            {
                if (tempRefDesc.ReferenceTypeId != ReferenceTypeIds.HasNotifier)
                {
                    e.Node.Nodes.Add(tempRefDesc.DisplayName.ToString()).Tag = tempRefDesc;
                }
            }
            foreach (TreeNode node in e.Node.Nodes)
            {
                node.Nodes.Add("");
            }

        }
        private void BrowsePage_Enter(object sender, EventArgs e)
        {
            this.Size = new Size(750, 521);
            if (myReferenceDescriptionCollection == null)
            {
                try
                {
                    myReferenceDescriptionCollection = myClientHelperAPI.BrowseRoot();
                    foreach (ReferenceDescription refDesc in myReferenceDescriptionCollection)
                    {
                        nodeTreeView.Nodes.Add(refDesc.DisplayName.ToString()).Tag = refDesc;
                        foreach (TreeNode node in nodeTreeView.Nodes)
                        {
                            node.Nodes.Add("");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
        }

        private void ConnectPage_Enter(object sender, EventArgs e)
        {
            this.Size = new Size(750, 521);
        }

        private void MonitoringPage_Enter(object sender, EventArgs e)
        {
            this.Size = new Size(885, 730);
        }
       
        private void EndpointListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            mySelectedEndpoint = (EndpointDescription)e.Item.Tag;
        }
        private void OpcTabControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            e.Cancel = !e.TabPage.Enabled;
            if (!e.TabPage.Enabled)
            {
                MessageBox.Show("Establish a connection to a server first.", "Error");
            }
        }
       
        private void UserPwButton_CheckedChanged(object sender, EventArgs e)
        {
            if (userPwButton.Checked)
            {
                userTextBox.Enabled = true;
                pwTextBox.Enabled = true;
            }
        }
        private void UserAnonButton_CheckedChanged(object sender, EventArgs e)
        {
            if (userAnonButton.Checked)
            {
                userTextBox.Enabled = false;
                pwTextBox.Enabled = false;
            }
        }
       
        private void DiscoveryTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EndpointButton_Click(this, new EventArgs());
            }
        }
        #endregion

        /// <summary>
        /// Global OPC UA event handlers
        /// </summary>
        #region OpcEventHandlers
        private void Notification_ServerCertificate(CertificateValidator cert, CertificateValidationEventArgs e)
        {
            //Handle certificate here
            //To accept a certificate manually move it to the root folder (Start > mmc.exe > add snap-in > certificates)
            //Or handle via UAClientCertForm

            if (this.InvokeRequired)
            {
                this.BeginInvoke(new CertificateValidationEventHandler(Notification_ServerCertificate), cert, e);
                return;
            }

            try
            {
                //Search for the server's certificate in store; if found -> accept
                X509Store store = new X509Store(StoreName.Root, StoreLocation.CurrentUser);
                store.Open(OpenFlags.ReadOnly);
                X509CertificateCollection certCol = store.Certificates.Find(X509FindType.FindByThumbprint, e.Certificate.Thumbprint, true);
                store.Close();
                if (certCol.Capacity > 0)
                {
                    e.Accept = true;
                }

                //Show cert dialog if cert hasn't been accepted yet
                else
                {
                    if (!e.Accept & myCertForm == null)
                    {
                        myCertForm = new UAClientCertForm(e);
                        myCertForm.ShowDialog();
                    }
                }
            }
            catch
            {
                ;
            }
        }
        private void Notification_MonitoredItem(MonitoredItem monitoredItem, MonitoredItemNotificationEventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new MonitoredItemNotificationEventHandler(Notification_MonitoredItem), monitoredItem, e);
                return;
            }

            MonitoredItemNotification notification = e.NotificationValue as MonitoredItemNotification;
            if (notification == null)
            {
                return;
            }

            if (monitoredItem.DisplayName.Contains("heating-"))
            {
                if (monitoredItem.DisplayName.Contains("state"))
                {
                    if (notification.Value.WrappedValue.ToString() == "true")
                    {
                        heatingMotorStatus.Text = "Running";
                        heatingMotorStatus.BackColor = Color.Lime;
                    }

                    else if (notification.Value.WrappedValue.ToString() == "false")
                    {
                        heatingMotorStatus.Text = "Off";
                        heatingMotorStatus.BackColor = Color.Red;
                    }
                }
                else if (monitoredItem.DisplayName.Contains("speed")) 
                {
                    heatingMotorSpeed.Text = notification.Value.WrappedValue.ToString();
                }
                else
                {
                    if (notification.Value.WrappedValue.ToString() == "true")
                    {
                        startHeatingAnyway.Text = "Stop";
                        startHeatingAnyway.BackColor = Color.Lime;
                        startHeatingAnywayCB.Checked = true;
                    }
                    else
                    {
                        startHeatingAnyway.Text = "Start Anyway";
                        startHeatingAnyway.BackColor = Color.Red;
                        startHeatingAnywayCB.Checked = false;
                    }
                }
            }
            else if (monitoredItem.DisplayName.Contains("cooling-"))
            {
                if (monitoredItem.DisplayName.Contains("state"))
                {
                    if (notification.Value.WrappedValue.ToString() == "true")
                    {
                        coolingMotorStatus.Text = "Running";
                        coolingMotorStatus.BackColor = Color.Lime;
                    }

                    else if (notification.Value.WrappedValue.ToString() == "false")
                    {
                        coolingMotorStatus.Text = "Off";
                        coolingMotorStatus.BackColor = Color.Red;
                    }
                }
                else if (monitoredItem.DisplayName.Contains("speed"))
                {
                    coolingMotorSpeed.Text = notification.Value.WrappedValue.ToString();
                }
                else
                {
                    if (notification.Value.WrappedValue.ToString() == "true")
                    {
                        startCoolingAnyway.Text = "Stop";
                        startCoolingAnyway.BackColor = Color.Lime;
                        startCoolingAnywayCB.Checked = true;
                    }
                    else
                    {
                        startCoolingAnyway.Text = "Start Anyway";
                        startCoolingAnyway.BackColor = Color.Red;
                        startCoolingAnywayCB.Checked = false;
                    }
                }
            }
            else
            {
                temperatureValue.Text = notification.Value.WrappedValue.ToString();
                sourceTimestamp.Text = notification.Value.SourceTimestamp.ToString();
                serverTimestamp.Text = notification.Value.ServerTimestamp.ToString();
                this.updateChart(notification.Value.WrappedValue.ToString());
            }
        }

        private void updateChart(string stringValue)
        {
            temperatureChart.Series["Temperature"].Points.Clear();

            int value = Int32.Parse(stringValue);
            chartValues = chartValues.Skip(1).ToList<int>();
            chartValues.Add(value);

            for (var i=0; i<numberOfPoints; i++)
            {
                temperatureChart.Series["Temperature"].Points.AddXY(i, chartValues[i]);
            }
        }

        private void Notification_KeepAlive(Session sender, KeepAliveEventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new KeepAliveEventHandler(Notification_KeepAlive), sender, e);
                return;
            }

            try
            {
                // check for events from discarded sessions.
                if (!Object.ReferenceEquals(sender, mySession))
                {
                    return;
                }

                // check for disconnected session.
                if (!ServiceResult.IsGood(e.Status))
                {
                    // try reconnecting using the existing session state
                    mySession.Reconnect();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                ResetUI();
            }
        }
        #endregion

        /// <summary>
        /// Private methods for UI handling
        /// </summary>
        #region PrivateMethods
        private void ResetUI()
        {
            descriptionGridView.Rows.Clear();
            nodeTreeView.Nodes.Clear();
            myReferenceDescriptionCollection = null;
            myStructList = null;
            epConnectServerButton.Text = "Connect to server";

            browsePage.Enabled = true;
            monitoringPage.Enabled = true;

            opcTabControl.SelectedIndex = 0;

            chartValues.Clear();
            for (var i = 0; i < numberOfPoints; i++) chartValues.Add(0); //initialize chart with zeroes
            this.updateChart(0.ToString());
        }
        #endregion

        private void StartStop_Button_Click(object sender, EventArgs e)
        {
            string value = "";
            if (startStop_Button.Text == "Stop process")
            {
                startStop_Button.Text = "Start process";
                startStop_Button.BackColor = Color.Red;
                value = "true";
            }
            else if (startStop_Button.Text == "Start process")
            {
                startStop_Button.Text = "Stop process";
                startStop_Button.BackColor = Color.Lime;
                value = "false";
            }
            this.WriteValue(controlProcessNodeId.Text, value);
        }

        private void WriteValue(string nodeId, string value)
        {
            if (value == "")
            {
                MessageBox.Show("Please enter valid value!");
                return;
            }

            List<String> values = new List<string>();
            List<String> nodeIdStrings = new List<string>();
            values.Add(value);
            nodeIdStrings.Add(nodeId);
            try
            {
                myClientHelperAPI.WriteValues(values, nodeIdStrings);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void SetPointValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void HeatingSubscribe_Click(object sender, EventArgs e)
        {
            var structNodeId = heatingNodeId.Text;
            this.Subscribe(structNodeId, "heating");
            Node structNode = myClientHelperAPI.ReadNode(structNodeId);
            heatingDisplayName.Text = structNode.DisplayName.ToString();
            heatingNodeClass.Text = structNode.NodeClass.ToString();
        }
        private void CoolingSubscribe_Click(object sender, EventArgs e)
        {
            var structNodeId = coolingNodeId.Text;
            this.Subscribe(structNodeId, "cooling");
            Node structNode = myClientHelperAPI.ReadNode(structNodeId);
            coolingDisplayName.Text = structNode.DisplayName.ToString();
            coolingNodeClass.Text = structNode.NodeClass.ToString();
        }

        private void Subscribe(string nodeId, string motorType)
        {
            referenceDescriptionCollection = myClientHelperAPI.ReadStructProperties(nodeId);
            Subscription subscription = myClientHelperAPI.Subscribe(1000);
            mySubscriptions.Add(subscription);

            try
            {
                foreach (ReferenceDescription tempRefDesc in referenceDescriptionCollection)
                {
                    //use different item names for correct assignment at the notificatino event
                    if (tempRefDesc.DisplayName.ToString().Contains("startAnyway"))
                    {
                        if (motorType == "cooling") coolingStartAnywayNodeId = tempRefDesc.NodeId.ToString();
                        else if (motorType == "heating") heatingStartAnywayNodeId = tempRefDesc.NodeId.ToString();  
                    }
                    
                    if (tempRefDesc.DisplayName.ToString().Contains("speed"))
                    {
                        if (motorType == "cooling") coolingSpeedNodeId = tempRefDesc.NodeId.ToString();
                        else if (motorType == "heating") heatingSpeedNodeId = tempRefDesc.NodeId.ToString();
                    }

                    string monitoredItemName = motorType + "-" + tempRefDesc.DisplayName.ToString();
                    myMonitoredItem = myClientHelperAPI.AddMonitoredItem(mySubscriptions[mySubscriptions.Count() - 1], tempRefDesc.NodeId.ToString(), monitoredItemName, 1);
                    myClientHelperAPI.ItemChangedNotification = new MonitoredItemNotificationEventHandler(Notification_MonitoredItem);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }


        private void desiredTemperatureButton_Click(object sender, EventArgs e)
        {
            this.WriteValue(setpointNodeId.Text, setpointValue.Text);
        }

        private void temperatureSubscribe_Click(object sender, EventArgs e)
        {
            Node node = myClientHelperAPI.ReadNode(temperatureNodeId.Text);
            Subscription subscription = myClientHelperAPI.Subscribe(1000);
            mySubscriptions.Add(subscription);

            temperatureDisplayName.Text = node.DisplayName.ToString();
            temperatureNodeClass.Text = node.NodeClass.ToString();

            try
            {
                //use different item names for correct assignment at the notificatino event
                string monitoredItemName = "temperature-" + node.DisplayName.ToString();
                myMonitoredItem = myClientHelperAPI.AddMonitoredItem(mySubscriptions[mySubscriptions.Count() - 1], node.NodeId.ToString(), monitoredItemName, 1);
                myClientHelperAPI.ItemChangedNotification = new MonitoredItemNotificationEventHandler(Notification_MonitoredItem);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void selectedHeatingSpeed_TextChanged(object sender, EventArgs e)
        {
            this.WriteValue(heatingSpeedNodeId, selectedHeatingSpeed.Text);
        }

        private void selectedCoolingSpeed_TextChanged(object sender, EventArgs e)
        {
            this.WriteValue(coolingSpeedNodeId, selectedCoolingSpeed.Text);
        }

        private void startHeatingAnyway_Click(object sender, EventArgs e)
        {
            string value = "";
            if(startHeatingAnyway.Text == "Start Anyway")
            {
                startHeatingAnyway.Text = "Stop";
                startHeatingAnyway.BackColor = Color.Lime;
                value = "true";
            }
            else
            {
                startHeatingAnyway.Text = "Start Anyway";
                startHeatingAnyway.BackColor = Color.Red;
                value = "false";
            }
            this.WriteValue(heatingStartAnywayNodeId, value);
        }

        private void startCoolingAnyway_Click(object sender, EventArgs e)
        {
            string value = "";
            if (startCoolingAnyway.Text == "Start Anyway")
            {
                startCoolingAnyway.Text = "Stop";
                startCoolingAnyway.BackColor = Color.Lime;
                value = "true";
            }
            else
            {
                startCoolingAnyway.Text = "Start Anyway";
                startCoolingAnyway.BackColor = Color.Red;
                value = "false";
            }
            this.WriteValue(coolingStartAnywayNodeId, value);
        }
    }
}