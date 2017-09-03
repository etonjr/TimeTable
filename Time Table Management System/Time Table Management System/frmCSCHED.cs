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
    public partial class frmCSCHED : Form
    {
        Db_Utilities db = new Db_Utilities();
        MySqlCommand cmd;
        MySqlDataAdapter ad;
        DataTable ss;

        private string wkDays, uID, subjID, subjN, cschedID, dDay, dSTime, dFTime, cmb;
        public frmCSCHED()
        {
            InitializeComponent();
        }
        private void loadDATA()
        {
            string query = "SELECT * FROM tbl_csched WHERE user_idfksc = '" + uID + "' AND sched_id = '" + cschedID + "'";
            cmd = new MySqlCommand(query, db.OpenConnection());
            MySqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                cmbDay.Text = r["day"].ToString();
                dtpSTime.Text = r["time"].ToString().Split('-').First().Trim();
                dtpFTime.Text = r["time"].ToString().Split('-').Last().Trim();
                txtGRADE.Text = r["grade"].ToString();
                txtSEC.Text = r["section"].ToString();
                txtROOM.Text = r["room"].ToString();
                dSTime = r["time"].ToString().Split('-').First().Trim();
                dFTime = r["time"].ToString().Split('-').Last().Trim();
                dDay = r["day"].ToString();
                wkDays = r["wkdays"].ToString();
            }
            r.Close();
            db.CloseConnection();
            cmbSubj.Text = frmMAIN.csubjN;
            subjID = frmMAIN.csubjID;
            subjN = frmMAIN.csubjN;
            tsmSAVE.Text = "Update";            
        }
        private void PopulateSUBJ()
        {
            cmbSubj.Text = "";
            cmbSubj.Items.Clear();
            subjID = "0";
            string query = "SELECT subjname FROM tbl_subj WHERE uid_idfku = '" + uID + "' ORDER BY subjname";
            cmd = new MySqlCommand(query, db.OpenConnection());
            MySqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                cmbSubj.Items.Add(r["subjname"].ToString());
            }
            r.Close();
            db.CloseConnection();
        } 
        private void populateDay()
        {
            cmbDay.Text = "";
            wkDays = "";
            cmbDay.Items.Clear();
            cmbDay.Items.Add("Sunday"); cmbDay.Items.Add("Monday"); cmbDay.Items.Add("Tuesday"); cmbDay.Items.Add("Wednesday");
            cmbDay.Items.Add("Thursday"); cmbDay.Items.Add("Friday"); cmbDay.Items.Add("Saturday");
        }
        private void frmSCHED_Load(object sender, EventArgs e)
        {
            uID = frmUSER.uID; subjID = frmMAIN.subjID; subjN = frmMAIN.subjN; cschedID = frmMAIN.cschedID;            
            if (cschedID != "") { loadDATA(); }
            else
            {
                tsmSAVE.Text = "Save"; cmbSubj.Text = subjN;
                dtpSTime.Value = DateTime.Now;
                dtpFTime.Value = DateTime.Now;
                dtpSTime.Text = DateTime.Now.ToString("hh:mm tt");
                dtpFTime.Text = DateTime.Now.ToString("hh:mm tt");
            }
        }
        private void cmbDay_DropDown(object sender, EventArgs e)
        {
            populateDay();
        }
        private void cmbDay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDay.SelectedIndex.Equals(0)) { wkDays = "g"; }
            else if (cmbDay.SelectedIndex.Equals(1)) { wkDays = "f"; }
            else if (cmbDay.SelectedIndex.Equals(2)) { wkDays = "e"; }
            else if (cmbDay.SelectedIndex.Equals(3)) { wkDays = "d"; }
            else if (cmbDay.SelectedIndex.Equals(4)) { wkDays = "c"; }
            else if (cmbDay.SelectedIndex.Equals(5)) { wkDays = "b"; }
            else if (cmbDay.SelectedIndex.Equals(6)) { wkDays = "a"; }
            else { wkDays = ""; }
        }

        private void cmbSubj_DropDown(object sender, EventArgs e)
        {
            if (cmbSubj.Items.Count >= 0) { PopulateSUBJ(); }
            else { MessageBox.Show("Subject List is Empty.", "No Records Found", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }
        private void cmbSubj_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "SELECT * FROM tbl_subj WHERE subjname = '" + cmbSubj.Text + "'";
            cmd = new MySqlCommand(query, db.OpenConnection());
            MySqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                subjID = r["subj_id"].ToString();
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
                ad = new MySqlDataAdapter("SELECT stime, ftime, day, sched_id FROM tbl_csched WHERE day = '" + cmbDay.Text + "' AND user_idfksc = '" + uID + "' ORDER BY ftime", db.OpenConnection());
                ss = new DataTable();
                ad.Fill(ss);
                dgvSample.DataSource = ss;
                foreach (DataGridViewRow rows in dgvSample.Rows)
                {
                    if (rows.Cells[0].Value == null) { break; }
                    DateTime dtstart = DateTime.Parse(rows.Cells[0].Value.ToString());
                    DateTime dtend = DateTime.Parse(rows.Cells[1].Value.ToString());

                    if (cschedID == "")
                    {
                        if ((dtpSTime.Value.TimeOfDay < dtstart.TimeOfDay) && (dtpFTime.Value.TimeOfDay <= dtstart.TimeOfDay) && cmbDay.Text == rows.Cells[2].Value.ToString()) { i += 0; }
                        else if ((dtpSTime.Value.TimeOfDay >= dtend.TimeOfDay) && (dtpFTime.Value.TimeOfDay > dtend.TimeOfDay) && cmbDay.Text == rows.Cells[2].Value.ToString()) { i += 0; }
                        else { i += 1; }
                    }
                    else if (cschedID != "")
                    {
                        if ((dtpSTime.Value.TimeOfDay < dtstart.TimeOfDay) && (dtpFTime.Value.TimeOfDay <= dtstart.TimeOfDay) && cmbDay.Text == rows.Cells[2].Value.ToString() && cschedID != rows.Cells[3].Value.ToString()) { i += 0; }
                        else if ((dtpSTime.Value.TimeOfDay >= dtend.TimeOfDay) && (dtpFTime.Value.TimeOfDay > dtend.TimeOfDay) && cmbDay.Text == rows.Cells[2].Value.ToString() && cschedID != rows.Cells[3].Value.ToString()) { i += 0; }
                        else
                        {
                            if (cschedID == rows.Cells[3].Value.ToString()) { i += 0; }
                            else { i += 1; }
                        }
                    }
                    sum += i;
                }
            }
            finally
            {
                string query = "SELECT esdate FROM tbl_esched WHERE (estime = '" + dtpSTime.Value.ToString("HH:mm") + "' OR eftime = '" + dtpFTime.Value.ToString("HH:mm") + "') AND user_idfke ='" + uID + "'";
                cmd = new MySqlCommand(query, db.OpenConnection());
                MySqlDataReader r = cmd.ExecuteReader();
                while (r.Read()) { cmb = Convert.ToDateTime(r["esdate"].ToString()).ToString("dddd"); }
                r.Close();
                db.CloseConnection();
                if (cmb == cmbDay.Text)
                {
                    MessageBox.Show("This schedule conflicts other schedule that is set in the event list.\n Please check again input information.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cmb = "";
                }
                else if (sum == 0)
                {
                    if (tsmSAVE.Text == "Save") { saveSCHED(); }
                    else if (tsmSAVE.Text == "Update") { updateSCHED(); }
                }
                else if (sum > 0)
                {
                    MessageBox.Show("The starting time you set conflicts the time set in another\nschedule for Today. Please check again input information.", "Time Overlap", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void saveSCHED()
        {
            string query = " INSERT INTO tbl_csched (wkdays,day,time,stime,ftime,grade,section,room,user_idfksc,subj_idfksc)" +
                                        "VALUES ('" + wkDays + "','" + cmbDay.Text + "','" + dtpSTime.Value.ToString("hh:mm tt") + " - " + dtpFTime.Value.ToString("hh:mm tt") + "','" + dtpSTime.Value.ToString("HH:mm") + "','" + dtpFTime.Value.ToString("HH:mm") + "','" + this.txtGRADE.Text + "','" + this.txtSEC.Text + "','" + this.txtROOM.Text + "','" + uID + "','" + subjID + "');";
            cmd = new MySqlCommand(query, db.OpenConnection());
            MySqlDataReader r = cmd.ExecuteReader();
            r.Close(); db.CloseConnection(); MessageBox.Show("Schedule Saved"); this.Close();
        }
        private void updateSCHED()
        {
            string query = "UPDATE tbl_csched SET wkdays = '" + wkDays + "',day = '" + cmbDay.Text + "', time = '" + dtpSTime.Value.ToString("hh:mm tt") + " - " + dtpFTime.Value.ToString("hh:mm tt") + "', stime = '" + dtpSTime.Value.ToString("HH:mm") + "', ftime = '" + dtpFTime.Value.ToString("HH:mm") + "', grade = '" + txtGRADE.Text + "', section = '" + txtSEC.Text + "', room = '" + txtROOM.Text + "', subj_idfksc = '" + subjID + "' WHERE sched_id = '" + cschedID + "'";
            cmd = new MySqlCommand(query, db.OpenConnection());
            MySqlDataReader re = cmd.ExecuteReader();
            re.Close(); db.CloseConnection(); MessageBox.Show("Schedule Updated"); this.Close();
        }       
        private void tsmSAVE_Click(object sender, EventArgs e)
        {
            if (subjID != "0" && txtGRADE.Text != "" && txtROOM.Text != "" && txtSEC.Text != "" && cmbDay.Text != "")
            {   
                if (dtpSTime.Value > dtpFTime.Value) { MessageBox.Show("The settings of Time/Period is invalid.\n Please check again input information.", "Time Overlap", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
                else if (dtpSTime.Value == dtpFTime.Value) { MessageBox.Show("The settings of Time/Period is invalid.\n Please check again input information.", "Time Overlap", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
                else
                {
                    if (tsmSAVE.Text == "Update")
                    {
                        if (cmbSubj.Text != subjN)
                        {
                            ad = new MySqlDataAdapter("SELECT * FROM tbl_csched WHERE day = '" + cmbDay.Text + "' AND time = '" + dtpSTime.Value.ToString("hh:mm tt") + " - " + dtpFTime.Value.ToString("hh:mm tt") + "' AND subj_idfksc = '" + subjID + "' AND user_idfksc = '" + uID + "'", db.OpenConnection());
                            ss = new DataTable();
                            ad.Fill(ss);
                            int i = ss.Rows.Count;
                            if (i > 0)
                            {
                                MessageBox.Show("There is already a schedule set for this subject( " + cmbSubj.Text + " ).\n Please check again input information.", "Information Already Exist", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                ss.Clear();
                            }
                            else { chkTimeLaps(); }
                        }
                        else if (cmbSubj.Text == subjN)
                        {
                            if (dtpSTime.Text + dtpFTime.Text == dSTime + dFTime && cmbDay.Text == dDay) { updateSCHED(); }
                            else
                            {
                                ad = new MySqlDataAdapter("SELECT * FROM tbl_csched WHERE day = '" + cmbDay.Text + "' AND time = '" + dtpSTime.Value.ToString("hh:mm tt") + " - " + dtpFTime.Value.ToString("hh:mm tt") + "' AND user_idfksc = '" + uID + "'", db.OpenConnection());
                                ss = new DataTable();
                                ad.Fill(ss);
                                int i = ss.Rows.Count;
                                if (i > 0)
                                {
                                    MessageBox.Show("The Schedule( " + cmbDay.Text + " ) - ( " + dtpSTime.Text + " ) already exist \n in another subject. Please check input information.", "Conflict Schedule", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    ss.Clear();
                                }
                                else { chkTimeLaps(); }
                            }
                        }
                    }
                    else if (tsmSAVE.Text == "Save")
                    {
                        ad = new MySqlDataAdapter("SELECT * FROM tbl_csched WHERE day = '" + cmbDay.Text + "' AND time = '" + dtpSTime.Value.ToString("hh:mm tt") + " - " + dtpFTime.Value.ToString("hh:mm tt") + "' AND subj_idfksc = '" + subjID + "' AND user_idfksc = '" + uID + "'", db.OpenConnection());
                        ss = new DataTable();
                        ad.Fill(ss);
                        int i = ss.Rows.Count;
                        if (i > 0)
                        {
                            MessageBox.Show("There is already a schedule set for this subject( " + cmbSubj.Text + " ).\n Please check again input information.", "Information Already Exist", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            ss.Clear();
                        }
                        else if (i == 0)
                        {
                            ad = new MySqlDataAdapter("SELECT * FROM tbl_csched WHERE day = '" + cmbDay.Text + "' AND time = '" + dtpSTime.Value.ToString("hh:mm tt") + " - " + dtpFTime.Value.ToString("hh:mm tt") + "' AND user_idfksc = '" + uID + "'", db.OpenConnection());
                            ss = new DataTable();
                            ad.Fill(ss);
                            int ii = ss.Rows.Count;
                            if (ii > 0)
                            {
                                MessageBox.Show("The Schedule( " + cmbDay.Text + " ) - ( " + dtpSTime.Text + " ) already exist \n in another subject. Please check input information.", "Conflict Schedule", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                ss.Clear();
                            }
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

        private void cmbDay_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtGRADE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) { e.Handled = true; }
        }

        private void txtSEC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) { e.Handled = true; }
        }

     

      
    }
}
