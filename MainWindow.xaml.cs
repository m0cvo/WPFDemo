using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFDemo
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

        private void DateLabel_Loaded(object sender, RoutedEventArgs e)
        {
            DateTime dt = DateTime.Now;

            DateLabel.Content = dt.Date.ToShortDateString();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            String str = "Hello, Thank you for clicking me!";
            Label1.Content = str;
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
