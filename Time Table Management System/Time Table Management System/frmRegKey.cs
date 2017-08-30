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
using Microsoft.Win32;

namespace Time_Table_Management_System
{
    public partial class frmRegKey : Form
    {
        Db_Utilities db = new Db_Utilities();
        ConnectionSetUp ConnSetup = new ConnectionSetUp();
        MySqlConnection con;
        public frmRegKey()
        {
            InitializeComponent();
        }

        private void btnCON_Click(object sender, EventArgs e)
        {
            if (txtServer.Text == "" || txtPort.Text == "" || txtDatabase.Text == "" || txtUid.Text == "" || txtPassword.Text == "")
            {
                lblRECON.Text = "Please fill all the blanks";
                lblRECON.Visible = true;
            }
            else
            {
                try
                {
                    lblRECON.Visible = false;
                    db.server = txtServer.Text;
                    db.port = txtPort.Text;
                    db.database = txtDatabase.Text;
                    db.username = txtUid.Text;
                    db.password = txtPassword.Text;

                    string connString = "SERVER=" + db.server + ";" +
                                      "PORT=" + db.port + ";" +
                                      "DATABASE=" + db.database + ";" +
                                      "UID=" + db.username + ";" +
                                      "PASSWORD=" + db.password + ";";
                    con = new MySqlConnection();
                    con.ConnectionString = connString;
                    
                    try
                    {
                        con.Open();
                        db.SaveSettings();
                        MessageBox.Show("Successfully Connected!");
                        this.Hide();
                        frmUSER user = new frmUSER();
                        user.ShowDialog();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Connection not Valid!.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection not Valid!.");
                }
            }
        }
        private void tsmEXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmRegKey_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void chkPWORD_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPWORD.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
                chkPWORD.Text = "Hide";
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                chkPWORD.Text = "Show";
            }
        }

        private void txtServer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
