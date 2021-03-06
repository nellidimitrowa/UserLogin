﻿using System;
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

namespace StudentInfoSystem
{
    /// <summary>
    /// Interaction logic for LogInFormUsername.xaml
    /// </summary>
    public partial class LogInFormUsername : Window
    {
        public static List<string> username = new List<string>();
        

        public LogInFormUsername()
        {
            InitializeComponent();
        }

        private void btnEnterUsername_Click(object sender, RoutedEventArgs e)
        {
            User user = UserData.IsUserUsernameCorrect(txtUsername.Text);
            if (user != null)
            {
                username.Add(txtUsername.Text);
                var logInFormPassword = new LogInFormPassword();
                logInFormPassword.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("There is no user with this username. Try again.");
                txtUsername.Text = String.Empty;
            }
        }
    }
}
