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
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFTime = new System.Windows.Forms.DateTimePicker();
            this.lblTimestarted = new System.Windows.Forms.Label();
            this.dtpSTime = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtPlace = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpFDate = new System.Windows.Forms.DateTimePicker();
            this.dtpSDate = new System.Windows.Forms.DateTimePicker();
            this.cmbEvent = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tsmTITLE = new System.Windows.Forms.ToolStrip();
            this.tsmUACCT = new System.Windows.Forms.ToolStripLabel();
            this.tsmSTAFFEXIT = new System.Windows.Forms.ToolStripButton();
            this.tsmSUBJ = new System.Windows.Forms.ToolStrip();
            this.tsmSAVE = new System.Windows.Forms.ToolStripButton();
            this.dgvSample = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.tsmTITLE.SuspendLayout();
            this.tsmSUBJ.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSample)).BeginInit();
            this.SuspendLayout();
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
            this.txtPlace.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPlace.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlace.Location = new System.Drawing.Point(119, 280);
            this.txtPlace.MaxLength = 20;
            this.txtPlace.Name = "txtPlace";
            this.txtPlace.Size = new System.Drawing.Size(196, 23);
            this.txtPlace.TabIndex = 132;
            this.txtPlace.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPlace.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlace_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dtpFDate);
            this.groupBox1.Controls.Add(this.dtpSDate);
            this.groupBox1.Controls.Add(this.cmbEvent);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dtpFTime);
            this.groupBox1.Controls.Add(this.lblTimestarted);
            this.groupBox1.Controls.Add(this.dtpSTime);
            this.groupBox1.Controls.Add(this.label2);
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
            // dtpFDate
            // 
            this.dtpFDate.CustomFormat = "MMM dd, yyyy - dddd";
            this.dtpFDate.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFDate.Location = new System.Drawing.Point(117, 83);
            this.dtpFDate.Name = "dtpFDate";
            this.dtpFDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpFDate.Size = new System.Drawing.Size(198, 23);
            this.dtpFDate.TabIndex = 155;
            this.dtpFDate.Value = new System.DateTime(2017, 6, 28, 0, 0, 0, 0);
            // 
            // dtpSDate
            // 
            this.dtpSDate.CustomFormat = "MMM dd, yyyy - dddd";
            this.dtpSDate.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSDate.Location = new System.Drawing.Point(119, 30);
            this.dtpSDate.Name = "dtpSDate";
            this.dtpSDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpSDate.Size = new System.Drawing.Size(198, 23);
            this.dtpSDate.TabIndex = 154;
            this.dtpSDate.Value = new System.DateTime(2017, 6, 28, 0, 0, 0, 0);
            // 
            // cmbEvent
            // 
            this.cmbEvent.BackColor = System.Drawing.Color.DarkSlateGray;
            this.cmbEvent.Font = new System.Drawing.Font("Broadway", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEvent.ForeColor = System.Drawing.SystemColors.Control;
            this.cmbEvent.FormattingEnabled = true;
            this.cmbEvent.Location = new System.Drawing.Point(119, 218);
            this.cmbEvent.Name = "cmbEvent";
            this.cmbEvent.Size = new System.Drawing.Size(198, 30);
            this.cmbEvent.TabIndex = 153;
            this.cmbEvent.DropDown += new System.EventHandler(this.cmbEvent_DropDown);
            this.cmbEvent.SelectedIndexChanged += new System.EventHandler(this.cmbEvent_SelectedIndexChanged);
            this.cmbEvent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbEvent_KeyPress);
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
            // dgvSample
            // 
            this.dgvSample.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSample.Location = new System.Drawing.Point(185, 56);
            this.dgvSample.Name = "dgvSample";
            this.dgvSample.Size = new System.Drawing.Size(10, 10);
            this.dgvSample.TabIndex = 155;
            this.dgvSample.Visible = false;
            // 
            // frmESCHED
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
            this.Controls.Add(this.dgvSample);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(90, 250);
            this.Name = "frmESCHED";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.frmEvent_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tsmTITLE.ResumeLayout(false);
            this.tsmTITLE.PerformLayout();
            this.tsmSUBJ.ResumeLayout(false);
            this.tsmSUBJ.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSample)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpFTime;
        private System.Windows.Forms.Label lblTimestarted;
        private System.Windows.Forms.DateTimePicker dtpSTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtPlace;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStrip tsmTITLE;
        private System.Windows.Forms.ToolStripLabel tsmUACCT;
        private System.Windows.Forms.ToolStripButton tsmSTAFFEXIT;
        private System.Windows.Forms.ToolStrip tsmSUBJ;
        private System.Windows.Forms.ToolStripButton tsmSAVE;
        private System.Windows.Forms.DataGridView dgvSample;
        private System.Windows.Forms.ComboBox cmbEvent;
        private System.Windows.Forms.DateTimePicker dtpSDate;
        private System.Windows.Forms.DateTimePicker dtpFDate;
    }
}