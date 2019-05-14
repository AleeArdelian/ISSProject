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

namespace ISSgui
{
    public partial class LoginWindow : Form
    {
        private IService service = null;

        public LoginWindow(IService service)
        {
            this.service = service;
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            Form3 nf = new Form3();
            nf.ShowDialog();
            this.Show();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationWindow nf = new RegistrationWindow();
            nf.ShowDialog();
            this.Show();
        }
    }
}
