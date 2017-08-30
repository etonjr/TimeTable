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
    public partial class frmADMIN : Form
    {
        Db_Utilities db = new Db_Utilities();
        MySqlCommand cmd;
        MySqlDataAdapter ad;
        DataTable ss;

        public static string adminID;
        public frmADMIN()
        {
            InitializeComponent();
        }

        private void frmADMIN_Load(object sender, EventArgs e)
        {
            dgView();
        }
        private void loadUser()
        {
            string query = "SELECT user_name,image FROM tbl_user WHERE user_id = '" + frmUSER.uID + "'";
            cmd = new MySqlCommand(query,db.OpenConnection());
            MySqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                lblUNAME.Text = r["user_name"].ToString();
                byte[] img = (byte[])(r["image"]);
                MemoryStream ms = new MemoryStream(img);
                pbxUPIC.Image = Image.FromStream(ms);
            }
            r.Close();
            db.CloseConnection();
        }
       private void dgView()
        {
            ad = new MySqlDataAdapter("SELECT user_id,user_name,password,fname,lname FROM tbl_user ORDER BY user_name", db.OpenConnection());
            ss = new DataTable();
            ad.Fill(ss);
            dgvADMIN.DataSource = ss;
            dgvColStats();
        }
       private void dgvColStats()
       {
           dgvADMIN.ColumnHeadersDefaultCellStyle.BackColor = Color.Silver;
           using (Font font = new Font(dgvADMIN.DefaultCellStyle.Font.FontFamily, 12, FontStyle.Bold))
           {
               dgvADMIN.ColumnHeadersDefaultCellStyle.Font = font;
           }
           dgvADMIN.Columns[0].Visible = false;
           dgvADMIN.Columns[1].HeaderText = "User Name";
           dgvADMIN.Columns[2].HeaderText = "Password";
           dgvADMIN.Columns[3].HeaderText = "First Name";
           dgvADMIN.Columns[4].HeaderText = "Last Name";
           
       }

     

       private void tsmADD_Click(object sender, EventArgs e)
       {
           adminID = "";
           frmPROFILE add = new frmPROFILE();
           add.ShowDialog();
           dgView();
       }

       private void tsmEDIT_Click(object sender, EventArgs e)
       {
           adminID = "0";
           frmPROFILE edit = new frmPROFILE();
           edit.ShowDialog();
           dgView();
       }

       private void tsmDEL_Click(object sender, EventArgs e)
       {
           if (frmUSER.uID == "")
           {
               MessageBox.Show("No User list detected. ", "Operation Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
           }
           else
           {
               cmd = new MySqlCommand();
               cmd.Connection = db.OpenConnection();
               cmd.CommandText = "DELETE FROM tbl_user WHERE user_id = '" + frmUSER.uID + "'";

               DialogResult dr = MessageBox.Show("Are you sure you want to delete this user's account?.\n All information with in this account will be deleted!!", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
               if (dr == DialogResult.Yes)
               {
                   MySqlDataReader r = cmd.ExecuteReader();
                   r.Close();
                   MessageBox.Show("Account Deleted.", "", MessageBoxButtons.OK);
                   db.CloseConnection();
                   dgView();
               }
               else if (dr == DialogResult.No)
               {
                   db.CloseConnection();
               }
           }
       }

       private void tsmADEXIT_Click(object sender, EventArgs e)
       {
           this.Close();
       }

       private void dgvADMIN_RowEnter(object sender, DataGridViewCellEventArgs e)
       {
           DataGridViewRow row = this.dgvADMIN.Rows[e.RowIndex];
           frmUSER.uID = row.Cells["user_id"].Value.ToString();
           loadUser();
       }
    }
}
