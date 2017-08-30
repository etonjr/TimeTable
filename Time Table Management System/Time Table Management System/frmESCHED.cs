using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace Time_Table_Management_System
{
    public partial class frmESCHED : Form
    {
        Db_Utilities db = new Db_Utilities();
        MySqlCommand cmd;
        MySqlDataAdapter ad;
        DataTable ss;

        private string uID, eventID, eventN, eschedID, dDay, dTime, dFTime; 
        public frmESCHED()
        {
            InitializeComponent();
        }
        private void loadDATA()
        {
            string query = "SELECT * FROM tbl_esched WHERE user_idfke = '" + uID + "' AND esched_id = '" + eschedID + "'";
            cmd = new MySqlCommand(query, db.OpenConnection());
            MySqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                dtpSDate.Text = Convert.ToDateTime(r["esdate"].ToString()).ToString("MMM dd, yyyy - dddd");
                dtpFDate.Text = Convert.ToDateTime(r["efdate"].ToString()).ToString("MMM dd, yyyy - dddd");
                dtpSTime.Text = r["etime"].ToString().Split('-').First().Trim();
                dtpFTime.Text = r["etime"].ToString().Split('-').Last().Trim();
                lblDTIME.Text = r["time"].ToString().Split('-').First().Trim();
                lblDTIMEF.Text = r["time"].ToString().Split('-').Last().Trim();
                lblDSdate.Text = r["esdate"].ToString();
                lblDFdate.Text = r["efdate"].ToString();
                txtPlace.Text = r["place"].ToString();
            }
            r.Close();
            db.CloseConnection();
            cmbSUBJ.Text = eventN;
            tsmSAVE.Text = "Update";
        }
        private void PopulateSUBJ()
        {
            cmbSUBJ.Text = "";
            cmbSUBJ.Items.Clear();
            eventID = "0";
            string query = "SELECT eventname FROM tbl_event WHERE uid_fkev = '" + uID + "' ORDER BY eventname";
            cmd = new MySqlCommand(query, db.OpenConnection());
            MySqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                cmbSUBJ.Items.Add(r["eventname"].ToString());
            }
            r.Close();
            db.CloseConnection();
        }
        private void frmEvent_Load(object sender, EventArgs e)
        {
            uID = frmUSER.uID;
            eventID = frmMAIN.eventID;
            eventN = frmMAIN.eventN;
            eschedID = frmMAIN.eschedID;
            if (eschedID != "") { loadDATA(); }
            else
            {
                tsmSAVE.Text = "Save";
                dtpSDate.Value = DateTime.Today; dtpFDate.Value = DateTime.Today;
                dtpSTime.Value = DateTime.Now; dtpFTime.Value = DateTime.Now;
                dtpSDate.Text = DateTime.Today.ToString("MMM dd, yyyy - dddd"); dtpFDate.Text = DateTime.Today.ToString("MMM dd, yyyy - dddd");
                dtpSTime.Text = DateTime.Now.ToString("hh:mm tt"); dtpFTime.Text = DateTime.Now.ToString("hh:mm tt");
            }
        }
        private void cmbSUBJ_DropDown(object sender, EventArgs e)
        {
            if (cmbSUBJ.Items.Count >= 0) { PopulateSUBJ(); }
            else { MessageBox.Show("Title List is Empty.", "No Records Found", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }
        private void cmbSUBJ_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "SELECT * FROM tbl_event WHERE eventname = '" + cmbSUBJ.Text + "'";
            cmd = new MySqlCommand(query, db.OpenConnection());
            MySqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                eventID = r["event_id"].ToString();
            }
            r.Close();
            db.CloseConnection();
        }
        private void saveSCHED()
        {
            string query = " INSERT INTO tbl_esched (esdate,efdate,etime,estime,eplace,user_idfke,event_idfke)" +
                                        "VALUES ('" + dtpSDate.Value.ToString("yyyy-dd-MM") + "','" + dtpFDate.Value.ToString("yyyy-dd-MM") + "','" + dtpSTime.Value.ToString("hh:mm tt") + " - " + dtpFTime.Value.ToString("hh:mm tt") + "','" + dtpSTime.Value.ToString("HH:mm") + "','" + this.txtPlace.Text + "','" + uID + "','" + eventID + "');";
            cmd = new MySqlCommand(query, db.OpenConnection());
            MySqlDataReader r = cmd.ExecuteReader();
            r.Close(); db.CloseConnection(); MessageBox.Show("Schedule Saved"); this.Close();
        }
        private void updateSCHED()
        {
            string query = "UPDATE tbl_esched SET esdate = '" + dtpSDate.Value.ToString("yyyy-dd-MM") + "',efdate = '" + dtpFDate.Value.ToString("yyyy-dd-MM") + "', etime = '" + dtpSTime.Value.ToString("hh:mm tt") + " - " + dtpFTime.Value.ToString("hh:mm tt") + "', estime = '" + dtpSTime.Value.ToString("HH:mm") + "', eplace = '" + txtPlace.Text + "', event_idfke = '" + eventID + "' WHERE esched_id = '" + eschedID + "'";
            cmd = new MySqlCommand(query, db.OpenConnection());
            MySqlDataReader re = cmd.ExecuteReader();
            re.Close(); db.CloseConnection(); MessageBox.Show("Schedule Updated"); this.Close();
        }

        private void tsmSAVE_Click(object sender, EventArgs e)
        {
            if (eventID != "0" && txtPlace.Text != "" )
            {
                if (tsmSAVE.Text == "Update")
                {
                    if (cmbSUBJ.Text != eventN)
                    {
                        ad = new MySqlDataAdapter("SELECT * FROM tbl_esched WHERE esdate = '" + dtpSDate.Value.ToString("yyyy-dd-MM") + "' AND efdate = '" + dtpFDate.Value.ToString("yyyy-dd-MM") + "' AND etime = '" + dtpSTime.Value.ToString("hh:mm tt") + " - " + dtpFTime.Value.ToString("hh:mm tt") + "' AND event_idfke = '" + eventID + "' AND user_idfke = '" + uID + "'", db.OpenConnection());
                        ss = new DataTable();
                        ad.Fill(ss);
                        int i = ss.Rows.Count;
                        if (i > 0)
                        {
                            MessageBox.Show("There is already a schedule set for this event( " + cmbSUBJ.Text + " ).\n Please check again input information.", "Information Already Exist", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            ss.Clear();
                        }
                        else { updateSCHED(); }
                    }
                    else if (cmbSUBJ.Text == eventN)
                    {
                        if (dtpSTime.Text + dtpFTime.Text == lblDTIME.Text + lblDTIMEF.Text && dtpSDate.Text == lblDSdate.Text && dtpFDate.Text == lblDFdate.Text) { updateSCHED(); }
                        else
                        {
                            ad = new MySqlDataAdapter("SELECT * FROM tbl_esched WHERE esdate = '" + dtpSDate.Value.ToString("yyyy-dd-MM") + "' AND efdate = '" + dtpFDate.Value.ToString("yyyy-dd-MM") + "' AND etime = '" + dtpSTime.Value.ToString("hh:mm tt") + " - " + dtpFTime.Value.ToString("hh:mm tt") + "' AND user_idfke = '" + uID + "'", db.OpenConnection());
                            ss = new DataTable();
                            ad.Fill(ss);
                            int ii = ss.Rows.Count;
                            if (ii > 0)
                            {
                                MessageBox.Show("This Schedule already exist in another event.\n Please check input information.", "Conflict Schedule", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                ss.Clear();
                            }
                            else { updateSCHED(); }
                        }
                    }
                }
                else if (tsmSAVE.Text == "Save")
                {
                    ad = new MySqlDataAdapter("SELECT * FROM tbl_esched WHERE esdate = '" + dtpSDate.Value.ToString("yyyy-dd-MM") + "' AND efdate = '" + dtpFDate.Value.ToString("yyyy-dd-MM") + "' AND etime = '" + dtpSTime.Value.ToString("hh:mm tt") + " - " + dtpFTime.Value.ToString("hh:mm tt") + "' AND event_idfke = '" + eventID + "' AND user_idfke = '" + uID + "'", db.OpenConnection());
                    ss = new DataTable();
                    ad.Fill(ss);
                    int i = ss.Rows.Count;
                    if (i > 0)
                    {
                        MessageBox.Show("There is already a schedule set for this event( " + cmbSUBJ.Text + " ).\n Please check again input information.", "Information Already Exist", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        ss.Clear();
                    }
                    else if (i == 0)
                    {
                        ad = new MySqlDataAdapter("SELECT * FROM tbl_esched WHERE esdate = '" + dtpSDate.Value.ToString("yyyy-dd-MM") + "' AND efdate = '" + dtpFDate.Value.ToString("yyyy-dd-MM") + "' AND etime = '" + dtpSTime.Value.ToString("hh:mm tt") + " - " + dtpFTime.Value.ToString("hh:mm tt") + "' AND user_idfke = '" + uID + "'", db.OpenConnection());
                        ss = new DataTable();
                        ad.Fill(ss);
                        int ii = ss.Rows.Count;
                        if (ii > 0)
                        {
                            MessageBox.Show("This Schedule already exist in another event.\n Please check input information.", "Conflict Schedule", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            ss.Clear();
                        }
                        else { saveSCHED(); }
                    }
                }
                else { MessageBox.Show("You can only create a schedule starting from TODAY's Date onwards. Please check again input information.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            }
            else { MessageBox.Show("Please fill-up all the required information before saving.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
        }

        private void tsmSTAFFEXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
