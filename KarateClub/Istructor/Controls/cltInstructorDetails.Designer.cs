namespace KarateClub
{
    partial class cltInstructorDetails
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.lblQualifiction = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lblInstructorID = new System.Windows.Forms.Label();
            this.llEditInstrunctorInfo = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cltPersonInformation1 = new KarateClub.cltPersonInformation();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(333, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 167;
            this.label3.Text = "Qualifiction:";
            // 
            // lblQualifiction
            // 
            this.lblQualifiction.AutoSize = true;
            this.lblQualifiction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQualifiction.Location = new System.Drawing.Point(482, 34);
            this.lblQualifiction.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQualifiction.Name = "lblQualifiction";
            this.lblQualifiction.Size = new System.Drawing.Size(53, 20);
            this.lblQualifiction.TabIndex = 165;
            this.lblQualifiction.Text = "[????]";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(7, 34);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(121, 20);
            this.label22.TabIndex = 162;
            this.label22.Text = "Instructor ID :";
            // 
            // lblInstructorID
            // 
            this.lblInstructorID.AutoSize = true;
            this.lblInstructorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructorID.Location = new System.Drawing.Point(172, 34);
            this.lblInstructorID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInstructorID.Name = "lblInstructorID";
            this.lblInstructorID.Size = new System.Drawing.Size(53, 20);
            this.lblInstructorID.TabIndex = 164;
            this.lblInstructorID.Text = "[????]";
            // 
            // llEditInstrunctorInfo
            // 
            this.llEditInstrunctorInfo.AutoSize = true;
            this.llEditInstrunctorInfo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llEditInstrunctorInfo.Location = new System.Drawing.Point(609, 65);
            this.llEditInstrunctorInfo.Name = "llEditInstrunctorInfo";
            this.llEditInstrunctorInfo.Size = new System.Drawing.Size(144, 19);
            this.llEditInstrunctorInfo.TabIndex = 168;
            this.llEditInstrunctorInfo.TabStop = true;
            this.llEditInstrunctorInfo.Text = "Edit Instructor Info";
            this.llEditInstrunctorInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llEditInstrunctorInfo_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.llEditInstrunctorInfo);
            this.groupBox1.Controls.Add(this.lblQualifiction);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblInstructorID);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 252);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(831, 101);
            this.groupBox1.TabIndex = 169;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Instructor Information";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::KarateClub.Properties.Resources.certificate;
            this.pictureBox2.Location = new System.Drawing.Point(444, 34);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 163;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KarateClub.Properties.Resources.id__1_;
            this.pictureBox1.Location = new System.Drawing.Point(131, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 166;
            this.pictureBox1.TabStop = false;
            // 
            // cltPersonInformation1
            // 
            this.cltPersonInformation1.BackColor = System.Drawing.Color.White;
            this.cltPersonInformation1.Location = new System.Drawing.Point(3, 3);
            this.cltPersonInformation1.Name = "cltPersonInformation1";
            this.cltPersonInformation1.Size = new System.Drawing.Size(835, 252);
            this.cltPersonInformation1.TabIndex = 170;
            // 
            // cltInstructorDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.cltPersonInformation1);
            this.Controls.Add(this.groupBox1);
            this.Name = "cltInstructorDetails";
            this.Size = new System.Drawing.Size(837, 357);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblQualifiction;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lblInstructorID;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.LinkLabel llEditInstrunctorInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private cltPersonInformation cltPersonInformation1;
    }
}
