using System;
using System.Windows;
using System.Windows.Forms;

namespace SqlFucntionToCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            SchoolDataSetTableAdapters.QueriesTableAdapter a = new SchoolDataSetTableAdapters.QueriesTableAdapter();
            TextBox tb = new TextBox();
            tb.Text = "ផានិត";
            a.INSERTSTUDENT("ghjhkj", tb.Text);
        }
    }
}
