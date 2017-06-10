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
using System.Runtime;
using System.ComponentModel;
using System.Configuration;
using System.Windows.Interop;
using System.Windows.Forms;

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

        private void DatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DatePick1.SelectedDate.Value.Date <  DateTime.Now.Date)
            {
                System.Windows.MessageBox.Show(DateTime.Now.Date + "\n" + DatePick1.SelectedDate.Value.Date);
                DatePick1.SelectedDate = null;
                DatePick1.Focus();
            }
        }
    }
}
