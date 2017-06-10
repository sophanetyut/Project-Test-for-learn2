using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace OLEDB_Connection
{
    public partial class Form1 : Form
    {

        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\code\AccessDB\KIMENG.mdb;
                                                        Persist Security Info = False;");
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                label1.Text = "Connected successfully";
            }
            catch (Exception ex)
            {
                label1.Text = ex.Message;
            }
            finally
            {
                con.Close();
            }
        }
    }
}
