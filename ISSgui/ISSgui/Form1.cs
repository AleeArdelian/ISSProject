using ISSgui.Domain;
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
    public partial class Form1 : Form
    {
        private DataBaseAdaptor dba;

        public Form1()
        {
            InitializeComponent();
            dba = new DataBaseAdaptor();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Int64> columnData = new List<Int64>();
            if (!textBox1.Text.Equals("") && !textBox2.Text.Equals(""))
            {
                dba.openConnection();
                SqlParameter pr1 = new SqlParameter("@x", textBox1.Text);
                SqlParameter pr2 = new SqlParameter("@y", textBox2.Text);
                SqlCommand cmd = new SqlCommand("select * from Participants where username=@x and passwd=@y", dba.GetConnection());
                cmd.Parameters.Add(pr1);
                cmd.Parameters.Add(pr2);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        columnData.Add(reader.GetInt64(0));
                    }
                }
                if (columnData.Count > 0)
                {
                    this.Hide();
                    Form3 f3 = new Form3();
                    f3.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("invalid username password combination!");
                }
                dba.closeConnection();
            }
            else
            {
                MessageBox.Show("invalid username password combination");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
            this.Show();
        }
    }
}
