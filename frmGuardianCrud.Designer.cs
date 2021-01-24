
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.isAdminComboBox = new System.Windows.Forms.ComboBox();
            lastNameLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            phoneNumberLabel = new System.Windows.Forms.Label();
            emailAddressLabel = new System.Windows.Forms.Label();
            isAdminLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.idNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guardianBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneNumberNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // idNumericUpDown
            // 
            this.idNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.guardianBindingSource, "id", true));
            this.idNumericUpDown.Location = new System.Drawing.Point(15, 121);
            this.idNumericUpDown.Name = "idNumericUpDown";
            this.idNumericUpDown.ReadOnly = true;
            this.idNumericUpDown.Size = new System.Drawing.Size(84, 22);
            this.idNumericUpDown.TabIndex = 2;
            this.idNumericUpDown.TabStop = false;
            this.idNumericUpDown.Visible = false;
            // 
            // guardianBindingSource
            // 
            this.guardianBindingSource.DataSource = typeof(GreatHomeChildcare.Models.Guardian);
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
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.guardianBindingSource, "LastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(15, 29);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.lastNameTextBox.TabIndex = 3;
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
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.guardianBindingSource, "FirstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(153, 29);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.firstNameTextBox.TabIndex = 4;
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
            // emailAddressLabel
            // 
            emailAddressLabel.AutoSize = true;
            emailAddressLabel.Location = new System.Drawing.Point(151, 69);
            emailAddressLabel.Name = "emailAddressLabel";
            emailAddressLabel.Size = new System.Drawing.Size(102, 17);
            emailAddressLabel.TabIndex = 7;
            emailAddressLabel.Text = "Email Address:";
            // 
            // emailAddressTextBox
            // 
            this.emailAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.guardianBindingSource, "EmailAddress", true));
            this.emailAddressTextBox.Location = new System.Drawing.Point(153, 89);
            this.emailAddressTextBox.Name = "emailAddressTextBox";
            this.emailAddressTextBox.Size = new System.Drawing.Size(100, 22);
            this.emailAddressTextBox.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(353, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(353, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Existing Guardians:";
            // 
            // isAdminLabel
            // 
            isAdminLabel.AutoSize = true;
            isAdminLabel.Location = new System.Drawing.Point(104, 155);
            isAdminLabel.Name = "isAdminLabel";
            isAdminLabel.Size = new System.Drawing.Size(65, 17);
            isAdminLabel.TabIndex = 12;
            isAdminLabel.Text = "is Admin:";
            // 
            // isAdminComboBox
            // 
            this.isAdminComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.guardianBindingSource, "isAdmin", true));
            this.isAdminComboBox.FormattingEnabled = true;
            this.isAdminComboBox.Location = new System.Drawing.Point(87, 175);
            this.isAdminComboBox.Name = "isAdminComboBox";
            this.isAdminComboBox.Size = new System.Drawing.Size(121, 24);
            this.isAdminComboBox.TabIndex = 13;
            // 
            // frmGuardianCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 450);
            this.Controls.Add(isAdminLabel);
            this.Controls.Add(this.isAdminComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
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
            this.Text = "frmGuardianCrud";
            ((System.ComponentModel.ISupportInitialize)(this.idNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guardianBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneNumberNumericUpDown)).EndInit();
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox isAdminComboBox;
    }
}