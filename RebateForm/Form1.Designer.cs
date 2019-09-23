using System;

namespace RebateForm
{
    partial class RebateForm
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
            this.viewPortListView = new System.Windows.Forms.ListView();
            this.fnameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lnameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.phNumberColumnHeaderList = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.phNumberColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fnameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FnameLabel = new System.Windows.Forms.Label();
            this.MnameLabel = new System.Windows.Forms.Label();
            this.FnameTextBox = new System.Windows.Forms.TextBox();
            this.MnameTextBox = new System.Windows.Forms.TextBox();
            this.LnameLabel = new System.Windows.Forms.Label();
            this.LnameTextBox = new System.Windows.Forms.TextBox();
            this.Address_1Label = new System.Windows.Forms.Label();
            this.Address_2Label = new System.Windows.Forms.Label();
            this.Address_1TextBox = new System.Windows.Forms.TextBox();
            this.Address_2TextBox = new System.Windows.Forms.TextBox();
            this.CityLabel = new System.Windows.Forms.Label();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.StateLabel = new System.Windows.Forms.Label();
            this.StateTextBox = new System.Windows.Forms.TextBox();
            this.ZipCodeLabel = new System.Windows.Forms.Label();
            this.ZipCodeTextBox = new System.Windows.Forms.TextBox();
            this.PhoneNumberMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.EmailIdLabel = new System.Windows.Forms.Label();
            this.EmailIdTextBox = new System.Windows.Forms.TextBox();
            this.DateReceivedLabel = new System.Windows.Forms.Label();
            this.DateReceivedTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.genderLabel = new System.Windows.Forms.Label();
            this.genderTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.proofOfPurchaseTextBox = new System.Windows.Forms.TextBox();
            this.dataEntryTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.dataButtonsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.listViewTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.stateButtonsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.stripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.dataEntryTableLayoutPanel.SuspendLayout();
            this.dataButtonsTableLayoutPanel.SuspendLayout();
            this.listViewTableLayoutPanel.SuspendLayout();
            this.stateButtonsTableLayoutPanel.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // viewPortListView
            // 
            this.viewPortListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.fnameColumnHeader,
            this.lnameColumnHeader,
            this.phNumberColumnHeaderList});
            this.viewPortListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewPortListView.FullRowSelect = true;
            this.viewPortListView.HideSelection = false;
            this.viewPortListView.Location = new System.Drawing.Point(4, 60);
            this.viewPortListView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.viewPortListView.Name = "viewPortListView";
            this.viewPortListView.Size = new System.Drawing.Size(570, 704);
            this.viewPortListView.TabIndex = 4;
            this.viewPortListView.UseCompatibleStateImageBehavior = false;
            this.viewPortListView.View = System.Windows.Forms.View.Details;
            this.viewPortListView.SelectedIndexChanged += new System.EventHandler(this.ViewPortListView_SelectedIndexChanged);
            // 
            // fnameColumnHeader
            // 
            this.fnameColumnHeader.Text = "First Name";
            this.fnameColumnHeader.Width = 193;
            // 
            // lnameColumnHeader
            // 
            this.lnameColumnHeader.Text = "Last Name";
            this.lnameColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lnameColumnHeader.Width = 193;
            // 
            // phNumberColumnHeaderList
            // 
            this.phNumberColumnHeaderList.Text = "Phone Number";
            this.phNumberColumnHeaderList.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.phNumberColumnHeaderList.Width = 193;
            // 
            // fname
            // 
            this.fname.Text = "First Name";
            this.fname.Width = 116;
            // 
            // lname
            // 
            this.lname.Text = "Last Name";
            this.lname.Width = 115;
            // 
            // phNumberColumnHeader
            // 
            this.phNumberColumnHeader.Text = "Phone Number";
            this.phNumberColumnHeader.Width = 210;
            // 
            // fnameCol
            // 
            this.fnameCol.Text = "First Name";
            // 
            // FnameLabel
            // 
            this.FnameLabel.AutoSize = true;
            this.FnameLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.FnameLabel.Location = new System.Drawing.Point(130, 55);
            this.FnameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FnameLabel.Name = "FnameLabel";
            this.FnameLabel.Size = new System.Drawing.Size(116, 55);
            this.FnameLabel.TabIndex = 0;
            this.FnameLabel.Text = "First Name";
            // 
            // MnameLabel
            // 
            this.MnameLabel.AutoSize = true;
            this.MnameLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.MnameLabel.Location = new System.Drawing.Point(108, 110);
            this.MnameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MnameLabel.Name = "MnameLabel";
            this.MnameLabel.Size = new System.Drawing.Size(138, 55);
            this.MnameLabel.TabIndex = 1;
            this.MnameLabel.Text = "Middle Name";
            // 
            // FnameTextBox
            // 
            this.FnameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FnameTextBox.Location = new System.Drawing.Point(254, 59);
            this.FnameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FnameTextBox.MaxLength = 20;
            this.FnameTextBox.Name = "FnameTextBox";
            this.FnameTextBox.Size = new System.Drawing.Size(242, 31);
            this.FnameTextBox.TabIndex = 0;
            this.FnameTextBox.TextChanged += new System.EventHandler(this.FnameTextBox_TextChanged);
            // 
            // MnameTextBox
            // 
            this.MnameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MnameTextBox.Location = new System.Drawing.Point(254, 114);
            this.MnameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MnameTextBox.MaxLength = 1;
            this.MnameTextBox.Name = "MnameTextBox";
            this.MnameTextBox.Size = new System.Drawing.Size(242, 31);
            this.MnameTextBox.TabIndex = 1;
            this.MnameTextBox.TextChanged += new System.EventHandler(this.MnameTextBox_TextChanged);
            // 
            // LnameLabel
            // 
            this.LnameLabel.AutoSize = true;
            this.LnameLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.LnameLabel.Location = new System.Drawing.Point(131, 165);
            this.LnameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LnameLabel.Name = "LnameLabel";
            this.LnameLabel.Size = new System.Drawing.Size(115, 55);
            this.LnameLabel.TabIndex = 5;
            this.LnameLabel.Text = "Last Name";
            // 
            // LnameTextBox
            // 
            this.LnameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LnameTextBox.Location = new System.Drawing.Point(254, 169);
            this.LnameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LnameTextBox.MaxLength = 20;
            this.LnameTextBox.Name = "LnameTextBox";
            this.LnameTextBox.Size = new System.Drawing.Size(242, 31);
            this.LnameTextBox.TabIndex = 2;
            this.LnameTextBox.TextChanged += new System.EventHandler(this.LnameTextBox_TextChanged);
            // 
            // Address_1Label
            // 
            this.Address_1Label.AutoSize = true;
            this.Address_1Label.Dock = System.Windows.Forms.DockStyle.Right;
            this.Address_1Label.Location = new System.Drawing.Point(97, 220);
            this.Address_1Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Address_1Label.Name = "Address_1Label";
            this.Address_1Label.Size = new System.Drawing.Size(149, 55);
            this.Address_1Label.TabIndex = 7;
            this.Address_1Label.Text = "Address line 1";
            // 
            // Address_2Label
            // 
            this.Address_2Label.AutoSize = true;
            this.Address_2Label.Dock = System.Windows.Forms.DockStyle.Right;
            this.Address_2Label.Location = new System.Drawing.Point(97, 275);
            this.Address_2Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Address_2Label.Name = "Address_2Label";
            this.Address_2Label.Size = new System.Drawing.Size(149, 55);
            this.Address_2Label.TabIndex = 8;
            this.Address_2Label.Text = "Address line 2";
            // 
            // Address_1TextBox
            // 
            this.Address_1TextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Address_1TextBox.Location = new System.Drawing.Point(254, 224);
            this.Address_1TextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Address_1TextBox.MaxLength = 35;
            this.Address_1TextBox.Name = "Address_1TextBox";
            this.Address_1TextBox.Size = new System.Drawing.Size(242, 31);
            this.Address_1TextBox.TabIndex = 3;
            this.Address_1TextBox.TextChanged += new System.EventHandler(this.Address_1TextBox_TextChanged);
            // 
            // Address_2TextBox
            // 
            this.Address_2TextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Address_2TextBox.Location = new System.Drawing.Point(254, 279);
            this.Address_2TextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Address_2TextBox.MaxLength = 35;
            this.Address_2TextBox.Name = "Address_2TextBox";
            this.Address_2TextBox.Size = new System.Drawing.Size(242, 31);
            this.Address_2TextBox.TabIndex = 4;
            this.Address_2TextBox.TextChanged += new System.EventHandler(this.Address_2TextBox_TextChanged);
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.CityLabel.Location = new System.Drawing.Point(197, 330);
            this.CityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(49, 55);
            this.CityLabel.TabIndex = 11;
            this.CityLabel.Text = "City";
            // 
            // CityTextBox
            // 
            this.CityTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CityTextBox.Location = new System.Drawing.Point(254, 334);
            this.CityTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CityTextBox.MaxLength = 25;
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(242, 31);
            this.CityTextBox.TabIndex = 5;
            this.CityTextBox.TextChanged += new System.EventHandler(this.CityTextBox_TextChanged);
            // 
            // StateLabel
            // 
            this.StateLabel.AutoSize = true;
            this.StateLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.StateLabel.Location = new System.Drawing.Point(184, 385);
            this.StateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StateLabel.Name = "StateLabel";
            this.StateLabel.Size = new System.Drawing.Size(62, 55);
            this.StateLabel.TabIndex = 13;
            this.StateLabel.Text = "State";
            // 
            // StateTextBox
            // 
            this.StateTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StateTextBox.Location = new System.Drawing.Point(254, 389);
            this.StateTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StateTextBox.MaxLength = 2;
            this.StateTextBox.Name = "StateTextBox";
            this.StateTextBox.Size = new System.Drawing.Size(242, 31);
            this.StateTextBox.TabIndex = 6;
            this.StateTextBox.TextChanged += new System.EventHandler(this.StateTextBox_TextChanged);
            // 
            // ZipCodeLabel
            // 
            this.ZipCodeLabel.AutoSize = true;
            this.ZipCodeLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ZipCodeLabel.Location = new System.Drawing.Point(147, 440);
            this.ZipCodeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ZipCodeLabel.Name = "ZipCodeLabel";
            this.ZipCodeLabel.Size = new System.Drawing.Size(99, 55);
            this.ZipCodeLabel.TabIndex = 15;
            this.ZipCodeLabel.Text = "Zip Code";
            // 
            // ZipCodeTextBox
            // 
            this.ZipCodeTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ZipCodeTextBox.Location = new System.Drawing.Point(254, 444);
            this.ZipCodeTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ZipCodeTextBox.MaxLength = 9;
            this.ZipCodeTextBox.Name = "ZipCodeTextBox";
            this.ZipCodeTextBox.Size = new System.Drawing.Size(242, 31);
            this.ZipCodeTextBox.TabIndex = 7;
            this.ZipCodeTextBox.TextChanged += new System.EventHandler(this.ZipCodeTextBox_TextChanged);
            // 
            // PhoneNumberMaskedTextBox
            // 
            this.PhoneNumberMaskedTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PhoneNumberMaskedTextBox.Location = new System.Drawing.Point(254, 554);
            this.PhoneNumberMaskedTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PhoneNumberMaskedTextBox.Mask = "(000)-000-0000";
            this.PhoneNumberMaskedTextBox.Name = "PhoneNumberMaskedTextBox";
            this.PhoneNumberMaskedTextBox.Size = new System.Drawing.Size(242, 31);
            this.PhoneNumberMaskedTextBox.TabIndex = 9;
            this.PhoneNumberMaskedTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PhoneNumberMaskedTextBox_KeyUp);
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.PhoneNumberLabel.Location = new System.Drawing.Point(91, 550);
            this.PhoneNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(155, 55);
            this.PhoneNumberLabel.TabIndex = 21;
            this.PhoneNumberLabel.Text = "Phone Number";
            // 
            // EmailIdLabel
            // 
            this.EmailIdLabel.AutoSize = true;
            this.EmailIdLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.EmailIdLabel.Location = new System.Drawing.Point(96, 605);
            this.EmailIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EmailIdLabel.Name = "EmailIdLabel";
            this.EmailIdLabel.Size = new System.Drawing.Size(150, 55);
            this.EmailIdLabel.TabIndex = 22;
            this.EmailIdLabel.Text = "Email Address";
            // 
            // EmailIdTextBox
            // 
            this.EmailIdTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmailIdTextBox.Location = new System.Drawing.Point(254, 609);
            this.EmailIdTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EmailIdTextBox.Name = "EmailIdTextBox";
            this.EmailIdTextBox.Size = new System.Drawing.Size(242, 31);
            this.EmailIdTextBox.TabIndex = 10;
            this.EmailIdTextBox.TextChanged += new System.EventHandler(this.EmailIdTextBox_TextChanged);
            // 
            // DateReceivedLabel
            // 
            this.DateReceivedLabel.AutoSize = true;
            this.DateReceivedLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.DateReceivedLabel.Location = new System.Drawing.Point(93, 715);
            this.DateReceivedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DateReceivedLabel.Name = "DateReceivedLabel";
            this.DateReceivedLabel.Size = new System.Drawing.Size(153, 55);
            this.DateReceivedLabel.TabIndex = 27;
            this.DateReceivedLabel.Text = "Date Received";
            // 
            // DateReceivedTimePicker
            // 
            this.DateReceivedTimePicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DateReceivedTimePicker.Location = new System.Drawing.Point(254, 719);
            this.DateReceivedTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DateReceivedTimePicker.Name = "DateReceivedTimePicker";
            this.DateReceivedTimePicker.Size = new System.Drawing.Size(242, 31);
            this.DateReceivedTimePicker.TabIndex = 12;
            this.DateReceivedTimePicker.ValueChanged += new System.EventHandler(this.DateReceivedTimePicker_ValueChanged);
            // 
            // AddButton
            // 
            this.AddButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddButton.Enabled = false;
            this.AddButton.Location = new System.Drawing.Point(4, 4);
            this.AddButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(72, 24);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeleteButton.Location = new System.Drawing.Point(84, 4);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(72, 24);
            this.DeleteButton.TabIndex = 1;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClearButton.Location = new System.Drawing.Point(164, 4);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(74, 24);
            this.ClearButton.TabIndex = 2;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.genderLabel.Location = new System.Drawing.Point(163, 495);
            this.genderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(83, 55);
            this.genderLabel.TabIndex = 36;
            this.genderLabel.Text = "Gender";
            // 
            // genderTextBox
            // 
            this.genderTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.genderTextBox.Location = new System.Drawing.Point(254, 499);
            this.genderTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.genderTextBox.MaxLength = 1;
            this.genderTextBox.Name = "genderTextBox";
            this.genderTextBox.Size = new System.Drawing.Size(242, 31);
            this.genderTextBox.TabIndex = 8;
            this.genderTextBox.TextChanged += new System.EventHandler(this.GenderTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Location = new System.Drawing.Point(58, 660);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 55);
            this.label1.TabIndex = 38;
            this.label1.Text = "Proof of purchase attached";
            // 
            // proofOfPurchaseTextBox
            // 
            this.proofOfPurchaseTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.proofOfPurchaseTextBox.Location = new System.Drawing.Point(254, 664);
            this.proofOfPurchaseTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.proofOfPurchaseTextBox.MaxLength = 1;
            this.proofOfPurchaseTextBox.Name = "proofOfPurchaseTextBox";
            this.proofOfPurchaseTextBox.Size = new System.Drawing.Size(242, 31);
            this.proofOfPurchaseTextBox.TabIndex = 11;
            this.proofOfPurchaseTextBox.TextChanged += new System.EventHandler(this.ProofOfPurchaseTextBox_TextChanged);
            // 
            // dataEntryTableLayoutPanel
            // 
            this.dataEntryTableLayoutPanel.ColumnCount = 3;
            this.dataEntryTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.33433F));
            this.dataEntryTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.33433F));
            this.dataEntryTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.33133F));
            this.dataEntryTableLayoutPanel.Controls.Add(this.dataButtonsTableLayoutPanel, 1, 14);
            this.dataEntryTableLayoutPanel.Controls.Add(this.FnameLabel, 0, 1);
            this.dataEntryTableLayoutPanel.Controls.Add(this.FnameTextBox, 1, 1);
            this.dataEntryTableLayoutPanel.Controls.Add(this.proofOfPurchaseTextBox, 1, 12);
            this.dataEntryTableLayoutPanel.Controls.Add(this.MnameLabel, 0, 2);
            this.dataEntryTableLayoutPanel.Controls.Add(this.label1, 0, 12);
            this.dataEntryTableLayoutPanel.Controls.Add(this.MnameTextBox, 1, 2);
            this.dataEntryTableLayoutPanel.Controls.Add(this.genderTextBox, 1, 9);
            this.dataEntryTableLayoutPanel.Controls.Add(this.DateReceivedTimePicker, 1, 13);
            this.dataEntryTableLayoutPanel.Controls.Add(this.LnameLabel, 0, 3);
            this.dataEntryTableLayoutPanel.Controls.Add(this.genderLabel, 0, 9);
            this.dataEntryTableLayoutPanel.Controls.Add(this.LnameTextBox, 1, 3);
            this.dataEntryTableLayoutPanel.Controls.Add(this.DateReceivedLabel, 0, 13);
            this.dataEntryTableLayoutPanel.Controls.Add(this.Address_1Label, 0, 4);
            this.dataEntryTableLayoutPanel.Controls.Add(this.Address_1TextBox, 1, 4);
            this.dataEntryTableLayoutPanel.Controls.Add(this.Address_2Label, 0, 5);
            this.dataEntryTableLayoutPanel.Controls.Add(this.EmailIdTextBox, 1, 11);
            this.dataEntryTableLayoutPanel.Controls.Add(this.Address_2TextBox, 1, 5);
            this.dataEntryTableLayoutPanel.Controls.Add(this.EmailIdLabel, 0, 11);
            this.dataEntryTableLayoutPanel.Controls.Add(this.CityTextBox, 1, 6);
            this.dataEntryTableLayoutPanel.Controls.Add(this.PhoneNumberMaskedTextBox, 1, 10);
            this.dataEntryTableLayoutPanel.Controls.Add(this.PhoneNumberLabel, 0, 10);
            this.dataEntryTableLayoutPanel.Controls.Add(this.CityLabel, 0, 6);
            this.dataEntryTableLayoutPanel.Controls.Add(this.StateLabel, 0, 7);
            this.dataEntryTableLayoutPanel.Controls.Add(this.StateTextBox, 1, 7);
            this.dataEntryTableLayoutPanel.Controls.Add(this.ZipCodeLabel, 0, 8);
            this.dataEntryTableLayoutPanel.Controls.Add(this.ZipCodeTextBox, 1, 8);
            this.dataEntryTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataEntryTableLayoutPanel.Location = new System.Drawing.Point(4, 4);
            this.dataEntryTableLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataEntryTableLayoutPanel.Name = "dataEntryTableLayoutPanel";
            this.dataEntryTableLayoutPanel.RowCount = 15;
            this.dataEntryTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.872617F));
            this.dataEntryTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.872616F));
            this.dataEntryTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.872616F));
            this.dataEntryTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.872616F));
            this.dataEntryTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.872616F));
            this.dataEntryTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.872616F));
            this.dataEntryTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.872616F));
            this.dataEntryTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.872616F));
            this.dataEntryTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.872616F));
            this.dataEntryTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.872616F));
            this.dataEntryTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.872616F));
            this.dataEntryTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.872616F));
            this.dataEntryTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.872616F));
            this.dataEntryTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.872616F));
            this.dataEntryTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.783376F));
            this.dataEntryTableLayoutPanel.Size = new System.Drawing.Size(578, 810);
            this.dataEntryTableLayoutPanel.TabIndex = 41;
            // 
            // dataButtonsTableLayoutPanel
            // 
            this.dataButtonsTableLayoutPanel.ColumnCount = 3;
            this.dataButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.dataButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.dataButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.dataButtonsTableLayoutPanel.Controls.Add(this.DeleteButton, 1, 0);
            this.dataButtonsTableLayoutPanel.Controls.Add(this.ClearButton, 2, 0);
            this.dataButtonsTableLayoutPanel.Controls.Add(this.AddButton, 0, 0);
            this.dataButtonsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataButtonsTableLayoutPanel.Location = new System.Drawing.Point(254, 774);
            this.dataButtonsTableLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataButtonsTableLayoutPanel.Name = "dataButtonsTableLayoutPanel";
            this.dataButtonsTableLayoutPanel.RowCount = 1;
            this.dataButtonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.dataButtonsTableLayoutPanel.Size = new System.Drawing.Size(242, 32);
            this.dataButtonsTableLayoutPanel.TabIndex = 43;
            // 
            // listViewTableLayoutPanel
            // 
            this.listViewTableLayoutPanel.ColumnCount = 1;
            this.listViewTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.listViewTableLayoutPanel.Controls.Add(this.stateButtonsTableLayoutPanel, 0, 2);
            this.listViewTableLayoutPanel.Controls.Add(this.viewPortListView, 0, 1);
            this.listViewTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewTableLayoutPanel.Location = new System.Drawing.Point(590, 4);
            this.listViewTableLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listViewTableLayoutPanel.Name = "listViewTableLayoutPanel";
            this.listViewTableLayoutPanel.RowCount = 3;
            this.listViewTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.listViewTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88F));
            this.listViewTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.listViewTableLayoutPanel.Size = new System.Drawing.Size(578, 810);
            this.listViewTableLayoutPanel.TabIndex = 42;
            // 
            // stateButtonsTableLayoutPanel
            // 
            this.stateButtonsTableLayoutPanel.ColumnCount = 3;
            this.stateButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.stateButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.stateButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.stateButtonsTableLayoutPanel.Controls.Add(this.saveButton, 1, 0);
            this.stateButtonsTableLayoutPanel.Controls.Add(this.cancelButton, 2, 0);
            this.stateButtonsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stateButtonsTableLayoutPanel.Location = new System.Drawing.Point(4, 772);
            this.stateButtonsTableLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.stateButtonsTableLayoutPanel.Name = "stateButtonsTableLayoutPanel";
            this.stateButtonsTableLayoutPanel.RowCount = 1;
            this.stateButtonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.stateButtonsTableLayoutPanel.Size = new System.Drawing.Size(570, 34);
            this.stateButtonsTableLayoutPanel.TabIndex = 44;
            // 
            // saveButton
            // 
            this.saveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saveButton.Location = new System.Drawing.Point(194, 4);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(182, 26);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cancelButton.Location = new System.Drawing.Point(384, 4);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(182, 26);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.dataEntryTableLayoutPanel, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.listViewTableLayoutPanel, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1172, 818);
            this.tableLayoutPanel4.TabIndex = 43;
            // 
            // stripStatusLabel
            // 
            this.stripStatusLabel.Name = "stripStatusLabel";
            this.stripStatusLabel.Size = new System.Drawing.Size(127, 32);
            this.stripStatusLabel.Text = "Add mode";
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripStatusLabel});
            this.statusStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.statusStrip.Location = new System.Drawing.Point(0, 818);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(0, 0, 14, 0);
            this.statusStrip.Size = new System.Drawing.Size(1172, 42);
            this.statusStrip.TabIndex = 40;
            this.statusStrip.Text = "statusStrip1";
            // 
            // RebateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 860);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.statusStrip);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RebateForm";
            this.Text = "Rebate Form";
            this.Load += new System.EventHandler(this.RebateForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RebateForm_KeyPress);
            this.dataEntryTableLayoutPanel.ResumeLayout(false);
            this.dataEntryTableLayoutPanel.PerformLayout();
            this.dataButtonsTableLayoutPanel.ResumeLayout(false);
            this.listViewTableLayoutPanel.ResumeLayout(false);
            this.stateButtonsTableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.ListView viewPortListView;
        private System.Windows.Forms.ColumnHeader fnameCol;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader fname;
        private System.Windows.Forms.ColumnHeader lname;
        private System.Windows.Forms.ColumnHeader phNumberColumnHeader;
        private System.Windows.Forms.ColumnHeader fnameColumnHeader;
        private System.Windows.Forms.ColumnHeader lnameColumnHeader;
        private System.Windows.Forms.ColumnHeader phNumberColumnHeaderList;
        private System.Windows.Forms.Label FnameLabel;
        private System.Windows.Forms.Label MnameLabel;
        private System.Windows.Forms.TextBox FnameTextBox;
        private System.Windows.Forms.TextBox MnameTextBox;
        private System.Windows.Forms.Label LnameLabel;
        private System.Windows.Forms.TextBox LnameTextBox;
        private System.Windows.Forms.Label Address_1Label;
        private System.Windows.Forms.Label Address_2Label;
        private System.Windows.Forms.TextBox Address_1TextBox;
        private System.Windows.Forms.TextBox Address_2TextBox;
        private System.Windows.Forms.Label CityLabel;
        private System.Windows.Forms.TextBox CityTextBox;
        private System.Windows.Forms.Label StateLabel;
        private System.Windows.Forms.TextBox StateTextBox;
        private System.Windows.Forms.Label ZipCodeLabel;
        private System.Windows.Forms.TextBox ZipCodeTextBox;
        private System.Windows.Forms.MaskedTextBox PhoneNumberMaskedTextBox;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.Label EmailIdLabel;
        private System.Windows.Forms.TextBox EmailIdTextBox;
        private System.Windows.Forms.Label DateReceivedLabel;
        private System.Windows.Forms.DateTimePicker DateReceivedTimePicker;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.TextBox genderTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox proofOfPurchaseTextBox;
        private System.Windows.Forms.TableLayoutPanel dataEntryTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel listViewTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel dataButtonsTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TableLayoutPanel stateButtonsTableLayoutPanel;
        private System.Windows.Forms.ToolStripStatusLabel stripStatusLabel;
        private System.Windows.Forms.StatusStrip statusStrip;
    }
}

