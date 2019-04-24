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
using System.Windows.Shapes;
using UserLogin;
using StudentRepository;

namespace StudentInfoSystem
{
    /// <summary>
    /// Interaction logic for LogInFormPassword.xaml
    /// </summary>
    public partial class LogInFormPassword : Window
    {
        public LogInFormPassword()
        {
            InitializeComponent();
        }

        private void btnEnterPassword_Click(object sender, RoutedEventArgs e)
        {
            User user = UserData.IsUserPasswordCorrect(txtPassword.Text);
            if(txtPassword.Text == "" || user  == null) 
            {
                MessageBox.Show("There is no user with this password. Try again.");
                txtPassword.Text = String.Empty;
            } else
            {
                var mainWindow = new MainWindow();
                Student student = StudentRepository.StudentValidation.GetStudentDataByUser(user);
                mainWindow.Show();
                mainWindow.ShowStudentInfo(student);
                this.Close();
            }
        }
    }
}
