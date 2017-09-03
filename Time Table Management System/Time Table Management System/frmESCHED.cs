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

        private string uID, eventID, eventN, eschedID, SDate, Fdate, dSTime, dFTime, cmb; 
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
                dtpSDate.Text = r["esdate"].ToString();
                dtpFDate.Text = r["efdate"].ToString();
                dtpSTime.Text = r["etime"].ToString().Split('-').First().Trim();
                dtpFTime.Text = r["etime"].ToString().Split('-').Last().Trim();
                dSTime = r["etime"].ToString().Split('-').First().Trim();
                dFTime = r["etime"].ToString().Split('-').Last().Trim();
                SDate = Convert.ToDateTime(r["esdate"].ToString()).ToString("MMM dd, yyyy - dddd");
                Fdate = Convert.ToDateTime(r["efdate"].ToString()).ToString("MMM dd, yyyy - dddd");
                txtPlace.Text = r["eplace"].ToString();
            }
            r.Close();
            db.CloseConnection();
            cmbEvent.Text = frmMAIN.ceventN;
            eventID = frmMAIN.ceventID;
            eventN = frmMAIN.ceventN;
            tsmSAVE.Text = "Update";
        }
        private void frmEvent_Load(object sender, EventArgs e)
        {
            uID = frmUSER.uID; eventID = frmMAIN.eventID; eventN = frmMAIN.eventN; eschedID = frmMAIN.eschedID;
            if (eschedID != "") { loadDATA(); }
            else
            {
                tsmSAVE.Text = "Save"; cmbEvent.Text = eventN;
                dtpSDate.Value = DateTime.Today; dtpFDate.Value = DateTime.Today;
                dtpSTime.Value = DateTime.Now; dtpFTime.Value = DateTime.Now;
                dtpSDate.Text = DateTime.Today.ToString("MMM dd, yyyy - dddd"); dtpFDate.Text = DateTime.Today.ToString("MMM dd, yyyy - dddd");
                dtpSTime.Text = DateTime.Now.ToString("hh:mm tt"); dtpFTime.Text = DateTime.Now.ToString("hh:mm tt");
            }
        }
        private void populateEvent()
        {
            cmbEvent.Text = "";
            cmbEvent.Items.Clear();
            eventID = "0";
            string query = "SELECT eventname FROM tbl_event WHERE uid_fkev = '" + uID + "' ORDER BY eventname";
            cmd = new MySqlCommand(query, db.OpenConnection());
            MySqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                cmbEvent.Items.Add(r["eventname"].ToString());
            }
            r.Close();
            db.CloseConnection();
        } 
        private void cmbEvent_DropDown(object sender, EventArgs e)
        {
            if (cmbEvent.Items.Count >= 0) { populateEvent(); }
            else { MessageBox.Show("Subject List is Empty.", "No Records Found", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void cmbEvent_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "SELECT * FROM tbl_event WHERE eventname = '" + cmbEvent.Text + "'";
            cmd = new MySqlCommand(query, db.OpenConnection());
            MySqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                eventID = r["event_id"].ToString();
            }
            r.Close();
            db.CloseConnection();
        }
        private void chkTimeLaps()
        {
            int i = 0;
            int sum = 0;
            try
            {
                ad = new MySqlDataAdapter("SELECT esdate, efdate, estime, eftime, esched_id FROM tbl_esched WHERE user_idfke = '" + uID + "' ORDER BY esdate", db.OpenConnection());
                ss = new DataTable();
                ad.Fill(ss);
                dgvSample.DataSource = ss;
                foreach (DataGridViewRow rows in dgvSample.Rows)
                {
                    if (rows.Cells[0].Value == null) { break; }
                    DateTime dtSDate = DateTime.Parse(rows.Cells[0].Value.ToString());
                    DateTime dtFDate = DateTime.Parse(rows.Cells[1].Value.ToString());
                    DateTime dtstart = DateTime.Parse(rows.Cells[2].Value.ToString());
                    DateTime dtend = DateTime.Parse(rows.Cells[3].Value.ToString());


                    if (eschedID == "")
                    {
                        if ((dtpSDate.Value < dtSDate) && (dtpFDate.Value < dtSDate) || (dtpSDate.Value > dtFDate) && (dtpFDate.Value > dtFDate)) { i += 0; }
                        else if (((dtpSDate.Value >= dtSDate) && (dtpFDate.Value <= dtFDate)) || ((dtpSDate.Value <= dtSDate) && (dtpFDate.Value >= dtFDate)) || ((dtpSDate.Value >= dtSDate) && (dtpFDate.Value >= dtFDate)) || ((dtpSDate.Value <= dtSDate) && (dtpFDate.Value <= dtFDate)))
                        {
                            if ((dtpSTime.Value.TimeOfDay < dtstart.TimeOfDay) && (dtpFTime.Value.TimeOfDay <= dtstart.TimeOfDay)) { i += 0; }
                            else if ((dtpSTime.Value.TimeOfDay >= dtend.TimeOfDay) && (dtpFTime.Value.TimeOfDay > dtend.TimeOfDay)) { i += 0; }
                            else { i += 1; }
                        }
                    }
                    else if (eschedID != "")
                    {
                        if (((dtpSDate.Value < dtSDate) && (dtpFDate.Value < dtFDate) || (dtpSDate.Value > dtFDate) && (dtpFDate.Value > dtFDate)) && eschedID != rows.Cells[4].Value.ToString()) { i += 0; }
                        else if (((dtpSDate.Value >= dtSDate) && (dtpFDate.Value <= dtFDate)) || ((dtpSDate.Value <= dtSDate) && (dtpFDate.Value >= dtFDate)) || ((dtpSDate.Value >= dtSDate) && (dtpFDate.Value >= dtFDate)) || ((dtpSDate.Value <= dtSDate) && (dtpFDate.Value <= dtFDate)))
                        {
                            if ((dtpSTime.Value.TimeOfDay < dtstart.TimeOfDay) && (dtpFTime.Value.TimeOfDay <= dtstart.TimeOfDay) && eschedID != rows.Cells[4].Value.ToString()) { i += 0; }
                            else if ((dtpSTime.Value.TimeOfDay >= dtend.TimeOfDay) && (dtpFTime.Value.TimeOfDay > dtend.TimeOfDay) && eschedID != rows.Cells[4].Value.ToString()) { i += 0; }
                            else
                            {
                                if (eschedID == rows.Cells[4].Value.ToString()) { i += 0; }
                                else { i += 1; }
                            }
                        }
                    }
                    sum += i;
                }
            }
            finally
            {
                string query = "SELECT day FROM tbl_csched WHERE (stime = '" + dtpSTime.Value.ToString("HH:mm") + "' OR ftime = '" + dtpFTime.Value.ToString("HH:mm") + "') AND user_idfksc ='" + uID + "'";
                cmd = new MySqlCommand(query, db.OpenConnection());
                MySqlDataReader r = cmd.ExecuteReader();
                while (r.Read()) { cmb = r["day"].ToString(); }
                r.Close();
                db.CloseConnection();
                if (cmb == dtpSDate.Value.ToString("dddd"))
                {
                    MessageBox.Show("This schedule conflicts other schedule that is set in the subject list.\n Please check again input information.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cmb = "";
                }
                else if (sum == 0)
                {
                    if (tsmSAVE.Text == "Save") { saveSCHED(); }
                    else if (tsmSAVE.Text == "Update") { updateSCHED(); }
                }
                else if (sum > 0)
                {
                    MessageBox.Show("The starting time or date you set conflicts in another schedule.\nPlease check again input information.", "Time Overlap", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void saveSCHED()
        {
            string query = " INSERT INTO tbl_esched (esdate,efdate,etime,estime,eftime,eplace,user_idfke,event_idfke)" +
                                        "VALUES ('" + dtpSDate.Value.ToString("yyyy-MM-dd") + "','" + dtpFDate.Value.ToString("yyyy-MM-dd") + "','" + dtpSTime.Value.ToString("hh:mm tt") + " - " + dtpFTime.Value.ToString("hh:mm tt") + "','" + dtpSTime.Value.ToString("HH:mm") + "','" + dtpFTime.Value.ToString("HH:mm") + "','" + this.txtPlace.Text + "','" + uID + "','" + eventID + "');";
            cmd = new MySqlCommand(query, db.OpenConnection());
            MySqlDataReader r = cmd.ExecuteReader();
            r.Close(); db.CloseConnection(); MessageBox.Show("Schedule Saved"); this.Close();
        }
        private void updateSCHED()
        {
            string query = "UPDATE tbl_esched SET esdate = '" + dtpSDate.Value.ToString("yyyy-MM-dd") + "',efdate = '" + dtpFDate.Value.ToString("yyyy-MM-dd") + "', etime = '" + dtpSTime.Value.ToString("hh:mm tt") + " - " + dtpFTime.Value.ToString("hh:mm tt") + "', estime = '" + dtpSTime.Value.ToString("HH:mm") + "',eftime = '" + dtpFTime.Value.ToString("HH:mm") + "', eplace = '" + txtPlace.Text + "', event_idfke = '" + eventID + "' WHERE esched_id = '" + eschedID + "'";
            cmd = new MySqlCommand(query, db.OpenConnection());
            MySqlDataReader re = cmd.ExecuteReader();
            re.Close(); db.CloseConnection(); MessageBox.Show("Schedule Updated"); this.Close();
        }


        private void tsmSAVE_Click(object sender, EventArgs e)
        {
            if (eventID != "0" && txtPlace.Text != "")
            {
                if ((dtpSTime.Value > dtpFTime.Value) || (dtpSDate.Value > dtpFDate.Value)) { MessageBox.Show("The settings of Time/Period or Date duration is invalid.\nPlease check again input information.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
                else if ((dtpSTime.Value == dtpFTime.Value) && (dtpSDate.Value == dtpFDate.Value)) { MessageBox.Show("The settings of Time/Period is invalid.\nPlease check again input information.", "Time Overlap", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
                else if (dtpSDate.Value < DateTime.Today) { MessageBox.Show("You can only create a schedule starting from Today's Date onwards.\nPlease check again input information.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
                else
                {
                    if (tsmSAVE.Text == "Update")
                    {
                        if (cmbEvent.Text != eventN)
                        {
                            ad = new MySqlDataAdapter("SELECT * FROM tbl_esched WHERE esdate = '" + dtpSDate.Value.ToString("yyyy-MM-dd") + "' AND efdate = '" + dtpFDate.Value.ToString("yyyy-MM-dd") + "' AND etime = '" + dtpSTime.Value.ToString("hh:mm tt") + " - " + dtpFTime.Value.ToString("hh:mm tt") + "' AND event_idfke = '" + eventID + "' AND user_idfke = '" + uID + "'", db.OpenConnection());
                            ss = new DataTable();
                            ad.Fill(ss);
                            int i = ss.Rows.Count;
                            if (i > 0) { MessageBox.Show("There is already a schedule set for this event( " + cmbEvent.Text + " ).\nPlease check again input information.", "Information Already Exist", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); ss.Clear(); }
                            else { chkTimeLaps(); }
                        }
                        else if (cmbEvent.Text == eventN)
                        {
                            if (dtpSTime.Text + dtpFTime.Text == dSTime + dFTime && dtpSDate.Text == SDate && dtpFDate.Text == Fdate) { updateSCHED(); }
                            else
                            {
                                ad = new MySqlDataAdapter("SELECT * FROM tbl_esched WHERE esdate = '" + dtpSDate.Value.ToString("yyyy-MM-dd") + "' AND efdate = '" + dtpFDate.Value.ToString("yyyy-MM-dd") + "' AND etime = '" + dtpSTime.Value.ToString("hh:mm tt") + " - " + dtpFTime.Value.ToString("hh:mm tt") + "' AND user_idfke = '" + uID + "'", db.OpenConnection());
                                ss = new DataTable();
                                ad.Fill(ss);
                                int ii = ss.Rows.Count;
                                if (ii > 0) { MessageBox.Show("This Schedule already exist in another event.\nPlease check input information.", "Conflict Schedule", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); ss.Clear(); }
                                else { chkTimeLaps(); }
                            }
                        }
                    }
                    else if (tsmSAVE.Text == "Save")
                    {
                        ad = new MySqlDataAdapter("SELECT * FROM tbl_esched WHERE esdate = '" + dtpSDate.Value.ToString("yyyy-MM-dd") + "' AND efdate = '" + dtpFDate.Value.ToString("yyyy-MM-dd") + "' AND etime = '" + dtpSTime.Value.ToString("hh:mm tt") + " - " + dtpFTime.Value.ToString("hh:mm tt") + "' AND event_idfke = '" + eventID + "' AND user_idfke = '" + uID + "'", db.OpenConnection());
                        ss = new DataTable();
                        ad.Fill(ss);
                        int i = ss.Rows.Count;
                        if (i > 0) { MessageBox.Show("There is already a schedule set for this event( " + cmbEvent.Text + " ).\nPlease check again input information.", "Information Already Exist", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); ss.Clear(); }
                        else if (i == 0)
                        {
                            ad = new MySqlDataAdapter("SELECT * FROM tbl_esched WHERE esdate = '" + dtpSDate.Value.ToString("yyyy-MM-dd") + "' AND efdate = '" + dtpFDate.Value.ToString("yyyy-MM-dd") + "' AND etime = '" + dtpSTime.Value.ToString("hh:mm tt") + " - " + dtpFTime.Value.ToString("hh:mm tt") + "' AND user_idfke = '" + uID + "'", db.OpenConnection());
                            ss = new DataTable();
                            ad.Fill(ss);
                            int ii = ss.Rows.Count;
                            if (ii > 0) { MessageBox.Show("This Schedule already exist in another event.\nPlease check input information.", "Conflict Schedule", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); ss.Clear(); }
                            else { chkTimeLaps(); }
                        }
                    }
                }
            }
            else { MessageBox.Show("Please fill-up all the required information before saving.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
        }

        private void tsmSTAFFEXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbEvent_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtPlace_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar)) { e.Handled = true; }
        }

      
    }
}
