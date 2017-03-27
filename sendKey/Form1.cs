using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace sendKey
{
    public partial class Form1 : Form
    {
        
       
        public Form1()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread.Sleep(5000);
            timer1.Start();
        }
        
        
        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (char c in textBox1.Text)
            {
                SendKeys.SendWait(c.ToString());
            }
            SendKeys.Send("{ENTER}");
            SendKeys.Send("{TAB}");
        }
    }
}
