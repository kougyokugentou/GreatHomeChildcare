
namespace GreatHomeChildcare
{
    partial class frmGuardianCrud
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label phoneNumberLabel;
            System.Windows.Forms.Label emailAddressLabel;
            System.Windows.Forms.Label isAdminLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGuardianCrud));
            this.idNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.guardianBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.emailAddressTextBox = new System.Windows.Forms.TextBox();
            this.isAdminComboBox = new System.Windows.Forms.ComboBox();
            this.btnCancelClose = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnSaveClose = new System.Windows.Forms.Button();
            this.panelPinEntry = new System.Windows.Forms.Panel();
            this.lblPinEntry = new System.Windows.Forms.Label();
            this.tbPinNumber = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            lastNameLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            phoneNumberLabel = new System.Windows.Forms.Label();
            emailAddressLabel = new System.Windows.Forms.Label();
            isAdminLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.idNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guardianBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneNumberNumericUpDown)).BeginInit();
            this.panelPinEntry.SuspendLayout();
            this.SuspendLayout();
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(12, 9);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(80, 17);
            lastNameLabel.TabIndex = 2;
            lastNameLabel.Text = "Last Name:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(150, 9);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(80, 17);
            firstNameLabel.TabIndex = 3;
            firstNameLabel.Text = "First Name:";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new System.Drawing.Point(12, 69);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new System.Drawing.Size(107, 17);
            phoneNumberLabel.TabIndex = 5;
            phoneNumberLabel.Text = "Phone Number:";
            // 
            // emailAddressLabel
            // 
            emailAddressLabel.AutoSize = true;
            emailAddressLabel.Location = new System.Drawing.Point(151, 69);
            emailAddressLabel.Name = "emailAddressLabel";
            emailAddressLabel.Size = new System.Drawing.Size(102, 17);
            emailAddressLabel.TabIndex = 7;
            emailAddressLabel.Text = "Email Address:";
            // 
            // isAdminLabel
            // 
            isAdminLabel.AutoSize = true;
            isAdminLabel.Location = new System.Drawing.Point(96, 130);
            isAdminLabel.Name = "isAdminLabel";
            isAdminLabel.Size = new System.Drawing.Size(65, 17);
            isAdminLabel.TabIndex = 12;
            isAdminLabel.Text = "is Admin:";
            // 
            // idNumericUpDown
            // 
            this.idNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.guardianBindingSource, "id", true));
            this.idNumericUpDown.Location = new System.Drawing.Point(8, 150);
            this.idNumericUpDown.Name = "idNumericUpDown";
            this.idNumericUpDown.ReadOnly = true;
            this.idNumericUpDown.Size = new System.Drawing.Size(65, 22);
            this.idNumericUpDown.TabIndex = 2;
            this.idNumericUpDown.TabStop = false;
            this.idNumericUpDown.Visible = false;
            // 
            // guardianBindingSource
            // 
            this.guardianBindingSource.DataSource = typeof(GreatHomeChildcare.Models.Guardian);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.guardianBindingSource, "LastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(15, 29);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.lastNameTextBox.TabIndex = 3;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.guardianBindingSource, "FirstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(153, 29);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.firstNameTextBox.TabIndex = 4;
            // 
            // phoneNumberNumericUpDown
            // 
            this.phoneNumberNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.guardianBindingSource, "PhoneNumber", true));
            this.phoneNumberNumericUpDown.Location = new System.Drawing.Point(15, 89);
            this.phoneNumberNumericUpDown.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.phoneNumberNumericUpDown.Minimum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.phoneNumberNumericUpDown.Name = "phoneNumberNumericUpDown";
            this.phoneNumberNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.phoneNumberNumericUpDown.TabIndex = 6;
            this.phoneNumberNumericUpDown.Value = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            // 
            // emailAddressTextBox
            // 
            this.emailAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.guardianBindingSource, "EmailAddress", true));
            this.emailAddressTextBox.Location = new System.Drawing.Point(153, 89);
            this.emailAddressTextBox.Name = "emailAddressTextBox";
            this.emailAddressTextBox.Size = new System.Drawing.Size(190, 22);
            this.emailAddressTextBox.TabIndex = 8;
            // 
            // isAdminComboBox
            // 
            this.isAdminComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.guardianBindingSource, "isAdmin", true));
            this.isAdminComboBox.FormattingEnabled = true;
            this.isAdminComboBox.Location = new System.Drawing.Point(79, 150);
            this.isAdminComboBox.Name = "isAdminComboBox";
            this.isAdminComboBox.Size = new System.Drawing.Size(121, 24);
            this.isAdminComboBox.TabIndex = 13;
            // 
            // btnCancelClose
            // 
            this.btnCancelClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelClose.ImageIndex = 0;
            this.btnCancelClose.ImageList = this.imageList1;
            this.btnCancelClose.Location = new System.Drawing.Point(21, 209);
            this.btnCancelClose.Name = "btnCancelClose";
            this.btnCancelClose.Size = new System.Drawing.Size(140, 50);
            this.btnCancelClose.TabIndex = 14;
            this.btnCancelClose.Text = "Cancel && Close";
            this.btnCancelClose.UseVisualStyleBackColor = true;
            this.btnCancelClose.Click += new System.EventHandler(this.btnCancelClose_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Cancel_16x.png");
            this.imageList1.Images.SetKeyName(1, "SaveClose_16x.png");
            // 
            // btnSaveClose
            // 
            this.btnSaveClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveClose.ImageIndex = 1;
            this.btnSaveClose.ImageList = this.imageList1;
            this.btnSaveClose.Location = new System.Drawing.Point(204, 208);
            this.btnSaveClose.Name = "btnSaveClose";
            this.btnSaveClose.Size = new System.Drawing.Size(139, 50);
            this.btnSaveClose.TabIndex = 15;
            this.btnSaveClose.Text = "Save && Close";
            this.btnSaveClose.UseVisualStyleBackColor = true;
            this.btnSaveClose.Click += new System.EventHandler(this.btnSaveClose_Click);
            // 
            // panelPinEntry
            // 
            this.panelPinEntry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPinEntry.Controls.Add(this.lblPinEntry);
            this.panelPinEntry.Controls.Add(this.tbPinNumber);
            this.panelPinEntry.Controls.Add(this.tableLayoutPanel1);
            this.panelPinEntry.Location = new System.Drawing.Point(360, 12);
            this.panelPinEntry.Name = "panelPinEntry";
            this.panelPinEntry.Size = new System.Drawing.Size(252, 297);
            this.panelPinEntry.TabIndex = 16;
            // 
            // lblPinEntry
            // 
            this.lblPinEntry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPinEntry.AutoSize = true;
            this.lblPinEntry.Location = new System.Drawing.Point(108, 9);
            this.lblPinEntry.Name = "lblPinEntry";
            this.lblPinEntry.Size = new System.Drawing.Size(34, 17);
            this.lblPinEntry.TabIndex = 4;
            this.lblPinEntry.Text = "PIN:";
            // 
            // tbPinNumber
            // 
            this.tbPinNumber.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbPinNumber.Location = new System.Drawing.Point(0, 33);
            this.tbPinNumber.MaxLength = 4;
            this.tbPinNumber.Name = "tbPinNumber";
            this.tbPinNumber.PasswordChar = '*';
            this.tbPinNumber.Size = new System.Drawing.Size(250, 22);
            this.tbPinNumber.TabIndex = 3;
            this.tbPinNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbPinNumber.UseSystemPasswordChar = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 55);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(250, 240);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // frmGuardianCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 321);
            this.Controls.Add(this.panelPinEntry);
            this.Controls.Add(this.btnSaveClose);
            this.Controls.Add(this.btnCancelClose);
            this.Controls.Add(isAdminLabel);
            this.Controls.Add(this.isAdminComboBox);
            this.Controls.Add(emailAddressLabel);
            this.Controls.Add(this.emailAddressTextBox);
            this.Controls.Add(phoneNumberLabel);
            this.Controls.Add(this.phoneNumberNumericUpDown);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.idNumericUpDown);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGuardianCrud";
            this.Text = "Guardian Management: Great Home Childcare";
            this.Load += new System.EventHandler(this.frmGuardianCrud_Load);
            ((System.ComponentModel.ISupportInitialize)(this.idNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guardianBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneNumberNumericUpDown)).EndInit();
            this.panelPinEntry.ResumeLayout(false);
            this.panelPinEntry.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource guardianBindingSource;
        private System.Windows.Forms.NumericUpDown idNumericUpDown;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.NumericUpDown phoneNumberNumericUpDown;
        private System.Windows.Forms.TextBox emailAddressTextBox;
        private System.Windows.Forms.ComboBox isAdminComboBox;
        private System.Windows.Forms.Button btnCancelClose;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnSaveClose;
        private System.Windows.Forms.Panel panelPinEntry;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblPinEntry;
        private System.Windows.Forms.TextBox tbPinNumber;
    }
}