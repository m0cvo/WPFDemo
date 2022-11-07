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

        private void ExitBtn_Click(object sender, RoutedEventArgs e) => Application.Current.Shutdown();

        private void NameBtn_Click(object sender, RoutedEventArgs e)
        {
            string name = NameBx.Text.ToString();
            MessageBox.Show("Hello "+ name);
        }

        private void SnowBtn_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            this.Hide();
            window1.Show();
        }

        private void ListBtn_Click(object sender, RoutedEventArgs e)
        {
            Window2 window2 = new Window2();
            this.Hide();
            window2.Show();
        }
    }
}
