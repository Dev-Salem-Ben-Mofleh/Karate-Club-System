namespace KarateClub
{
    partial class frmLisInstructors
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblCountInstructor = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.cbInstructor = new System.Windows.Forms.ComboBox();
            this.txtInstructor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvInstructor = new System.Windows.Forms.DataGridView();
            this.cmInstuctor = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolShowInstructorDetails2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolAddNewInstructor3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolEditInstructor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolDeleteInstructor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolShowtrained = new System.Windows.Forms.ToolStripMenuItem();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAnnNewInstructor = new System.Windows.Forms.Button();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstructor)).BeginInit();
            this.cmInstuctor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCountInstructor
            // 
            this.lblCountInstructor.AutoSize = true;
            this.lblCountInstructor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountInstructor.Location = new System.Drawing.Point(97, 556);
            this.lblCountInstructor.Name = "lblCountInstructor";
            this.lblCountInstructor.Size = new System.Drawing.Size(21, 16);
            this.lblCountInstructor.TabIndex = 171;
            this.lblCountInstructor.Text = "??";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(-5, 552);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(96, 20);
            this.label21.TabIndex = 170;
            this.label21.Text = "# Records:";
            // 
            // cbInstructor
            // 
            this.cbInstructor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInstructor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbInstructor.FormattingEnabled = true;
            this.cbInstructor.Items.AddRange(new object[] {
            "None",
            "Instructor ID",
            "Name",
            "Gender"});
            this.cbInstructor.Location = new System.Drawing.Point(91, 232);
            this.cbInstructor.Name = "cbInstructor";
            this.cbInstructor.Size = new System.Drawing.Size(210, 24);
            this.cbInstructor.TabIndex = 168;
            this.cbInstructor.SelectedIndexChanged += new System.EventHandler(this.cbInstructor_SelectedIndexChanged);
            // 
            // txtInstructor
            // 
            this.txtInstructor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInstructor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInstructor.Location = new System.Drawing.Point(308, 232);
            this.txtInstructor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtInstructor.Name = "txtInstructor";
            this.txtInstructor.Size = new System.Drawing.Size(256, 22);
            this.txtInstructor.TabIndex = 167;
            this.txtInstructor.TextChanged += new System.EventHandler(this.txtInstructor_TextChanged);
            this.txtInstructor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInstructor_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 166;
            this.label5.Text = "Filter By:";
            // 
            // dgvInstructor
            // 
            this.dgvInstructor.AllowUserToAddRows = false;
            this.dgvInstructor.AllowUserToDeleteRows = false;
            this.dgvInstructor.AllowUserToResizeRows = false;
            this.dgvInstructor.BackgroundColor = System.Drawing.Color.White;
            this.dgvInstructor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInstructor.ContextMenuStrip = this.cmInstuctor;
            this.dgvInstructor.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvInstructor.Location = new System.Drawing.Point(7, 260);
            this.dgvInstructor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvInstructor.MultiSelect = false;
            this.dgvInstructor.Name = "dgvInstructor";
            this.dgvInstructor.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInstructor.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInstructor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInstructor.Size = new System.Drawing.Size(1041, 270);
            this.dgvInstructor.TabIndex = 165;
            this.dgvInstructor.TabStop = false;
            // 
            // cmInstuctor
            // 
            this.cmInstuctor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolShowInstructorDetails2,
            this.toolAddNewInstructor3,
            this.toolEditInstructor,
            this.toolDeleteInstructor,
            this.toolShowtrained});
            this.cmInstuctor.Name = "contextMenuStrip1";
            this.cmInstuctor.Size = new System.Drawing.Size(214, 194);
            // 
            // toolShowInstructorDetails2
            // 
            this.toolShowInstructorDetails2.BackColor = System.Drawing.Color.Black;
            this.toolShowInstructorDetails2.ForeColor = System.Drawing.Color.White;
            this.toolShowInstructorDetails2.Image = global::KarateClub.Properties.Resources.PersonDetails_32;
            this.toolShowInstructorDetails2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolShowInstructorDetails2.Name = "toolShowInstructorDetails2";
            this.toolShowInstructorDetails2.Size = new System.Drawing.Size(213, 38);
            this.toolShowInstructorDetails2.Text = "&Show Instructor Details";
            this.toolShowInstructorDetails2.Click += new System.EventHandler(this.toolShowInstructorDetails2_Click);
            // 
            // toolAddNewInstructor3
            // 
            this.toolAddNewInstructor3.BackColor = System.Drawing.Color.Black;
            this.toolAddNewInstructor3.ForeColor = System.Drawing.Color.White;
            this.toolAddNewInstructor3.Image = global::KarateClub.Properties.Resources.AddPerson_32;
            this.toolAddNewInstructor3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolAddNewInstructor3.Name = "toolAddNewInstructor3";
            this.toolAddNewInstructor3.Size = new System.Drawing.Size(213, 38);
            this.toolAddNewInstructor3.Text = "Add &New Instructor";
            this.toolAddNewInstructor3.Click += new System.EventHandler(this.toolAddNewInstructor3_Click);
            // 
            // toolEditInstructor
            // 
            this.toolEditInstructor.BackColor = System.Drawing.Color.Black;
            this.toolEditInstructor.ForeColor = System.Drawing.Color.White;
            this.toolEditInstructor.Image = global::KarateClub.Properties.Resources.edit_32;
            this.toolEditInstructor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolEditInstructor.Name = "toolEditInstructor";
            this.toolEditInstructor.Size = new System.Drawing.Size(213, 38);
            this.toolEditInstructor.Text = "&Edit";
            this.toolEditInstructor.Click += new System.EventHandler(this.toolEditInstructor_Click);
            // 
            // toolDeleteInstructor
            // 
            this.toolDeleteInstructor.BackColor = System.Drawing.Color.Black;
            this.toolDeleteInstructor.ForeColor = System.Drawing.Color.White;
            this.toolDeleteInstructor.Image = global::KarateClub.Properties.Resources.Delete_32;
            this.toolDeleteInstructor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolDeleteInstructor.Name = "toolDeleteInstructor";
            this.toolDeleteInstructor.Size = new System.Drawing.Size(213, 38);
            this.toolDeleteInstructor.Text = "&Delete";
            this.toolDeleteInstructor.Click += new System.EventHandler(this.toolDeleteInstructor_Click);
            // 
            // toolShowtrained
            // 
            this.toolShowtrained.BackColor = System.Drawing.Color.Black;
            this.toolShowtrained.ForeColor = System.Drawing.Color.White;
            this.toolShowtrained.Image = global::KarateClub.Properties.Resources.Calendar_32;
            this.toolShowtrained.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolShowtrained.Name = "toolShowtrained";
            this.toolShowtrained.Size = new System.Drawing.Size(213, 38);
            this.toolShowtrained.Text = "&Show Trained Members";
            this.toolShowtrained.Click += new System.EventHandler(this.toolShowtrained_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label6.Location = new System.Drawing.Point(417, 128);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(292, 37);
            this.label6.TabIndex = 164;
            this.label6.Text = "Manage Insturctor";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAnnNewInstructor
            // 
            this.btnAnnNewInstructor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnNewInstructor.Image = global::KarateClub.Properties.Resources.Add_Person_72;
            this.btnAnnNewInstructor.Location = new System.Drawing.Point(959, 179);
            this.btnAnnNewInstructor.Name = "btnAnnNewInstructor";
            this.btnAnnNewInstructor.Size = new System.Drawing.Size(88, 75);
            this.btnAnnNewInstructor.TabIndex = 169;
            this.btnAnnNewInstructor.UseVisualStyleBackColor = true;
            this.btnAnnNewInstructor.Click += new System.EventHandler(this.btnAnnNewInstructor_Click);
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Image = global::KarateClub.Properties.Resources.taekwondo__4_;
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(459, 13);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(179, 113);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox2.TabIndex = 163;
            this.guna2PictureBox2.TabStop = false;
            // 
            // frmLisInstructors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1061, 607);
            this.Controls.Add(this.lblCountInstructor);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.cbInstructor);
            this.Controls.Add(this.txtInstructor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvInstructor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAnnNewInstructor);
            this.Controls.Add(this.guna2PictureBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLisInstructors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLisInstructors";
            this.Load += new System.EventHandler(this.frmLisInstructors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstructor)).EndInit();
            this.cmInstuctor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCountInstructor;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox cbInstructor;
        private System.Windows.Forms.TextBox txtInstructor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvInstructor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAnnNewInstructor;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private System.Windows.Forms.ContextMenuStrip cmInstuctor;
        private System.Windows.Forms.ToolStripMenuItem toolShowInstructorDetails2;
        private System.Windows.Forms.ToolStripMenuItem toolAddNewInstructor3;
        private System.Windows.Forms.ToolStripMenuItem toolEditInstructor;
        private System.Windows.Forms.ToolStripMenuItem toolDeleteInstructor;
        private System.Windows.Forms.ToolStripMenuItem toolShowtrained;
    }
}