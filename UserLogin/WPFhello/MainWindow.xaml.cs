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

namespace WPFhello
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

        private void btnHello_Click(object sender, RoutedEventArgs e)
        {
            if (txtName.Text.Length < 2)
            {
                MessageBox.Show("The name is too short.");
            }
            else
            {
                MessageBox.Show("Hello, " + txtName.Text + "!!!");
            }
        }

        private void btnResult_Click(object sender, RoutedEventArgs e)
        {
            int value;
            Int32.TryParse(txtN.Text, out value);
            if (value == 0) 
            {
                MessageBox.Show("Invalid data. \nPlease, try again.");
            }

            if (value == 1 || value == 2) 
            {
                MessageBox.Show("n! = " + value);
            }

            if(value > 2) 
            {
                int result = 1;
                for (int i = value; i > 0; i--)
                {
                    result = result * i;
                }
                MessageBox.Show("n! = " + result);
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Do you really want to exit?", "Close", MessageBoxButton.YesNo);
            switch (result)
            {
                case MessageBoxResult.Yes:
                    MessageBox.Show("Bye, bye!");
                    break;
                case MessageBoxResult.No:
                    MessageBox.Show("Hello again!");
                    e.Cancel = true;
                    break;
            }
        }
    }
}
