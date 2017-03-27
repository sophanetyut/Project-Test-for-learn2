using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MusicPlayer
{
    public partial class Form1 : Form
    {
        OpenFileDialog OpenFileDialog1 = new OpenFileDialog();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (OpenFileDialog1.ShowDialog()==DialogResult.OK)
            {
                textBox1.Text = OpenFileDialog1.FileName;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="")
            {
                MessageBox.Show("Please choose the music file.");
                return;
            }

            try
            {
                
                FileStream file = new FileStream(textBox1.Text, FileMode.Open, FileAccess.Read);
                byte[] songData = new byte[file.Length];
                file.Close();

                SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=Music;Integrated Security=True");
                con.Open();
                SqlCommand comm = new SqlCommand("insert into Tbl_Music values(@song)", con);
                comm.Parameters.AddWithValue("@song", songData);
                comm.ExecuteNonQuery();

                MessageBox.Show("Successfull ");
                con.Close();
            }
            catch (Exception s)
            {
                MessageBox.Show(s.ToString());
            }
        }

        
        private void btnPlay_Click(object sender, EventArgs e)
        {
           
            int count = 0;
            if (count==0)
            {
                //try
                //{
                    SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=Music;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select content from tbl_Music where fName=2", con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                    //byte[] binaryData = Convert.FromBase64CharArray(dr[0].ToString());
                    //File.WriteAllBytes(@"c:\\song.mp3", binaryData);
                    //player.URL = @"c:\\song.mp3";
                    

                    //using (MemoryStream ms=new MemoryStream(s))
                    //{

                    //    SoundPlayer player = new SoundPlayer(ms);
                    //    player.Play();
                    con.Close();
                    //}
                    count = 1;
                        
                    }

                //}
                //catch (Exception exs)
                //{
                //    MessageBox.Show(exs.ToString());
                //}

            }
            //MediaPlayer p=new MediaPlayer()


        }
    }
}
