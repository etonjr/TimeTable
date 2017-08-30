namespace Time_Table_Management_System
{
    partial class frmESCHED
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmESCHED));
            this.lblDSdate = new System.Windows.Forms.Label();
            this.lblDTIMEF = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFTime = new System.Windows.Forms.DateTimePicker();
            this.lblDTIME = new System.Windows.Forms.Label();
            this.lblTimestarted = new System.Windows.Forms.Label();
            this.dtpSTime = new System.Windows.Forms.DateTimePicker();
            this.lblSCHEDID = new System.Windows.Forms.Label();
            this.lblSUBJID = new System.Windows.Forms.Label();
            this.lblSUBJN = new System.Windows.Forms.Label();
            this.lblUID = new System.Windows.Forms.Label();
            this.cmbSUBJ = new System.Windows.Forms.ComboBox();
            this.dtpSDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtPlace = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDFdate = new System.Windows.Forms.Label();
            this.tsmTITLE = new System.Windows.Forms.ToolStrip();
            this.tsmUACCT = new System.Windows.Forms.ToolStripLabel();
            this.tsmSTAFFEXIT = new System.Windows.Forms.ToolStripButton();
            this.tsmSUBJ = new System.Windows.Forms.ToolStrip();
            this.tsmSAVE = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            this.tsmTITLE.SuspendLayout();
            this.tsmSUBJ.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDSdate
            // 
            this.lblDSdate.AutoSize = true;
            this.lblDSdate.Font = new System.Drawing.Font("Calibri", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDSdate.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDSdate.Location = new System.Drawing.Point(133, 59);
            this.lblDSdate.Name = "lblDSdate";
            this.lblDSdate.Size = new System.Drawing.Size(0, 10);
            this.lblDSdate.TabIndex = 150;
            this.lblDSdate.Visible = false;
            // 
            // lblDTIMEF
            // 
            this.lblDTIMEF.AutoSize = true;
            this.lblDTIMEF.Font = new System.Drawing.Font("Calibri", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDTIMEF.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDTIMEF.Location = new System.Drawing.Point(242, 202);
            this.lblDTIMEF.Name = "lblDTIMEF";
            this.lblDTIMEF.Size = new System.Drawing.Size(0, 10);
            this.lblDTIMEF.TabIndex = 149;
            this.lblDTIMEF.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(207, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 31);
            this.label5.TabIndex = 148;
            this.label5.Text = "-";
            // 
            // dtpFTime
            // 
            this.dtpFTime.CustomFormat = "hh:mm tt";
            this.dtpFTime.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFTime.Location = new System.Drawing.Point(237, 171);
            this.dtpFTime.Name = "dtpFTime";
            this.dtpFTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpFTime.ShowUpDown = true;
            this.dtpFTime.Size = new System.Drawing.Size(80, 23);
            this.dtpFTime.TabIndex = 147;
            this.dtpFTime.Value = new System.DateTime(2017, 6, 28, 0, 0, 0, 0);
            // 
            // lblDTIME
            // 
            this.lblDTIME.AutoSize = true;
            this.lblDTIME.Font = new System.Drawing.Font("Calibri", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDTIME.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDTIME.Location = new System.Drawing.Point(122, 202);
            this.lblDTIME.Name = "lblDTIME";
            this.lblDTIME.Size = new System.Drawing.Size(0, 10);
            this.lblDTIME.TabIndex = 146;
            this.lblDTIME.Visible = false;
            // 
            // lblTimestarted
            // 
            this.lblTimestarted.AutoSize = true;
            this.lblTimestarted.BackColor = System.Drawing.Color.Transparent;
            this.lblTimestarted.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimestarted.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTimestarted.Location = new System.Drawing.Point(21, 135);
            this.lblTimestarted.Name = "lblTimestarted";
            this.lblTimestarted.Size = new System.Drawing.Size(124, 21);
            this.lblTimestarted.TabIndex = 144;
            this.lblTimestarted.Text = "Time  /  Period :";
            // 
            // dtpSTime
            // 
            this.dtpSTime.CustomFormat = "hh:mm tt";
            this.dtpSTime.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSTime.Location = new System.Drawing.Point(119, 171);
            this.dtpSTime.Name = "dtpSTime";
            this.dtpSTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpSTime.ShowUpDown = true;
            this.dtpSTime.Size = new System.Drawing.Size(82, 23);
            this.dtpSTime.TabIndex = 145;
            this.dtpSTime.Value = new System.DateTime(2017, 6, 28, 0, 0, 0, 0);
            // 
            // lblSCHEDID
            // 
            this.lblSCHEDID.AutoSize = true;
            this.lblSCHEDID.Font = new System.Drawing.Font("Calibri", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSCHEDID.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSCHEDID.Location = new System.Drawing.Point(15, 268);
            this.lblSCHEDID.Name = "lblSCHEDID";
            this.lblSCHEDID.Size = new System.Drawing.Size(0, 10);
            this.lblSCHEDID.TabIndex = 139;
            this.lblSCHEDID.Visible = false;
            // 
            // lblSUBJID
            // 
            this.lblSUBJID.AutoSize = true;
            this.lblSUBJID.Font = new System.Drawing.Font("Calibri", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSUBJID.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSUBJID.Location = new System.Drawing.Point(15, 184);
            this.lblSUBJID.Name = "lblSUBJID";
            this.lblSUBJID.Size = new System.Drawing.Size(0, 10);
            this.lblSUBJID.TabIndex = 138;
            this.lblSUBJID.Visible = false;
            // 
            // lblSUBJN
            // 
            this.lblSUBJN.AutoSize = true;
            this.lblSUBJN.Font = new System.Drawing.Font("Calibri", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSUBJN.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSUBJN.Location = new System.Drawing.Point(126, 257);
            this.lblSUBJN.Name = "lblSUBJN";
            this.lblSUBJN.Size = new System.Drawing.Size(0, 10);
            this.lblSUBJN.TabIndex = 137;
            this.lblSUBJN.Visible = false;
            // 
            // lblUID
            // 
            this.lblUID.AutoSize = true;
            this.lblUID.Font = new System.Drawing.Font("Calibri", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUID.ForeColor = System.Drawing.SystemColors.Control;
            this.lblUID.Location = new System.Drawing.Point(15, 59);
            this.lblUID.Name = "lblUID";
            this.lblUID.Size = new System.Drawing.Size(0, 10);
            this.lblUID.TabIndex = 136;
            this.lblUID.Visible = false;
            // 
            // cmbSUBJ
            // 
            this.cmbSUBJ.BackColor = System.Drawing.Color.Tan;
            this.cmbSUBJ.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSUBJ.FormattingEnabled = true;
            this.cmbSUBJ.Location = new System.Drawing.Point(119, 224);
            this.cmbSUBJ.Name = "cmbSUBJ";
            this.cmbSUBJ.Size = new System.Drawing.Size(196, 23);
            this.cmbSUBJ.TabIndex = 129;
            this.cmbSUBJ.DropDown += new System.EventHandler(this.cmbSUBJ_DropDown);
            this.cmbSUBJ.SelectedIndexChanged += new System.EventHandler(this.cmbSUBJ_SelectedIndexChanged);
            // 
            // dtpSDate
            // 
            this.dtpSDate.CustomFormat = "MMM dd, yyyy - dddd";
            this.dtpSDate.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSDate.Location = new System.Drawing.Point(119, 29);
            this.dtpSDate.Name = "dtpSDate";
            this.dtpSDate.Size = new System.Drawing.Size(196, 23);
            this.dtpSDate.TabIndex = 125;
            this.dtpSDate.Value = new System.DateTime(2017, 6, 28, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(49, 280);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 21);
            this.label1.TabIndex = 130;
            this.label1.Text = "Place :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.Control;
            this.label19.Location = new System.Drawing.Point(52, 225);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(52, 21);
            this.label19.TabIndex = 128;
            this.label19.Text = "Title :";
            // 
            // txtPlace
            // 
            this.txtPlace.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlace.Location = new System.Drawing.Point(119, 280);
            this.txtPlace.MaxLength = 1;
            this.txtPlace.Name = "txtPlace";
            this.txtPlace.Size = new System.Drawing.Size(196, 23);
            this.txtPlace.TabIndex = 132;
            this.txtPlace.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblDFdate);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dtpFDate);
            this.groupBox1.Controls.Add(this.lblDSdate);
            this.groupBox1.Controls.Add(this.lblDTIMEF);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dtpFTime);
            this.groupBox1.Controls.Add(this.lblDTIME);
            this.groupBox1.Controls.Add(this.lblTimestarted);
            this.groupBox1.Controls.Add(this.dtpSTime);
            this.groupBox1.Controls.Add(this.lblSCHEDID);
            this.groupBox1.Controls.Add(this.lblSUBJID);
            this.groupBox1.Controls.Add(this.lblSUBJN);
            this.groupBox1.Controls.Add(this.lblUID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbSUBJ);
            this.groupBox1.Controls.Add(this.dtpSDate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.txtPlace);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 331);
            this.groupBox1.TabIndex = 142;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(21, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 21);
            this.label2.TabIndex = 124;
            this.label2.Text = "Date Start:";
            // 
            // dtpFDate
            // 
            this.dtpFDate.CustomFormat = "MMM dd, yyyy - dddd";
            this.dtpFDate.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFDate.Location = new System.Drawing.Point(119, 84);
            this.dtpFDate.Name = "dtpFDate";
            this.dtpFDate.Size = new System.Drawing.Size(196, 23);
            this.dtpFDate.TabIndex = 151;
            this.dtpFDate.Value = new System.DateTime(2017, 6, 28, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(17, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 21);
            this.label6.TabIndex = 152;
            this.label6.Text = "Date Finish:";
            // 
            // lblDFdate
            // 
            this.lblDFdate.AutoSize = true;
            this.lblDFdate.Font = new System.Drawing.Font("Calibri", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDFdate.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDFdate.Location = new System.Drawing.Point(133, 113);
            this.lblDFdate.Name = "lblDFdate";
            this.lblDFdate.Size = new System.Drawing.Size(0, 10);
            this.lblDFdate.TabIndex = 153;
            this.lblDFdate.Visible = false;
            // 
            // tsmTITLE
            // 
            this.tsmTITLE.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tsmTITLE.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tsmTITLE.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsmTITLE.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.tsmTITLE.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmUACCT,
            this.tsmSTAFFEXIT});
            this.tsmTITLE.Location = new System.Drawing.Point(0, 0);
            this.tsmTITLE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tsmTITLE.Name = "tsmTITLE";
            this.tsmTITLE.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tsmTITLE.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsmTITLE.Size = new System.Drawing.Size(363, 42);
            this.tsmTITLE.TabIndex = 144;
            // 
            // tsmUACCT
            // 
            this.tsmUACCT.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.tsmUACCT.ForeColor = System.Drawing.SystemColors.Control;
            this.tsmUACCT.Image = ((System.Drawing.Image)(resources.GetObject("tsmUACCT.Image")));
            this.tsmUACCT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmUACCT.Margin = new System.Windows.Forms.Padding(2);
            this.tsmUACCT.Name = "tsmUACCT";
            this.tsmUACCT.Padding = new System.Windows.Forms.Padding(2);
            this.tsmUACCT.Size = new System.Drawing.Size(204, 34);
            this.tsmUACCT.Text = "Event Schedule";
            // 
            // tsmSTAFFEXIT
            // 
            this.tsmSTAFFEXIT.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsmSTAFFEXIT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsmSTAFFEXIT.Image = ((System.Drawing.Image)(resources.GetObject("tsmSTAFFEXIT.Image")));
            this.tsmSTAFFEXIT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmSTAFFEXIT.Name = "tsmSTAFFEXIT";
            this.tsmSTAFFEXIT.Size = new System.Drawing.Size(34, 35);
            this.tsmSTAFFEXIT.Click += new System.EventHandler(this.tsmSTAFFEXIT_Click);
            // 
            // tsmSUBJ
            // 
            this.tsmSUBJ.BackColor = System.Drawing.Color.Gainsboro;
            this.tsmSUBJ.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsmSUBJ.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSAVE});
            this.tsmSUBJ.Location = new System.Drawing.Point(0, 42);
            this.tsmSUBJ.Margin = new System.Windows.Forms.Padding(2);
            this.tsmSUBJ.Name = "tsmSUBJ";
            this.tsmSUBJ.Padding = new System.Windows.Forms.Padding(2);
            this.tsmSUBJ.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsmSUBJ.Size = new System.Drawing.Size(363, 33);
            this.tsmSUBJ.TabIndex = 145;
            this.tsmSUBJ.Text = "toolStrip1";
            // 
            // tsmSAVE
            // 
            this.tsmSAVE.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold);
            this.tsmSAVE.Image = ((System.Drawing.Image)(resources.GetObject("tsmSAVE.Image")));
            this.tsmSAVE.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmSAVE.Margin = new System.Windows.Forms.Padding(5, 2, 2, 2);
            this.tsmSAVE.Name = "tsmSAVE";
            this.tsmSAVE.Padding = new System.Windows.Forms.Padding(2);
            this.tsmSAVE.Size = new System.Drawing.Size(66, 25);
            this.tsmSAVE.Text = "Save";
            this.tsmSAVE.Click += new System.EventHandler(this.tsmSAVE_Click);
            // 
            // frmEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(363, 423);
            this.ControlBox = false;
            this.Controls.Add(this.tsmSUBJ);
            this.Controls.Add(this.tsmTITLE);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(90, 250);
            this.Name = "frmEvent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.frmEvent_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tsmTITLE.ResumeLayout(false);
            this.tsmTITLE.PerformLayout();
            this.tsmSUBJ.ResumeLayout(false);
            this.tsmSUBJ.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDSdate;
        private System.Windows.Forms.Label lblDTIMEF;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpFTime;
        private System.Windows.Forms.Label lblDTIME;
        private System.Windows.Forms.Label lblTimestarted;
        private System.Windows.Forms.DateTimePicker dtpSTime;
        private System.Windows.Forms.Label lblSCHEDID;
        private System.Windows.Forms.Label lblSUBJID;
        private System.Windows.Forms.Label lblSUBJN;
        private System.Windows.Forms.Label lblUID;
        private System.Windows.Forms.ComboBox cmbSUBJ;
        private System.Windows.Forms.DateTimePicker dtpSDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtPlace;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpFDate;
        private System.Windows.Forms.Label lblDFdate;
        private System.Windows.Forms.ToolStrip tsmTITLE;
        private System.Windows.Forms.ToolStripLabel tsmUACCT;
        private System.Windows.Forms.ToolStripButton tsmSTAFFEXIT;
        private System.Windows.Forms.ToolStrip tsmSUBJ;
        private System.Windows.Forms.ToolStripButton tsmSAVE;
    }
}