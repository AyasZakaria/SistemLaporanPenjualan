namespace SPBU.GUI
{
    partial class Laporan_Transaksi
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataTableTransaksiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetTransaksi = new SPBU.Laporan.DataSetTransaksi();
            this.dataTableTransaksiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetTransaksiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTableTransaksiTableAdapter = new SPBU.Laporan.DataSetTransaksiTableAdapters.DataTableTransaksiTableAdapter();
            this.dataTableTransaksiBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataTableTransaksiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTransaksi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableTransaksiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTransaksiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableTransaksiBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.dataTableTransaksiBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SPBU.GUI.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(415, 263);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataTableTransaksiBindingSource1
            // 
            this.dataTableTransaksiBindingSource1.DataMember = "DataTableTransaksi";
            this.dataTableTransaksiBindingSource1.DataSource = this.dataSetTransaksi;
            // 
            // dataSetTransaksi
            // 
            this.dataSetTransaksi.DataSetName = "DataSetTransaksi";
            this.dataSetTransaksi.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTableTransaksiBindingSource
            // 
            this.dataTableTransaksiBindingSource.DataMember = "DataTableTransaksi";
            this.dataTableTransaksiBindingSource.DataSource = this.dataSetTransaksi;
            // 
            // dataSetTransaksiBindingSource
            // 
            this.dataSetTransaksiBindingSource.DataSource = this.dataSetTransaksi;
            this.dataSetTransaksiBindingSource.Position = 0;
            // 
            // dataTableTransaksiTableAdapter
            // 
            this.dataTableTransaksiTableAdapter.ClearBeforeFill = true;
            // 
            // dataTableTransaksiBindingSource2
            // 
            this.dataTableTransaksiBindingSource2.DataMember = "DataTableTransaksi";
            this.dataTableTransaksiBindingSource2.DataSource = this.dataSetTransaksi;
            // 
            // Laporan_Transaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 263);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Laporan_Transaksi";
            this.Text = "Laporan_transaksi";
            this.Load += new System.EventHandler(this.Laporan_Transaksi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTableTransaksiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTransaksi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableTransaksiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTransaksiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableTransaksiBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dataSetTransaksiBindingSource;
        private Laporan.DataSetTransaksi dataSetTransaksi;
        private System.Windows.Forms.BindingSource dataTableTransaksiBindingSource;
        private Laporan.DataSetTransaksiTableAdapters.DataTableTransaksiTableAdapter dataTableTransaksiTableAdapter;
        private System.Windows.Forms.BindingSource dataTableTransaksiBindingSource1;
        private System.Windows.Forms.BindingSource dataTableTransaksiBindingSource2;
    }
}