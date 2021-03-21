namespace UA_Client_1500
{
    partial class UAClientForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UAClientForm));
            this.opcTabControl = new System.Windows.Forms.TabControl();
            this.connectPage = new System.Windows.Forms.TabPage();
            this.discoveryTextBox = new System.Windows.Forms.TextBox();
            this.endpointLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.endpointListView = new System.Windows.Forms.ListView();
            this.Endpoints = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.endpointButton = new System.Windows.Forms.Button();
            this.labelUri = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pwTextBox = new System.Windows.Forms.TextBox();
            this.userAnonButton = new System.Windows.Forms.RadioButton();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.userPwButton = new System.Windows.Forms.RadioButton();
            this.epConnectServerButton = new System.Windows.Forms.Button();
            this.browsePage = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.descriptionGridView = new System.Windows.Forms.DataGridView();
            this.attributeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nodeTreeView = new System.Windows.Forms.TreeView();
            this.monitoringPage = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.serverTimestamp = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.sourceTimestamp = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.temperatureValue = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.temperatureNodeClass = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.temperatureDisplayName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.temperatureNodeId = new System.Windows.Forms.TextBox();
            this.temperatureSubscribe = new System.Windows.Forms.Button();
            this.temperatureChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.selectedCoolingSpeed = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.startCoolingAnyway = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label23 = new System.Windows.Forms.Label();
            this.coolingNodeId = new System.Windows.Forms.TextBox();
            this.coolingSubscribe = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.coolingNodeClass = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.coolingDisplayName = new System.Windows.Forms.TextBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.startCoolingAnywayCB = new System.Windows.Forms.CheckBox();
            this.coolingMotorSpeed = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.coolingMotorStatus = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.controlProcessNodeId = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.setpointNodeId = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.desiredTemperatureButton = new System.Windows.Forms.Button();
            this.setpointValue = new System.Windows.Forms.TextBox();
            this.startStop_Button = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.heatingMotorGroupBox = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.startHeatingAnyway = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.heatingNodeId = new System.Windows.Forms.TextBox();
            this.heatingSubscribe = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.heatingNodeClass = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.heatingDisplayName = new System.Windows.Forms.TextBox();
            this.selectedHeatingSpeed = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.startHeatingAnywayCB = new System.Windows.Forms.CheckBox();
            this.heatingMotorSpeed = new System.Windows.Forms.TextBox();
            this.heatingSpeedLabel = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.heatingMotorStatus = new System.Windows.Forms.TextBox();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Attribute = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endpointColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.opcTabControl.SuspendLayout();
            this.connectPage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.browsePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionGridView)).BeginInit();
            this.monitoringPage.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.temperatureChart)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.heatingMotorGroupBox.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // opcTabControl
            // 
            this.opcTabControl.Controls.Add(this.connectPage);
            this.opcTabControl.Controls.Add(this.browsePage);
            this.opcTabControl.Controls.Add(this.monitoringPage);
            this.opcTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.opcTabControl.Location = new System.Drawing.Point(0, 0);
            this.opcTabControl.Name = "opcTabControl";
            this.opcTabControl.SelectedIndex = 0;
            this.opcTabControl.Size = new System.Drawing.Size(869, 691);
            this.opcTabControl.TabIndex = 0;
            this.opcTabControl.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.OpcTabControl_Selecting);
            // 
            // connectPage
            // 
            this.connectPage.Controls.Add(this.discoveryTextBox);
            this.connectPage.Controls.Add(this.endpointLabel);
            this.connectPage.Controls.Add(this.label2);
            this.connectPage.Controls.Add(this.label1);
            this.connectPage.Controls.Add(this.endpointListView);
            this.connectPage.Controls.Add(this.endpointButton);
            this.connectPage.Controls.Add(this.labelUri);
            this.connectPage.Controls.Add(this.groupBox1);
            this.connectPage.Location = new System.Drawing.Point(4, 22);
            this.connectPage.Name = "connectPage";
            this.connectPage.Padding = new System.Windows.Forms.Padding(3);
            this.connectPage.Size = new System.Drawing.Size(861, 665);
            this.connectPage.TabIndex = 0;
            this.connectPage.Text = "Connect";
            this.connectPage.UseVisualStyleBackColor = true;
            this.connectPage.Enter += new System.EventHandler(this.ConnectPage_Enter);
            // 
            // discoveryTextBox
            // 
            this.discoveryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.discoveryTextBox.Location = new System.Drawing.Point(8, 27);
            this.discoveryTextBox.Name = "discoveryTextBox";
            this.discoveryTextBox.Size = new System.Drawing.Size(749, 20);
            this.discoveryTextBox.TabIndex = 11;
            this.discoveryTextBox.Text = "opc.tcp://192.168.0.25";
            this.discoveryTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DiscoveryTextBox_KeyDown);
            // 
            // endpointLabel
            // 
            this.endpointLabel.AutoSize = true;
            this.endpointLabel.Location = new System.Drawing.Point(5, 11);
            this.endpointLabel.Name = "endpointLabel";
            this.endpointLabel.Size = new System.Drawing.Size(319, 13);
            this.endpointLabel.TabIndex = 9;
            this.endpointLabel.Text = "Get all available Endpoints of a server\'s or discovery server\'s URL:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 445);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 6;
            // 
            // endpointListView
            // 
            this.endpointListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.endpointListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Endpoints});
            this.endpointListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.endpointListView.HideSelection = false;
            this.endpointListView.Location = new System.Drawing.Point(8, 53);
            this.endpointListView.MultiSelect = false;
            this.endpointListView.Name = "endpointListView";
            this.endpointListView.Size = new System.Drawing.Size(847, 438);
            this.endpointListView.TabIndex = 4;
            this.endpointListView.UseCompatibleStateImageBehavior = false;
            this.endpointListView.View = System.Windows.Forms.View.Details;
            this.endpointListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.EndpointListView_ItemSelectionChanged);
            // 
            // Endpoints
            // 
            this.Endpoints.Text = "Found Endpoints";
            this.Endpoints.Width = 718;
            // 
            // endpointButton
            // 
            this.endpointButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.endpointButton.Location = new System.Drawing.Point(763, 25);
            this.endpointButton.Name = "endpointButton";
            this.endpointButton.Size = new System.Drawing.Size(92, 23);
            this.endpointButton.TabIndex = 3;
            this.endpointButton.Text = "Get Endpoints";
            this.endpointButton.UseVisualStyleBackColor = true;
            this.endpointButton.Click += new System.EventHandler(this.EndpointButton_Click);
            // 
            // labelUri
            // 
            this.labelUri.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelUri.AutoSize = true;
            this.labelUri.Location = new System.Drawing.Point(8, 432);
            this.labelUri.Name = "labelUri";
            this.labelUri.Size = new System.Drawing.Size(0, 13);
            this.labelUri.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.pwTextBox);
            this.groupBox1.Controls.Add(this.userAnonButton);
            this.groupBox1.Controls.Add(this.userTextBox);
            this.groupBox1.Controls.Add(this.userPwButton);
            this.groupBox1.Controls.Add(this.epConnectServerButton);
            this.groupBox1.Location = new System.Drawing.Point(228, 497);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 160);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User authentication";
            // 
            // pwTextBox
            // 
            this.pwTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pwTextBox.Enabled = false;
            this.pwTextBox.Location = new System.Drawing.Point(6, 98);
            this.pwTextBox.Name = "pwTextBox";
            this.pwTextBox.PasswordChar = '*';
            this.pwTextBox.Size = new System.Drawing.Size(229, 20);
            this.pwTextBox.TabIndex = 16;
            this.pwTextBox.Text = "Password";
            this.pwTextBox.UseSystemPasswordChar = true;
            // 
            // userAnonButton
            // 
            this.userAnonButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.userAnonButton.AutoSize = true;
            this.userAnonButton.Checked = true;
            this.userAnonButton.Location = new System.Drawing.Point(6, 19);
            this.userAnonButton.Name = "userAnonButton";
            this.userAnonButton.Size = new System.Drawing.Size(80, 17);
            this.userAnonButton.TabIndex = 13;
            this.userAnonButton.TabStop = true;
            this.userAnonButton.Text = "Anonymous";
            this.userAnonButton.UseVisualStyleBackColor = true;
            this.userAnonButton.CheckedChanged += new System.EventHandler(this.UserAnonButton_CheckedChanged);
            // 
            // userTextBox
            // 
            this.userTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.userTextBox.Enabled = false;
            this.userTextBox.Location = new System.Drawing.Point(6, 72);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(229, 20);
            this.userTextBox.TabIndex = 15;
            this.userTextBox.Text = "User name";
            // 
            // userPwButton
            // 
            this.userPwButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.userPwButton.AutoSize = true;
            this.userPwButton.Location = new System.Drawing.Point(6, 42);
            this.userPwButton.Name = "userPwButton";
            this.userPwButton.Size = new System.Drawing.Size(98, 17);
            this.userPwButton.TabIndex = 14;
            this.userPwButton.Text = "User/Password";
            this.userPwButton.UseVisualStyleBackColor = true;
            this.userPwButton.CheckedChanged += new System.EventHandler(this.UserPwButton_CheckedChanged);
            // 
            // epConnectServerButton
            // 
            this.epConnectServerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.epConnectServerButton.Location = new System.Drawing.Point(6, 124);
            this.epConnectServerButton.Name = "epConnectServerButton";
            this.epConnectServerButton.Size = new System.Drawing.Size(229, 23);
            this.epConnectServerButton.TabIndex = 5;
            this.epConnectServerButton.Text = "Connect to selected Endpoint";
            this.epConnectServerButton.UseVisualStyleBackColor = true;
            this.epConnectServerButton.Click += new System.EventHandler(this.EpConnectButton_Click);
            // 
            // browsePage
            // 
            this.browsePage.Controls.Add(this.label7);
            this.browsePage.Controls.Add(this.label6);
            this.browsePage.Controls.Add(this.label3);
            this.browsePage.Controls.Add(this.descriptionGridView);
            this.browsePage.Controls.Add(this.nodeTreeView);
            this.browsePage.Location = new System.Drawing.Point(4, 22);
            this.browsePage.Name = "browsePage";
            this.browsePage.Size = new System.Drawing.Size(861, 665);
            this.browsePage.TabIndex = 4;
            this.browsePage.Text = "Browse Nodes";
            this.browsePage.UseVisualStyleBackColor = true;
            this.browsePage.Enter += new System.EventHandler(this.BrowsePage_Enter);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(362, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Selected node\'s information:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Browse the server\'s nodes:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 8;
            // 
            // descriptionGridView
            // 
            this.descriptionGridView.AllowUserToAddRows = false;
            this.descriptionGridView.AllowUserToDeleteRows = false;
            this.descriptionGridView.AllowUserToResizeRows = false;
            this.descriptionGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.descriptionGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.descriptionGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.descriptionGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.attributeColumn,
            this.valueColumn});
            this.descriptionGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.descriptionGridView.Location = new System.Drawing.Point(365, 27);
            this.descriptionGridView.Name = "descriptionGridView";
            this.descriptionGridView.ReadOnly = true;
            this.descriptionGridView.RowHeadersVisible = false;
            this.descriptionGridView.Size = new System.Drawing.Size(488, 635);
            this.descriptionGridView.TabIndex = 2;
            // 
            // attributeColumn
            // 
            this.attributeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            this.attributeColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.attributeColumn.HeaderText = "Attribute";
            this.attributeColumn.Name = "attributeColumn";
            this.attributeColumn.ReadOnly = true;
            // 
            // valueColumn
            // 
            this.valueColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro;
            this.valueColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.valueColumn.HeaderText = "Value";
            this.valueColumn.Name = "valueColumn";
            this.valueColumn.ReadOnly = true;
            // 
            // nodeTreeView
            // 
            this.nodeTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.nodeTreeView.Location = new System.Drawing.Point(8, 27);
            this.nodeTreeView.Name = "nodeTreeView";
            this.nodeTreeView.ShowLines = false;
            this.nodeTreeView.Size = new System.Drawing.Size(351, 635);
            this.nodeTreeView.TabIndex = 1;
            this.nodeTreeView.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.NodeTreeView_BeforeExpand);
            this.nodeTreeView.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.NodeTreeView_BeforeSelect);
            // 
            // monitoringPage
            // 
            this.monitoringPage.Controls.Add(this.label17);
            this.monitoringPage.Controls.Add(this.serverTimestamp);
            this.monitoringPage.Controls.Add(this.label16);
            this.monitoringPage.Controls.Add(this.sourceTimestamp);
            this.monitoringPage.Controls.Add(this.groupBox2);
            this.monitoringPage.Controls.Add(this.temperatureChart);
            this.monitoringPage.Controls.Add(this.groupBox7);
            this.monitoringPage.Controls.Add(this.groupBox4);
            this.monitoringPage.Controls.Add(this.heatingMotorGroupBox);
            this.monitoringPage.Location = new System.Drawing.Point(4, 22);
            this.monitoringPage.Name = "monitoringPage";
            this.monitoringPage.Padding = new System.Windows.Forms.Padding(3);
            this.monitoringPage.Size = new System.Drawing.Size(861, 665);
            this.monitoringPage.TabIndex = 7;
            this.monitoringPage.Text = "Monitoring page";
            this.monitoringPage.UseVisualStyleBackColor = true;
            this.monitoringPage.Enter += new System.EventHandler(this.MonitoringPage_Enter);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(476, 359);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(113, 16);
            this.label17.TabIndex = 51;
            this.label17.Text = "Server timestamp";
            // 
            // serverTimestamp
            // 
            this.serverTimestamp.Location = new System.Drawing.Point(609, 358);
            this.serverTimestamp.Name = "serverTimestamp";
            this.serverTimestamp.Size = new System.Drawing.Size(164, 20);
            this.serverTimestamp.TabIndex = 52;
            this.serverTimestamp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(95, 358);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(116, 16);
            this.label16.TabIndex = 50;
            this.label16.Text = "Source timestamp";
            // 
            // sourceTimestamp
            // 
            this.sourceTimestamp.Location = new System.Drawing.Point(228, 357);
            this.sourceTimestamp.Name = "sourceTimestamp";
            this.sourceTimestamp.Size = new System.Drawing.Size(164, 20);
            this.sourceTimestamp.TabIndex = 50;
            this.sourceTimestamp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.temperatureValue);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.temperatureNodeClass);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.temperatureDisplayName);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.temperatureNodeId);
            this.groupBox2.Controls.Add(this.temperatureSubscribe);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(306, 163);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(252, 183);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Temperature";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 143);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 16);
            this.label12.TabIndex = 48;
            this.label12.Text = "Value";
            // 
            // temperatureValue
            // 
            this.temperatureValue.Location = new System.Drawing.Point(107, 140);
            this.temperatureValue.Name = "temperatureValue";
            this.temperatureValue.Size = new System.Drawing.Size(139, 22);
            this.temperatureValue.TabIndex = 49;
            this.temperatureValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 16);
            this.label10.TabIndex = 46;
            this.label10.Text = "NodeClass";
            // 
            // temperatureNodeClass
            // 
            this.temperatureNodeClass.Location = new System.Drawing.Point(107, 112);
            this.temperatureNodeClass.Name = "temperatureNodeClass";
            this.temperatureNodeClass.Size = new System.Drawing.Size(139, 22);
            this.temperatureNodeClass.TabIndex = 47;
            this.temperatureNodeClass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 88);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 16);
            this.label11.TabIndex = 44;
            this.label11.Text = "DisplayName";
            // 
            // temperatureDisplayName
            // 
            this.temperatureDisplayName.Location = new System.Drawing.Point(107, 85);
            this.temperatureDisplayName.Name = "temperatureDisplayName";
            this.temperatureDisplayName.Size = new System.Drawing.Size(139, 22);
            this.temperatureDisplayName.TabIndex = 45;
            this.temperatureDisplayName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 16);
            this.label9.TabIndex = 43;
            this.label9.Text = "NodeId";
            // 
            // temperatureNodeId
            // 
            this.temperatureNodeId.Location = new System.Drawing.Point(67, 25);
            this.temperatureNodeId.Name = "temperatureNodeId";
            this.temperatureNodeId.Size = new System.Drawing.Size(179, 22);
            this.temperatureNodeId.TabIndex = 42;
            this.temperatureNodeId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // temperatureSubscribe
            // 
            this.temperatureSubscribe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temperatureSubscribe.Location = new System.Drawing.Point(80, 53);
            this.temperatureSubscribe.Name = "temperatureSubscribe";
            this.temperatureSubscribe.Size = new System.Drawing.Size(85, 26);
            this.temperatureSubscribe.TabIndex = 30;
            this.temperatureSubscribe.Text = "Subscribe";
            this.temperatureSubscribe.UseVisualStyleBackColor = true;
            this.temperatureSubscribe.Click += new System.EventHandler(this.temperatureSubscribe_Click);
            // 
            // temperatureChart
            // 
            this.temperatureChart.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Left;
            chartArea1.Name = "ChartArea1";
            this.temperatureChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.temperatureChart.Legends.Add(legend1);
            this.temperatureChart.Location = new System.Drawing.Point(8, 382);
            this.temperatureChart.Name = "temperatureChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Red;
            series1.Legend = "Legend1";
            series1.Name = "Temperature";
            this.temperatureChart.Series.Add(series1);
            this.temperatureChart.Size = new System.Drawing.Size(845, 261);
            this.temperatureChart.TabIndex = 40;
            this.temperatureChart.Text = "Temperature Chart";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Temperature";
            title1.Text = "Temperature";
            this.temperatureChart.Titles.Add(title1);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.selectedCoolingSpeed);
            this.groupBox7.Controls.Add(this.label8);
            this.groupBox7.Controls.Add(this.startCoolingAnyway);
            this.groupBox7.Controls.Add(this.groupBox8);
            this.groupBox7.Controls.Add(this.groupBox9);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(564, 13);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(292, 333);
            this.groupBox7.TabIndex = 39;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Cooling motor";
            // 
            // selectedCoolingSpeed
            // 
            this.selectedCoolingSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedCoolingSpeed.FormattingEnabled = true;
            this.selectedCoolingSpeed.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.selectedCoolingSpeed.Location = new System.Drawing.Point(232, 187);
            this.selectedCoolingSpeed.Name = "selectedCoolingSpeed";
            this.selectedCoolingSpeed.Size = new System.Drawing.Size(48, 24);
            this.selectedCoolingSpeed.TabIndex = 33;
            this.selectedCoolingSpeed.Text = "0";
            this.selectedCoolingSpeed.TextChanged += new System.EventHandler(this.selectedCoolingSpeed_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(122, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 16);
            this.label8.TabIndex = 34;
            this.label8.Text = "Selected speed";
            // 
            // startCoolingAnyway
            // 
            this.startCoolingAnyway.BackColor = System.Drawing.Color.Red;
            this.startCoolingAnyway.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startCoolingAnyway.ForeColor = System.Drawing.SystemColors.ControlText;
            this.startCoolingAnyway.Location = new System.Drawing.Point(6, 183);
            this.startCoolingAnyway.Name = "startCoolingAnyway";
            this.startCoolingAnyway.Size = new System.Drawing.Size(110, 28);
            this.startCoolingAnyway.TabIndex = 33;
            this.startCoolingAnyway.Text = "Start Anyway";
            this.startCoolingAnyway.UseVisualStyleBackColor = false;
            this.startCoolingAnyway.Click += new System.EventHandler(this.startCoolingAnyway_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label23);
            this.groupBox8.Controls.Add(this.coolingNodeId);
            this.groupBox8.Controls.Add(this.coolingSubscribe);
            this.groupBox8.Controls.Add(this.label24);
            this.groupBox8.Controls.Add(this.coolingNodeClass);
            this.groupBox8.Controls.Add(this.label25);
            this.groupBox8.Controls.Add(this.coolingDisplayName);
            this.groupBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox8.Location = new System.Drawing.Point(6, 21);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(280, 157);
            this.groupBox8.TabIndex = 30;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Object atributes";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(9, 29);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(53, 16);
            this.label23.TabIndex = 9;
            this.label23.Text = "NodeId";
            // 
            // coolingNodeId
            // 
            this.coolingNodeId.Location = new System.Drawing.Point(76, 26);
            this.coolingNodeId.Name = "coolingNodeId";
            this.coolingNodeId.Size = new System.Drawing.Size(198, 22);
            this.coolingNodeId.TabIndex = 10;
            this.coolingNodeId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // coolingSubscribe
            // 
            this.coolingSubscribe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coolingSubscribe.Location = new System.Drawing.Point(103, 56);
            this.coolingSubscribe.Name = "coolingSubscribe";
            this.coolingSubscribe.Size = new System.Drawing.Size(85, 26);
            this.coolingSubscribe.TabIndex = 29;
            this.coolingSubscribe.Text = "Subscribe";
            this.coolingSubscribe.UseVisualStyleBackColor = true;
            this.coolingSubscribe.Click += new System.EventHandler(this.CoolingSubscribe_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(6, 118);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(76, 16);
            this.label24.TabIndex = 7;
            this.label24.Text = "NodeClass";
            // 
            // coolingNodeClass
            // 
            this.coolingNodeClass.Location = new System.Drawing.Point(103, 118);
            this.coolingNodeClass.Name = "coolingNodeClass";
            this.coolingNodeClass.Size = new System.Drawing.Size(171, 22);
            this.coolingNodeClass.TabIndex = 8;
            this.coolingNodeClass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(6, 91);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(91, 16);
            this.label25.TabIndex = 2;
            this.label25.Text = "DisplayName";
            // 
            // coolingDisplayName
            // 
            this.coolingDisplayName.Location = new System.Drawing.Point(103, 88);
            this.coolingDisplayName.Name = "coolingDisplayName";
            this.coolingDisplayName.Size = new System.Drawing.Size(171, 22);
            this.coolingDisplayName.TabIndex = 6;
            this.coolingDisplayName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.startCoolingAnywayCB);
            this.groupBox9.Controls.Add(this.coolingMotorSpeed);
            this.groupBox9.Controls.Add(this.label26);
            this.groupBox9.Controls.Add(this.label27);
            this.groupBox9.Controls.Add(this.coolingMotorStatus);
            this.groupBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox9.Location = new System.Drawing.Point(6, 228);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(280, 99);
            this.groupBox9.TabIndex = 31;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Monitoring";
            // 
            // startCoolingAnywayCB
            // 
            this.startCoolingAnywayCB.AutoSize = true;
            this.startCoolingAnywayCB.BackColor = System.Drawing.Color.Transparent;
            this.startCoolingAnywayCB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.startCoolingAnywayCB.Location = new System.Drawing.Point(76, 78);
            this.startCoolingAnywayCB.Name = "startCoolingAnywayCB";
            this.startCoolingAnywayCB.Size = new System.Drawing.Size(127, 20);
            this.startCoolingAnywayCB.TabIndex = 44;
            this.startCoolingAnywayCB.Text = "Started (anyway)";
            this.startCoolingAnywayCB.UseVisualStyleBackColor = false;
            // 
            // coolingMotorSpeed
            // 
            this.coolingMotorSpeed.Location = new System.Drawing.Point(74, 51);
            this.coolingMotorSpeed.Name = "coolingMotorSpeed";
            this.coolingMotorSpeed.Size = new System.Drawing.Size(200, 22);
            this.coolingMotorSpeed.TabIndex = 44;
            this.coolingMotorSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(9, 54);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(49, 16);
            this.label26.TabIndex = 1;
            this.label26.Text = "Speed";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(9, 25);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(45, 16);
            this.label27.TabIndex = 9;
            this.label27.Text = "Status";
            // 
            // coolingMotorStatus
            // 
            this.coolingMotorStatus.BackColor = System.Drawing.Color.Red;
            this.coolingMotorStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coolingMotorStatus.Location = new System.Drawing.Point(74, 19);
            this.coolingMotorStatus.Name = "coolingMotorStatus";
            this.coolingMotorStatus.Size = new System.Drawing.Size(200, 26);
            this.coolingMotorStatus.TabIndex = 10;
            this.coolingMotorStatus.Text = "Off";
            this.coolingMotorStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.controlProcessNodeId);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.setpointNodeId);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.desiredTemperatureButton);
            this.groupBox4.Controls.Add(this.setpointValue);
            this.groupBox4.Controls.Add(this.startStop_Button);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(306, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(252, 150);
            this.groupBox4.TabIndex = 39;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "System configuration";
            // 
            // controlProcessNodeId
            // 
            this.controlProcessNodeId.Location = new System.Drawing.Point(125, 78);
            this.controlProcessNodeId.Name = "controlProcessNodeId";
            this.controlProcessNodeId.Size = new System.Drawing.Size(127, 22);
            this.controlProcessNodeId.TabIndex = 33;
            this.controlProcessNodeId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(0, 82);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(123, 16);
            this.label14.TabIndex = 32;
            this.label14.Text = "ControlProc nodeId";
            // 
            // setpointNodeId
            // 
            this.setpointNodeId.Location = new System.Drawing.Point(125, 21);
            this.setpointNodeId.Name = "setpointNodeId";
            this.setpointNodeId.Size = new System.Drawing.Size(127, 22);
            this.setpointNodeId.TabIndex = 30;
            this.setpointNodeId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 16);
            this.label13.TabIndex = 31;
            this.label13.Text = "Setpoint nodeId";
            // 
            // desiredTemperatureButton
            // 
            this.desiredTemperatureButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desiredTemperatureButton.Location = new System.Drawing.Point(203, 50);
            this.desiredTemperatureButton.Name = "desiredTemperatureButton";
            this.desiredTemperatureButton.Size = new System.Drawing.Size(43, 23);
            this.desiredTemperatureButton.TabIndex = 30;
            this.desiredTemperatureButton.Text = "Set";
            this.desiredTemperatureButton.UseVisualStyleBackColor = true;
            this.desiredTemperatureButton.Click += new System.EventHandler(this.desiredTemperatureButton_Click);
            // 
            // setpointValue
            // 
            this.setpointValue.Location = new System.Drawing.Point(144, 51);
            this.setpointValue.Name = "setpointValue";
            this.setpointValue.Size = new System.Drawing.Size(53, 22);
            this.setpointValue.TabIndex = 5;
            this.setpointValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.setpointValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SetPointValue_KeyPress);
            // 
            // startStop_Button
            // 
            this.startStop_Button.BackColor = System.Drawing.Color.Red;
            this.startStop_Button.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startStop_Button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.startStop_Button.Location = new System.Drawing.Point(58, 106);
            this.startStop_Button.Name = "startStop_Button";
            this.startStop_Button.Size = new System.Drawing.Size(148, 38);
            this.startStop_Button.TabIndex = 4;
            this.startStop_Button.Text = "Start process";
            this.startStop_Button.UseVisualStyleBackColor = false;
            this.startStop_Button.Click += new System.EventHandler(this.StartStop_Button_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Setpoint temperature";
            // 
            // heatingMotorGroupBox
            // 
            this.heatingMotorGroupBox.Controls.Add(this.label4);
            this.heatingMotorGroupBox.Controls.Add(this.startHeatingAnyway);
            this.heatingMotorGroupBox.Controls.Add(this.groupBox5);
            this.heatingMotorGroupBox.Controls.Add(this.selectedHeatingSpeed);
            this.heatingMotorGroupBox.Controls.Add(this.groupBox6);
            this.heatingMotorGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heatingMotorGroupBox.Location = new System.Drawing.Point(8, 13);
            this.heatingMotorGroupBox.Name = "heatingMotorGroupBox";
            this.heatingMotorGroupBox.Size = new System.Drawing.Size(292, 333);
            this.heatingMotorGroupBox.TabIndex = 38;
            this.heatingMotorGroupBox.TabStop = false;
            this.heatingMotorGroupBox.Text = "Heating motor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(122, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Selected speed";
            // 
            // startHeatingAnyway
            // 
            this.startHeatingAnyway.BackColor = System.Drawing.Color.Red;
            this.startHeatingAnyway.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startHeatingAnyway.ForeColor = System.Drawing.SystemColors.ControlText;
            this.startHeatingAnyway.Location = new System.Drawing.Point(6, 183);
            this.startHeatingAnyway.Name = "startHeatingAnyway";
            this.startHeatingAnyway.Size = new System.Drawing.Size(110, 28);
            this.startHeatingAnyway.TabIndex = 32;
            this.startHeatingAnyway.Text = "Start Anyway";
            this.startHeatingAnyway.UseVisualStyleBackColor = false;
            this.startHeatingAnyway.Click += new System.EventHandler(this.startHeatingAnyway_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label21);
            this.groupBox5.Controls.Add(this.heatingNodeId);
            this.groupBox5.Controls.Add(this.heatingSubscribe);
            this.groupBox5.Controls.Add(this.label20);
            this.groupBox5.Controls.Add(this.heatingNodeClass);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.heatingDisplayName);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(6, 21);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(280, 157);
            this.groupBox5.TabIndex = 30;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Object atributes";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(9, 29);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(53, 16);
            this.label21.TabIndex = 9;
            this.label21.Text = "NodeId";
            // 
            // heatingNodeId
            // 
            this.heatingNodeId.Location = new System.Drawing.Point(76, 26);
            this.heatingNodeId.Name = "heatingNodeId";
            this.heatingNodeId.Size = new System.Drawing.Size(198, 22);
            this.heatingNodeId.TabIndex = 10;
            this.heatingNodeId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // heatingSubscribe
            // 
            this.heatingSubscribe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heatingSubscribe.Location = new System.Drawing.Point(103, 56);
            this.heatingSubscribe.Name = "heatingSubscribe";
            this.heatingSubscribe.Size = new System.Drawing.Size(85, 26);
            this.heatingSubscribe.TabIndex = 29;
            this.heatingSubscribe.Text = "Subscribe";
            this.heatingSubscribe.UseVisualStyleBackColor = true;
            this.heatingSubscribe.Click += new System.EventHandler(this.HeatingSubscribe_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 118);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(76, 16);
            this.label20.TabIndex = 7;
            this.label20.Text = "NodeClass";
            // 
            // heatingNodeClass
            // 
            this.heatingNodeClass.Location = new System.Drawing.Point(103, 118);
            this.heatingNodeClass.Name = "heatingNodeClass";
            this.heatingNodeClass.Size = new System.Drawing.Size(171, 22);
            this.heatingNodeClass.TabIndex = 8;
            this.heatingNodeClass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 91);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 16);
            this.label15.TabIndex = 2;
            this.label15.Text = "DisplayName";
            // 
            // heatingDisplayName
            // 
            this.heatingDisplayName.Location = new System.Drawing.Point(103, 88);
            this.heatingDisplayName.Name = "heatingDisplayName";
            this.heatingDisplayName.Size = new System.Drawing.Size(171, 22);
            this.heatingDisplayName.TabIndex = 6;
            this.heatingDisplayName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // selectedHeatingSpeed
            // 
            this.selectedHeatingSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedHeatingSpeed.FormattingEnabled = true;
            this.selectedHeatingSpeed.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.selectedHeatingSpeed.Location = new System.Drawing.Point(232, 187);
            this.selectedHeatingSpeed.Name = "selectedHeatingSpeed";
            this.selectedHeatingSpeed.Size = new System.Drawing.Size(48, 24);
            this.selectedHeatingSpeed.TabIndex = 0;
            this.selectedHeatingSpeed.Text = "0";
            this.selectedHeatingSpeed.TextChanged += new System.EventHandler(this.selectedHeatingSpeed_TextChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.startHeatingAnywayCB);
            this.groupBox6.Controls.Add(this.heatingMotorSpeed);
            this.groupBox6.Controls.Add(this.heatingSpeedLabel);
            this.groupBox6.Controls.Add(this.label22);
            this.groupBox6.Controls.Add(this.heatingMotorStatus);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(6, 228);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(280, 98);
            this.groupBox6.TabIndex = 31;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Monitoring";
            // 
            // startHeatingAnywayCB
            // 
            this.startHeatingAnywayCB.AutoSize = true;
            this.startHeatingAnywayCB.BackColor = System.Drawing.Color.Transparent;
            this.startHeatingAnywayCB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.startHeatingAnywayCB.Location = new System.Drawing.Point(74, 79);
            this.startHeatingAnywayCB.Name = "startHeatingAnywayCB";
            this.startHeatingAnywayCB.Size = new System.Drawing.Size(127, 20);
            this.startHeatingAnywayCB.TabIndex = 43;
            this.startHeatingAnywayCB.Text = "Started (anyway)";
            this.startHeatingAnywayCB.UseVisualStyleBackColor = false;
            // 
            // heatingMotorSpeed
            // 
            this.heatingMotorSpeed.Location = new System.Drawing.Point(74, 51);
            this.heatingMotorSpeed.Name = "heatingMotorSpeed";
            this.heatingMotorSpeed.Size = new System.Drawing.Size(200, 22);
            this.heatingMotorSpeed.TabIndex = 43;
            this.heatingMotorSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // heatingSpeedLabel
            // 
            this.heatingSpeedLabel.AutoSize = true;
            this.heatingSpeedLabel.Location = new System.Drawing.Point(9, 54);
            this.heatingSpeedLabel.Name = "heatingSpeedLabel";
            this.heatingSpeedLabel.Size = new System.Drawing.Size(49, 16);
            this.heatingSpeedLabel.TabIndex = 1;
            this.heatingSpeedLabel.Text = "Speed";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(9, 25);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(45, 16);
            this.label22.TabIndex = 9;
            this.label22.Text = "Status";
            // 
            // heatingMotorStatus
            // 
            this.heatingMotorStatus.BackColor = System.Drawing.Color.Red;
            this.heatingMotorStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heatingMotorStatus.Location = new System.Drawing.Point(74, 19);
            this.heatingMotorStatus.Name = "heatingMotorStatus";
            this.heatingMotorStatus.Size = new System.Drawing.Size(200, 26);
            this.heatingMotorStatus.TabIndex = 10;
            this.heatingMotorStatus.Text = "Off";
            this.heatingMotorStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Value
            // 
            this.Value.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Value.HeaderText = "Value";
            this.Value.Name = "Value";
            // 
            // Attribute
            // 
            this.Attribute.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Attribute.HeaderText = "Attribute";
            this.Attribute.Name = "Attribute";
            // 
            // endpointColumn
            // 
            this.endpointColumn.DisplayIndex = 0;
            this.endpointColumn.Text = "Endpoints";
            this.endpointColumn.Width = 700;
            // 
            // UAClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 691);
            this.Controls.Add(this.opcTabControl);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UAClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OPC UA Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClientForm_FormClosing);
            this.opcTabControl.ResumeLayout(false);
            this.connectPage.ResumeLayout(false);
            this.connectPage.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.browsePage.ResumeLayout(false);
            this.browsePage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionGridView)).EndInit();
            this.monitoringPage.ResumeLayout(false);
            this.monitoringPage.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.temperatureChart)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.heatingMotorGroupBox.ResumeLayout(false);
            this.heatingMotorGroupBox.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl opcTabControl;
        private System.Windows.Forms.TabPage connectPage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button epConnectServerButton;
        private System.Windows.Forms.ListView endpointListView;
        private System.Windows.Forms.Button endpointButton;
        private System.Windows.Forms.Label labelUri;
        private System.Windows.Forms.TabPage browsePage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView descriptionGridView;
        private System.Windows.Forms.TreeView nodeTreeView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn Attribute;
        private System.Windows.Forms.ColumnHeader endpointColumn;
        private System.Windows.Forms.Label endpointLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ColumnHeader Endpoints;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox discoveryTextBox;
        private System.Windows.Forms.TextBox pwTextBox;
        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.RadioButton userPwButton;
        private System.Windows.Forms.RadioButton userAnonButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage monitoringPage;
        private System.Windows.Forms.DataGridViewTextBoxColumn attributeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueColumn;
        private System.Windows.Forms.ComboBox selectedHeatingSpeed;
        private System.Windows.Forms.Label heatingSpeedLabel;
        private System.Windows.Forms.GroupBox heatingMotorGroupBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button startStop_Button;
        private System.Windows.Forms.TextBox setpointValue;
        private System.Windows.Forms.TextBox heatingDisplayName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox heatingNodeClass;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button heatingSubscribe;
        private System.Windows.Forms.TextBox heatingNodeId;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox heatingMotorStatus;
        private System.Windows.Forms.Button startHeatingAnyway;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox coolingNodeId;
        private System.Windows.Forms.Button coolingSubscribe;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox coolingNodeClass;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox coolingDisplayName;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox coolingMotorStatus;
        private System.Windows.Forms.DataVisualization.Charting.Chart temperatureChart;
        private System.Windows.Forms.Button temperatureSubscribe;
        private System.Windows.Forms.TextBox temperatureNodeId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox selectedCoolingSpeed;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button startCoolingAnyway;
        private System.Windows.Forms.CheckBox startCoolingAnywayCB;
        private System.Windows.Forms.TextBox coolingMotorSpeed;
        private System.Windows.Forms.CheckBox startHeatingAnywayCB;
        private System.Windows.Forms.TextBox heatingMotorSpeed;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox temperatureValue;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox temperatureNodeClass;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox temperatureDisplayName;
        private System.Windows.Forms.Button desiredTemperatureButton;
        private System.Windows.Forms.TextBox setpointNodeId;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox controlProcessNodeId;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox serverTimestamp;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox sourceTimestamp;
    }
}

