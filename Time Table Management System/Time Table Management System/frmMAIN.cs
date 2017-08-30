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

        public static string cschedID, subjID, subjN, csubjN, csubjID, eschedID, eventID, eventN, ceventN, ceventID;        
        
        public frmMAIN()
        {
            InitializeComponent();
            timer1.Start();
        }
        private void loadSubj()
        {
            string query = "SELECT subj_id FROM tbl_subj WHERE uid_idfku ='" + frmUSER.uID + "'";
            cmd = new MySqlCommand(query, db.OpenConnection());
            MySqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            { subjID = r["subj_id"].ToString(); }
            r.Close();db.CloseConnection();
        }
        private void loadEvent()
        {
            string query = "SELECT event_id FROM tbl_event WHERE uid_fkev ='" + frmUSER.uID + "'";
            cmd = new MySqlCommand(query, db.OpenConnection());
            MySqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            { eventID = r["event_id"].ToString(); }
            r.Close();db.CloseConnection();
        }
        private void dgvColTitle()
        {
            dgvTITLE.Columns[0].Visible = false;
            dgvTITLE.Columns[1].HeaderText = "Subject Name";
            dgvTITLE.Columns[2].Visible = false;
        }
        private void dgViewEvent()
        {
            ad = new MySqlDataAdapter("SELECT event_id,eventname,uid_fkev FROM tbl_event WHERE uid_fkev = '" + frmUSER.uID + "' ORDER BY eventname", db.OpenConnection());
            ss = new DataTable();
            ad.Fill(ss);
            dgvTITLE.DataSource = ss;
            dgvColTitle();
        }
        private void dgViewTitle()
        {
            ad = new MySqlDataAdapter("SELECT subj_id,subjname,uid_idfku FROM tbl_subj WHERE uid_idfku = '" + frmUSER.uID + "' ORDER BY subjname", db.OpenConnection());
            ss = new DataTable();
            ad.Fill(ss);
            dgvTITLE.DataSource = ss;
            dgvColTitle();
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
        private void dgViewSched()
        {
            ad = new MySqlDataAdapter("SELECT sc.sched_id,sc.wkdays,sc.day,sc.time,sc.stime,su.subjname,sc.grade,sc.section,sc.room,sc.subj_idfksc,sc.user_idfksc FROM tbl_csched sc INNER JOIN tbl_subj su " +
                " ON sc.subj_idfksc = su.subj_id WHERE user_idfksc = '" + frmUSER.uID + "' AND day = '" + lblDATE.Text + "' ORDER BY stime", db.OpenConnection());
            ss = new DataTable();
            ad.Fill(ss);
            dgvSCHED.DataSource = ss;
            dgvColSched();
            dgvColSizeSched();
        }
      
        private void loadCsched()
        {
            string query = "SELECT sched_id FROM tbl_csched WHERE user_idfksc ='" + frmUSER.uID + "'";
            cmd = new MySqlCommand(query, db.OpenConnection());
            MySqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            { cschedID = r["sched_id"].ToString(); }
            r.Close();
            db.CloseConnection();
        }
        private void loadEsched()
        {
            string query = "SELECT esched_id FROM tbl_esched WHERE user_idfke ='" + frmUSER.uID + "'";
            cmd = new MySqlCommand(query, db.OpenConnection());
            MySqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            { eschedID = r["esched_id"].ToString(); }
            r.Close();
            db.CloseConnection();
        }
        private void dgViewTitleSched()
        {
            loadCsched(); loadEsched();
            if(cschedID != ""){
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
            else if (eschedID != "") {
                ad = new MySqlDataAdapter("SELECT e.esched_id,e.esdate,e.efdate,e.etime,e.estime,ev.eventname,e.eplace,e.user_idfke,e.subj_idfke FROM tbl_esched e INNER JOIN tbl_event ev " +
                              " ON e.event_idfke = ev.event_id WHERE user_idfke = '" + frmUSER.uID + "' AND eventname = '" + eventN + "' ORDER BY sdate ASC, stime DESC", db.OpenConnection());
                ss = new DataTable();
                ad.Fill(ss);
                dgvSCHED.DataSource = ss;
                dgvColSched();
                dgvSCHED.Columns[1].Visible = true;
                dgvSCHED.Columns[1].HeaderText = "Date Start";
                dgvSCHED.Columns[2].Visible = true;
                dgvSCHED.Columns[2].HeaderText = "Date Finish";
                dgvSCHED.Columns[5].HeaderText = "Event";
                dgvSCHED.Columns[6].HeaderText = "Place";
                dgvSCHED.Columns[7].Visible = false;
                dgvSCHED.Columns[8].Visible = false;
                dgvColSizeSched();
                dgvSCHED.ClearSelection();
                dgvDefColor();
            }
        }
        private void dgvDefTitle()
        {
            dgvTITLE.ClearSelection(); btnTITLE.Enabled = false; subjID = ""; subjN = ""; cschedID = "";
            eschedID = ""; eventID = ""; eventN = "";
        }
        private void dgvDefSched()
        {
            dgvSCHED.ClearSelection(); cschedID = ""; csubjID = ""; csubjN = ""; 
            eschedID = ""; ceventID = ""; ceventN = "";
            tsmDelSched.Enabled = false; btnSCHED.Enabled = false;
        }
        private void dgvDefColor()
        {
            foreach (DataGridViewRow rows in dgvSCHED.Rows)
            {
                foreach (DataGridViewCell cell in rows.Cells)
                {
                    if (rows.Cells[2].Value.ToString() == DateTime.Today.ToString("dddd"))
                    {
                        rows.DefaultCellStyle.BackColor = Color.Green; rows.DefaultCellStyle.ForeColor = Color.White;
                    }
                    else if (rows.Cells[2].Value.ToString() == "Sunday")
                    {
                        rows.DefaultCellStyle.BackColor = Color.Maroon; rows.DefaultCellStyle.ForeColor = Color.White;
                    }
                    else { rows.DefaultCellStyle.BackColor = Color.DarkSlateGray; rows.DefaultCellStyle.ForeColor = Color.White; }
                }
            }
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
        private void frmMAIN_Load(object sender, EventArgs e)
        {
            dtpDate.Value = DateTime.Today;
            lblDATE.Text = DateTime.Today.ToString("ddddd");
            lblDATE.ForeColor = Color.Chartreuse;
            btnSUBJ.BackColor = SystemColors.MenuHighlight;
            loadUser(); dgViewTitle(); dgViewSched(); dgvDefTitle(); dgvDefSched();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            lblTIME.Text = dt.ToString("hh:mm:ss tt");
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
            edit.ShowDialog();
            loadUser();
        }
        private void tsmAddEvent_Click(object sender, EventArgs e)
        {
            dgvDefTitle();
            frmEVENT add = new frmEVENT();
            add.ShowDialog();
            lblDATE.Text = dtpDate.Value.ToString("dddd");
            lblDATE.ForeColor = Color.Chartreuse;
            dgViewTitle(); dgvTITLE.ClearSelection();
            dgViewSched(); dgvDefSched();
        }
        private void tsmAddSubj_Click(object sender, EventArgs e)
        {
            //dgvDefTitle();
            frmSUBJ add = new frmSUBJ();
            add.ShowDialog();
            lblDATE.Text = dtpDate.Value.ToString("dddd");
            lblDATE.ForeColor = Color.Chartreuse;
            dgViewTitle(); dgvTITLE.ClearSelection();
            dgViewSched(); dgvDefSched();
        }
        private void btnTITLE_Click(object sender, EventArgs e)
        {
            frmSUBJ edit = new frmSUBJ();
            edit.ShowDialog();
            lblDATE.Text = dtpDate.Value.ToString("dddd");
            lblDATE.ForeColor = Color.Chartreuse;
            dgViewTitle(); dgvDefTitle();
            dgViewSched(); dgvDefSched();
        }///lagyan ng event sa sched
        private void dgvTITLE_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnTITLE.Enabled = true;  btnSCHED.Enabled = false; tsmDelSched.Enabled = false;
            dgViewTitleSched();
            lblDATE.Text = "Title : " + subjN;
            if (dgvSCHED.Rows.Count != 0)
            {
                lblDATE.ForeColor = Color.Chartreuse;
            }
            else { lblDATE.ForeColor = Color.White; }
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
                    dgViewTitleSched();
                    lblDATE.Text = "Title : " + subjN;
                    if (dgvSCHED.Rows.Count != 0)
                    {
                        lblDATE.ForeColor = Color.Chartreuse;
                    }
                    else { lblDATE.ForeColor = Color.White; }
                }
            }
            else if (eventID != "")
            {
                eventID = row.Cells["event_id"].Value.ToString();
                eventN = row.Cells["eventname"].Value.ToString();
                if (row.Selected == true)
                {
                    dgViewTitleSched();
                    lblDATE.Text = "Title : " + subjN;
                    if (dgvSCHED.Rows.Count != 0)
                    {
                        lblDATE.ForeColor = Color.Chartreuse;
                    }
                    else { lblDATE.ForeColor = Color.White; }
                }
            }
        }
      
        private void tsmAddESched_Click(object sender, EventArgs e)
        {
            dgvDefSched();
            frmESCHED add = new frmESCHED();
            add.ShowDialog();
            if (dgvTITLE.SelectedRows.Count != 0) { dgViewTitleSched(); dgvDefSched(); }
            else
            {
                lblDATE.Text = DateTime.Today.ToString("dddd");
                lblDATE.ForeColor = Color.Chartreuse;
                dgViewSched(); dgvDefSched();
            }
        }
        private void tsmAddCSched_Click(object sender, EventArgs e)
        {
            dgvDefSched();
            frmCSCHED add = new frmCSCHED();
            add.ShowDialog();
            if (dgvTITLE.SelectedRows.Count != 0) { dgViewTitleSched(); dgvDefSched(); }
            else
            {
                lblDATE.Text = DateTime.Today.ToString("dddd");
                lblDATE.ForeColor = Color.Chartreuse;
                dgViewSched(); dgvDefSched();
            }
        }

        private void btnSCHED_Click(object sender, EventArgs e)
        {
            frmCSCHED edit = new frmCSCHED();
            edit.ShowDialog();
            if (dgvTITLE.SelectedRows.Count != 0) { dgViewTitleSched(); dgvDefSched(); }
            else { dgViewSched(); dgvDefSched(); }
            
        }
        private void dgvSCHED_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSCHED.Rows.Count != 0) { tsmDelSched.Enabled = true; btnSCHED.Enabled = true; }
            else { tsmDelSched.Enabled = false; btnSCHED.Enabled = false; }
        }
        private void dgvSCHED_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvSCHED.Rows[e.RowIndex];
            cschedID = row.Cells["sched_id"].Value.ToString();
            csubjN = row.Cells["subjname"].Value.ToString();
            csubjID = row.Cells["subj_idfksc"].Value.ToString();
        }
        private void dgvSCHED_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                e.Paint(e.ClipBounds, DataGridViewPaintParts.All);
                Rectangle divider = new Rectangle(e.CellBounds.X, e.CellBounds.Y + e.CellBounds.Height - 25, e.CellBounds.Width, 25);
                e.Graphics.FillRectangle(Brushes.DarkSeaGreen, divider);
                e.Handled = true;
            }
        }
        private void btnNEXT_Click(object sender, EventArgs e)
        {
            DateTime dt = new DateTime();
            dt = Convert.ToDateTime(dtpDate.Value);
            dt = dt.AddDays(0);
            dtpDate.Value = dt.AddDays(1);
            lblDATE.Text = dtpDate.Value.ToString("ddddd");
            dgViewSched(); dgvDefTitle(); dgvDefSched();
            if (lblDATE.Text == DayOfWeek.Sunday.ToString()) { lblDATE.ForeColor = Color.Red; }
            else if (lblDATE.Text == DateTime.Today.ToString("dddd")) { lblDATE.ForeColor = Color.Chartreuse; }
            else { lblDATE.ForeColor = Color.White; }
        }
        private void btnBACK_Click(object sender, EventArgs e)
        {            DateTime dt = new DateTime();
            dt = Convert.ToDateTime(dtpDate.Value);
            dt = dt.AddDays(0);
            dtpDate.Value = dt.AddDays(-1);
            lblDATE.Text = dtpDate.Value.ToString("ddddd");
            dgViewSched(); dgvDefTitle(); dgvDefSched();
            if (lblDATE.Text == DayOfWeek.Sunday.ToString()) { lblDATE.ForeColor = Color.Red; }
            else if (lblDATE.Text == DateTime.Today.ToString("dddd")) { lblDATE.ForeColor = Color.Chartreuse; }
            else { lblDATE.ForeColor = Color.White; }
        }
        private void tsmDelSched_Click(object sender, EventArgs e)
        {
            if (cschedID != "")
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
                    db.CloseConnection();
                    dgViewTitleSched();
                    dgvDefSched();
                }
                else if (dr == DialogResult.No)
                {
                    db.CloseConnection();
                }
            }
            else { MessageBox.Show("Schedule List is Empty.", "No Records Found", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void btnSUBJ_Click(object sender, EventArgs e)
        {
            loadSubj(); eventID = ""; dgViewTitle(); btnSUBJ.BackColor = SystemColors.MenuHighlight; btnEVENT.BackColor = Color.Transparent;
        }

        private void btnEVENT_Click(object sender, EventArgs e)
        {
            loadEvent(); subjID = ""; dgViewEvent(); btnSUBJ.BackColor = Color.Transparent; btnEVENT.BackColor = SystemColors.MenuHighlight;
        }

       

    }
}