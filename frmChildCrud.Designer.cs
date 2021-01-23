namespace GreatHomeChildcare
{
    partial class frmChildCrud
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
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label raceLabel;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label photoLabel;
            System.Windows.Forms.Label addressLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChildCrud));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.childBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.raceTextBox = new System.Windows.Forms.TextBox();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.lblGuardians = new System.Windows.Forms.Label();
            this.dgvGuardians = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddGuardian = new System.Windows.Forms.Button();
            this.btnEditGuardian = new System.Windows.Forms.Button();
            this.btnDeleteGuardian = new System.Windows.Forms.Button();
            this.btnStartCam = new System.Windows.Forms.Button();
            this.btnPhotoFromDisk = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.photoPictureBox = new System.Windows.Forms.PictureBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.idNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.openFileDialogPhotoFromDisk = new System.Windows.Forms.OpenFileDialog();
            this.frmChildCrudBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.photoPanel = new System.Windows.Forms.Panel();
            this.btnTakePhoto = new System.Windows.Forms.Button();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            raceLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            photoLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.childBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuardians)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmChildCrudBindingSource)).BeginInit();
            this.photoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(12, 19);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(80, 17);
            firstNameLabel.TabIndex = 1;
            firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(171, 19);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(80, 17);
            lastNameLabel.TabIndex = 3;
            lastNameLabel.Text = "Last Name:";
            // 
            // raceLabel
            // 
            raceLabel.AutoSize = true;
            raceLabel.Location = new System.Drawing.Point(12, 87);
            raceLabel.Name = "raceLabel";
            raceLabel.Size = new System.Drawing.Size(40, 17);
            raceLabel.TabIndex = 5;
            raceLabel.Text = "race:";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new System.Drawing.Point(180, 87);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(57, 17);
            genderLabel.TabIndex = 7;
            genderLabel.Text = "gender:";
            // 
            // photoLabel
            // 
            photoLabel.AutoSize = true;
            photoLabel.Location = new System.Drawing.Point(374, 1);
            photoLabel.Name = "photoLabel";
            photoLabel.Size = new System.Drawing.Size(48, 17);
            photoLabel.TabIndex = 21;
            photoLabel.Text = "photo:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            addressLabel.ImageIndex = 1;
            addressLabel.ImageList = this.imageList1;
            addressLabel.Location = new System.Drawing.Point(12, 165);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(84, 17);
            addressLabel.TabIndex = 9;
            addressLabel.Text = "     Address:";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "AddButton_16x.png");
            this.imageList1.Images.SetKeyName(1, "Address_16x.png");
            this.imageList1.Images.SetKeyName(2, "Camera_16x.png");
            this.imageList1.Images.SetKeyName(3, "Cancel_16x.png");
            this.imageList1.Images.SetKeyName(4, "DeleteUser_16x.png");
            this.imageList1.Images.SetKeyName(5, "Edit_16x.png");
            this.imageList1.Images.SetKeyName(6, "SaveClose_16x.png");
            this.imageList1.Images.SetKeyName(7, "OpenfileDialog_16x.png");
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.childBindingSource, "FirstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(15, 39);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.firstNameTextBox.TabIndex = 2;
            // 
            // childBindingSource
            // 
            this.childBindingSource.DataSource = typeof(GreatHomeChildcare.Models.Child);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.childBindingSource, "LastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(174, 39);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.lastNameTextBox.TabIndex = 4;
            // 
            // raceTextBox
            // 
            this.raceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.childBindingSource, "race", true));
            this.raceTextBox.Location = new System.Drawing.Point(15, 107);
            this.raceTextBox.Name = "raceTextBox";
            this.raceTextBox.Size = new System.Drawing.Size(100, 22);
            this.raceTextBox.TabIndex = 6;
            // 
            // genderComboBox
            // 
            this.genderComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.childBindingSource, "gender", true));
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Location = new System.Drawing.Point(174, 107);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(121, 24);
            this.genderComboBox.TabIndex = 8;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.childBindingSource, "address", true));
            this.addressTextBox.Location = new System.Drawing.Point(12, 185);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(283, 79);
            this.addressTextBox.TabIndex = 10;
            // 
            // lblGuardians
            // 
            this.lblGuardians.AutoSize = true;
            this.lblGuardians.Location = new System.Drawing.Point(12, 300);
            this.lblGuardians.Name = "lblGuardians";
            this.lblGuardians.Size = new System.Drawing.Size(74, 17);
            this.lblGuardians.TabIndex = 11;
            this.lblGuardians.Text = "Guardians";
            // 
            // dgvGuardians
            // 
            this.dgvGuardians.AllowUserToAddRows = false;
            this.dgvGuardians.AllowUserToDeleteRows = false;
            this.dgvGuardians.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGuardians.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.LastName,
            this.FirstName,
            this.PhoneNumber,
            this.EmailAddress});
            this.dgvGuardians.Location = new System.Drawing.Point(15, 320);
            this.dgvGuardians.Name = "dgvGuardians";
            this.dgvGuardians.ReadOnly = true;
            this.dgvGuardians.RowHeadersWidth = 51;
            this.dgvGuardians.RowTemplate.Height = 24;
            this.dgvGuardians.Size = new System.Drawing.Size(807, 106);
            this.dgvGuardians.TabIndex = 12;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 125;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "LastName";
            this.LastName.MinimumWidth = 6;
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            this.LastName.Width = 125;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "FirstName";
            this.FirstName.MinimumWidth = 6;
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            this.FirstName.Width = 125;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.HeaderText = "PhoneNumber";
            this.PhoneNumber.MinimumWidth = 6;
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.ReadOnly = true;
            this.PhoneNumber.Width = 125;
            // 
            // EmailAddress
            // 
            this.EmailAddress.HeaderText = "EmailAddress";
            this.EmailAddress.MinimumWidth = 6;
            this.EmailAddress.Name = "EmailAddress";
            this.EmailAddress.ReadOnly = true;
            this.EmailAddress.Width = 125;
            // 
            // btnAddGuardian
            // 
            this.btnAddGuardian.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddGuardian.ImageKey = "AddButton_16x.png";
            this.btnAddGuardian.ImageList = this.imageList1;
            this.btnAddGuardian.Location = new System.Drawing.Point(18, 439);
            this.btnAddGuardian.Name = "btnAddGuardian";
            this.btnAddGuardian.Size = new System.Drawing.Size(168, 26);
            this.btnAddGuardian.TabIndex = 13;
            this.btnAddGuardian.Text = "Add Guardian";
            this.btnAddGuardian.UseVisualStyleBackColor = true;
            this.btnAddGuardian.Click += new System.EventHandler(this.btnAddGuardian_Click);
            // 
            // btnEditGuardian
            // 
            this.btnEditGuardian.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditGuardian.ImageIndex = 5;
            this.btnEditGuardian.ImageList = this.imageList1;
            this.btnEditGuardian.Location = new System.Drawing.Point(305, 439);
            this.btnEditGuardian.Name = "btnEditGuardian";
            this.btnEditGuardian.Size = new System.Drawing.Size(185, 26);
            this.btnEditGuardian.TabIndex = 14;
            this.btnEditGuardian.Text = "Edit Guardian";
            this.btnEditGuardian.UseVisualStyleBackColor = true;
            this.btnEditGuardian.Click += new System.EventHandler(this.btnEditGuardian_Click);
            // 
            // btnDeleteGuardian
            // 
            this.btnDeleteGuardian.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteGuardian.ImageIndex = 4;
            this.btnDeleteGuardian.ImageList = this.imageList1;
            this.btnDeleteGuardian.Location = new System.Drawing.Point(634, 439);
            this.btnDeleteGuardian.Name = "btnDeleteGuardian";
            this.btnDeleteGuardian.Size = new System.Drawing.Size(175, 26);
            this.btnDeleteGuardian.TabIndex = 15;
            this.btnDeleteGuardian.Text = "Delete Guardian";
            this.btnDeleteGuardian.UseVisualStyleBackColor = true;
            this.btnDeleteGuardian.Click += new System.EventHandler(this.btnDeleteGuardian_Click);
            // 
            // btnStartCam
            // 
            this.btnStartCam.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStartCam.ImageIndex = 2;
            this.btnStartCam.ImageList = this.imageList1;
            this.btnStartCam.Location = new System.Drawing.Point(325, 204);
            this.btnStartCam.Name = "btnStartCam";
            this.btnStartCam.Size = new System.Drawing.Size(146, 42);
            this.btnStartCam.TabIndex = 18;
            this.btnStartCam.Text = "Start Camera";
            this.btnStartCam.UseVisualStyleBackColor = true;
            this.btnStartCam.Click += new System.EventHandler(this.btnStartCam_Click);
            // 
            // btnPhotoFromDisk
            // 
            this.btnPhotoFromDisk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPhotoFromDisk.ImageIndex = 7;
            this.btnPhotoFromDisk.ImageList = this.imageList1;
            this.btnPhotoFromDisk.Location = new System.Drawing.Point(325, 263);
            this.btnPhotoFromDisk.Name = "btnPhotoFromDisk";
            this.btnPhotoFromDisk.Size = new System.Drawing.Size(147, 41);
            this.btnPhotoFromDisk.TabIndex = 19;
            this.btnPhotoFromDisk.Text = "From Disk";
            this.btnPhotoFromDisk.UseVisualStyleBackColor = true;
            this.btnPhotoFromDisk.Click += new System.EventHandler(this.btnPhotoFromDisk_Click);
            // 
            // btnSave
            // 
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.ImageIndex = 6;
            this.btnSave.ImageList = this.imageList1;
            this.btnSave.Location = new System.Drawing.Point(675, 61);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(147, 43);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Save && Close";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // photoPictureBox
            // 
            this.photoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.childBindingSource, "photo", true));
            this.photoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.photoPictureBox.Image = global::GreatHomeChildcare.Properties.Resources.child;
            this.photoPictureBox.Location = new System.Drawing.Point(0, 0);
            this.photoPictureBox.Name = "photoPictureBox";
            this.photoPictureBox.Size = new System.Drawing.Size(156, 161);
            this.photoPictureBox.TabIndex = 22;
            this.photoPictureBox.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.ImageIndex = 3;
            this.btnCancel.ImageList = this.imageList1;
            this.btnCancel.Location = new System.Drawing.Point(675, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(147, 43);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "Cancel && Close";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // idNumericUpDown
            // 
            this.idNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.childBindingSource, "id", true));
            this.idNumericUpDown.Location = new System.Drawing.Point(733, 126);
            this.idNumericUpDown.Name = "idNumericUpDown";
            this.idNumericUpDown.ReadOnly = true;
            this.idNumericUpDown.Size = new System.Drawing.Size(76, 22);
            this.idNumericUpDown.TabIndex = 24;
            this.idNumericUpDown.TabStop = false;
            this.idNumericUpDown.Visible = false;
            // 
            // openFileDialogPhotoFromDisk
            // 
            this.openFileDialogPhotoFromDisk.FileName = "openFileDialog1";
            // 
            // frmChildCrudBindingSource
            // 
            this.frmChildCrudBindingSource.DataSource = typeof(GreatHomeChildcare.frmChildCrud);
            // 
            // photoPanel
            // 
            this.photoPanel.Controls.Add(this.photoPictureBox);
            this.photoPanel.Location = new System.Drawing.Point(315, 21);
            this.photoPanel.Name = "photoPanel";
            this.photoPanel.Size = new System.Drawing.Size(156, 161);
            this.photoPanel.TabIndex = 25;
            // 
            // btnTakePhoto
            // 
            this.btnTakePhoto.Enabled = false;
            this.btnTakePhoto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTakePhoto.ImageIndex = 2;
            this.btnTakePhoto.ImageList = this.imageList1;
            this.btnTakePhoto.Location = new System.Drawing.Point(487, 204);
            this.btnTakePhoto.Name = "btnTakePhoto";
            this.btnTakePhoto.Size = new System.Drawing.Size(136, 42);
            this.btnTakePhoto.TabIndex = 26;
            this.btnTakePhoto.Text = "Take Photo";
            this.btnTakePhoto.UseVisualStyleBackColor = true;
            this.btnTakePhoto.Click += new System.EventHandler(this.btnTakePhoto_Click);
            // 
            // frmChildCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 608);
            this.Controls.Add(this.btnTakePhoto);
            this.Controls.Add(this.photoPanel);
            this.Controls.Add(this.idNumericUpDown);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(photoLabel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnPhotoFromDisk);
            this.Controls.Add(this.btnStartCam);
            this.Controls.Add(this.btnDeleteGuardian);
            this.Controls.Add(this.btnEditGuardian);
            this.Controls.Add(this.btnAddGuardian);
            this.Controls.Add(this.dgvGuardians);
            this.Controls.Add(this.lblGuardians);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(genderLabel);
            this.Controls.Add(this.genderComboBox);
            this.Controls.Add(raceLabel);
            this.Controls.Add(this.raceTextBox);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Name = "frmChildCrud";
            this.Text = "Child Management : Great Home Childcare";
            this.Load += new System.EventHandler(this.frmChildCrud_Load);
            ((System.ComponentModel.ISupportInitialize)(this.childBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuardians)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmChildCrudBindingSource)).EndInit();
            this.photoPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource childBindingSource;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox raceTextBox;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label lblGuardians;
        private System.Windows.Forms.DataGridView dgvGuardians;
        private System.Windows.Forms.Button btnAddGuardian;
        private System.Windows.Forms.Button btnEditGuardian;
        private System.Windows.Forms.Button btnDeleteGuardian;
        private System.Windows.Forms.Button btnStartCam;
        private System.Windows.Forms.Button btnPhotoFromDisk;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox photoPictureBox;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.NumericUpDown idNumericUpDown;
        private System.Windows.Forms.BindingSource frmChildCrudBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailAddress;
        private System.Windows.Forms.OpenFileDialog openFileDialogPhotoFromDisk;
        private System.Windows.Forms.Panel photoPanel;
        private System.Windows.Forms.Button btnTakePhoto;
    }
}