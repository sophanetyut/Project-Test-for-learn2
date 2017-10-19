namespace SQL_RDBC_Report_Test
{
    partial class Report
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
            this.IndrahanuDataSet = new SQL_RDBC_Report_Test.IndrahanuDataSet();
            this.tbl_RegistrationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_RegistrationTableAdapter = new SQL_RDBC_Report_Test.IndrahanuDataSetTableAdapters.tbl_RegistrationTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.IndrahanuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_RegistrationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "ABC";
            reportDataSource1.Value = this.tbl_RegistrationBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SQL_RDBC_Report_Test.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(778, 384);
            this.reportViewer1.TabIndex = 0;
            // 
            // IndrahanuDataSet
            // 
            this.IndrahanuDataSet.DataSetName = "IndrahanuDataSet";
            this.IndrahanuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_RegistrationBindingSource
            // 
            this.tbl_RegistrationBindingSource.DataMember = "tbl_Registration";
            this.tbl_RegistrationBindingSource.DataSource = this.IndrahanuDataSet;
            // 
            // tbl_RegistrationTableAdapter
            // 
            this.tbl_RegistrationTableAdapter.ClearBeforeFill = true;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 408);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Report";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IndrahanuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_RegistrationBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tbl_RegistrationBindingSource;
        private IndrahanuDataSet IndrahanuDataSet;
        private IndrahanuDataSetTableAdapters.tbl_RegistrationTableAdapter tbl_RegistrationTableAdapter;
    }
}