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

        private void ShowStudentInfo(Student student)
        {
            txtFirstName.Text = student.GetFirstName();
            txtSecondName.Text = student.GetSecondName();
            txtLastName.Text = student.GetLastName();
            txtFaculty.Text = student.GetFaculty();
            txtSpeciality.Text = student.GetSpeciality();
            txtEducationalDegree.Text = student.GetEducationalDegree();
            txtStatus.Text = student.GetStatus();
            txtFacultyNumber.Text = student.GetFacNum();
            txtCourse.Text = student.GetCourse().ToString();
            txtStream.Text = student.GetStream().ToString();
            txtGroup.Text = student.GetGroup().ToString();
        }

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
            foreach (var item in gPersonalInformation.Children)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).IsEnabled = true;
                }
            }

            foreach (var item in gStudentInformation.Children)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).IsEnabled = true;
                }
            }
        }
    }
}
