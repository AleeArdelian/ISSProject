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

namespace Client
{
    public partial class MemberMainWindow : Form
    {
        private IService service;
        private String cnp;

        public MemberMainWindow(IService service, String cnp)
        {
            this.cnp = cnp;
            this.service = service;
            InitializeComponent();
            this.tbaCnpLabel.Text = cnp;
            this.panelUploadPaper.Visible = false;
            this.panelReview.Visible = false;
            populateDGVS();
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
                SqlDataAdapter dta2 = new SqlDataAdapter("SELECT P.PaperName, P.Abstract, P.Content, P.Topic FROM Papers P INNER JOIN AuthorPapers AP ON P.PaperID=AP.PaperID WHERE AP.AuthorCNP!="+this.cnp, dbCon);
                DataTable tbl2 = new DataTable();
                dta2.Fill(tbl2);
                papersDGV.DataSource = tbl2;
                SqlDataAdapter dta3 = new SqlDataAdapter("SELECT P.PaperName, P.Abstract, P.Content, P.Topic FROM Papers P INNER JOIN AuthorPapers AP ON P.PaperID=AP.PaperID WHERE AP.AuthorCNP=" + this.cnp, dbCon);
                DataTable tbl3 = new DataTable();
                dta3.Fill(tbl3);
                yourPapersDGV.DataSource = tbl3;
                dbCon.Close();
            }
        }

        private void btnUpdateInfo_Click(object sender, EventArgs e)
        {
            service.UpdateRegularMember(this.cnp, firstNameTextBox.Text, lastNameTextBox.Text, affiliationTextBox.Text);
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            this.panelUploadPaper.Visible = true;
        }

        private void btnReview_Click(object sender, EventArgs e)
        {
            this.comboBoxQualifier.Items.Add("Strong Reject");
            this.comboBoxQualifier.Items.Add("Reject");
            this.comboBoxQualifier.Items.Add("Weak Reject");
            this.comboBoxQualifier.Items.Add("Boarderline Paper");
            this.comboBoxQualifier.Items.Add("Strong Accept");
            this.comboBoxQualifier.Items.Add("Accept");
            this.comboBoxQualifier.Items.Add("Weak Accept");
            this.panelReview.Visible = true;
        }

        private void conferencesDGV_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int cid = Int32.Parse(conferencesDGV[0, rowIndex].Value.ToString());
            SqlConnection dbCon = new SqlConnection(ConfigurationManager.ConnectionStrings["cmsDatabase"].ConnectionString);
            SqlCommand cmd = new SqlCommand("select * from (select S.SectionID, S.SectionChairCNP, S.Room, S.SectionName, C.ConferenceID" +
                " from Conferences C inner join ConferenceSections CS on C.ConferenceID = CS.ConferenceID inner join Sections S on S.SectionID = CS.SectionID) q" +
                " where ConferenceID = @cid", dbCon);
            SqlParameter pr = new SqlParameter("@cid", cid);
            cmd.Parameters.Add(pr);
            SqlDataAdapter dta = new SqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            dta.Fill(tbl);
            sectionsDGV.DataSource = tbl;
            sectionsDGV.Columns["SectionID"].Visible = false; sectionsDGV.Columns["SectionChairCNP"].Visible = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int srw = sectionsDGV.CurrentCell.RowIndex;
            int crw = conferencesDGV.CurrentCell.RowIndex;

            int sid = Int32.Parse(sectionsDGV[0, srw].Value.ToString());
            int cid = Int32.Parse(conferencesDGV[0, crw].Value.ToString());

            service.AddPaper(contentLabel.Text, absTextBox.Text, paperNameTextBox.Text, topicTextBox.Text, sid);

            SqlConnection dbCon = new SqlConnection(ConfigurationManager.ConnectionStrings["cmsDatabase"].ConnectionString);
            SqlCommand cmdIA = new SqlCommand("INSERT INTO Authors(CNP) values (" + this.cnp + ")", dbCon);
            try
            {
                dbCon.Open(); cmdIA.ExecuteNonQuery(); dbCon.Close();
                SqlCommand cmd = new SqlCommand("INSERT INTO ConferenceAuthors(ConferenceID,AuthorCNP) VALUES(" + cid + "," + this.cnp + ")", dbCon);
                dbCon.Open(); cmd.ExecuteNonQuery(); dbCon.Close();
            }
            catch (SqlException)
            {
                dbCon.Close();
            }
            int pid = service.FindMaxPaperID();
            SqlCommand cmd1 = new SqlCommand("INSERT INTO AuthorPapers(AuthorCNP,PaperID) VALUES(" + this.cnp + "," + pid + ")", dbCon);
            dbCon.Open(); cmd1.ExecuteNonQuery(); dbCon.Close();
            populateDGVS();
        }
        
    }
}
