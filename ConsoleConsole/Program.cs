﻿using System;
using System.IO;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Data;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Windows.Forms;
using ShockwaveFlashObjects;

namespace ConsoleConsole
{
    class Program
    {
        
        static void Main(string[] args)
        {           
            Console.WriteLine("សួរស្តី");
            ShockwaveFlash s = new ShockwaveFlash();
            try
            {
                s.Movie = "https://www.youtube.com/v/NwL98zzdEXo?autoplay=1";

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }



        private string InvoiceID(string es)
        {
           
            int indx = es.Length - 1;
            string num="";
            for (int i = 0; i < 13; i++)
            {
                //num+=es.Substring()
                if (indx>=0)
                {
                    num = es.Substring(indx,1) + num;
                }
                else
                {
                    num = "0" + num;
                }
                indx--;
            }
            return "KM"+num;
        }
    }
}
