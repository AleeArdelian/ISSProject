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
    public partial class ListenerRegisterWindow : Form
    {
        IService service;

        public ListenerRegisterWindow(IService service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (service.registerListener(firstNametextbox.Text, lastNameTextbox.Text, cnpTextbox.Text, emailTextbox.Text, usernameTextbox.Text, passwordTextbox.Text))
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
