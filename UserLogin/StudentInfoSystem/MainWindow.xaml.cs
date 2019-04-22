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

namespace StudentInfoSystem
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

        private void ClearTextBoxContent()
        {
            txtFirstName.Text = String.Empty;
            txtSecondName.Text = String.Empty;
            txtLastName.Text = String.Empty;
            txtFaculty.Text = String.Empty;
            txtSpeciality.Text = String.Empty;
            txtEducationalDegree.Text = String.Empty;
            txtStatus.Text = String.Empty;
            txtFacultyNumber.Text = String.Empty;
            txtCouse.Text = String.Empty;
            txtStream.Text = String.Empty;
            txtGroup.Text = String.Empty;
        }
    }
}
