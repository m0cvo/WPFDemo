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
    /// Now using .Net 7.
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void DateLabel_Loaded(object sender, RoutedEventArgs e)
        {
            //DateTime is used as an object to set the current date
            DateTime dt = DateTime.Now;

            DateLabel.Content = dt.Date.ToShortDateString();
        }
        
        /// <summary>
        /// Interaction logic for Button1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        private void SubmitBtn_Click(object sender, RoutedEventArgs e)
        {
            try //let's try and see if this works as expected
            {
                if (ChkOne.IsChecked == false && ChkTwo.IsChecked == false)
                {
                    MessageBox.Show("please tick one check box!");
                    return;
                }
                else if (ChkOne.IsChecked == true && ChkTwo.IsChecked == true)
                {
                    MessageBox.Show("please check only one box!");
                    return ;
                }
                else if (ChkOne.IsChecked == true)
                {
                    MessageBox.Show("One is checked!");
                    return;
                }
                else if (ChkTwo.IsChecked == true)
                {
                    MessageBox.Show("Two is checked!");
                    return;
                }
            }
            catch (Exception Ex) //if anything doesn't work let's catch the error and deal with it safely.
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void SpeechBtn_Click(object sender, RoutedEventArgs e)
        {
            //this one's an experimental stage as now working with .net 7.
            SpeechWin speechWin = new SpeechWin();
            speechWin.Show();
        }
    }
}
