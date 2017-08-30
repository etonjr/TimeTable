namespace Time_Table_Management_System
{
    partial class frmRegKey
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegKey));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkPWORD = new System.Windows.Forms.CheckBox();
            this.lblRECON = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUid = new System.Windows.Forms.TextBox();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.btnCON = new System.Windows.Forms.Button();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbUid = new System.Windows.Forms.Label();
            this.lbDatabase = new System.Windows.Forms.Label();
            this.lbPort = new System.Windows.Forms.Label();
            this.lbServer = new System.Windows.Forms.Label();
            this.lbConnectionString = new System.Windows.Forms.Label();
            this.tsmREGKEY = new System.Windows.Forms.ToolStrip();
            this.tsmEXIT = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            this.tsmREGKEY.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.chkPWORD);
            this.groupBox1.Controls.Add(this.lblRECON);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtUid);
            this.groupBox1.Controls.Add(this.txtDatabase);
            this.groupBox1.Controls.Add(this.txtPort);
            this.groupBox1.Controls.Add(this.txtServer);
            this.groupBox1.Controls.Add(this.btnCON);
            this.groupBox1.Controls.Add(this.lbPassword);
            this.groupBox1.Controls.Add(this.lbUid);
            this.groupBox1.Controls.Add(this.lbDatabase);
            this.groupBox1.Controls.Add(this.lbPort);
            this.groupBox1.Controls.Add(this.lbServer);
            this.groupBox1.Controls.Add(this.lbConnectionString);
            this.groupBox1.Location = new System.Drawing.Point(12, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 294);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // chkPWORD
            // 
            this.chkPWORD.AutoSize = true;
            this.chkPWORD.BackColor = System.Drawing.Color.Transparent;
            this.chkPWORD.Font = new System.Drawing.Font("Georgia", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPWORD.ForeColor = System.Drawing.SystemColors.Control;
            this.chkPWORD.Location = new System.Drawing.Point(130, 189);
            this.chkPWORD.Name = "chkPWORD";
            this.chkPWORD.Size = new System.Drawing.Size(54, 17);
            this.chkPWORD.TabIndex = 108;
            this.chkPWORD.Text = "Show";
            this.chkPWORD.UseVisualStyleBackColor = false;
            this.chkPWORD.CheckedChanged += new System.EventHandler(this.chkPWORD_CheckedChanged);
            // 
            // lblRECON
            // 
            this.lblRECON.AutoSize = true;
            this.lblRECON.BackColor = System.Drawing.Color.Red;
            this.lblRECON.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRECON.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRECON.Location = new System.Drawing.Point(67, 268);
            this.lblRECON.Name = "lblRECON";
            this.lblRECON.Size = new System.Drawing.Size(0, 17);
            this.lblRECON.TabIndex = 101;
            this.lblRECON.Visible = false;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(129, 166);
            this.txtPassword.MaxLength = 10;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 38;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtServer_KeyPress);
            // 
            // txtUid
            // 
            this.txtUid.Location = new System.Drawing.Point(129, 140);
            this.txtUid.MaxLength = 20;
            this.txtUid.Name = "txtUid";
            this.txtUid.Size = new System.Drawing.Size(100, 20);
            this.txtUid.TabIndex = 37;
            this.txtUid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtServer_KeyPress);
            // 
            // txtDatabase
            // 
            this.txtDatabase.Location = new System.Drawing.Point(129, 114);
            this.txtDatabase.MaxLength = 20;
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(100, 20);
            this.txtDatabase.TabIndex = 36;
            this.txtDatabase.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtServer_KeyPress);
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(129, 85);
            this.txtPort.MaxLength = 10;
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(100, 20);
            this.txtPort.TabIndex = 35;
            this.txtPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtServer_KeyPress);
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(129, 59);
            this.txtServer.MaxLength = 20;
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(100, 20);
            this.txtServer.TabIndex = 34;
            this.txtServer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtServer_KeyPress);
            // 
            // btnCON
            // 
            this.btnCON.BackColor = System.Drawing.Color.DarkGreen;
            this.btnCON.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCON.BackgroundImage")));
            this.btnCON.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCON.Font = new System.Drawing.Font("Papyrus", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCON.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCON.Location = new System.Drawing.Point(84, 212);
            this.btnCON.Name = "btnCON";
            this.btnCON.Size = new System.Drawing.Size(145, 42);
            this.btnCON.TabIndex = 33;
            this.btnCON.Text = "CONNECT";
            this.btnCON.UseVisualStyleBackColor = false;
            this.btnCON.Click += new System.EventHandler(this.btnCON_Click);
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Papyrus", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.ForeColor = System.Drawing.SystemColors.Control;
            this.lbPassword.Location = new System.Drawing.Point(28, 170);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(92, 16);
            this.lbPassword.TabIndex = 31;
            this.lbPassword.Text = "PASSWORD :";
            // 
            // lbUid
            // 
            this.lbUid.AutoSize = true;
            this.lbUid.Font = new System.Drawing.Font("Papyrus", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUid.ForeColor = System.Drawing.SystemColors.Control;
            this.lbUid.Location = new System.Drawing.Point(81, 141);
            this.lbUid.Name = "lbUid";
            this.lbUid.Size = new System.Drawing.Size(40, 16);
            this.lbUid.TabIndex = 30;
            this.lbUid.Text = "UID :";
            // 
            // lbDatabase
            // 
            this.lbDatabase.AutoSize = true;
            this.lbDatabase.Font = new System.Drawing.Font("Papyrus", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDatabase.ForeColor = System.Drawing.SystemColors.Control;
            this.lbDatabase.Location = new System.Drawing.Point(28, 118);
            this.lbDatabase.Name = "lbDatabase";
            this.lbDatabase.Size = new System.Drawing.Size(94, 16);
            this.lbDatabase.TabIndex = 29;
            this.lbDatabase.Text = "DATABASE :";
            // 
            // lbPort
            // 
            this.lbPort.AutoSize = true;
            this.lbPort.Font = new System.Drawing.Font("Papyrus", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPort.ForeColor = System.Drawing.SystemColors.Control;
            this.lbPort.Location = new System.Drawing.Point(73, 89);
            this.lbPort.Name = "lbPort";
            this.lbPort.Size = new System.Drawing.Size(50, 16);
            this.lbPort.TabIndex = 28;
            this.lbPort.Text = "PORT :";
            // 
            // lbServer
            // 
            this.lbServer.AutoSize = true;
            this.lbServer.Font = new System.Drawing.Font("Papyrus", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbServer.ForeColor = System.Drawing.SystemColors.Control;
            this.lbServer.Location = new System.Drawing.Point(57, 60);
            this.lbServer.Name = "lbServer";
            this.lbServer.Size = new System.Drawing.Size(68, 16);
            this.lbServer.TabIndex = 27;
            this.lbServer.Text = "SERVER :";
            // 
            // lbConnectionString
            // 
            this.lbConnectionString.AutoSize = true;
            this.lbConnectionString.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConnectionString.ForeColor = System.Drawing.SystemColors.Control;
            this.lbConnectionString.Location = new System.Drawing.Point(42, 26);
            this.lbConnectionString.Name = "lbConnectionString";
            this.lbConnectionString.Size = new System.Drawing.Size(233, 21);
            this.lbConnectionString.TabIndex = 26;
            this.lbConnectionString.Text = "MYSQL Database Connection";
            // 
            // tsmREGKEY
            // 
            this.tsmREGKEY.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tsmREGKEY.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tsmREGKEY.BackgroundImage")));
            this.tsmREGKEY.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsmREGKEY.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsmREGKEY.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.tsmREGKEY.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmEXIT});
            this.tsmREGKEY.Location = new System.Drawing.Point(0, 0);
            this.tsmREGKEY.Name = "tsmREGKEY";
            this.tsmREGKEY.Padding = new System.Windows.Forms.Padding(2);
            this.tsmREGKEY.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsmREGKEY.Size = new System.Drawing.Size(325, 41);
            this.tsmREGKEY.TabIndex = 107;
            // 
            // tsmEXIT
            // 
            this.tsmEXIT.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsmEXIT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsmEXIT.Image = ((System.Drawing.Image)(resources.GetObject("tsmEXIT.Image")));
            this.tsmEXIT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmEXIT.Name = "tsmEXIT";
            this.tsmEXIT.Size = new System.Drawing.Size(34, 34);
            this.tsmEXIT.Text = "toolStripButton1";
            this.tsmEXIT.Click += new System.EventHandler(this.tsmEXIT_Click);
            // 
            // frmRegKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(325, 350);
            this.Controls.Add(this.tsmREGKEY);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRegKey";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmRegKey_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tsmREGKEY.ResumeLayout(false);
            this.tsmREGKEY.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUid;
        private System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Button btnCON;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbUid;
        private System.Windows.Forms.Label lbDatabase;
        private System.Windows.Forms.Label lbPort;
        private System.Windows.Forms.Label lbServer;
        private System.Windows.Forms.Label lbConnectionString;
        private System.Windows.Forms.Label lblRECON;
        private System.Windows.Forms.ToolStrip tsmREGKEY;
        private System.Windows.Forms.ToolStripButton tsmEXIT;
        private System.Windows.Forms.CheckBox chkPWORD;

    }
}