
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
            this.btnReports = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.sqLiteCommand1 = new System.Data.SQLite.SQLiteCommand();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvChildren = new System.Windows.Forms.DataGridView();
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
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 28);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(151, 40);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Back to sign in page";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // sqLiteCommand1
            // 
            this.sqLiteCommand1.CommandText = null;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 146);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(140, 50);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add New Child";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // dgvChildren
            // 
            this.dgvChildren.AllowUserToAddRows = false;
            this.dgvChildren.AllowUserToDeleteRows = false;
            this.dgvChildren.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChildren.Location = new System.Drawing.Point(217, 36);
            this.dgvChildren.MultiSelect = false;
            this.dgvChildren.Name = "dgvChildren";
            this.dgvChildren.ReadOnly = true;
            this.dgvChildren.RowHeadersWidth = 51;
            this.dgvChildren.RowTemplate.Height = 24;
            this.dgvChildren.Size = new System.Drawing.Size(571, 392);
            this.dgvChildren.TabIndex = 4;
            // 
            // frmAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvChildren);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnReports);
            this.Name = "frmAdminForm";
            this.Text = "Administration : Great Home Childcare";
            this.Load += new System.EventHandler(this.frmAdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChildren)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnClose;
        private System.Data.SQLite.SQLiteCommand sqLiteCommand1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvChildren;
    }
}