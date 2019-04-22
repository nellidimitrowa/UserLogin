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
using StudentRepository;

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

        private void ClearTextBoxesContent()
        {

            foreach (var item in gPersonalInformation.Children)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Text = String.Empty;
                }
            }

            foreach (var item in gStudentInformation.Children)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Text = String.Empty;
                }
            }
        }

        //private void ShowStudentInfo()
        //{
        //    txtFirstName.Text = 
        //}

        private void DisableTextBoxes()
        {
            foreach (var item in gPersonalInformation.Children)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).IsEnabled = false;
                }
            }

            foreach (var item in gStudentInformation.Children)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).IsEnabled = false;
                }
            }
        }

        private void EnableTextBoxes()
        {
            txtFirstName.IsEnabled = true;
            txtSecondName.IsEnabled = true;
            txtLastName.IsEnabled = true;
            txtFaculty.IsEnabled = true;
            txtSpeciality.IsEnabled = true;
            txtEducationalDegree.IsEnabled = true;
            txtStatus.IsEnabled = true;
            txtFacultyNumber.IsEnabled = true;
            txtCourse.IsEnabled = true;
            txtStream.IsEnabled = true;
            txtGroup.IsEnabled = true;
        }
    }
}
