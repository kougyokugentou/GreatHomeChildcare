
using System;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReports));
            this.cbChildPicker = new System.Windows.Forms.ComboBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.dgvReports = new System.Windows.Forms.DataGridView();
            this.ChildName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.in_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GInDisplayName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.out_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GOutDisplayname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSavetoSV = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnPrint = new System.Windows.Forms.Button();
            this.saveFileDialogReport = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).BeginInit();
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
            this.cbChildPicker.SelectionChangeCommitted += new System.EventHandler(this.cbChildPicker_SelectionChangeCommitted);
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
            // dtpFrom
            // 
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(13, 177);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(121, 22);
            this.dtpFrom.TabIndex = 2;
            this.dtpFrom.CloseUp += new System.EventHandler(this.dtpFrom_CloseUp);
            this.dtpFrom.DropDown += new System.EventHandler(this.dtpFrom_DropDown);
            // 
            // dtpTo
            // 
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(12, 257);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(121, 22);
            this.dtpTo.TabIndex = 3;
            this.dtpTo.CloseUp += new System.EventHandler(this.dtpTo_CloseUp);
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(12, 154);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(40, 17);
            this.lblFrom.TabIndex = 4;
            this.lblFrom.Text = "From";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(12, 234);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(25, 17);
            this.lblTo.TabIndex = 5;
            this.lblTo.Text = "To";
            // 
            // dgvReports
            // 
            this.dgvReports.AllowUserToAddRows = false;
            this.dgvReports.AllowUserToDeleteRows = false;
            this.dgvReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReports.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ChildName,
            this.in_time,
            this.GInDisplayName,
            this.out_time,
            this.GOutDisplayname,
            this.Duration});
            this.dgvReports.Location = new System.Drawing.Point(204, 39);
            this.dgvReports.Name = "dgvReports";
            this.dgvReports.ReadOnly = true;
            this.dgvReports.RowHeadersWidth = 51;
            this.dgvReports.RowTemplate.Height = 24;
            this.dgvReports.Size = new System.Drawing.Size(846, 367);
            this.dgvReports.TabIndex = 6;
            // 
            // ChildName
            // 
            this.ChildName.HeaderText = "ChildName";
            this.ChildName.MinimumWidth = 6;
            this.ChildName.Name = "ChildName";
            this.ChildName.ReadOnly = true;
            this.ChildName.Width = 125;
            // 
            // in_time
            // 
            this.in_time.HeaderText = "in_time";
            this.in_time.MinimumWidth = 6;
            this.in_time.Name = "in_time";
            this.in_time.ReadOnly = true;
            this.in_time.Width = 125;
            // 
            // GInDisplayName
            // 
            this.GInDisplayName.HeaderText = "Guardian In";
            this.GInDisplayName.MinimumWidth = 6;
            this.GInDisplayName.Name = "GInDisplayName";
            this.GInDisplayName.ReadOnly = true;
            this.GInDisplayName.Width = 125;
            // 
            // out_time
            // 
            this.out_time.HeaderText = "out_time";
            this.out_time.MinimumWidth = 6;
            this.out_time.Name = "out_time";
            this.out_time.ReadOnly = true;
            this.out_time.Width = 125;
            // 
            // GOutDisplayname
            // 
            this.GOutDisplayname.HeaderText = "Guardian Out";
            this.GOutDisplayname.MinimumWidth = 6;
            this.GOutDisplayname.Name = "GOutDisplayname";
            this.GOutDisplayname.ReadOnly = true;
            this.GOutDisplayname.Width = 125;
            // 
            // Duration
            // 
            this.Duration.HeaderText = "Duration";
            this.Duration.MinimumWidth = 6;
            this.Duration.Name = "Duration";
            this.Duration.ReadOnly = true;
            this.Duration.Width = 125;
            // 
            // btnSavetoSV
            // 
            this.btnSavetoSV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSavetoSV.ImageIndex = 0;
            this.btnSavetoSV.ImageList = this.imageList1;
            this.btnSavetoSV.Location = new System.Drawing.Point(13, 364);
            this.btnSavetoSV.Name = "btnSavetoSV";
            this.btnSavetoSV.Size = new System.Drawing.Size(148, 42);
            this.btnSavetoSV.TabIndex = 7;
            this.btnSavetoSV.Text = "Save as CSV";
            this.btnSavetoSV.UseVisualStyleBackColor = true;
            this.btnSavetoSV.Click += new System.EventHandler(this.btnSavetoCSV_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "ResultToCSV_16x.png");
            this.imageList1.Images.SetKeyName(1, "Print_16x.png");
            // 
            // btnPrint
            // 
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.ImageIndex = 1;
            this.btnPrint.ImageList = this.imageList1;
            this.btnPrint.Location = new System.Drawing.Point(12, 427);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(149, 34);
            this.btnPrint.TabIndex = 8;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // saveFileDialogReport
            // 
            this.saveFileDialogReport.DefaultExt = "CSV";
            this.saveFileDialogReport.Filter = "CSV Files|*.csv";
            this.saveFileDialogReport.Title = "Save Report";
            // 
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 469);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnSavetoSV);
            this.Controls.Add(this.dgvReports);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.cbChildPicker);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReports";
            this.Text = "Reports : Great Home Childcare";
            this.Load += new System.EventHandler(this.frmReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbChildPicker;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.DataGridView dgvReports;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChildName;
        private System.Windows.Forms.DataGridViewTextBoxColumn in_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn GInDisplayName;
        private System.Windows.Forms.DataGridViewTextBoxColumn out_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn GOutDisplayname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.Button btnSavetoSV;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.SaveFileDialog saveFileDialogReport;
    }
}