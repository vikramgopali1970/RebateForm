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
            this.FnameLabel = new System.Windows.Forms.Label();
            this.MnameLabel = new System.Windows.Forms.Label();
            this.FnameTextBox = new System.Windows.Forms.TextBox();
            this.MnameTextBox = new System.Windows.Forms.TextBox();
            this.viewPortListView = new System.Windows.Forms.ListView();
            this.fnameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lnameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.phNumberColumnHeaderList = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.phNumberColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LnameTextBox = new System.Windows.Forms.TextBox();
            this.LnameLabel = new System.Windows.Forms.Label();
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
            this.MaleRadioButton = new System.Windows.Forms.RadioButton();
            this.FemaleRadioButton = new System.Windows.Forms.RadioButton();
            this.PhoneNumberMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.EmailIdLabel = new System.Windows.Forms.Label();
            this.EmailIdTextBox = new System.Windows.Forms.TextBox();
            this.DateReceivedLabel = new System.Windows.Forms.Label();
            this.DateReceivedTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.YesRadioButton = new System.Windows.Forms.RadioButton();
            this.NoRadioButton = new System.Windows.Forms.RadioButton();
            this.fnameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // FnameLabel
            // 
            this.FnameLabel.AutoSize = true;
            this.FnameLabel.Location = new System.Drawing.Point(71, 128);
            this.FnameLabel.Name = "FnameLabel";
            this.FnameLabel.Size = new System.Drawing.Size(116, 25);
            this.FnameLabel.TabIndex = 0;
            this.FnameLabel.Text = "First Name";
            // 
            // MnameLabel
            // 
            this.MnameLabel.AutoSize = true;
            this.MnameLabel.Location = new System.Drawing.Point(71, 170);
            this.MnameLabel.Name = "MnameLabel";
            this.MnameLabel.Size = new System.Drawing.Size(138, 25);
            this.MnameLabel.TabIndex = 1;
            this.MnameLabel.Text = "Middle Name";
            // 
            // FnameTextBox
            // 
            this.FnameTextBox.Location = new System.Drawing.Point(211, 122);
            this.FnameTextBox.MaxLength = 20;
            this.FnameTextBox.Name = "FnameTextBox";
            this.FnameTextBox.Size = new System.Drawing.Size(282, 31);
            this.FnameTextBox.TabIndex = 2;
            // 
            // MnameTextBox
            // 
            this.MnameTextBox.Location = new System.Drawing.Point(211, 164);
            this.MnameTextBox.Name = "MnameTextBox";
            this.MnameTextBox.Size = new System.Drawing.Size(282, 31);
            this.MnameTextBox.TabIndex = 3;
            // 
            // viewPortListView
            // 
            this.viewPortListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.fnameColumnHeader,
            this.lnameColumnHeader,
            this.phNumberColumnHeaderList});
            this.viewPortListView.FullRowSelect = true;
            this.viewPortListView.HideSelection = false;
            this.viewPortListView.Location = new System.Drawing.Point(645, 114);
            this.viewPortListView.Name = "viewPortListView";
            this.viewPortListView.Size = new System.Drawing.Size(679, 729);
            this.viewPortListView.TabIndex = 4;
            this.viewPortListView.UseCompatibleStateImageBehavior = false;
            this.viewPortListView.View = System.Windows.Forms.View.Details;
            this.viewPortListView.SelectedIndexChanged += new System.EventHandler(this.ViewPortListView_SelectedIndexChanged);
            // 
            // fnameColumnHeader
            // 
            this.fnameColumnHeader.Text = "First Name";
            this.fnameColumnHeader.Width = 116;
            // 
            // lnameColumnHeader
            // 
            this.lnameColumnHeader.Text = "Last Name";
            this.lnameColumnHeader.Width = 115;
            // 
            // phNumberColumnHeaderList
            // 
            this.phNumberColumnHeaderList.Text = "Phone Number";
            this.phNumberColumnHeaderList.Width = 210;
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
            // LnameTextBox
            // 
            this.LnameTextBox.Location = new System.Drawing.Point(211, 208);
            this.LnameTextBox.MaxLength = 20;
            this.LnameTextBox.Name = "LnameTextBox";
            this.LnameTextBox.Size = new System.Drawing.Size(282, 31);
            this.LnameTextBox.TabIndex = 6;
            // 
            // LnameLabel
            // 
            this.LnameLabel.AutoSize = true;
            this.LnameLabel.Location = new System.Drawing.Point(71, 214);
            this.LnameLabel.Name = "LnameLabel";
            this.LnameLabel.Size = new System.Drawing.Size(115, 25);
            this.LnameLabel.TabIndex = 5;
            this.LnameLabel.Text = "Last Name";
            // 
            // Address_1Label
            // 
            this.Address_1Label.AutoSize = true;
            this.Address_1Label.Location = new System.Drawing.Point(71, 266);
            this.Address_1Label.Name = "Address_1Label";
            this.Address_1Label.Size = new System.Drawing.Size(149, 25);
            this.Address_1Label.TabIndex = 7;
            this.Address_1Label.Text = "Address line 1";
            // 
            // Address_2Label
            // 
            this.Address_2Label.AutoSize = true;
            this.Address_2Label.Location = new System.Drawing.Point(71, 310);
            this.Address_2Label.Name = "Address_2Label";
            this.Address_2Label.Size = new System.Drawing.Size(149, 25);
            this.Address_2Label.TabIndex = 8;
            this.Address_2Label.Text = "Address line 2";
            // 
            // Address_1TextBox
            // 
            this.Address_1TextBox.Location = new System.Drawing.Point(247, 260);
            this.Address_1TextBox.MaxLength = 35;
            this.Address_1TextBox.Name = "Address_1TextBox";
            this.Address_1TextBox.Size = new System.Drawing.Size(246, 31);
            this.Address_1TextBox.TabIndex = 9;
            // 
            // Address_2TextBox
            // 
            this.Address_2TextBox.Location = new System.Drawing.Point(247, 304);
            this.Address_2TextBox.MaxLength = 35;
            this.Address_2TextBox.Name = "Address_2TextBox";
            this.Address_2TextBox.Size = new System.Drawing.Size(246, 31);
            this.Address_2TextBox.TabIndex = 10;
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.Location = new System.Drawing.Point(71, 360);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(49, 25);
            this.CityLabel.TabIndex = 11;
            this.CityLabel.Text = "City";
            // 
            // CityTextBox
            // 
            this.CityTextBox.Location = new System.Drawing.Point(126, 354);
            this.CityTextBox.MaxLength = 25;
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(234, 31);
            this.CityTextBox.TabIndex = 12;
            // 
            // StateLabel
            // 
            this.StateLabel.AutoSize = true;
            this.StateLabel.Location = new System.Drawing.Point(366, 357);
            this.StateLabel.Name = "StateLabel";
            this.StateLabel.Size = new System.Drawing.Size(62, 25);
            this.StateLabel.TabIndex = 13;
            this.StateLabel.Text = "State";
            // 
            // StateTextBox
            // 
            this.StateTextBox.Location = new System.Drawing.Point(429, 351);
            this.StateTextBox.MaxLength = 2;
            this.StateTextBox.Name = "StateTextBox";
            this.StateTextBox.Size = new System.Drawing.Size(65, 31);
            this.StateTextBox.TabIndex = 14;
            // 
            // ZipCodeLabel
            // 
            this.ZipCodeLabel.AutoSize = true;
            this.ZipCodeLabel.Location = new System.Drawing.Point(71, 412);
            this.ZipCodeLabel.Name = "ZipCodeLabel";
            this.ZipCodeLabel.Size = new System.Drawing.Size(99, 25);
            this.ZipCodeLabel.TabIndex = 15;
            this.ZipCodeLabel.Text = "Zip Code";
            // 
            // ZipCodeTextBox
            // 
            this.ZipCodeTextBox.Location = new System.Drawing.Point(176, 406);
            this.ZipCodeTextBox.MaxLength = 9;
            this.ZipCodeTextBox.Name = "ZipCodeTextBox";
            this.ZipCodeTextBox.Size = new System.Drawing.Size(317, 31);
            this.ZipCodeTextBox.TabIndex = 16;
            // 
            // MaleRadioButton
            // 
            this.MaleRadioButton.AutoSize = true;
            this.MaleRadioButton.Location = new System.Drawing.Point(45, 30);
            this.MaleRadioButton.Name = "MaleRadioButton";
            this.MaleRadioButton.Size = new System.Drawing.Size(90, 29);
            this.MaleRadioButton.TabIndex = 18;
            this.MaleRadioButton.TabStop = true;
            this.MaleRadioButton.Text = "Male";
            this.MaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // FemaleRadioButton
            // 
            this.FemaleRadioButton.AutoSize = true;
            this.FemaleRadioButton.Location = new System.Drawing.Point(147, 30);
            this.FemaleRadioButton.Name = "FemaleRadioButton";
            this.FemaleRadioButton.Size = new System.Drawing.Size(114, 29);
            this.FemaleRadioButton.TabIndex = 19;
            this.FemaleRadioButton.TabStop = true;
            this.FemaleRadioButton.Text = "Female";
            this.FemaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // PhoneNumberMaskedTextBox
            // 
            this.PhoneNumberMaskedTextBox.Location = new System.Drawing.Point(232, 557);
            this.PhoneNumberMaskedTextBox.Name = "PhoneNumberMaskedTextBox";
            this.PhoneNumberMaskedTextBox.Size = new System.Drawing.Size(261, 31);
            this.PhoneNumberMaskedTextBox.TabIndex = 20;
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Location = new System.Drawing.Point(71, 560);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(155, 25);
            this.PhoneNumberLabel.TabIndex = 21;
            this.PhoneNumberLabel.Text = "Phone Number";
            // 
            // EmailIdLabel
            // 
            this.EmailIdLabel.AutoSize = true;
            this.EmailIdLabel.Location = new System.Drawing.Point(71, 605);
            this.EmailIdLabel.Name = "EmailIdLabel";
            this.EmailIdLabel.Size = new System.Drawing.Size(150, 25);
            this.EmailIdLabel.TabIndex = 22;
            this.EmailIdLabel.Text = "Email Address";
            // 
            // EmailIdTextBox
            // 
            this.EmailIdTextBox.Location = new System.Drawing.Point(232, 602);
            this.EmailIdTextBox.Name = "EmailIdTextBox";
            this.EmailIdTextBox.Size = new System.Drawing.Size(261, 31);
            this.EmailIdTextBox.TabIndex = 23;
            // 
            // DateReceivedLabel
            // 
            this.DateReceivedLabel.AutoSize = true;
            this.DateReceivedLabel.Location = new System.Drawing.Point(71, 797);
            this.DateReceivedLabel.Name = "DateReceivedLabel";
            this.DateReceivedLabel.Size = new System.Drawing.Size(153, 25);
            this.DateReceivedLabel.TabIndex = 27;
            this.DateReceivedLabel.Text = "Date Received";
            // 
            // DateReceivedTimePicker
            // 
            this.DateReceivedTimePicker.Location = new System.Drawing.Point(247, 791);
            this.DateReceivedTimePicker.Name = "DateReceivedTimePicker";
            this.DateReceivedTimePicker.Size = new System.Drawing.Size(246, 31);
            this.DateReceivedTimePicker.TabIndex = 28;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(86, 889);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(109, 40);
            this.AddButton.TabIndex = 29;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(221, 889);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(109, 40);
            this.DeleteButton.TabIndex = 30;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(357, 889);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(109, 40);
            this.ClearButton.TabIndex = 31;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MaleRadioButton);
            this.groupBox1.Controls.Add(this.FemaleRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(76, 460);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 78);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gender";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.YesRadioButton);
            this.groupBox2.Controls.Add(this.NoRadioButton);
            this.groupBox2.Location = new System.Drawing.Point(76, 662);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(277, 112);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Proof of Purchase Attached";
            // 
            // YesRadioButton
            // 
            this.YesRadioButton.AutoSize = true;
            this.YesRadioButton.Location = new System.Drawing.Point(43, 61);
            this.YesRadioButton.Name = "YesRadioButton";
            this.YesRadioButton.Size = new System.Drawing.Size(81, 29);
            this.YesRadioButton.TabIndex = 18;
            this.YesRadioButton.TabStop = true;
            this.YesRadioButton.Text = "Yes";
            this.YesRadioButton.UseVisualStyleBackColor = true;
            // 
            // NoRadioButton
            // 
            this.NoRadioButton.AutoSize = true;
            this.NoRadioButton.Location = new System.Drawing.Point(145, 61);
            this.NoRadioButton.Name = "NoRadioButton";
            this.NoRadioButton.Size = new System.Drawing.Size(70, 29);
            this.NoRadioButton.TabIndex = 19;
            this.NoRadioButton.TabStop = true;
            this.NoRadioButton.Text = "No";
            this.NoRadioButton.UseVisualStyleBackColor = true;
            // 
            // fnameCol
            // 
            this.fnameCol.Text = "First Name";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(1063, 912);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(123, 47);
            this.saveButton.TabIndex = 34;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(1213, 912);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(133, 47);
            this.cancelButton.TabIndex = 35;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // RebateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1408, 1006);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.DateReceivedTimePicker);
            this.Controls.Add(this.DateReceivedLabel);
            this.Controls.Add(this.EmailIdTextBox);
            this.Controls.Add(this.EmailIdLabel);
            this.Controls.Add(this.PhoneNumberLabel);
            this.Controls.Add(this.PhoneNumberMaskedTextBox);
            this.Controls.Add(this.ZipCodeTextBox);
            this.Controls.Add(this.ZipCodeLabel);
            this.Controls.Add(this.StateTextBox);
            this.Controls.Add(this.StateLabel);
            this.Controls.Add(this.CityTextBox);
            this.Controls.Add(this.CityLabel);
            this.Controls.Add(this.Address_2TextBox);
            this.Controls.Add(this.Address_1TextBox);
            this.Controls.Add(this.Address_2Label);
            this.Controls.Add(this.Address_1Label);
            this.Controls.Add(this.LnameTextBox);
            this.Controls.Add(this.LnameLabel);
            this.Controls.Add(this.viewPortListView);
            this.Controls.Add(this.MnameTextBox);
            this.Controls.Add(this.FnameTextBox);
            this.Controls.Add(this.MnameLabel);
            this.Controls.Add(this.FnameLabel);
            this.Name = "RebateForm";
            this.Text = "Rebate Form";
            this.Load += new System.EventHandler(this.RebateForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FnameLabel;
        private System.Windows.Forms.Label MnameLabel;
        private System.Windows.Forms.TextBox FnameTextBox;
        private System.Windows.Forms.TextBox MnameTextBox;
        private System.Windows.Forms.TextBox LnameTextBox;
        private System.Windows.Forms.Label LnameLabel;
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
        private System.Windows.Forms.RadioButton MaleRadioButton;
        private System.Windows.Forms.RadioButton FemaleRadioButton;
        private System.Windows.Forms.MaskedTextBox PhoneNumberMaskedTextBox;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.Label EmailIdLabel;
        private System.Windows.Forms.TextBox EmailIdTextBox;
        private System.Windows.Forms.Label DateReceivedLabel;
        private System.Windows.Forms.DateTimePicker DateReceivedTimePicker;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton YesRadioButton;
        private System.Windows.Forms.RadioButton NoRadioButton;
        internal System.Windows.Forms.ListView viewPortListView;
        private System.Windows.Forms.ColumnHeader fnameCol;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader fname;
        private System.Windows.Forms.ColumnHeader lname;
        private System.Windows.Forms.ColumnHeader phNumberColumnHeader;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ColumnHeader fnameColumnHeader;
        private System.Windows.Forms.ColumnHeader lnameColumnHeader;
        private System.Windows.Forms.ColumnHeader phNumberColumnHeaderList;
    }
}

