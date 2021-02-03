
namespace GreatHomeChildcare
{
    partial class frmReports
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
            this.cbChildPicker = new System.Windows.Forms.ComboBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbChildPicker
            // 
            this.cbChildPicker.DisplayMember = "DisplayName";
            this.cbChildPicker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChildPicker.FormattingEnabled = true;
            this.cbChildPicker.Location = new System.Drawing.Point(13, 57);
            this.cbChildPicker.Name = "cbChildPicker";
            this.cbChildPicker.Size = new System.Drawing.Size(121, 24);
            this.cbChildPicker.TabIndex = 0;
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(13, 22);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(39, 17);
            this.lblFilter.TabIndex = 1;
            this.lblFilter.Text = "Filter";
            // 
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.cbChildPicker);
            this.Name = "frmReports";
            this.Text = "Reports : Great Home Childcare";
            this.Load += new System.EventHandler(this.frmReports_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbChildPicker;
        private System.Windows.Forms.Label lblFilter;
    }
}