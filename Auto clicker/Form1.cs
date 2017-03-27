using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace Auto_clicker
{
    public partial class Form1 : Form
    {
        [DllImport("user32")]
        public static extern int SetCursorPos(int x, int y);
        private const int MOUSEEVENTF_MOVE = 0x0001; /* mouse move */
        private const int MOUSEEVENTF_LEFTDOWN = 0x0002; /* left button down */
        private const int MOUSEEVENTF_LEFTUP = 0x0004; /* left button up */
        private const int MOUSEEVENTF_RIGHTDOWN = 0x0008; /* right button down */

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention= CallingConvention.StdCall)]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons,int dwExtraInfo);




        int click = 0;

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            
            click++;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            

            SetCursorPos(0, 0);
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbX.Text = Cursor.Position.X.ToString();
            lbY.Text = Cursor.Position.Y.ToString();
        }
    }
}
