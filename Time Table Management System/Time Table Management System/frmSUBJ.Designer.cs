namespace Time_Table_Management_System
{
    partial class frmSUBJ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSUBJ));
            this.tsmSUBJ = new System.Windows.Forms.ToolStrip();
            this.tsmSUBJSAVE = new System.Windows.Forms.ToolStripButton();
            this.tsmDEL = new System.Windows.Forms.ToolStripButton();
            this.lblREQSUBJN = new System.Windows.Forms.Label();
            this.txtSUBJN = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.tsmSUBJTITLE = new System.Windows.Forms.ToolStrip();
            this.tsmUACCTUPROF = new System.Windows.Forms.ToolStripLabel();
            this.tsmUACCTEXIT = new System.Windows.Forms.ToolStripButton();
            this.tsmSUBJ.SuspendLayout();
            this.tsmSUBJTITLE.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsmSUBJ
            // 
            this.tsmSUBJ.BackColor = System.Drawing.Color.Gainsboro;
            this.tsmSUBJ.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsmSUBJ.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSUBJSAVE,
            this.tsmDEL});
            this.tsmSUBJ.Location = new System.Drawing.Point(0, 46);
            this.tsmSUBJ.Margin = new System.Windows.Forms.Padding(2);
            this.tsmSUBJ.Name = "tsmSUBJ";
            this.tsmSUBJ.Padding = new System.Windows.Forms.Padding(2);
            this.tsmSUBJ.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsmSUBJ.Size = new System.Drawing.Size(421, 33);
            this.tsmSUBJ.TabIndex = 112;
            this.tsmSUBJ.Text = "toolStrip1";
            // 
            // tsmSUBJSAVE
            // 
            this.tsmSUBJSAVE.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold);
            this.tsmSUBJSAVE.Image = ((System.Drawing.Image)(resources.GetObject("tsmSUBJSAVE.Image")));
            this.tsmSUBJSAVE.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmSUBJSAVE.Margin = new System.Windows.Forms.Padding(5, 2, 2, 2);
            this.tsmSUBJSAVE.Name = "tsmSUBJSAVE";
            this.tsmSUBJSAVE.Padding = new System.Windows.Forms.Padding(2);
            this.tsmSUBJSAVE.Size = new System.Drawing.Size(66, 25);
            this.tsmSUBJSAVE.Text = "Save";
            this.tsmSUBJSAVE.Click += new System.EventHandler(this.tsmSUBJSAVE_Click);
            // 
            // tsmDEL
            // 
            this.tsmDEL.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsmDEL.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmDEL.Image = ((System.Drawing.Image)(resources.GetObject("tsmDEL.Image")));
            this.tsmDEL.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmDEL.Margin = new System.Windows.Forms.Padding(2, 2, 5, 2);
            this.tsmDEL.Name = "tsmDEL";
            this.tsmDEL.Padding = new System.Windows.Forms.Padding(2);
            this.tsmDEL.Size = new System.Drawing.Size(78, 25);
            this.tsmDEL.Text = "Delete";
            this.tsmDEL.Click += new System.EventHandler(this.tsmDEL_Click);
            // 
            // lblREQSUBJN
            // 
            this.lblREQSUBJN.AutoSize = true;
            this.lblREQSUBJN.BackColor = System.Drawing.Color.Red;
            this.lblREQSUBJN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblREQSUBJN.ForeColor = System.Drawing.SystemColors.Window;
            this.lblREQSUBJN.Location = new System.Drawing.Point(322, 139);
            this.lblREQSUBJN.Name = "lblREQSUBJN";
            this.lblREQSUBJN.Size = new System.Drawing.Size(56, 13);
            this.lblREQSUBJN.TabIndex = 110;
            this.lblREQSUBJN.Text = "(Required)";
            this.lblREQSUBJN.Visible = false;
            // 
            // txtSUBJN
            // 
            this.txtSUBJN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSUBJN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSUBJN.Location = new System.Drawing.Point(135, 109);
            this.txtSUBJN.Margin = new System.Windows.Forms.Padding(4);
            this.txtSUBJN.MaxLength = 40;
            this.txtSUBJN.Name = "txtSUBJN";
            this.txtSUBJN.Size = new System.Drawing.Size(243, 26);
            this.txtSUBJN.TabIndex = 109;
            this.txtSUBJN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSUBJ_KeyPress);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label19.Location = new System.Drawing.Point(47, 112);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(80, 20);
            this.label19.TabIndex = 108;
            this.label19.Text = "Subject :";
            // 
            // tsmSUBJTITLE
            // 
            this.tsmSUBJTITLE.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tsmSUBJTITLE.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsmSUBJTITLE.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.tsmSUBJTITLE.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmUACCTUPROF,
            this.tsmUACCTEXIT});
            this.tsmSUBJTITLE.Location = new System.Drawing.Point(0, 0);
            this.tsmSUBJTITLE.Margin = new System.Windows.Forms.Padding(2);
            this.tsmSUBJTITLE.Name = "tsmSUBJTITLE";
            this.tsmSUBJTITLE.Padding = new System.Windows.Forms.Padding(2);
            this.tsmSUBJTITLE.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsmSUBJTITLE.Size = new System.Drawing.Size(421, 46);
            this.tsmSUBJTITLE.TabIndex = 111;
            this.tsmSUBJTITLE.Text = "toolStrip1";
            // 
            // tsmUACCTUPROF
            // 
            this.tsmUACCTUPROF.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Bold);
            this.tsmUACCTUPROF.ForeColor = System.Drawing.SystemColors.Control;
            this.tsmUACCTUPROF.Image = ((System.Drawing.Image)(resources.GetObject("tsmUACCTUPROF.Image")));
            this.tsmUACCTUPROF.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmUACCTUPROF.Margin = new System.Windows.Forms.Padding(2);
            this.tsmUACCTUPROF.Name = "tsmUACCTUPROF";
            this.tsmUACCTUPROF.Padding = new System.Windows.Forms.Padding(2);
            this.tsmUACCTUPROF.Size = new System.Drawing.Size(131, 38);
            this.tsmUACCTUPROF.Text = "Subject";
            // 
            // tsmUACCTEXIT
            // 
            this.tsmUACCTEXIT.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsmUACCTEXIT.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.tsmUACCTEXIT.Image = ((System.Drawing.Image)(resources.GetObject("tsmUACCTEXIT.Image")));
            this.tsmUACCTEXIT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmUACCTEXIT.Margin = new System.Windows.Forms.Padding(2);
            this.tsmUACCTEXIT.Name = "tsmUACCTEXIT";
            this.tsmUACCTEXIT.Padding = new System.Windows.Forms.Padding(2);
            this.tsmUACCTEXIT.Size = new System.Drawing.Size(38, 38);
            this.tsmUACCTEXIT.Click += new System.EventHandler(this.tsmUACCTEXIT_Click);
            // 
            // frmSUBJ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(421, 174);
            this.Controls.Add(this.tsmSUBJ);
            this.Controls.Add(this.lblREQSUBJN);
            this.Controls.Add(this.txtSUBJN);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.tsmSUBJTITLE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSUBJ";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.frmSUBJ_Load);
            this.tsmSUBJ.ResumeLayout(false);
            this.tsmSUBJ.PerformLayout();
            this.tsmSUBJTITLE.ResumeLayout(false);
            this.tsmSUBJTITLE.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsmSUBJ;
        private System.Windows.Forms.ToolStripButton tsmSUBJSAVE;
        private System.Windows.Forms.Label lblREQSUBJN;
        private System.Windows.Forms.TextBox txtSUBJN;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ToolStrip tsmSUBJTITLE;
        private System.Windows.Forms.ToolStripLabel tsmUACCTUPROF;
        private System.Windows.Forms.ToolStripButton tsmUACCTEXIT;
        private System.Windows.Forms.ToolStripButton tsmDEL;
    }
}