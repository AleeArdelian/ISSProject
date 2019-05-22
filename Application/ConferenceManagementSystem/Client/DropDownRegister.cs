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
    public partial class DropDownRegister : Form
    {
        private IService service;

        public DropDownRegister(IService service)
        {
            InitializeComponent();
            this.service = service;
            comboBox1.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

      
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Invalid option! Please choose again!");
                this.Close();

            }
            else if (comboBox1.SelectedItem.ToString() == "ChairMember" || comboBox1.SelectedItem.ToString() == "RegularMember")
            {
                this.Hide();
                RegistrationWindow regWindow = new RegistrationWindow(this.service);
                regWindow.ShowDialog();
            }
            else if(comboBox1.SelectedItem.ToString() == "Author")
            {
                this.Hide();
                AuthorRegisterWindow registerWindow = new AuthorRegisterWindow(this.service);
                registerWindow.ShowDialog();
                
            }
            else if(comboBox1.SelectedItem.ToString() == "Listener")
            {
                this.Hide();
                ListenerRegisterWindow regWindow = new ListenerRegisterWindow(this.service);
                regWindow.ShowDialog();
                
            }
        }
    }
}
