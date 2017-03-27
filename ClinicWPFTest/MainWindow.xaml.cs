using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ClinicWPFTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        Thread tr;
        int id = 0;

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            
            tr = new Thread(new ThreadStart(Doom));
            tr.Start();
            lbShow.Content = "Started for " + id;
            id++;
            Thread.Sleep(1000);
            lbShow.Content = "Started for " + id;
        }


        private void Doom()
        {
            for (int i = 0; i < 20; i++)
            {
                Console.Beep();
                Thread.Sleep(1000);
            }
        }
        

    }
}
