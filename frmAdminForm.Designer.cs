
namespace GreatHomeChildcare
{
    partial class frmAdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminForm));
            this.btnReports = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvChildren = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Photo = new System.Windows.Forms.DataGridViewImageColumn();
            this.DisplayName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChildren)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReports
            // 
            this.btnReports.Location = new System.Drawing.Point(12, 89);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(112, 32);
            this.btnReports.TabIndex = 1;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 28);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(151, 40);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Back to sign in page";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 146);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(140, 50);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add New Child";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvChildren
            // 
            this.dgvChildren.AllowUserToAddRows = false;
            this.dgvChildren.AllowUserToDeleteRows = false;
            this.dgvChildren.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChildren.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Photo,
            this.DisplayName});
            this.dgvChildren.Location = new System.Drawing.Point(217, 36);
            this.dgvChildren.MultiSelect = false;
            this.dgvChildren.Name = "dgvChildren";
            this.dgvChildren.ReadOnly = true;
            this.dgvChildren.RowHeadersWidth = 51;
            this.dgvChildren.RowTemplate.Height = 82;
            this.dgvChildren.Size = new System.Drawing.Size(571, 392);
            this.dgvChildren.TabIndex = 4;
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
            // Photo
            // 
            this.Photo.HeaderText = "Photo";
            this.Photo.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Photo.MinimumWidth = 6;
            this.Photo.Name = "Photo";
            this.Photo.ReadOnly = true;
            this.Photo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Photo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Photo.Width = 118;
            // 
            // DisplayName
            // 
            this.DisplayName.HeaderText = "DisplayName";
            this.DisplayName.MinimumWidth = 6;
            this.DisplayName.Name = "DisplayName";
            this.DisplayName.ReadOnly = true;
            this.DisplayName.Width = 125;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(12, 213);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(130, 47);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update Child";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(12, 279);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(122, 47);
            this.btnQuit.TabIndex = 6;
            this.btnQuit.Text = "Quit Program";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // frmAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgvChildren);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnReports);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAdminForm";
            this.Text = "Administration : Great Home Childcare";
            this.Load += new System.EventHandler(this.frmAdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChildren)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvChildren;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewImageColumn Photo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DisplayName;
    }
}