using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listview_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] strID = { "001", "002", "003" };
        string[] strName = { "a", "b", "c" };
        string[] strValue = { "val001", "val002", "val003" };

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
