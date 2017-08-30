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
    public partial class frmUSER : Form
    {
        Db_Utilities db = new Db_Utilities();
        MySqlCommand cmd;

        public static string uID;
        public frmUSER()
        {
            InitializeComponent();
        }

        private void frmUSER_Load(object sender, EventArgs e)
        {
            uID = "0";
            if (db.OpenConnection() == null)
            {
                frmRegKey rk = new frmRegKey();
                rk.ShowDialog();
                this.Hide();
            }
            else
            {
                this.Show();
            }
            
        }
        private void clearStats() { txtLOGPWORD.Clear(); txtLOGUNAME.Clear(); lblLOGINREQPWORD.Visible = false; lblLOGINREQUNAME.Visible = false; }
        private void frmUSER_FormClosed(object sender, FormClosedEventArgs e) { this.Show(); clearStats(); chkPWORD.Checked = false; chkPWORD.Text = "Show"; }
        private void loginUser()
        {
            if (txtLOGUNAME.Text != "")
            {
                if (txtLOGPWORD.Text != "")
                {
                    string query = "SELECT user_id,user_name,password FROM tbl_user WHERE user_name = '" + txtLOGUNAME.Text + "' AND password = '" + txtLOGPWORD.Text + "'";
                    cmd = new MySqlCommand(query, db.OpenConnection());
                    MySqlDataReader r = cmd.ExecuteReader();
                    while (r.Read())
                    { uID = r["user_id"].ToString(); }
                    r.Close();
                    db.CloseConnection();
                }
                else { lblLOGINREQPWORD.Visible = true; }
            }
            else { lblLOGINREQUNAME.Visible = true; }
        }
        private void btnLOGIN_Click(object sender, EventArgs e)
        {
            if (txtLOGUNAME.Text == "ADMIN" && txtLOGPWORD.Text == "ADMIN")
            {
                frmADMIN admin = new frmADMIN();
                admin.FormClosed += new FormClosedEventHandler(frmUSER_FormClosed);
                this.Hide();
                admin.ShowDialog();
            }
            else
            {
                loginUser();
                if (uID != "0")
                {
                    frmMAIN main = new frmMAIN();
                    main.FormClosed += new FormClosedEventHandler(frmUSER_FormClosed);
                    this.Hide();
                    main.ShowDialog();
                }
                else
                {
                    if (txtLOGUNAME.Text == "") { lblLOGINREQUNAME.Visible = true; }
                    else if (txtLOGPWORD.Text == "") { lblLOGINREQPWORD.Visible = true; }
                    else { lblLOGINREQUNAME.Visible = true; lblLOGINREQPWORD.Visible = true; MessageBox.Show("Incorrect User Name or Password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                }
            }

        }
        private void txtLOGUNAME_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void btnLOGINCANCEL_Click(object sender, EventArgs e)
        {
            clearStats();
        }

        private void tsmUSEREXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtLOGUNAME_TextChanged(object sender, EventArgs e)
        {
            if (txtLOGUNAME.Text == "")
            {
                uID = "0";
            }
        }

        private void txtLOGPWORD_TextChanged(object sender, EventArgs e)
        {
            if (txtLOGPWORD.Text != "")
            {
                uID = "0";
            }
        }

        private void chkPWORD_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPWORD.Checked)
            {
                txtLOGPWORD.UseSystemPasswordChar = false;
                chkPWORD.Text = "Hide";
            }
            else
            {
                txtLOGPWORD.UseSystemPasswordChar = true;
                chkPWORD.Text = "Show";
            }
        }
    }
}
