namespace WindowsFormsApplication3
{
    partial class frmInBaoCao
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.hoadonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QLCFSHOPDataSet1 = new WindowsFormsApplication3.QLCFSHOPDataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.hoadonTableAdapter = new WindowsFormsApplication3.QLCFSHOPDataSet1TableAdapters.hoadonTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.hoadonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLCFSHOPDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // hoadonBindingSource
            // 
            this.hoadonBindingSource.DataMember = "hoadon";
            this.hoadonBindingSource.DataSource = this.QLCFSHOPDataSet1;
            // 
            // QLCFSHOPDataSet1
            // 
            this.QLCFSHOPDataSet1.DataSetName = "QLCFSHOPDataSet1";
            this.QLCFSHOPDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.hoadonBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication3.Inviet.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(717, 366);
            this.reportViewer1.TabIndex = 0;
            // 
            // hoadonTableAdapter
            // 
            this.hoadonTableAdapter.ClearBeforeFill = true;
            // 
            // frmInBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 390);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmInBaoCao";
            this.Text = "In hóa đơn";
            this.Load += new System.EventHandler(this.frmInBaoCao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hoadonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLCFSHOPDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource hoadonBindingSource;
        private QLCFSHOPDataSet1 QLCFSHOPDataSet1;
        private QLCFSHOPDataSet1TableAdapters.hoadonTableAdapter hoadonTableAdapter;
    }
}