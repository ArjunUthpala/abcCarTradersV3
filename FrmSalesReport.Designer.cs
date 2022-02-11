
namespace abcCarTradersV1
{
    partial class FrmSalesReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tbl_cus_orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
       //     this.ABCCarTradersDataSet3 = new abcCarTradersV1.ABCCarTradersDataSet3();
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SalesDataset = new abcCarTradersV1.SalesDataset();
            this.tbl_cus_order2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
        //    this.tbl_cus_orderTableAdapter = new abcCarTradersV1.ABCCarTradersDataSet3TableAdapters.tbl_cus_orderTableAdapter();
      //      this.ABCCarTradersDataSet4 = new abcCarTradersV1.ABCCarTradersDataSet4();
            this.DataTable1TableAdapter = new abcCarTradersV1.SalesDatasetTableAdapters.DataTable1TableAdapter();
            this.tbl_cus_order2TableAdapter = new abcCarTradersV1.SalesDatasetTableAdapters.tbl_cus_order2TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_cus_orderBindingSource)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.ABCCarTradersDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_cus_order2BindingSource)).BeginInit();
      //      ((System.ComponentModel.ISupportInitialize)(this.ABCCarTradersDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // tbl_cus_orderBindingSource
            // 
            this.tbl_cus_orderBindingSource.DataMember = "tbl_cus_order";
   //         this.tbl_cus_orderBindingSource.DataSource = this.ABCCarTradersDataSet3;
            // 
            // ABCCarTradersDataSet3
            // 
   //         this.ABCCarTradersDataSet3.DataSetName = "ABCCarTradersDataSet3";
   //         this.ABCCarTradersDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.SalesDataset;
            // 
            // SalesDataset
            // 
            this.SalesDataset.DataSetName = "SalesDataset";
            this.SalesDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_cus_order2BindingSource
            // 
            this.tbl_cus_order2BindingSource.DataMember = "tbl_cus_order2";
            this.tbl_cus_order2BindingSource.DataSource = this.SalesDataset;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetABC";
            reportDataSource1.Value = this.tbl_cus_orderBindingSource;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.tbl_cus_orderBindingSource;
            reportDataSource3.Name = "DataSet2";
            reportDataSource3.Value = this.DataTable1BindingSource;
            reportDataSource4.Name = "DataSet3";
            reportDataSource4.Value = this.tbl_cus_order2BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "abcCarTradersV1.SalesDetails.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1240, 657);
            this.reportViewer1.TabIndex = 0;
            // 
            // tbl_cus_orderTableAdapter
            // 
        //    this.tbl_cus_orderTableAdapter.ClearBeforeFill = true;
            // 
            // ABCCarTradersDataSet4
            // 
       //     this.ABCCarTradersDataSet4.DataSetName = "ABCCarTradersDataSet4";
      //      this.ABCCarTradersDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataTable1TableAdapter
            // 
            this.DataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // tbl_cus_order2TableAdapter
            // 
            this.tbl_cus_order2TableAdapter.ClearBeforeFill = true;
            // 
            // FrmSalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmSalesReport";
            this.Text = "Completed Sales Summary";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_cus_orderBindingSource)).EndInit();
     //       ((System.ComponentModel.ISupportInitialize)(this.ABCCarTradersDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_cus_order2BindingSource)).EndInit();
       //     ((System.ComponentModel.ISupportInitialize)(this.ABCCarTradersDataSet4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tbl_cus_orderBindingSource;
   //     private ABCCarTradersDataSet3 ABCCarTradersDataSet3;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private SalesDataset SalesDataset;
   //     private ABCCarTradersDataSet3TableAdapters.tbl_cus_orderTableAdapter tbl_cus_orderTableAdapter;
   //     private ABCCarTradersDataSet4 ABCCarTradersDataSet4;
        private SalesDatasetTableAdapters.DataTable1TableAdapter DataTable1TableAdapter;
        private System.Windows.Forms.BindingSource tbl_cus_order2BindingSource;
        private SalesDatasetTableAdapters.tbl_cus_order2TableAdapter tbl_cus_order2TableAdapter;
    }
}