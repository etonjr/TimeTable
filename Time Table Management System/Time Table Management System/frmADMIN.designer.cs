namespace Time_Table_Management_System
{
    partial class frmADMIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmADMIN));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pbxUPIC = new System.Windows.Forms.PictureBox();
            this.lblUNAME = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUID = new System.Windows.Forms.Label();
            this.tsmTITLE = new System.Windows.Forms.ToolStrip();
            this.tsmUACCT = new System.Windows.Forms.ToolStripLabel();
            this.tsmSTAFFEXIT = new System.Windows.Forms.ToolStripButton();
            this.tsmSTAFF = new System.Windows.Forms.ToolStrip();
            this.tsmADD = new System.Windows.Forms.ToolStripButton();
            this.tsmEDIT = new System.Windows.Forms.ToolStripButton();
            this.tsmDEL = new System.Windows.Forms.ToolStripButton();
            this.dgvADMIN = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUPIC)).BeginInit();
            this.tsmTITLE.SuspendLayout();
            this.tsmSTAFF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvADMIN)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxUPIC
            // 
            this.pbxUPIC.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxUPIC.BackgroundImage")));
            this.pbxUPIC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxUPIC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxUPIC.Location = new System.Drawing.Point(20, 114);
            this.pbxUPIC.Margin = new System.Windows.Forms.Padding(4);
            this.pbxUPIC.Name = "pbxUPIC";
            this.pbxUPIC.Size = new System.Drawing.Size(105, 104);
            this.pbxUPIC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxUPIC.TabIndex = 95;
            this.pbxUPIC.TabStop = false;
            // 
            // lblUNAME
            // 
            this.lblUNAME.AutoSize = true;
            this.lblUNAME.BackColor = System.Drawing.Color.Transparent;
            this.lblUNAME.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUNAME.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblUNAME.Location = new System.Drawing.Point(137, 177);
            this.lblUNAME.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUNAME.Name = "lblUNAME";
            this.lblUNAME.Size = new System.Drawing.Size(120, 19);
            this.lblUNAME.TabIndex = 94;
            this.lblUNAME.Text = "LOGIN PERSON";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Red;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(131, 156);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(4, 62);
            this.label4.TabIndex = 93;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Red;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(135, 201);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(500, 4);
            this.label3.TabIndex = 92;
            // 
            // lblUID
            // 
            this.lblUID.AutoSize = true;
            this.lblUID.Location = new System.Drawing.Point(132, 132);
            this.lblUID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUID.Name = "lblUID";
            this.lblUID.Size = new System.Drawing.Size(0, 17);
            this.lblUID.TabIndex = 90;
            // 
            // tsmTITLE
            // 
            this.tsmTITLE.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tsmTITLE.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tsmTITLE.BackgroundImage")));
            this.tsmTITLE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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
            this.tsmTITLE.Size = new System.Drawing.Size(654, 42);
            this.tsmTITLE.TabIndex = 96;
            // 
            // tsmUACCT
            // 
            this.tsmUACCT.BackColor = System.Drawing.Color.Transparent;
            this.tsmUACCT.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.tsmUACCT.ForeColor = System.Drawing.SystemColors.Control;
            this.tsmUACCT.Image = ((System.Drawing.Image)(resources.GetObject("tsmUACCT.Image")));
            this.tsmUACCT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmUACCT.Margin = new System.Windows.Forms.Padding(2);
            this.tsmUACCT.Name = "tsmUACCT";
            this.tsmUACCT.Padding = new System.Windows.Forms.Padding(2);
            this.tsmUACCT.Size = new System.Drawing.Size(185, 34);
            this.tsmUACCT.Text = "User Account";
            // 
            // tsmSTAFFEXIT
            // 
            this.tsmSTAFFEXIT.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsmSTAFFEXIT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsmSTAFFEXIT.Image = ((System.Drawing.Image)(resources.GetObject("tsmSTAFFEXIT.Image")));
            this.tsmSTAFFEXIT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmSTAFFEXIT.Name = "tsmSTAFFEXIT";
            this.tsmSTAFFEXIT.Size = new System.Drawing.Size(34, 35);
            this.tsmSTAFFEXIT.Click += new System.EventHandler(this.tsmADEXIT_Click);
            // 
            // tsmSTAFF
            // 
            this.tsmSTAFF.BackColor = System.Drawing.Color.Gainsboro;
            this.tsmSTAFF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsmSTAFF.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tsmSTAFF.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsmSTAFF.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsmSTAFF.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmADD,
            this.tsmEDIT,
            this.tsmDEL});
            this.tsmSTAFF.Location = new System.Drawing.Point(0, 42);
            this.tsmSTAFF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tsmSTAFF.Name = "tsmSTAFF";
            this.tsmSTAFF.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tsmSTAFF.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsmSTAFF.Size = new System.Drawing.Size(654, 36);
            this.tsmSTAFF.TabIndex = 97;
            // 
            // tsmADD
            // 
            this.tsmADD.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold);
            this.tsmADD.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tsmADD.Image = ((System.Drawing.Image)(resources.GetObject("tsmADD.Image")));
            this.tsmADD.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmADD.Margin = new System.Windows.Forms.Padding(5, 2, 2, 2);
            this.tsmADD.Name = "tsmADD";
            this.tsmADD.Padding = new System.Windows.Forms.Padding(2);
            this.tsmADD.Size = new System.Drawing.Size(65, 28);
            this.tsmADD.Text = "Add";
            this.tsmADD.Click += new System.EventHandler(this.tsmADD_Click);
            // 
            // tsmEDIT
            // 
            this.tsmEDIT.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold);
            this.tsmEDIT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tsmEDIT.Image = ((System.Drawing.Image)(resources.GetObject("tsmEDIT.Image")));
            this.tsmEDIT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmEDIT.Margin = new System.Windows.Forms.Padding(5, 2, 2, 2);
            this.tsmEDIT.Name = "tsmEDIT";
            this.tsmEDIT.Padding = new System.Windows.Forms.Padding(2);
            this.tsmEDIT.Size = new System.Drawing.Size(66, 28);
            this.tsmEDIT.Text = "Edit";
            this.tsmEDIT.Click += new System.EventHandler(this.tsmEDIT_Click);
            // 
            // tsmDEL
            // 
            this.tsmDEL.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold);
            this.tsmDEL.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tsmDEL.Image = ((System.Drawing.Image)(resources.GetObject("tsmDEL.Image")));
            this.tsmDEL.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmDEL.Margin = new System.Windows.Forms.Padding(5, 2, 2, 2);
            this.tsmDEL.Name = "tsmDEL";
            this.tsmDEL.Padding = new System.Windows.Forms.Padding(2);
            this.tsmDEL.Size = new System.Drawing.Size(82, 28);
            this.tsmDEL.Text = "Delete";
            this.tsmDEL.Click += new System.EventHandler(this.tsmDEL_Click);
            // 
            // dgvADMIN
            // 
            this.dgvADMIN.AllowUserToAddRows = false;
            this.dgvADMIN.AllowUserToDeleteRows = false;
            this.dgvADMIN.AllowUserToResizeRows = false;
            this.dgvADMIN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvADMIN.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvADMIN.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvADMIN.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvADMIN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Tan;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvADMIN.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvADMIN.EnableHeadersVisualStyles = false;
            this.dgvADMIN.Location = new System.Drawing.Point(20, 242);
            this.dgvADMIN.MultiSelect = false;
            this.dgvADMIN.Name = "dgvADMIN";
            this.dgvADMIN.ReadOnly = true;
            this.dgvADMIN.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvADMIN.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvADMIN.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvADMIN.RowTemplate.Height = 25;
            this.dgvADMIN.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvADMIN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvADMIN.Size = new System.Drawing.Size(615, 164);
            this.dgvADMIN.TabIndex = 98;
            this.dgvADMIN.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvADMIN_RowEnter);
            // 
            // frmADMIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Tan;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(654, 418);
            this.ControlBox = false;
            this.Controls.Add(this.dgvADMIN);
            this.Controls.Add(this.tsmSTAFF);
            this.Controls.Add(this.tsmTITLE);
            this.Controls.Add(this.pbxUPIC);
            this.Controls.Add(this.lblUNAME);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblUID);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmADMIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmADMIN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxUPIC)).EndInit();
            this.tsmTITLE.ResumeLayout(false);
            this.tsmTITLE.PerformLayout();
            this.tsmSTAFF.ResumeLayout(false);
            this.tsmSTAFF.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvADMIN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxUPIC;
        private System.Windows.Forms.Label lblUNAME;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblUID;
        private System.Windows.Forms.ToolStrip tsmTITLE;
        private System.Windows.Forms.ToolStripButton tsmSTAFFEXIT;
        private System.Windows.Forms.ToolStrip tsmSTAFF;
        private System.Windows.Forms.ToolStripButton tsmDEL;
        private System.Windows.Forms.ToolStripButton tsmADD;
        private System.Windows.Forms.ToolStripButton tsmEDIT;
        private System.Windows.Forms.ToolStripLabel tsmUACCT;
        private System.Windows.Forms.DataGridView dgvADMIN;


    }
}