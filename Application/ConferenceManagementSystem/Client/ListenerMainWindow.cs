using Common.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client {
    public partial class ListenerMainWindow : Form {
        private IService service;
        private String cnp;

        public ListenerMainWindow(IService service, String cnp) {
            InitializeComponent();
            this.service = service;
            this.cnp = cnp;
        }

        private void populateDGV() {
            using (SqlConnection dbCon = new SqlConnection(ConfigurationManager.ConnectionStrings["cmsDatabase"].ConnectionString)) {
                dbCon.Open();
                SqlDataAdapter dta = new SqlDataAdapter("SELECT * FROM Sections", dbCon);
                DataTable tbl = new DataTable();
                dta.Fill(tbl);
                sectionsDGV.DataSource = tbl;
                sectionsDGV.Columns["SectionID"].Visible = false;
                sectionsDGV.Columns["SectionChairCNP"].Visible = false;
                dbCon.Close();
            }
        }

        private void ListenerMainWindow_Load(object sender, EventArgs e) {
            populateDGV();
        }

        private void buttonJoinSection_Click(object sender, EventArgs e) {
            //if the user didn't select anything
            if (sectionsDGV.SelectedRows.Count == 0)
                MessageBox.Show("Please select at least 1 section. You need to select the entire row.");
            for (int rowIndex = 0; rowIndex < sectionsDGV.SelectedRows.Count; rowIndex++) {
                int sectionId = (Int32)sectionsDGV.SelectedRows[rowIndex].Cells[0].Value;
                String sectionName = sectionsDGV.SelectedRows[rowIndex].Cells[2].Value.ToString();
                using (SqlConnection dbCon = new SqlConnection(ConfigurationManager.ConnectionStrings["cmsDatabase"].ConnectionString)) {
                    dbCon.Open();
                    //check if participant is already registered in this section
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "SELECT COUNT(*) FROM ParticipantSections WHERE SectionId = '" + sectionId + "'";
                    cmd.Connection = dbCon;
                    Int32 count = (Int32)cmd.ExecuteScalar();
                    if (count > 0)
                        MessageBox.Show("You are already registered in " + sectionName + ".");
                    else {
                        //register to selected section
                        SqlCommand insertCmd = new SqlCommand();
                        insertCmd.CommandText = "INSERT INTO ParticipantSections VALUES ('" + sectionId + "', '" + cnp + "')";
                        insertCmd.Connection = dbCon;
                        insertCmd.ExecuteNonQuery();
                        MessageBox.Show("Successfully registered to " + sectionName + ".");
                    }
                    dbCon.Close();
                }
            }
        }
    }
}
