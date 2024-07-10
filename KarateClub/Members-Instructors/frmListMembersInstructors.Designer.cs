namespace KarateClub
{
    partial class frmListMembersInstructors
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblCountMemberInstructor = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.cbMemberInstructor = new System.Windows.Forms.ComboBox();
            this.txbMemberInstructor = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvMemberInstructor = new System.Windows.Forms.DataGridView();
            this.cmMembersInstructors = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolShowMemberInstructor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolAddMemberInstructor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolEditMemberInstructor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolDeleteMemberInstructor = new System.Windows.Forms.ToolStripMenuItem();
            this.label13 = new System.Windows.Forms.Label();
            this.btnAddMemberInstructor = new System.Windows.Forms.Button();
            this.guna2PictureBox4 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberInstructor)).BeginInit();
            this.cmMembersInstructors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCountMemberInstructor
            // 
            this.lblCountMemberInstructor.AutoSize = true;
            this.lblCountMemberInstructor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountMemberInstructor.Location = new System.Drawing.Point(100, 569);
            this.lblCountMemberInstructor.Name = "lblCountMemberInstructor";
            this.lblCountMemberInstructor.Size = new System.Drawing.Size(21, 16);
            this.lblCountMemberInstructor.TabIndex = 171;
            this.lblCountMemberInstructor.Text = "??";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(-2, 566);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(96, 20);
            this.label23.TabIndex = 170;
            this.label23.Text = "# Records:";
            // 
            // cbMemberInstructor
            // 
            this.cbMemberInstructor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMemberInstructor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMemberInstructor.FormattingEnabled = true;
            this.cbMemberInstructor.Items.AddRange(new object[] {
            "None",
            "Member-Instructor ID",
            "Member Name",
            "Instructor Name"});
            this.cbMemberInstructor.Location = new System.Drawing.Point(74, 239);
            this.cbMemberInstructor.Name = "cbMemberInstructor";
            this.cbMemberInstructor.Size = new System.Drawing.Size(210, 24);
            this.cbMemberInstructor.TabIndex = 168;
            this.cbMemberInstructor.SelectedIndexChanged += new System.EventHandler(this.cbMemberInstructor_SelectedIndexChanged);
            // 
            // txbMemberInstructor
            // 
            this.txbMemberInstructor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbMemberInstructor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMemberInstructor.Location = new System.Drawing.Point(291, 239);
            this.txbMemberInstructor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbMemberInstructor.Name = "txbMemberInstructor";
            this.txbMemberInstructor.Size = new System.Drawing.Size(256, 22);
            this.txbMemberInstructor.TabIndex = 167;
            this.txbMemberInstructor.TextChanged += new System.EventHandler(this.txbMemberInstructor_TextChanged);
            this.txbMemberInstructor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbMemberInstructor_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(-2, 242);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 20);
            this.label11.TabIndex = 166;
            this.label11.Text = "Filter By:";
            // 
            // dgvMemberInstructor
            // 
            this.dgvMemberInstructor.AllowUserToAddRows = false;
            this.dgvMemberInstructor.AllowUserToDeleteRows = false;
            this.dgvMemberInstructor.AllowUserToResizeRows = false;
            this.dgvMemberInstructor.BackgroundColor = System.Drawing.Color.White;
            this.dgvMemberInstructor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMemberInstructor.ContextMenuStrip = this.cmMembersInstructors;
            this.dgvMemberInstructor.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvMemberInstructor.Location = new System.Drawing.Point(2, 275);
            this.dgvMemberInstructor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvMemberInstructor.MultiSelect = false;
            this.dgvMemberInstructor.Name = "dgvMemberInstructor";
            this.dgvMemberInstructor.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMemberInstructor.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMemberInstructor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMemberInstructor.Size = new System.Drawing.Size(1056, 270);
            this.dgvMemberInstructor.TabIndex = 165;
            this.dgvMemberInstructor.TabStop = false;
            // 
            // cmMembersInstructors
            // 
            this.cmMembersInstructors.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolShowMemberInstructor,
            this.toolAddMemberInstructor,
            this.toolEditMemberInstructor,
            this.toolDeleteMemberInstructor});
            this.cmMembersInstructors.Name = "contextMenuStrip1";
            this.cmMembersInstructors.Size = new System.Drawing.Size(197, 178);
            // 
            // toolShowMemberInstructor
            // 
            this.toolShowMemberInstructor.BackColor = System.Drawing.Color.Black;
            this.toolShowMemberInstructor.ForeColor = System.Drawing.Color.White;
            this.toolShowMemberInstructor.Image = global::KarateClub.Properties.Resources.PersonDetails_32;
            this.toolShowMemberInstructor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolShowMemberInstructor.Name = "toolShowMemberInstructor";
            this.toolShowMemberInstructor.Size = new System.Drawing.Size(196, 38);
            this.toolShowMemberInstructor.Text = "&Show  Details";
            this.toolShowMemberInstructor.Click += new System.EventHandler(this.toolShowMemberInstructor_Click);
            // 
            // toolAddMemberInstructor
            // 
            this.toolAddMemberInstructor.BackColor = System.Drawing.Color.Black;
            this.toolAddMemberInstructor.ForeColor = System.Drawing.Color.White;
            this.toolAddMemberInstructor.Image = global::KarateClub.Properties.Resources.AddPerson_32;
            this.toolAddMemberInstructor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolAddMemberInstructor.Name = "toolAddMemberInstructor";
            this.toolAddMemberInstructor.Size = new System.Drawing.Size(196, 38);
            this.toolAddMemberInstructor.Text = "Add &New ";
            this.toolAddMemberInstructor.Click += new System.EventHandler(this.toolAddMemberInstructor_Click);
            // 
            // toolEditMemberInstructor
            // 
            this.toolEditMemberInstructor.BackColor = System.Drawing.Color.Black;
            this.toolEditMemberInstructor.ForeColor = System.Drawing.Color.White;
            this.toolEditMemberInstructor.Image = global::KarateClub.Properties.Resources.edit_32;
            this.toolEditMemberInstructor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolEditMemberInstructor.Name = "toolEditMemberInstructor";
            this.toolEditMemberInstructor.Size = new System.Drawing.Size(196, 38);
            this.toolEditMemberInstructor.Text = "&Edit";
            this.toolEditMemberInstructor.Click += new System.EventHandler(this.toolEditMemberInstructor_Click);
            // 
            // toolDeleteMemberInstructor
            // 
            this.toolDeleteMemberInstructor.BackColor = System.Drawing.Color.Black;
            this.toolDeleteMemberInstructor.ForeColor = System.Drawing.Color.White;
            this.toolDeleteMemberInstructor.Image = global::KarateClub.Properties.Resources.Delete_32;
            this.toolDeleteMemberInstructor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolDeleteMemberInstructor.Name = "toolDeleteMemberInstructor";
            this.toolDeleteMemberInstructor.Size = new System.Drawing.Size(196, 38);
            this.toolDeleteMemberInstructor.Text = "&Delete";
            this.toolDeleteMemberInstructor.Click += new System.EventHandler(this.toolDeleteMemberInstructor_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label13.Location = new System.Drawing.Point(327, 138);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(425, 37);
            this.label13.TabIndex = 164;
            this.label13.Text = "Manage Member-Instructor";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddMemberInstructor
            // 
            this.btnAddMemberInstructor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMemberInstructor.Image = global::KarateClub.Properties.Resources.Add_Person_72;
            this.btnAddMemberInstructor.Location = new System.Drawing.Point(970, 192);
            this.btnAddMemberInstructor.Name = "btnAddMemberInstructor";
            this.btnAddMemberInstructor.Size = new System.Drawing.Size(88, 75);
            this.btnAddMemberInstructor.TabIndex = 169;
            this.btnAddMemberInstructor.UseVisualStyleBackColor = true;
            this.btnAddMemberInstructor.Click += new System.EventHandler(this.btnAddMemberInstructor_Click);
            // 
            // guna2PictureBox4
            // 
            this.guna2PictureBox4.Image = global::KarateClub.Properties.Resources.staff_management;
            this.guna2PictureBox4.ImageRotate = 0F;
            this.guna2PictureBox4.Location = new System.Drawing.Point(443, 20);
            this.guna2PictureBox4.Name = "guna2PictureBox4";
            this.guna2PictureBox4.Size = new System.Drawing.Size(179, 113);
            this.guna2PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox4.TabIndex = 163;
            this.guna2PictureBox4.TabStop = false;
            // 
            // frmListMembersInstructors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1061, 607);
            this.Controls.Add(this.lblCountMemberInstructor);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.cbMemberInstructor);
            this.Controls.Add(this.txbMemberInstructor);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dgvMemberInstructor);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnAddMemberInstructor);
            this.Controls.Add(this.guna2PictureBox4);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListMembersInstructors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmListMembersInstructors";
            this.Load += new System.EventHandler(this.frmListMembersInstructors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberInstructor)).EndInit();
            this.cmMembersInstructors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCountMemberInstructor;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox cbMemberInstructor;
        private System.Windows.Forms.TextBox txbMemberInstructor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgvMemberInstructor;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnAddMemberInstructor;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox4;
        private System.Windows.Forms.ContextMenuStrip cmMembersInstructors;
        private System.Windows.Forms.ToolStripMenuItem toolShowMemberInstructor;
        private System.Windows.Forms.ToolStripMenuItem toolAddMemberInstructor;
        private System.Windows.Forms.ToolStripMenuItem toolEditMemberInstructor;
        private System.Windows.Forms.ToolStripMenuItem toolDeleteMemberInstructor;
    }
}