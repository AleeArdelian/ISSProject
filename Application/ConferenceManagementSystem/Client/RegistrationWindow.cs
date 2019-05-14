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
    public partial class RegistrationWindow : Form
    {
        private IService service;

        public RegistrationWindow(IService service)
        {
            this.service = service;
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("register successful");
            this.Close();
        }
    }
}
