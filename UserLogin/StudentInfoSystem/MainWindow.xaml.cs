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

        public void ClearTextBoxesContent()
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

        public void ShowStudentInfo(Student student)
        {
            txtFirstName.Text = student.firstName;
            txtSecondName.Text = student.secondName;
            txtLastName.Text = student.lastName;
            txtFaculty.Text = student.faculty;
            txtSpeciality.Text = student.speciality;
            txtEducationalDegree.Text = student.educationalDegree;
            txtStatus.Text = student.status;
            txtFacultyNumber.Text = student.facultyNumber;
            txtCourse.Text = student.course.ToString();
            txtStream.Text = student.stream.ToString();
            txtGroup.Text = student.group.ToString();
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

        public void EnableTextBoxes()
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

        private void btnLogOut_Click(object sender, RoutedEventArgs e)
        {
            LogInFormUsername loginFormUsername = new LogInFormUsername();
            loginFormUsername.Show();
            this.Close();
        }
    }
}
