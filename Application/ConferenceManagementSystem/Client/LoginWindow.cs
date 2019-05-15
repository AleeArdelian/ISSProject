using Common.Domain;
using Common.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class LoginWindow : Form
    {
        private IService service;

        public LoginWindow(IService service)
        {
            this.service = service;
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Tuple<String,String> mytuple = service.login(usernameTextBox.Text, passwordTextBox.Text);
            switch (mytuple.Item2)
            {
                default:
                    this.Hide();
                    MainWindow mainWindow = new MainWindow(this.service);
                    mainWindow.ShowDialog();
                    this.Show();
                    break;
                case "FAILED":
                    MessageBox.Show("Incorrect username or password. Try again.", "Warning", MessageBoxButtons.OK);
                    break;
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationWindow regWindow = new RegistrationWindow(this.service);
            regWindow.ShowDialog();
            this.Show();
        }
    }
}
