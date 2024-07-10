namespace KarateClub
{
    partial class frmShowTrainedMembers
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClosefrom = new System.Windows.Forms.Button();
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.ctlTrainedHistory1 = new KarateClub.ctlTrainedHistory();
            this.cltInstructorDetails1 = new KarateClub.cltInstructorDetails();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblTitle.Location = new System.Drawing.Point(5, 19);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(726, 53);
            this.lblTitle.TabIndex = 161;
            this.lblTitle.Text = "Trained Member By Instructor";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::KarateClub.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(620, 624);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(126, 37);
            this.btnClose.TabIndex = 165;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.btnClosefrom);
            this.panel1.Controls.Add(this.btnCloseForm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 31);
            this.panel1.TabIndex = 166;
            // 
            // btnClosefrom
            // 
            this.btnClosefrom.BackColor = System.Drawing.Color.Transparent;
            this.btnClosefrom.FlatAppearance.BorderSize = 0;
            this.btnClosefrom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClosefrom.ForeColor = System.Drawing.Color.White;
            this.btnClosefrom.Location = new System.Drawing.Point(826, 5);
            this.btnClosefrom.Name = "btnClosefrom";
            this.btnClosefrom.Size = new System.Drawing.Size(21, 23);
            this.btnClosefrom.TabIndex = 163;
            this.btnClosefrom.Text = "X";
            this.btnClosefrom.UseVisualStyleBackColor = false;
            this.btnClosefrom.Click += new System.EventHandler(this.btnClosefrom_Click);
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseForm.FlatAppearance.BorderSize = 0;
            this.btnCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseForm.ForeColor = System.Drawing.Color.White;
            this.btnCloseForm.Location = new System.Drawing.Point(971, 3);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(21, 23);
            this.btnCloseForm.TabIndex = 162;
            this.btnCloseForm.Text = "X";
            this.btnCloseForm.UseVisualStyleBackColor = false;
            // 
            // ctlTrainedHistory1
            // 
            this.ctlTrainedHistory1.BackColor = System.Drawing.Color.White;
            this.ctlTrainedHistory1.Location = new System.Drawing.Point(12, 420);
            this.ctlTrainedHistory1.Name = "ctlTrainedHistory1";
            this.ctlTrainedHistory1.Size = new System.Drawing.Size(742, 209);
            this.ctlTrainedHistory1.TabIndex = 167;
            // 
            // cltInstructorDetails1
            // 
            this.cltInstructorDetails1.BackColor = System.Drawing.Color.White;
            this.cltInstructorDetails1.Location = new System.Drawing.Point(12, 66);
            this.cltInstructorDetails1.Name = "cltInstructorDetails1";
            this.cltInstructorDetails1.Size = new System.Drawing.Size(838, 359);
            this.cltInstructorDetails1.TabIndex = 163;
            // 
            // frmShowTrainedMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(850, 668);
            this.Controls.Add(this.ctlTrainedHistory1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.cltInstructorDetails1);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmShowTrainedMembers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmShowTrainedMembers_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private cltInstructorDetails cltInstructorDetails1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClosefrom;
        private System.Windows.Forms.Button btnCloseForm;
        private ctlTrainedHistory ctlTrainedHistory1;
    }
}