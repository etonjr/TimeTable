namespace Time_Table_Management_System
{
    partial class frmCSCHED
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCSCHED));
            this.tsmSAVE = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbSubj = new System.Windows.Forms.ComboBox();
            this.cmbDay = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFTime = new System.Windows.Forms.DateTimePicker();
            this.lblTPeriod = new System.Windows.Forms.Label();
            this.dtpSTime = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSEC = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGRADE = new System.Windows.Forms.TextBox();
            this.txtROOM = new System.Windows.Forms.TextBox();
            this.dgvSample = new System.Windows.Forms.DataGridView();
            this.tsmSUBJ = new System.Windows.Forms.ToolStrip();
            this.tsmSTAFFEXIT = new System.Windows.Forms.ToolStripButton();
            this.tsmUACCT = new System.Windows.Forms.ToolStripLabel();
            this.tsmTITLE = new System.Windows.Forms.ToolStrip();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSample)).BeginInit();
            this.tsmSUBJ.SuspendLayout();
            this.tsmTITLE.SuspendLayout();
            this.SuspendLayout();
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cmbSubj);
            this.groupBox1.Controls.Add(this.cmbDay);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dtpFTime);
            this.groupBox1.Controls.Add(this.lblTPeriod);
            this.groupBox1.Controls.Add(this.dtpSTime);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSEC);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtGRADE);
            this.groupBox1.Controls.Add(this.txtROOM);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 299);
            this.groupBox1.TabIndex = 139;
            this.groupBox1.TabStop = false;
            // 
            // cmbSubj
            // 
            this.cmbSubj.BackColor = System.Drawing.Color.DarkSlateGray;
            this.cmbSubj.Font = new System.Drawing.Font("Broadway", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSubj.ForeColor = System.Drawing.SystemColors.Control;
            this.cmbSubj.FormattingEnabled = true;
            this.cmbSubj.Location = new System.Drawing.Point(105, 139);
            this.cmbSubj.Name = "cmbSubj";
            this.cmbSubj.Size = new System.Drawing.Size(202, 30);
            this.cmbSubj.TabIndex = 152;
            this.cmbSubj.DropDown += new System.EventHandler(this.cmbSubj_DropDown);
            this.cmbSubj.SelectedIndexChanged += new System.EventHandler(this.cmbSubj_SelectedIndexChanged);
            this.cmbSubj.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbDay_KeyPress);
            // 
            // cmbDay
            // 
            this.cmbDay.BackColor = System.Drawing.Color.DarkSlateGray;
            this.cmbDay.Font = new System.Drawing.Font("Broadway", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDay.ForeColor = System.Drawing.SystemColors.Control;
            this.cmbDay.FormattingEnabled = true;
            this.cmbDay.Location = new System.Drawing.Point(105, 28);
            this.cmbDay.Name = "cmbDay";
            this.cmbDay.Size = new System.Drawing.Size(202, 30);
            this.cmbDay.TabIndex = 151;
            this.cmbDay.DropDown += new System.EventHandler(this.cmbDay_DropDown);
            this.cmbDay.SelectedIndexChanged += new System.EventHandler(this.cmbDay_SelectedIndexChanged);
            this.cmbDay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbDay_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(197, 94);
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
            this.dtpFTime.Location = new System.Drawing.Point(227, 101);
            this.dtpFTime.Name = "dtpFTime";
            this.dtpFTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpFTime.ShowUpDown = true;
            this.dtpFTime.Size = new System.Drawing.Size(80, 23);
            this.dtpFTime.TabIndex = 147;
            this.dtpFTime.Value = new System.DateTime(2017, 6, 28, 0, 0, 0, 0);
            // 
            // lblTPeriod
            // 
            this.lblTPeriod.AutoSize = true;
            this.lblTPeriod.BackColor = System.Drawing.Color.Transparent;
            this.lblTPeriod.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTPeriod.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTPeriod.Location = new System.Drawing.Point(31, 69);
            this.lblTPeriod.Name = "lblTPeriod";
            this.lblTPeriod.Size = new System.Drawing.Size(124, 21);
            this.lblTPeriod.TabIndex = 144;
            this.lblTPeriod.Text = "Time  /  Period :";
            // 
            // dtpSTime
            // 
            this.dtpSTime.CustomFormat = "hh:mm tt";
            this.dtpSTime.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSTime.Location = new System.Drawing.Point(109, 101);
            this.dtpSTime.Name = "dtpSTime";
            this.dtpSTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpSTime.ShowUpDown = true;
            this.dtpSTime.Size = new System.Drawing.Size(82, 23);
            this.dtpSTime.TabIndex = 145;
            this.dtpSTime.Value = new System.DateTime(2017, 6, 28, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(50, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 21);
            this.label2.TabIndex = 124;
            this.label2.Text = "Day :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(46, 265);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 21);
            this.label4.TabIndex = 134;
            this.label4.Text = "Room :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(41, 191);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 21);
            this.label1.TabIndex = 130;
            this.label1.Text = "Grade :";
            // 
            // txtSEC
            // 
            this.txtSEC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSEC.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSEC.Location = new System.Drawing.Point(111, 229);
            this.txtSEC.MaxLength = 20;
            this.txtSEC.Name = "txtSEC";
            this.txtSEC.Size = new System.Drawing.Size(196, 23);
            this.txtSEC.TabIndex = 133;
            this.txtSEC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSEC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSEC_KeyPress);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.Control;
            this.label19.Location = new System.Drawing.Point(31, 146);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(73, 21);
            this.label19.TabIndex = 128;
            this.label19.Text = "Subject :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(31, 229);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 21);
            this.label3.TabIndex = 131;
            this.label3.Text = "Section :";
            // 
            // txtGRADE
            // 
            this.txtGRADE.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGRADE.Location = new System.Drawing.Point(111, 191);
            this.txtGRADE.MaxLength = 2;
            this.txtGRADE.Name = "txtGRADE";
            this.txtGRADE.Size = new System.Drawing.Size(51, 23);
            this.txtGRADE.TabIndex = 132;
            this.txtGRADE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGRADE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGRADE_KeyPress);
            // 
            // txtROOM
            // 
            this.txtROOM.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtROOM.Location = new System.Drawing.Point(111, 265);
            this.txtROOM.MaxLength = 2;
            this.txtROOM.Name = "txtROOM";
            this.txtROOM.Size = new System.Drawing.Size(100, 23);
            this.txtROOM.TabIndex = 135;
            this.txtROOM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtROOM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGRADE_KeyPress);
            // 
            // dgvSample
            // 
            this.dgvSample.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSample.Location = new System.Drawing.Point(183, 56);
            this.dgvSample.Name = "dgvSample";
            this.dgvSample.Size = new System.Drawing.Size(10, 10);
            this.dgvSample.TabIndex = 141;
            this.dgvSample.Visible = false;
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
            this.tsmSUBJ.Size = new System.Drawing.Size(358, 33);
            this.tsmSUBJ.TabIndex = 140;
            this.tsmSUBJ.Text = "toolStrip1";
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
            // tsmUACCT
            // 
            this.tsmUACCT.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.tsmUACCT.ForeColor = System.Drawing.SystemColors.Control;
            this.tsmUACCT.Image = ((System.Drawing.Image)(resources.GetObject("tsmUACCT.Image")));
            this.tsmUACCT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmUACCT.Margin = new System.Windows.Forms.Padding(2);
            this.tsmUACCT.Name = "tsmUACCT";
            this.tsmUACCT.Padding = new System.Windows.Forms.Padding(2);
            this.tsmUACCT.Size = new System.Drawing.Size(198, 34);
            this.tsmUACCT.Text = "Class Schedule";
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
            this.tsmTITLE.Size = new System.Drawing.Size(358, 42);
            this.tsmTITLE.TabIndex = 138;
            // 
            // frmCSCHED
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(358, 393);
            this.Controls.Add(this.tsmSUBJ);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tsmTITLE);
            this.Controls.Add(this.dgvSample);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(90, 250);
            this.Name = "frmCSCHED";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.frmSCHED_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSample)).EndInit();
            this.tsmSUBJ.ResumeLayout(false);
            this.tsmSUBJ.PerformLayout();
            this.tsmTITLE.ResumeLayout(false);
            this.tsmTITLE.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripButton tsmSAVE;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtROOM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSEC;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGRADE;
        private System.Windows.Forms.ToolStrip tsmSUBJ;
        private System.Windows.Forms.ToolStripButton tsmSTAFFEXIT;
        private System.Windows.Forms.ToolStripLabel tsmUACCT;
        private System.Windows.Forms.ToolStrip tsmTITLE;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpFTime;
        private System.Windows.Forms.Label lblTPeriod;
        private System.Windows.Forms.DateTimePicker dtpSTime;
        private System.Windows.Forms.ComboBox cmbDay;
        private System.Windows.Forms.DataGridView dgvSample;
        private System.Windows.Forms.ComboBox cmbSubj;
    }
}