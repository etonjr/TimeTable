﻿using System;
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
    public partial class frmTITLE : Form
    {
        Db_Utilities db = new Db_Utilities();
        MySqlCommand cmd;
        MySqlDataAdapter ad;
        DataTable ss;

        private string uID, subjID, subjN, eventID, eventN, tsmAddS, tsmAddE;
        public frmTITLE()
        {
            InitializeComponent();
        }

        private void frmSUBJ_Load(object sender, EventArgs e)
        {
            uID = frmUSER.uID;
            eventID = frmMAIN.eventID; eventN = frmMAIN.eventN;
            subjN = frmMAIN.subjN; subjID = frmMAIN.subjID;
            tsmAddE = frmMAIN.addE; tsmAddS = frmMAIN.addS;
            if (subjID != "") { tsmTITLE.Text = "Subject"; tsmSUBJSAVE.Text = "Update"; tsmDEL.Enabled = true; txtSUBJN.Text = subjN; }
            else if (eventID != "") { tsmTITLE.Text = "Event"; tsmSUBJSAVE.Text = "Update"; tsmDEL.Enabled = true; txtSUBJN.Text = eventN; }
            else
            {
                if (tsmAddS != "") { tsmTITLE.Text = tsmAddS; }
                else if (tsmAddE != "") { tsmTITLE.Text = tsmAddE; }
                tsmSUBJSAVE.Text = "Save"; tsmDEL.Enabled = false;
            }
        }
        private void saveTitle()
        {
            if (tsmTITLE.Text == "Subject")
            {
                string query = " INSERT INTO tbl_subj (subjname,uid_idfku)" +
                                  "VALUES ('" + this.txtSUBJN.Text + "','" + uID + "');";
                cmd = new MySqlCommand(query, db.OpenConnection());
                MySqlDataReader r = cmd.ExecuteReader();
                r.Close(); db.CloseConnection(); MessageBox.Show("Subject Saved"); this.Close();
            }
            else if (tsmTITLE.Text == "Event")
            {
                string query = " INSERT INTO tbl_event (eventname,uid_fkev)" +
                                  "VALUES ('" + this.txtSUBJN.Text + "','" + uID + "');";
                cmd = new MySqlCommand(query, db.OpenConnection());
                MySqlDataReader r = cmd.ExecuteReader();
                r.Close(); db.CloseConnection(); MessageBox.Show("Event Saved"); this.Close();
            }
        }
        private void updateTitle()
        {
            if (tsmTITLE.Text == "Subject")
            {
                string query = "UPDATE tbl_subj SET subjname = '" + txtSUBJN.Text + "' WHERE subj_id = '" + subjID + "'";
                cmd = new MySqlCommand(query, db.OpenConnection());
                MySqlDataReader re = cmd.ExecuteReader();
                re.Close(); db.CloseConnection(); MessageBox.Show("Subject Updated"); this.Close();
            }
            else if (tsmTITLE.Text == "Event")
            {
                string query = "UPDATE tbl_event SET eventname = '" + txtSUBJN.Text + "' WHERE event_id = '" + eventID + "'";
                cmd = new MySqlCommand(query, db.OpenConnection());
                MySqlDataReader re = cmd.ExecuteReader();
                re.Close(); db.CloseConnection(); MessageBox.Show("Event Updated"); this.Close();
            }
        }

        private void tsmSUBJSAVE_Click(object sender, EventArgs e)
        {
            if (txtSUBJN.Text != "")
            {
                if (tsmSUBJSAVE.Text == "Update")
                {
                    if (subjN == txtSUBJN.Text || eventN == txtSUBJN.Text) { updateTitle(); }
                    else
                    {
                        if (tsmTITLE.Text == "Subject")
                        {
                            ad = new MySqlDataAdapter("SELECT * FROM tbl_subj WHERE subjname = '" + txtSUBJN.Text + "' AND uid_idfku = '" + uID + "'", db.OpenConnection());
                            ss = new DataTable();
                            ad.Fill(ss);
                            int i = ss.Rows.Count;
                            if (i > 0) { MessageBox.Show("The Subject( " + txtSUBJN.Text + " ) already exist.\n Please check input information.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); ss.Clear(); }
                            else { updateTitle(); }
                        }
                        else if (tsmTITLE.Text == "Event")
                        {
                            ad = new MySqlDataAdapter("SELECT * FROM tbl_event WHERE eventname = '" + txtSUBJN.Text + "' AND uid_fkev = '" + uID + "'", db.OpenConnection());
                            ss = new DataTable();
                            ad.Fill(ss);
                            int i = ss.Rows.Count;
                            if (i > 0) { MessageBox.Show("The Event( " + txtSUBJN.Text + " ) already exist.\n Please check input information.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); ss.Clear(); }
                            else { updateTitle(); }
                        }
                    }
                }
                else if (tsmSUBJSAVE.Text == "Save")
                {
                    if (tsmTITLE.Text == "Subject")
                    {
                        ad = new MySqlDataAdapter("SELECT * FROM tbl_subj WHERE subjname = '" + txtSUBJN.Text + "' AND uid_idfku = '" + uID + "'", db.OpenConnection());
                        ss = new DataTable();
                        ad.Fill(ss);
                        int i = ss.Rows.Count;
                        if (i > 0) { MessageBox.Show("The Subject( " + txtSUBJN.Text + " ) already exist.\n Please check input information.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); ss.Clear(); }
                        else { saveTitle(); }
                    }
                    else if (tsmTITLE.Text == "Event")
                    {
                        ad = new MySqlDataAdapter("SELECT * FROM tbl_event WHERE eventname = '" + txtSUBJN.Text + "' AND uid_fkev = '" + uID + "'", db.OpenConnection());
                        ss = new DataTable();
                        ad.Fill(ss);
                        int i = ss.Rows.Count;
                        if (i > 0) { MessageBox.Show("The Event( " + txtSUBJN.Text + " ) already exist.\n Please check input information.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); ss.Clear(); }
                        else { saveTitle(); }
                    }
                }
            }
            else { lblREQSUBJN.Visible = true; }
        }

        private void txtSUBJ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)) { e.Handled = true; }
        }

        private void tsmUACCTEXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmDEL_Click(object sender, EventArgs e)
        {

            if (tsmTITLE.Text == "Subject")
            {
                if (txtSUBJN.Text != "" && subjN != "")
                {
                    cmd = new MySqlCommand();
                    cmd.Connection = db.OpenConnection();
                    cmd.CommandText = "DELETE FROM tbl_subj WHERE subjname = '" + txtSUBJN.Text + "' AND uid_idfku = '" + uID + "'";

                    DialogResult dr = MessageBox.Show("Are you sure you want to delete this subject?.\n ALL INFORMATION about this SUBJECT will also be DELETED!!", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        MySqlDataReader r = cmd.ExecuteReader();
                        r.Close();
                        MessageBox.Show("Subject Deleted.", "", MessageBoxButtons.OK);
                        db.CloseConnection();
                        this.Close();
                    }
                    else if (dr == DialogResult.No)
                    {
                        db.CloseConnection();
                    }
                }
            }
            else if (tsmTITLE.Text == "Event")
            {
                if (txtSUBJN.Text != "" && eventN != "")
                {
                    cmd = new MySqlCommand();
                    cmd.Connection = db.OpenConnection();
                    cmd.CommandText = "DELETE FROM tbl_event WHERE eventname = '" + txtSUBJN.Text + "' AND uid_fkev = '" + uID + "'";

                    DialogResult dr = MessageBox.Show("Are you sure you want to delete this event?.\n ALL INFORMATION about this EVENT will also be DELETED!!", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        MySqlDataReader r = cmd.ExecuteReader();
                        r.Close();
                        MessageBox.Show("Event Deleted.", "", MessageBoxButtons.OK);
                        db.CloseConnection(); this.Close();
                    }
                    else if (dr == DialogResult.No) { db.CloseConnection(); }
                }
            }
            else { MessageBox.Show("Subject List is Empty.", "No Records Found", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }
    }
}
