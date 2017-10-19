using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Reporting.WinForms;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SQL_RDBC_Report_Test
{
    public partial class Report : Form
    {
        IndrahanuDataSet indradhanudataset = new IndrahanuDataSet();
        ReportDataSource rps;
            

        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'IndrahanuDataSet.tbl_Registration' table. You can move, or remove it, as needed.
            
            this.tbl_RegistrationTableAdapter.Fill(this.IndrahanuDataSet.tbl_Registration);
            //rps = new ReportDataSource();
            //SqlConnection con = new SqlConnection("Server=(local);Database=Indrahanu;Trusted_Connection=True;");
            //SqlCommand com = new SqlCommand("select * from tbl_Registration where SNK=7", con);
            //SqlDataAdapter adt = new SqlDataAdapter(com);
            //DataTable dt = new DataTable();
            //adt.Fill(dt);






            // MessageBox.Show(dt.Rows.Count.ToString());

            // IndrahanuDataSetTableAdapters.tbl_RegistrationTableAdapter rta = new IndrahanuDataSetTableAdapters.tbl_RegistrationTableAdapter();
            // rta = dt;
            // indradhanudataset.BeginInit();
            //// rps = new ReportDataSource("tbl_Registration", dt); 
            // rps.Name = "ABC";
            // rps.Value = indradhanudataset.tbl_Registration;

            // reportViewer1.LocalReport.DataSources.Add(rps);
            // reportViewer1.LocalReport.ReportEmbeddedResource = "Report1.rdlc";
            // indradhanudataset.EndInit();

            // rta.ClearBeforeFill = true;
            // rta.Fill(indradhanudataset.tbl_Registration);           

            this.reportViewer1.RefreshReport();
        }
    }
}
