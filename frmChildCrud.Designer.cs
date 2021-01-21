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
            System.Windows.Forms.Label addressLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChildCrud));
            System.Windows.Forms.Label photoLabel;
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.raceTextBox = new System.Windows.Forms.TextBox();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.lblGuardians = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAddGuardian = new System.Windows.Forms.Button();
            this.btnEditGuardian = new System.Windows.Forms.Button();
            this.btnDeleteGuardian = new System.Windows.Forms.Button();
            this.btnPhotoFromCam = new System.Windows.Forms.Button();
            this.btnPhotoFromDisk = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.photoPictureBox = new System.Windows.Forms.PictureBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.childBindingSource = new System.Windows.Forms.BindingSource(this.components);
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            raceLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            photoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).BeginInit();
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
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(25, 165);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(63, 17);
            addressLabel.TabIndex = 9;
            addressLabel.Text = "address:";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.childBindingSource, "FirstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(15, 39);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.firstNameTextBox.TabIndex = 2;
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
            this.lblGuardians.Location = new System.Drawing.Point(15, 282);
            this.lblGuardians.Name = "lblGuardians";
            this.lblGuardians.Size = new System.Drawing.Size(74, 17);
            this.lblGuardians.TabIndex = 11;
            this.lblGuardians.Text = "Guardians";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 302);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(384, 106);
            this.dataGridView1.TabIndex = 12;
            // 
            // btnAddGuardian
            // 
            this.btnAddGuardian.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddGuardian.ImageKey = "Add_16x.png";
            this.btnAddGuardian.ImageList = this.imageList1;
            this.btnAddGuardian.Location = new System.Drawing.Point(21, 421);
            this.btnAddGuardian.Name = "btnAddGuardian";
            this.btnAddGuardian.Size = new System.Drawing.Size(135, 26);
            this.btnAddGuardian.TabIndex = 13;
            this.btnAddGuardian.Text = "Add Guardian";
            this.btnAddGuardian.UseVisualStyleBackColor = true;
            // 
            // btnEditGuardian
            // 
            this.btnEditGuardian.Location = new System.Drawing.Point(162, 421);
            this.btnEditGuardian.Name = "btnEditGuardian";
            this.btnEditGuardian.Size = new System.Drawing.Size(112, 26);
            this.btnEditGuardian.TabIndex = 14;
            this.btnEditGuardian.Text = "Edit Guardian";
            this.btnEditGuardian.UseVisualStyleBackColor = true;
            // 
            // btnDeleteGuardian
            // 
            this.btnDeleteGuardian.Location = new System.Drawing.Point(281, 421);
            this.btnDeleteGuardian.Name = "btnDeleteGuardian";
            this.btnDeleteGuardian.Size = new System.Drawing.Size(121, 26);
            this.btnDeleteGuardian.TabIndex = 15;
            this.btnDeleteGuardian.Text = "Delete Guardian";
            this.btnDeleteGuardian.UseVisualStyleBackColor = true;
            // 
            // btnPhotoFromCam
            // 
            this.btnPhotoFromCam.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPhotoFromCam.Location = new System.Drawing.Point(496, 222);
            this.btnPhotoFromCam.Name = "btnPhotoFromCam";
            this.btnPhotoFromCam.Size = new System.Drawing.Size(146, 42);
            this.btnPhotoFromCam.TabIndex = 18;
            this.btnPhotoFromCam.Text = "From Camera";
            this.btnPhotoFromCam.UseVisualStyleBackColor = true;
            // 
            // btnPhotoFromDisk
            // 
            this.btnPhotoFromDisk.Location = new System.Drawing.Point(494, 281);
            this.btnPhotoFromDisk.Name = "btnPhotoFromDisk";
            this.btnPhotoFromDisk.Size = new System.Drawing.Size(147, 41);
            this.btnPhotoFromDisk.TabIndex = 19;
            this.btnPhotoFromDisk.Text = "From Disk";
            this.btnPhotoFromDisk.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Add_16x.png");
            this.imageList1.Images.SetKeyName(1, "AddButton_16x.png");
            this.imageList1.Images.SetKeyName(2, "Address_16x.png");
            this.imageList1.Images.SetKeyName(3, "Camera_16x.png");
            this.imageList1.Images.SetKeyName(4, "Cancel_16x.png");
            this.imageList1.Images.SetKeyName(5, "Close_16x.png");
            this.imageList1.Images.SetKeyName(6, "DeleteUser_16x.png");
            this.imageList1.Images.SetKeyName(7, "Edit_16x.png");
            this.imageList1.Images.SetKeyName(8, "ResultToCSV_16x.png");
            this.imageList1.Images.SetKeyName(9, "Save_16x.png");
            this.imageList1.Images.SetKeyName(10, "SaveClose_16x.png");
            this.imageList1.Images.SetKeyName(11, "SaveFileDialogControl_16x.png");
            this.imageList1.Images.SetKeyName(12, "Search_16x.png");
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(604, 404);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 43);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Save && Close";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // photoLabel
            // 
            photoLabel.AutoSize = true;
            photoLabel.Location = new System.Drawing.Point(545, 19);
            photoLabel.Name = "photoLabel";
            photoLabel.Size = new System.Drawing.Size(48, 17);
            photoLabel.TabIndex = 21;
            photoLabel.Text = "photo:";
            // 
            // photoPictureBox
            // 
            this.photoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.childBindingSource, "photo", true));
            this.photoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("photoPictureBox.Image")));
            this.photoPictureBox.Location = new System.Drawing.Point(494, 39);
            this.photoPictureBox.Name = "photoPictureBox";
            this.photoPictureBox.Size = new System.Drawing.Size(156, 161);
            this.photoPictureBox.TabIndex = 22;
            this.photoPictureBox.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(474, 404);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 43);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "Cancel && Close";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // childBindingSource
            // 
            this.childBindingSource.DataSource = typeof(GreatHomeChildcare.Models.Child);
            // 
            // frmChildCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 493);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(photoLabel);
            this.Controls.Add(this.photoPictureBox);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnPhotoFromDisk);
            this.Controls.Add(this.btnPhotoFromCam);
            this.Controls.Add(this.btnDeleteGuardian);
            this.Controls.Add(this.btnEditGuardian);
            this.Controls.Add(this.btnAddGuardian);
            this.Controls.Add(this.dataGridView1);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAddGuardian;
        private System.Windows.Forms.Button btnEditGuardian;
        private System.Windows.Forms.Button btnDeleteGuardian;
        private System.Windows.Forms.Button btnPhotoFromCam;
        private System.Windows.Forms.Button btnPhotoFromDisk;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox photoPictureBox;
        private System.Windows.Forms.Button btnCancel;
    }
}