using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Youtube_embed_player
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const string page = "<html><head><title></title></head><body>{0}</body></html>";
        string video= "<iframe width=\"854\" height=\"480\" src=\"https://www.youtube.com/embed/5cAZ74pCDT0?rel=0&amp;autoplay=1\" frameborder=\"0\" allowfullscreen></iframe>";
        string vi = "<iframe width=\"854\" height=\"480\" src=\"https://www.youtube.com/embed/9c806i1s57s?rel=0&amp;autoplay=1\" frameborder=\"0\" allowfullscreen></iframe>";
        string vich= "<iframe width=\"854\" height=\"480\" src=\"https://www.youtube.com/embed/qGqH9dBUer0?rel=0&amp;autoplay=1\" frameborder=\"0\" allowfullscreen></iframe>";
        string phanet= "<iframe width=\"854\" height=\"480\" src=\"https://www.youtube.com/embed/3yqDEGUFXc0\" frameborder=\"0\" allowfullscreen></iframe>";
        
        private void Form1_Load(object sender, EventArgs e)
        {
           
           webBrowser1.DocumentText=string.Format(page,phanet);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        int i=0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = i.ToString();
            i++;
            webBrowser1.DocumentText = string.Format(page, vich);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.DocumentText = string.Format(page, phanet);
        }
    }
}
