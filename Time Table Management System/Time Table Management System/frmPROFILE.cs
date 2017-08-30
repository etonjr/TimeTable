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
    public partial class frmPROFILE : Form
    {
        Db_Utilities db = new Db_Utilities();
        MySqlCommand cmd;
        MySqlDataAdapter ad;
        DataTable ss;

        public frmPROFILE()
        {
            InitializeComponent();
        }

        private void frmPROFILE_Load(object sender, EventArgs e)
        {
            if (frmUSER.uID != "" && frmADMIN.adminID != "")
            {
                btnSAVE.Text = "Update";
                string query = "SELECT user_name,password,fname,lname,cno,address,position,image FROM tbl_user WHERE user_id ='" + frmUSER.uID + "'";
                cmd = new MySqlCommand(query, db.OpenConnection());
                MySqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    txtUFNAME.Text = r["fname"].ToString();
                    txtULNAME.Text = r["lname"].ToString();
                    txtUPWORD.Text = r["password"].ToString();
                    txtUNAME.Text = r["user_name"].ToString();
                    txtADDRESS.Text = r["address"].ToString();
                    txtCNO.Text = r["cno"].ToString();
                    txtUPOS.Text = r["position"].ToString();
                    lblUNDUP.Text = r["user_name"].ToString();
                    byte[] img = (byte[])(r["image"]);
                    MemoryStream ms = new MemoryStream(img);
                    pbxUPIC.Image = Image.FromStream(ms);
                }
                r.Close();
                db.CloseConnection();
            }
            else if (frmADMIN.adminID == "")
            {
                btnSAVE.Text = "Save";
            }
        }

        private void btnUPLOAD_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Select Profile Picture(*.JPG; *.PNG;)|*.jpg; *.png";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pbxUPIC.Image = Image.FromFile(dlg.FileName);
            }
        }

        private void btnDELPIC_Click(object sender, EventArgs e)
        {
            pbxUPIC.Image = Image.FromFile(Application.StartupPath + "\\personalinfo5.jpg");
        }
        private void saveImage()
        {
            MemoryStream ms = new MemoryStream();
            pbxUPIC.Image.Save(ms, pbxUPIC.Image.RawFormat);
            byte[] img = ms.ToArray();

            string queryimg = " INSERT INTO tbl_user (user_name,password,fname,lname,address,cno,position,image)" +
                              "VALUES ('" + this.txtUNAME.Text + "','" + this.txtUPWORD.Text + "','" + this.txtUFNAME.Text + "','" + this.txtULNAME.Text + "','" + this.txtADDRESS.Text + "','" + this.txtCNO.Text + "','" + this.txtUPOS.Text + "',@img);";
            MySqlCommand commandimg = new MySqlCommand(queryimg, db.OpenConnection());
            commandimg.Parameters.Add(new MySqlParameter("@img", img));
            MySqlDataReader rimg = commandimg.ExecuteReader();
            rimg.Close();
            db.CloseConnection();
            MessageBox.Show("Account Saved.");
            this.Close();
        }
        private void updateImage()
        {
            MemoryStream ms = new MemoryStream();
            pbxUPIC.Image.Save(ms, pbxUPIC.Image.RawFormat);
            byte[] img = ms.ToArray();

            string query = "UPDATE tbl_user SET user_name = '" + txtUNAME.Text + "', password = '" + txtUPWORD.Text + "', fname = '" + txtUFNAME.Text + "', lname = '" + txtULNAME.Text + "', cno = '" + txtCNO.Text + "', address = '" + txtADDRESS.Text + "', position = '" + txtUPOS.Text + "',image = @img WHERE user_id = '" + frmUSER.uID + "'";
            cmd = new MySqlCommand(query, db.OpenConnection());
            cmd.Parameters.Add(new MySqlParameter("@img", img));
            MySqlDataReader re = cmd.ExecuteReader();
            re.Close();
            MessageBox.Show("Your Account has been updated.");
            db.CloseConnection();
            this.Close();
        }

        private void btnSAVE_Click(object sender, EventArgs e)
        {
            if (txtUFNAME.Text != "" && txtULNAME.Text != "" && txtUPWORD.Text != "" && txtUNAME.Text != "" && txtCNO.Text != "" && txtADDRESS.Text != "" && txtUPOS.Text != "" && btnSAVE.Text == "Save")
            {
                if (txtUNAME.Text != "")
                {
                    ad = new MySqlDataAdapter("SELECT user_name FROM tbl_user WHERE user_name = '" + txtUNAME.Text + "'", db.OpenConnection());
                    ss = new DataTable();
                    ad.Fill(ss);
                    int i = ss.Rows.Count;
                    if (i > 0)
                    {
                        MessageBox.Show("User name ( " + txtUNAME.Text + " ) already exist.", "User Name Existed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        lblUACCTREQUNAME.Visible = true;
                        ss.Clear();
                    }
                    else { saveImage(); }
                }
            }
            else if (txtUFNAME.Text != "" && txtULNAME.Text != "" && txtUPWORD.Text != "" && txtUNAME.Text != "" && txtCNO.Text != "" && txtADDRESS.Text != "" && txtUPOS.Text != "" && btnSAVE.Text == "Update")
            {
                if (lblUNDUP.Text == txtUNAME.Text) { updateImage(); }
                else
                {
                    ad = new MySqlDataAdapter("SELECT * FROM tbl_user WHERE user_name = '" + txtUNAME.Text + "'", db.OpenConnection());
                    ss = new DataTable();
                    ad.Fill(ss);
                    int i = ss.Rows.Count;
                    if (i > 0)
                    {
                        MessageBox.Show("User name ( " + txtUNAME.Text + " ) already exist.", "User Name Existed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        lblUACCTREQUNAME.Visible = true;
                        ss.Clear();
                    }
                    else { updateImage(); }
                }
            }
            else if (txtUFNAME.Text == "") { lblUACCTREQFNAME.Visible = true; }
            else if (txtULNAME.Text == "") { lblUACCTREQLNAME.Visible = true; }
            else if (txtUPWORD.Text == "") { lblUACCTREQPWORD.Visible = true; }
            else if (txtUNAME.Text == "") { lblUACCTREQUNAME.Visible = true; }
            else if (txtADDRESS.Text == "") { lblREQADDRESS.Visible = true; }
            else if (txtCNO.Text == "") { lblREQCNO.Visible = true; }
            else if (txtUPOS.Text == "") { lblREQPOS.Visible = true; } 
        }

        private void tsmEXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUFNAME_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar)) { e.Handled = true; }
        }

        private void txtUPWORD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) { e.Handled = true; }
        }

        private void txtCNO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) { e.Handled = true; }
        }

        private void txtADDRESS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar)) { e.Handled = true; }
        }
    }
}
