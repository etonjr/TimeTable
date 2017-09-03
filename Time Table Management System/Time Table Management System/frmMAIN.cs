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
using System.IO;

namespace Time_Table_Management_System
{
    public partial class frmMAIN : Form
    {
        Db_Utilities db = new Db_Utilities();
        MySqlCommand cmd;
        MySqlDataAdapter ad;
        DataTable ss;

        public static string cschedID, subjID, subjN, csubjN, csubjID, eschedID, eventID, eventN, ceventN, ceventID, cplace, addS, addE;       
        
        public frmMAIN()
        {
            InitializeComponent();
            timer2.Start();
        }
        private void dgvColTitle()
        {
            dgvTITLE.Columns[0].Visible = false;
            dgvTITLE.Columns[1].Visible = true;
            dgvTITLE.Columns[2].Visible = false;
        }
        private void dgvColSizeSched()
        {
            dgvSCHED.Columns[1].Width = 150;
            dgvSCHED.Columns[2].Width = 75;
            dgvSCHED.Columns[3].Width = 150;
            dgvSCHED.Columns[4].Width = 75;
            dgvSCHED.Columns[5].Width = 150;
            dgvSCHED.Columns[6].Width = 50;
            dgvSCHED.Columns[7].Width = 70;
            dgvSCHED.Columns[8].Width = 65;
        }
        private void dgvColSched()
        {
            dgvSCHED.Columns[0].Visible = false;
            dgvSCHED.Columns[1].Visible = false;
            dgvSCHED.Columns[2].Visible = false;
            dgvSCHED.Columns[3].HeaderText = "Time / Period";
            dgvSCHED.Columns[4].Visible = false;
            dgvSCHED.Columns[5].Visible = true;
            dgvSCHED.Columns[5].HeaderText = "Title";
            dgvSCHED.Columns[6].HeaderText = "Grade";
            dgvSCHED.Columns[7].HeaderText = "Section";
            dgvSCHED.Columns[8].HeaderText = "Room";
            dgvSCHED.Columns[9].Visible = false;
            dgvSCHED.Columns[10].Visible = false;
        }
        private void dgvColSizeESched()
        {
            dgvSCHED.Columns[1].Width = 100;
            dgvSCHED.Columns[2].Width = 100;
            dgvSCHED.Columns[3].Width = 100;
            dgvSCHED.Columns[6].Width = 75;
            dgvSCHED.Columns[7].Width = 120;
        }

        private void dgvColESched()
        {
            dgvSCHED.Columns[0].Visible = false;
            dgvSCHED.Columns[1].HeaderText = "Date Start";
            dgvSCHED.Columns[1].DefaultCellStyle.Format = "MMM dd, yyyy - dddd";
            dgvSCHED.Columns[2].HeaderText = "Date Finish";
            dgvSCHED.Columns[2].DefaultCellStyle.Format = "MMM dd, yyyy - dddd";
            dgvSCHED.Columns[3].HeaderText = "Time / Period";
            dgvSCHED.Columns[4].Visible = false;
            dgvSCHED.Columns[5].Visible = false;
            dgvSCHED.Columns[6].HeaderText = "Event";
            dgvSCHED.Columns[7].HeaderText = "Place";
            dgvSCHED.Columns[8].Visible = false;
            dgvSCHED.Columns[9].Visible = false;
        }
        private void loadUser()
        {
            string query = "SELECT user_name,cno,address,position,image FROM tbl_user WHERE user_id ='" + frmUSER.uID + "'";
            cmd = new MySqlCommand(query, db.OpenConnection());
            MySqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                lblUNAME.Text = r["user_name"].ToString();
                lblUCNO.Text = r["cno"].ToString();
                lblUPOS.Text = r["position"].ToString();
                lblUADD.Text = r["address"].ToString();
                byte[] img = (byte[])(r["image"]);
                MemoryStream ms = new MemoryStream(img);
                pbxUPIC.Image = Image.FromStream(ms);
            }
            r.Close();
            db.CloseConnection();
        }
        private void dgViewEvent()
        {
            ad = new MySqlDataAdapter("SELECT event_id,eventname,uid_fkev FROM tbl_event WHERE uid_fkev = '" + frmUSER.uID + "' ORDER BY eventname", db.OpenConnection());
            ss = new DataTable();
            ad.Fill(ss);
            eventID = "0";
            dgvTITLE.DataSource = ss;
            dgvColTitle();
        }
        private void dgViewSubject()
        {
            ad = new MySqlDataAdapter("SELECT subj_id,subjname,uid_idfku FROM tbl_subj WHERE uid_idfku = '" + frmUSER.uID + "' ORDER BY subjname", db.OpenConnection());
            ss = new DataTable();
            ad.Fill(ss);
            subjID = "0";
            dgvTITLE.DataSource = ss;
            dgvColTitle();
        }
        private void dgViewSched()
        {
            if (subjID != "")
            {
                ad = new MySqlDataAdapter("SELECT sc.sched_id,sc.wkdays,sc.day,sc.time,sc.stime,su.subjname,sc.grade,sc.section,sc.room,sc.subj_idfksc,sc.user_idfksc FROM tbl_csched sc INNER JOIN tbl_subj su " +
                    " ON sc.subj_idfksc = su.subj_id WHERE user_idfksc = '" + frmUSER.uID + "' AND day = '" + lblDATE.Text + "' ORDER BY stime", db.OpenConnection());
                ss = new DataTable();
                ad.Fill(ss);
                dgvSCHED.DataSource = ss;
                dgvColSched();
                dgvColSizeSched();
            }
            else if (eventID != "")
            {
                ad = new MySqlDataAdapter("SELECT e.esched_id,e.esdate,e.efdate,e.etime,e.estime,e.eftime,ev.eventname,e.eplace,e.user_idfke,e.event_idfke FROM tbl_esched e INNER JOIN tbl_event ev " +
                                        " ON e.event_idfke = ev.event_id WHERE user_idfke = '" + frmUSER.uID + "' AND esdate = '" + dtpDate.Value.ToString("yyyy-MM-dd") + "' ORDER BY esdate, estime DESC", db.OpenConnection());
                ss = new DataTable();
                ad.Fill(ss);
                dgvSCHED.DataSource = ss;
                dgvColESched();
                dgvColSizeESched();
            }
        }
        private void dgViewSubjSched()
        {
            ad = new MySqlDataAdapter("SELECT sc.sched_id,sc.wkdays,sc.day,sc.time,sc.stime,su.subjname,sc.grade,sc.section,sc.room,sc.subj_idfksc,sc.user_idfksc FROM tbl_csched sc INNER JOIN tbl_subj su " +
                                        " ON sc.subj_idfksc = su.subj_id WHERE user_idfksc = '" + frmUSER.uID + "' AND subjname = '" + subjN + "' ORDER BY wkdays DESC, stime", db.OpenConnection());
            ss = new DataTable();
            ad.Fill(ss);
            dgvSCHED.DataSource = ss;
            dgvColSched();
            dgvSCHED.Columns[2].Visible = true;
            dgvSCHED.Columns[2].HeaderText = "Day Scheduled";
            dgvSCHED.Columns[5].Visible = false;
            dgvColSizeSched();
            dgvSCHED.ClearSelection();
            dgvDefColor();
        }
        private void dgViewEventSched()
        {
            ad = new MySqlDataAdapter("SELECT e.esched_id,e.esdate,e.efdate,e.etime,e.estime,e.eftime,ev.eventname,e.eplace,e.user_idfke,e.event_idfke FROM tbl_esched e INNER JOIN tbl_event ev " +
                                        " ON e.event_idfke = ev.event_id WHERE user_idfke = '" + frmUSER.uID + "' AND eventname = '" + eventN + "' ORDER BY esdate, estime DESC", db.OpenConnection());
            ss = new DataTable();
            ad.Fill(ss);
            dgvSCHED.DataSource = ss;
            dgvColESched();
            dgvColSizeESched();
            dgvSCHED.ClearSelection();
            dgvDefColor();
        }
        private void dgvClear()
        {
            dgvTITLE.ClearSelection(); dgvSCHED.ClearSelection();
        }
        private void dgvDefTitle()
        {
            btnTITLE.Enabled = false; subjID = ""; subjN = ""; cschedID = "";
            eschedID = ""; eventID = ""; eventN = "";
        }
        private void dgvDefSched()
        {
            cschedID = ""; csubjID = ""; csubjN = ""; 
            eschedID = ""; ceventID = ""; ceventN = "";
            tsmDelSched.Enabled = false; btnSCHED.Enabled = false;
        }
        private void dgvDefColor()
        {
            if (subjID != "")
            {
                foreach (DataGridViewRow rows in dgvSCHED.Rows)
                {
                    foreach (DataGridViewCell cell in rows.Cells)
                    {
                        if (rows.Cells[2].Value.ToString() == DateTime.Today.ToString("dddd")) { rows.DefaultCellStyle.BackColor = Color.Green; rows.DefaultCellStyle.ForeColor = Color.White; }
                        else if (rows.Cells[2].Value.ToString() == "Sunday") { rows.DefaultCellStyle.BackColor = Color.Maroon; rows.DefaultCellStyle.ForeColor = Color.White; }
                        else { rows.DefaultCellStyle.BackColor = Color.DarkSlateGray; rows.DefaultCellStyle.ForeColor = Color.White; }
                    }
                }
            }
            else if (eventID != "")
            {
                foreach (DataGridViewRow rows in dgvSCHED.Rows)
                {
                    foreach (DataGridViewCell cell in rows.Cells)
                    {
                        if (Convert.ToDateTime(rows.Cells[1].Value.ToString()).ToString("MMM dd, yyyy - dddd") == DateTime.Today.ToString("MMM dd, yyyy - dddd") || Convert.ToDateTime(rows.Cells[2].Value.ToString()).ToString("MMM dd, yyyy - dddd") == DateTime.Today.ToString("MMM dd, yyyy - dddd")) { rows.DefaultCellStyle.BackColor = Color.Green; rows.DefaultCellStyle.ForeColor = Color.White; }
                        else if (Convert.ToDateTime(rows.Cells[1].Value.ToString()).ToString("dddd") == "Sunday" || Convert.ToDateTime(rows.Cells[2].Value.ToString()).ToString("dddd") == "Sunday") { rows.DefaultCellStyle.BackColor = Color.Maroon; rows.DefaultCellStyle.ForeColor = Color.White; }
                        else { rows.DefaultCellStyle.BackColor = Color.DarkSlateGray; rows.DefaultCellStyle.ForeColor = Color.White; }
                    }
                }
            }
        }
        private void frmMAIN_Load(object sender, EventArgs e)
        {
            dtpDate.Value = DateTime.Today;
            lblDATE.Text = DateTime.Today.ToString("dddd");
            lblDATE.ForeColor = Color.Chartreuse;
            btnSUBJ.BackColor = SystemColors.MenuHighlight;
            loadUser(); dgvDefTitle(); dgvDefSched(); dgViewSubject(); dgViewSched(); 
            dgvClear(); btnSUBJ.Enabled = false;
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            lblTIME.Text = dt.ToString("hh:mm:ss tt");
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            IsExistTime();
        }
        public void IsExistTime()
        {
            ad = new MySqlDataAdapter("SELECT sc.stime, sc.day, e.esdate, e.estime FROM tbl_csched sc INNER JOIN tbl_esched e ON sc.user_idfksc = e.user_idfke WHERE user_idfksc = '" + frmUSER.uID + "'", db.OpenConnection());
            ss = new DataTable();
            ad.Fill(ss);
            dgvSample.DataSource = ss;
            foreach (DataGridViewRow rows in dgvSample.Rows)
            {
                foreach (DataGridViewCell cell in rows.Cells)
                {
                    if (rows.Cells[0].Value == null) { break; }
                    DateTime subjTime = DateTime.Parse(rows.Cells[0].Value.ToString());
                    string subjDay = rows.Cells[1].Value.ToString();
                    DateTime evDate = DateTime.Parse(rows.Cells[2].Value.ToString());
                    DateTime evTime = DateTime.Parse(rows.Cells[3].Value.ToString());
                    if (subjDay == DateTime.Today.ToString("dddd") && subjTime.AddMinutes(-5).ToString("hh:mm tt") == DateTime.Now.ToString("hh:mm tt"))
                    {
                        string query = "SELECT su.subjname,sc.time,sc.grade,sc.section,sc.room FROM tbl_csched sc INNER JOIN tbl_subj su ON sc.subj_idfksc = su.subj_id WHERE stime = '" + DateTime.Now.AddMinutes(5).ToString("HH:mm") + "' AND day = '" + DateTime.Today.ToString("dddd") + "' AND user_idfksc ='" + frmUSER.uID + "'";
                        cmd = new MySqlCommand(query, db.OpenConnection());
                        MySqlDataReader r = cmd.ExecuteReader();
                        while (r.Read())
                        {
                            string a = r["subjname"].ToString();
                            string b = r["time"].ToString();
                            string c = r["grade"].ToString();
                            string d = r["section"].ToString();
                            string e = r["room"].ToString();

                            notifIcon.BalloonTipText = "Your Schedule for Today was set as:" + "\nSubject: " + a + "\nTime/Period: " + b + "\nGrade: " + c + "\nSection: " + d + "\nRoom: " + e;
                            notifIcon.ShowBalloonTip(50000);
                        }
                        r.Close();
                        db.CloseConnection();
                    }
                    else if (evDate.ToString("MMM dd, yyyy - dddd") == DateTime.Today.ToString("MMM dd, yyyy - dddd") && evTime.AddMinutes(-5).ToString("hh:mm tt") == DateTime.Now.ToString("hh:mm tt"))
                    {
                        string query = "SELECT ev.eventname,e.etime,e.eplace FROM tbl_esched e INNER JOIN tbl_event ev ON e.event_idfke = ev.event_id WHERE esdate = '" + DateTime.Today.ToString("yyyy-MM-dd") + "' AND estime = '" + DateTime.Now.AddMinutes(5).ToString("HH:mm") + "' AND user_idfke ='" + frmUSER.uID + "'";
                        cmd = new MySqlCommand(query, db.OpenConnection());
                        MySqlDataReader r = cmd.ExecuteReader();
                        while (r.Read())
                        {
                            string a = r["eventname"].ToString();
                            string d = r["etime"].ToString();
                            string e = r["eplace"].ToString();

                            notifIcon.BalloonTipText = "An Event will start at:" + "\nEvent: " + a + "\nTime/Period: " + d + "\nPlace: " + e;
                            notifIcon.ShowBalloonTip(50000);
                        }
                        r.Close();
                        db.CloseConnection();
                    }
                }
            }

        }
        private void frmMAIN_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                notifIcon.Icon = SystemIcons.Application;
                timer1.Start();
                timer1.Interval = 15000;
            }
            else if (this.WindowState == FormWindowState.Normal)
            {
                timer1.Stop();
            }
        }

        private void notifIcon_BalloonTipClicked(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void notifIcon_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }
        private void SetToolTipOnTask(string text)
        {
            ToolTip tiptool = new ToolTip();
            tiptool.SetToolTip(dgvSCHED, text);
        }
        private void btnMIN_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnEXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPROFILE_Click(object sender, EventArgs e)
        {
            frmADMIN.adminID = "0";
            frmPROFILE edit = new frmPROFILE();
            edit.ShowDialog(); loadUser();
        }
        private void tsmAddEvent_Click(object sender, EventArgs e)
        {
            dgvDefTitle(); addE = "Event"; addS = "";
            frmTITLE add = new frmTITLE();
            add.ShowDialog(); btnSUBJ.BackColor = Color.Transparent; btnEVENT.BackColor = SystemColors.MenuHighlight; btnEVENT.Enabled = false; btnSUBJ.Enabled = true;
            dtpDate.Value = DateTime.Today; lblDATE.Text = DateTime.Today.ToString("MMM dd, yyyy - dddd"); lblDATE.ForeColor = Color.Chartreuse; dgvDefTitle(); dgvDefSched(); dgViewEvent(); dgViewSched(); dgvClear();
        }
        private void tsmAddSubj_Click(object sender, EventArgs e)
        {
            dgvDefTitle(); addS = "Subject"; addE = "";
            frmTITLE add = new frmTITLE();
            add.ShowDialog(); btnEVENT.BackColor = Color.Transparent; btnSUBJ.BackColor = SystemColors.MenuHighlight; btnSUBJ.Enabled = false; btnEVENT.Enabled = true;
            lblDATE.Text = DateTime.Today.ToString("dddd"); lblDATE.ForeColor = Color.Chartreuse; dgvDefTitle(); dgvDefSched(); dgViewSubject(); dgViewSched(); dgvClear(); 
        }
        private void btnTITLE_Click(object sender, EventArgs e)
        {
            frmTITLE edit = new frmTITLE();
            edit.ShowDialog();
            if (subjID != ""){lblDATE.Text = DateTime.Today.ToString("dddd"); lblDATE.ForeColor = Color.Chartreuse; dgvDefTitle(); dgvDefSched(); dgViewSubject(); dgViewSched(); dgvClear();}
            else if (eventID != "") { dtpDate.Value = DateTime.Today; lblDATE.Text = DateTime.Today.ToString("MMM dd, yyyy - dddd"); lblDATE.ForeColor = Color.Chartreuse; dgvDefTitle(); dgvDefSched(); dgViewEvent(); dgViewSched(); dgvClear(); }
        }
        private void dgvTITLE_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnTITLE.Enabled = true; btnSCHED.Enabled = false; tsmDelSched.Enabled = false;
            if (subjID != "")
            {
                dgViewSubjSched(); lblDATE.Text = "Title : " + subjN;
                if (dgvSCHED.Rows.Count != 0) { lblDATE.ForeColor = Color.Chartreuse; }
                else { lblDATE.ForeColor = Color.White; }
            }
            else if (eventID != "")
            {
                dgViewEventSched(); dtpDate.Value = DateTime.Today; lblDATE.Text = "Title : " + eventN;
                if (dgvSCHED.Rows.Count != 0) { lblDATE.ForeColor = Color.Chartreuse; }
                else { lblDATE.ForeColor = Color.White; }
            }
        }
        private void dgvTITLE_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvTITLE.Rows[e.RowIndex];
            if (subjID != "")
            {
                subjID = row.Cells["subj_id"].Value.ToString();
                subjN = row.Cells["subjname"].Value.ToString();
                if (row.Selected == true)
                {
                    dgViewSubjSched(); lblDATE.Text = "Title : " + subjN;
                    if (dgvSCHED.Rows.Count != 0) { lblDATE.ForeColor = Color.Chartreuse; }
                    else { lblDATE.ForeColor = Color.White; }
                }
            }

            else if (eventID != "")
            {
                eventID = row.Cells["event_id"].Value.ToString();
                eventN = row.Cells["eventname"].Value.ToString();
                if (row.Selected == true)
                {
                    dgViewEventSched(); lblDATE.Text = "Title : " + eventN;
                    if (dgvSCHED.Rows.Count != 0) { lblDATE.ForeColor = Color.Chartreuse; }
                    else { lblDATE.ForeColor = Color.White; }
                }
            }
        }    
        private void tsmAddESched_Click(object sender, EventArgs e)
        {
            if (dgvTITLE.SelectedRows.Count != 0 && eventID != "")
            {
                dgvDefSched();
                frmESCHED add = new frmESCHED();
                add.ShowDialog();
                dgViewSched(); dgViewEventSched(); dgvSCHED.ClearSelection();
            }
            else { MessageBox.Show("Please add a title for this schedule first.", "", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }
        private void tsmAddCSched_Click(object sender, EventArgs e)
        {
            if (dgvTITLE.SelectedRows.Count != 0 && subjID != "")
            {
                dgvDefSched();
                frmCSCHED add = new frmCSCHED();
                add.ShowDialog();
                dgViewSched(); dgViewSubjSched(); dgvSCHED.ClearSelection();
            }
            else { MessageBox.Show("Please add or select a title for this schedule first.", "", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void btnSCHED_Click(object sender, EventArgs e)
        {
            if (subjID != "")
            {
                frmCSCHED edit = new frmCSCHED();
                edit.ShowDialog();
                if (dgvTITLE.SelectedRows.Count != 0)
                {
                    dgvDefSched(); dgViewSched(); dgViewSubjSched(); dgvSCHED.ClearSelection(); ;
                }
                else { dgvDefSched(); dgViewSched(); tsmDelSched.Enabled = false; btnSCHED.Enabled = false; dgvClear(); }
            }
            else if (eventID != "")
            {
                frmESCHED edit = new frmESCHED();
                edit.ShowDialog();
                if (dgvTITLE.SelectedRows.Count != 0)
                {
                    dgvDefSched(); dgViewSched(); dgViewEventSched(); dgvSCHED.ClearSelection(); ;
                }
                else { dgvDefSched(); dgViewSched(); tsmDelSched.Enabled = false; btnSCHED.Enabled = false; dgvClear(); }
            }
        }
        private void dgvSCHED_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSCHED.Rows.Count != 0) { tsmDelSched.Enabled = true; btnSCHED.Enabled = true; }
            else { dgvDefSched(); tsmDelSched.Enabled = false; btnSCHED.Enabled = false; dgvClear(); }
        }
        private void dgvSCHED_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvSCHED.Rows[e.RowIndex];
            if (subjID != "")
            {
                cschedID = row.Cells["sched_id"].Value.ToString();
                csubjN = row.Cells["subjname"].Value.ToString();
                csubjID = row.Cells["subj_idfksc"].Value.ToString();
            }
            else if (eventID != "")
            {
                eschedID = row.Cells["esched_id"].Value.ToString();
                ceventN = row.Cells["eventname"].Value.ToString();
                ceventID = row.Cells["event_idfke"].Value.ToString();
                cplace = row.Cells["eplace"].Value.ToString();
            }
        }
        private void dgvSCHED_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                e.Paint(e.ClipBounds, DataGridViewPaintParts.All);
                Rectangle divider = new Rectangle(e.CellBounds.X, e.CellBounds.Y + e.CellBounds.Height - 25, e.CellBounds.Width, 25);
                e.Graphics.FillRectangle(Brushes.DarkSeaGreen, divider); e.Handled = true;
            }
        }
        private void btnNEXT_Click(object sender, EventArgs e)
        {
            DateTime dt = new DateTime(); dt = Convert.ToDateTime(dtpDate.Value); dt = dt.AddDays(0); dtpDate.Value = dt.AddDays(1);
            if (subjID != "")
            {
                lblDATE.Text = dtpDate.Value.ToString("dddd"); dgvDefTitle(); dgvDefSched(); dgViewSubject(); dgViewSched(); dgvClear();
                if (lblDATE.Text == DayOfWeek.Sunday.ToString()) { lblDATE.ForeColor = Color.Red; }
                else if (lblDATE.Text == DateTime.Today.ToString("dddd")) { lblDATE.ForeColor = Color.Chartreuse; }
                else { lblDATE.ForeColor = Color.White; }
            }
            else if (eventID != "")
            {
                lblDATE.Text = dtpDate.Value.ToString("MMM dd, yyyy - dddd"); dgvDefTitle(); dgvDefSched(); dgViewEvent(); dgViewSched(); dgvClear();
                if (dtpDate.Value.ToString("dddd") == "Sunday") { lblDATE.ForeColor = Color.Red; }
                else if (lblDATE.Text == DateTime.Today.ToString("MMM dd, yyyy - dddd")) { lblDATE.ForeColor = Color.Chartreuse; }
                else { lblDATE.ForeColor = Color.White; }
            }
        }
        private void btnBACK_Click(object sender, EventArgs e)
        {
            DateTime dt = new DateTime(); dt = Convert.ToDateTime(dtpDate.Value); dt = dt.AddDays(0); dtpDate.Value = dt.AddDays(-1);
            if (subjID != "")
            {
                lblDATE.Text = dtpDate.Value.ToString("dddd"); dgvDefTitle(); dgvDefSched(); dgViewSubject(); dgViewSched(); dgvClear();
                if (lblDATE.Text == DayOfWeek.Sunday.ToString()) { lblDATE.ForeColor = Color.Red; }
                else if (lblDATE.Text == DateTime.Today.ToString("dddd")) { lblDATE.ForeColor = Color.Chartreuse; }
                else { lblDATE.ForeColor = Color.White; }
            }
            else if (eventID != "")
            {
                lblDATE.Text = dtpDate.Value.ToString("MMM dd, yyyy - dddd"); dgvDefTitle(); dgvDefSched(); dgViewEvent(); dgViewSched(); dgvClear();
                if (dtpDate.Value.ToString("dddd") == "Sunday") { lblDATE.ForeColor = Color.Red; }
                else if (lblDATE.Text == DateTime.Today.ToString("MMM dd, yyyy - dddd")) { lblDATE.ForeColor = Color.Chartreuse; }
                else { lblDATE.ForeColor = Color.White; }
            }
        }
        private void tsmDelSched_Click(object sender, EventArgs e)
        {
            if (subjID != "")
            {
                cmd = new MySqlCommand();
                cmd.Connection = db.OpenConnection();
                cmd.CommandText = "DELETE FROM tbl_csched WHERE sched_id = '" + cschedID + "' AND user_idfksc = '" + frmUSER.uID + "'";

                DialogResult dr = MessageBox.Show("Are you sure you want to delete the schedule for this subject?.", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    MySqlDataReader r = cmd.ExecuteReader();
                    r.Close();
                    MessageBox.Show("Schedule Deleted.", "", MessageBoxButtons.OK);
                    db.CloseConnection(); dgvDefSched(); dgViewSched(); dgViewSubjSched(); dgvSCHED.ClearSelection(); ;
                }
                else if (dr == DialogResult.No) { db.CloseConnection(); }
            }
            else if (eventID != "")
            {
                cmd = new MySqlCommand();
                cmd.Connection = db.OpenConnection();
                cmd.CommandText = "DELETE FROM tbl_esched WHERE esched_id = '" + eschedID + "' AND user_idfke = '" + frmUSER.uID + "'";

                DialogResult dr = MessageBox.Show("Are you sure you want to delete the schedule for this event?.", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    MySqlDataReader r = cmd.ExecuteReader();
                    r.Close();
                    MessageBox.Show("Event Deleted.", "", MessageBoxButtons.OK);
                    db.CloseConnection(); dgvDefSched(); dgViewSched(); dgViewEventSched(); dgvSCHED.ClearSelection(); ;
                }
                else if (dr == DialogResult.No) { db.CloseConnection(); }
            }
            else { MessageBox.Show("Schedule List is Empty.", "No Records Found", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }
        private void btnSUBJ_Click(object sender, EventArgs e)
        {
            btnSUBJ.BackColor = SystemColors.MenuHighlight; btnEVENT.BackColor = Color.Transparent; btnSUBJ.Enabled = false; btnEVENT.Enabled = true; dtpDate.Value = DateTime.Today; lblDATE.Text = DateTime.Today.ToString("dddd"); lblDATE.ForeColor = Color.Chartreuse;
            dgvDefTitle(); dgvDefSched(); dgViewSubject(); dgViewSched(); dgvClear();
        }

        private void btnEVENT_Click(object sender, EventArgs e)
        {
            btnSUBJ.BackColor = Color.Transparent; btnEVENT.BackColor = SystemColors.MenuHighlight; btnSUBJ.Enabled = true; btnEVENT.Enabled = false; dtpDate.Value = DateTime.Today; lblDATE.Text = DateTime.Today.ToString("MMM dd, yyyy - dddd"); lblDATE.ForeColor = Color.Chartreuse;
            dgvDefTitle(); dgvDefSched(); dgViewEvent(); dgViewSched(); dgvClear();
        }

     
    }
}