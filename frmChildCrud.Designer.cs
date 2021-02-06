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
            System.Windows.Forms.Label dOBLabel;
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.raceTextBox = new System.Windows.Forms.TextBox();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.lblGuardians = new System.Windows.Forms.Label();
            this.dgvGuardians = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isAdmin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddExistingGuardian = new System.Windows.Forms.Button();
            this.btnEditGuardian = new System.Windows.Forms.Button();
            this.btnDeleteGuardian = new System.Windows.Forms.Button();
            this.btnPhotoFromCam = new System.Windows.Forms.Button();
            this.btnPhotoFromDisk = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.photoPictureBox = new System.Windows.Forms.PictureBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.idNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.dOBMonthCalendar = new System.Windows.Forms.MonthCalendar();
            this.pic_openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblExistingGuardians = new System.Windows.Forms.Label();
            this.cbExistingGuardians = new System.Windows.Forms.ComboBox();
            this.btnNewGuardian = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.childBindingSource = new System.Windows.Forms.BindingSource(this.components);
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            raceLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            photoLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            dOBLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuardians)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.childBindingSource)).BeginInit();
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
            photoLabel.Location = new System.Drawing.Point(704, -1);
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
            this.imageList1.Images.SetKeyName(8, "Add_16x.png");
            // 
            // dOBLabel
            // 
            dOBLabel.AutoSize = true;
            dOBLabel.Location = new System.Drawing.Point(425, 19);
            dOBLabel.Name = "dOBLabel";
            dOBLabel.Size = new System.Drawing.Size(42, 17);
            dOBLabel.TabIndex = 24;
            dOBLabel.Text = "DOB:";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.childBindingSource, "FirstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(15, 39);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.firstNameTextBox.TabIndex = 2;
            this.firstNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.String_TextBox_Validating);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.childBindingSource, "LastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(174, 39);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.lastNameTextBox.TabIndex = 4;
            this.lastNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.String_TextBox_Validating);
            // 
            // raceTextBox
            // 
            this.raceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.childBindingSource, "race", true));
            this.raceTextBox.Location = new System.Drawing.Point(15, 107);
            this.raceTextBox.Name = "raceTextBox";
            this.raceTextBox.Size = new System.Drawing.Size(100, 22);
            this.raceTextBox.TabIndex = 6;
            this.raceTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.String_TextBox_Validating);
            // 
            // genderComboBox
            // 
            this.genderComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.childBindingSource, "gender", true));
            this.genderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Location = new System.Drawing.Point(174, 107);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(121, 24);
            this.genderComboBox.TabIndex = 8;
            this.genderComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.genderComboBox_Validating);
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.childBindingSource, "address", true));
            this.addressTextBox.Location = new System.Drawing.Point(12, 185);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(283, 79);
            this.addressTextBox.TabIndex = 10;
            this.addressTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.String_TextBox_Validating);
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
            this.isAdmin,
            this.LastName,
            this.FirstName,
            this.PhoneNumber,
            this.EmailAddress});
            this.dgvGuardians.Location = new System.Drawing.Point(15, 320);
            this.dgvGuardians.Name = "dgvGuardians";
            this.dgvGuardians.ReadOnly = true;
            this.dgvGuardians.RowHeadersWidth = 51;
            this.dgvGuardians.RowTemplate.Height = 24;
            this.dgvGuardians.Size = new System.Drawing.Size(979, 106);
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
            // isAdmin
            // 
            this.isAdmin.HeaderText = "isAdmin";
            this.isAdmin.MinimumWidth = 6;
            this.isAdmin.Name = "isAdmin";
            this.isAdmin.ReadOnly = true;
            this.isAdmin.Visible = false;
            this.isAdmin.Width = 125;
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
            // btnAddExistingGuardian
            // 
            this.btnAddExistingGuardian.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddExistingGuardian.ImageKey = "AddButton_16x.png";
            this.btnAddExistingGuardian.ImageList = this.imageList1;
            this.btnAddExistingGuardian.Location = new System.Drawing.Point(206, 441);
            this.btnAddExistingGuardian.Name = "btnAddExistingGuardian";
            this.btnAddExistingGuardian.Size = new System.Drawing.Size(241, 75);
            this.btnAddExistingGuardian.TabIndex = 13;
            this.btnAddExistingGuardian.Text = "Add Chosen Existing\r\nGuardian (from Dropdown)\r\nto Child";
            this.btnAddExistingGuardian.UseVisualStyleBackColor = true;
            this.btnAddExistingGuardian.Click += new System.EventHandler(this.btnAddExistingGuardian_Click);
            // 
            // btnEditGuardian
            // 
            this.btnEditGuardian.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditGuardian.ImageIndex = 5;
            this.btnEditGuardian.ImageList = this.imageList1;
            this.btnEditGuardian.Location = new System.Drawing.Point(756, 438);
            this.btnEditGuardian.Name = "btnEditGuardian";
            this.btnEditGuardian.Size = new System.Drawing.Size(225, 34);
            this.btnEditGuardian.TabIndex = 14;
            this.btnEditGuardian.Text = "Edit Selected Guardian";
            this.btnEditGuardian.UseVisualStyleBackColor = true;
            this.btnEditGuardian.Click += new System.EventHandler(this.btnEditGuardian_Click);
            // 
            // btnDeleteGuardian
            // 
            this.btnDeleteGuardian.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteGuardian.ImageIndex = 4;
            this.btnDeleteGuardian.ImageList = this.imageList1;
            this.btnDeleteGuardian.Location = new System.Drawing.Point(756, 478);
            this.btnDeleteGuardian.Name = "btnDeleteGuardian";
            this.btnDeleteGuardian.Size = new System.Drawing.Size(225, 38);
            this.btnDeleteGuardian.TabIndex = 15;
            this.btnDeleteGuardian.Text = "Delete Selected Guardian";
            this.btnDeleteGuardian.UseVisualStyleBackColor = true;
            this.btnDeleteGuardian.Click += new System.EventHandler(this.btnDeleteGuardian_Click);
            // 
            // btnPhotoFromCam
            // 
            this.btnPhotoFromCam.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPhotoFromCam.ImageIndex = 2;
            this.btnPhotoFromCam.ImageList = this.imageList1;
            this.btnPhotoFromCam.Location = new System.Drawing.Point(655, 202);
            this.btnPhotoFromCam.Name = "btnPhotoFromCam";
            this.btnPhotoFromCam.Size = new System.Drawing.Size(146, 42);
            this.btnPhotoFromCam.TabIndex = 18;
            this.btnPhotoFromCam.Text = "From Camera";
            this.btnPhotoFromCam.UseVisualStyleBackColor = true;
            this.btnPhotoFromCam.Click += new System.EventHandler(this.btnPhotoFromCam_Click);
            // 
            // btnPhotoFromDisk
            // 
            this.btnPhotoFromDisk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPhotoFromDisk.ImageIndex = 7;
            this.btnPhotoFromDisk.ImageList = this.imageList1;
            this.btnPhotoFromDisk.Location = new System.Drawing.Point(653, 261);
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
            this.btnSave.Location = new System.Drawing.Point(847, 60);
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
            this.photoPictureBox.Image = global::GreatHomeChildcare.Properties.Resources.child;
            this.photoPictureBox.Location = new System.Drawing.Point(653, 19);
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
            this.btnCancel.Location = new System.Drawing.Point(847, 11);
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
            this.idNumericUpDown.Location = new System.Drawing.Point(905, 202);
            this.idNumericUpDown.Name = "idNumericUpDown";
            this.idNumericUpDown.ReadOnly = true;
            this.idNumericUpDown.Size = new System.Drawing.Size(76, 22);
            this.idNumericUpDown.TabIndex = 24;
            this.idNumericUpDown.TabStop = false;
            this.idNumericUpDown.Visible = false;
            // 
            // dOBMonthCalendar
            // 
            this.dOBMonthCalendar.DataBindings.Add(new System.Windows.Forms.Binding("SelectionRange", this.childBindingSource, "DOB", true));
            this.dOBMonthCalendar.Location = new System.Drawing.Point(339, 45);
            this.dOBMonthCalendar.MaxSelectionCount = 1;
            this.dOBMonthCalendar.Name = "dOBMonthCalendar";
            this.dOBMonthCalendar.TabIndex = 25;
            this.dOBMonthCalendar.Validating += new System.ComponentModel.CancelEventHandler(this.dOBMonthCalendar_Validating);
            // 
            // pic_openFileDialog
            // 
            this.pic_openFileDialog.DefaultExt = "*.png";
            this.pic_openFileDialog.FileName = "pic_openFileDialog";
            this.pic_openFileDialog.Filter = "Photos|*.png";
            this.pic_openFileDialog.Title = "Upload child photo";
            this.pic_openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.pic_openFileDialog_FileOk);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblExistingGuardians
            // 
            this.lblExistingGuardians.AutoSize = true;
            this.lblExistingGuardians.Location = new System.Drawing.Point(12, 441);
            this.lblExistingGuardians.Name = "lblExistingGuardians";
            this.lblExistingGuardians.Size = new System.Drawing.Size(130, 17);
            this.lblExistingGuardians.TabIndex = 27;
            this.lblExistingGuardians.Text = "Existing Guardians:";
            // 
            // cbExistingGuardians
            // 
            this.cbExistingGuardians.FormattingEnabled = true;
            this.cbExistingGuardians.Location = new System.Drawing.Point(12, 464);
            this.cbExistingGuardians.Name = "cbExistingGuardians";
            this.cbExistingGuardians.Size = new System.Drawing.Size(171, 24);
            this.cbExistingGuardians.TabIndex = 26;
            this.cbExistingGuardians.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbExistingGuardians_KeyPress);
            // 
            // btnNewGuardian
            // 
            this.btnNewGuardian.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewGuardian.ImageIndex = 8;
            this.btnNewGuardian.ImageList = this.imageList1;
            this.btnNewGuardian.Location = new System.Drawing.Point(540, 442);
            this.btnNewGuardian.Name = "btnNewGuardian";
            this.btnNewGuardian.Size = new System.Drawing.Size(195, 66);
            this.btnNewGuardian.TabIndex = 28;
            this.btnNewGuardian.Text = "Create New Guardian\r\n&& Add to Child";
            this.btnNewGuardian.UseVisualStyleBackColor = true;
            this.btnNewGuardian.Click += new System.EventHandler(this.btnNewGuardian_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.ImageIndex = 4;
            this.btnDelete.ImageList = this.imageList1;
            this.btnDelete.Location = new System.Drawing.Point(834, 143);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(159, 37);
            this.btnDelete.TabIndex = 29;
            this.btnDelete.Text = "DELETE CHILD";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // childBindingSource
            // 
            this.childBindingSource.DataSource = typeof(GreatHomeChildcare.Models.Child);
            // 
            // frmChildCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 657);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNewGuardian);
            this.Controls.Add(this.lblExistingGuardians);
            this.Controls.Add(this.cbExistingGuardians);
            this.Controls.Add(dOBLabel);
            this.Controls.Add(this.dOBMonthCalendar);
            this.Controls.Add(this.idNumericUpDown);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(photoLabel);
            this.Controls.Add(this.photoPictureBox);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnPhotoFromDisk);
            this.Controls.Add(this.btnPhotoFromCam);
            this.Controls.Add(this.btnDeleteGuardian);
            this.Controls.Add(this.btnEditGuardian);
            this.Controls.Add(this.btnAddExistingGuardian);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmChildCrud";
            this.Text = "Child Management : Great Home Childcare";
            this.Load += new System.EventHandler(this.frmChildCrud_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuardians)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.childBindingSource)).EndInit();
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
        private System.Windows.Forms.Button btnAddExistingGuardian;
        private System.Windows.Forms.Button btnEditGuardian;
        private System.Windows.Forms.Button btnDeleteGuardian;
        private System.Windows.Forms.Button btnPhotoFromCam;
        private System.Windows.Forms.Button btnPhotoFromDisk;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox photoPictureBox;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.NumericUpDown idNumericUpDown;
        private System.Windows.Forms.MonthCalendar dOBMonthCalendar;
        private System.Windows.Forms.OpenFileDialog pic_openFileDialog;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblExistingGuardians;
        private System.Windows.Forms.ComboBox cbExistingGuardians;
        private System.Windows.Forms.Button btnNewGuardian;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn isAdmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailAddress;
        private System.Windows.Forms.Button btnDelete;
    }
}