namespace WindowsFormsApplication3
{
    partial class frmInHoaDon
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.hoadonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QLCFSHOPDataSet = new WindowsFormsApplication3.QLCFSHOPDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.hoadonTableAdapter = new WindowsFormsApplication3.QLCFSHOPDataSetTableAdapters.hoadonTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.hoadonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLCFSHOPDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // hoadonBindingSource
            // 
            this.hoadonBindingSource.DataMember = "hoadon";
            this.hoadonBindingSource.DataSource = this.QLCFSHOPDataSet;
            // 
            // QLCFSHOPDataSet
            // 
            this.QLCFSHOPDataSet.DataSetName = "QLCFSHOPDataSet";
            this.QLCFSHOPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.hoadonBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication3.InHoaDon.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(59, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(639, 348);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // hoadonTableAdapter
            // 
            this.hoadonTableAdapter.ClearBeforeFill = true;
            // 
            // frmInHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 400);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmInHoaDon";
            this.Text = "frmInHoaDon";
            this.Load += new System.EventHandler(this.frmInHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hoadonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLCFSHOPDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource hoadonBindingSource;
        private QLCFSHOPDataSet QLCFSHOPDataSet;
        private QLCFSHOPDataSetTableAdapters.hoadonTableAdapter hoadonTableAdapter;
    }
}