using Common.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class AuthorRegisterWindow : Form
    {
        IService service;

        public AuthorRegisterWindow(IService service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (service.registerAuthor(firstNameTextBox.Text, lastNameTextbox.Text, cnpTextbox.Text, affiliationTextBox.Text, emailTextbox.Text, usernameTextBox.Text, passwordTextbox.Text))
            {
                MessageBox.Show("register successful");
                this.Close();
            }
            else
            {
                MessageBox.Show("register failed");
            }
        }
    }
}
