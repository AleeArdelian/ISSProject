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
using System.Configuration;

namespace Client
{
    public partial class AuthorMainWindow : Form
    {
        IService service;
        String cnp;

        public AuthorMainWindow(IService service,String cnp)
        {
            this.service = service;
            this.cnp = cnp;
            InitializeComponent();
            cnpLabel.Text = cnp.ToString();
            populateDGVS();
            panelUploadPaper.Visible = false;
        }

        private void btnUpdateInfo_Click(object sender, EventArgs e)
        {
            service.UpdateAuthor(this.cnp, firstNameTextBox.Text, lastNameTextBox.Text);
        }

        private void populateDGVS()
        {
            using (SqlConnection dbCon = new SqlConnection(ConfigurationManager.ConnectionStrings["cmsDatabase"].ConnectionString))
            {
                dbCon.Open();
                SqlDataAdapter dta = new SqlDataAdapter("SELECT * FROM Conferences", dbCon);
                DataTable tbl = new DataTable();
                dta.Fill(tbl);
                conferencesDGV.DataSource = tbl;
                SqlDataAdapter dta1 = new SqlDataAdapter("SELECT * FROM Sections", dbCon);
                DataTable tbl1 = new DataTable();
                dta1.Fill(tbl1);
                sectionsDGV.DataSource = tbl1;
                conferencesDGV.Columns["ConferenceID"].Visible = false;
                sectionsDGV.Columns["SectionID"].Visible = false; sectionsDGV.Columns["SectionChairCNP"].Visible = false;
                dbCon.Close();
            }
        }

        private void conferencesDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int cid = Int32.Parse(conferencesDGV[0, rowIndex].Value.ToString());
            SqlConnection dbCon = new SqlConnection(ConfigurationManager.ConnectionStrings["cmsDatabase"].ConnectionString);
            SqlCommand cmd = new SqlCommand("select * from (select S.SectionID, S.SectionChairCNP, S.Room, S.SectionName, C.ConferenceID"+
                " from Conferences C inner join ConferenceSections CS on C.ConferenceID = CS.ConferenceID inner join Sections S on S.SectionID = CS.SectionID) q"+
                " where ConferenceID = @cid", dbCon);
            SqlParameter pr = new SqlParameter("@cid", cid);
            cmd.Parameters.Add(pr);
            SqlDataAdapter dta = new SqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            dta.Fill(tbl);
            sectionsDGV.DataSource = tbl;
            sectionsDGV.Columns["SectionID"].Visible = false; sectionsDGV.Columns["SectionChairCNP"].Visible = false;
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            panelUploadPaper.Visible = true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int srw = sectionsDGV.CurrentCell.RowIndex;
            int crw = conferencesDGV.CurrentCell.RowIndex;

            int sid = Int32.Parse(sectionsDGV[0, srw].Value.ToString());
            int cid = Int32.Parse(conferencesDGV[0, crw].Value.ToString());

            service.AddPaper(contentTextBox.Text, absTextBox.Text, paperNameTextBox.Text, topicTextBox.Text, sid);

            SqlConnection dbCon = new SqlConnection(ConfigurationManager.ConnectionStrings["cmsDatabase"].ConnectionString);
            SqlCommand cmd = new SqlCommand("INSERT INTO ConferenceAuthors(ConferenceID,AuthorCNP) VALUES(" + cid + "," + this.cnp + ")",dbCon);
            dbCon.Open(); cmd.ExecuteNonQuery(); dbCon.Close();
            int pid = service.FindMaxPaperID();
            SqlCommand cmd1 = new SqlCommand("INSERT INTO AuthorPapers(AuthorCNP,PaperID) VALUES(" + this.cnp + "," + pid + ")", dbCon);
            dbCon.Open(); cmd1.ExecuteNonQuery(); dbCon.Close();
        }
    }
}
