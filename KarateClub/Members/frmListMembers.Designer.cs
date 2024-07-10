namespace KarateClub
{
    partial class frmListMembers
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
            this.cbFilterByMemebr = new System.Windows.Forms.ComboBox();
            this.txtFilterValueMember = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRecordsCountMemeber = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvMembers = new System.Windows.Forms.DataGridView();
            this.cmsPeople = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMemberTakeNextBeltTest = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMemberPeriod = new System.Windows.Forms.ToolStripMenuItem();
            this.showMemberPeriodHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddNewMember = new System.Windows.Forms.Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.cbIsActive = new System.Windows.Forms.ComboBox();
            this.cbRankName = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).BeginInit();
            this.cmsPeople.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbFilterByMemebr
            // 
            this.cbFilterByMemebr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterByMemebr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterByMemebr.FormattingEnabled = true;
            this.cbFilterByMemebr.Items.AddRange(new object[] {
            "None",
            "Member ID",
            "Name",
            "Rank Name",
            "Phone",
            "Is Active"});
            this.cbFilterByMemebr.Location = new System.Drawing.Point(102, 229);
            this.cbFilterByMemebr.Name = "cbFilterByMemebr";
            this.cbFilterByMemebr.Size = new System.Drawing.Size(210, 24);
            this.cbFilterByMemebr.TabIndex = 161;
            this.cbFilterByMemebr.SelectedIndexChanged += new System.EventHandler(this.cbFilterByMemebr_SelectedIndexChanged);
            // 
            // txtFilterValueMember
            // 
            this.txtFilterValueMember.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilterValueMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterValueMember.Location = new System.Drawing.Point(319, 229);
            this.txtFilterValueMember.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFilterValueMember.Name = "txtFilterValueMember";
            this.txtFilterValueMember.Size = new System.Drawing.Size(256, 22);
            this.txtFilterValueMember.TabIndex = 160;
            this.txtFilterValueMember.TextChanged += new System.EventHandler(this.txtFilterValueMember_TextChanged);
            this.txtFilterValueMember.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterValueMember_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 159;
            this.label3.Text = "Filter By:";
            // 
            // lblRecordsCountMemeber
            // 
            this.lblRecordsCountMemeber.AutoSize = true;
            this.lblRecordsCountMemeber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordsCountMemeber.Location = new System.Drawing.Point(120, 546);
            this.lblRecordsCountMemeber.Name = "lblRecordsCountMemeber";
            this.lblRecordsCountMemeber.Size = new System.Drawing.Size(21, 16);
            this.lblRecordsCountMemeber.TabIndex = 158;
            this.lblRecordsCountMemeber.Text = "??";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 543);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 157;
            this.label4.Text = "# Records:";
            // 
            // dgvMembers
            // 
            this.dgvMembers.AllowUserToAddRows = false;
            this.dgvMembers.AllowUserToDeleteRows = false;
            this.dgvMembers.AllowUserToResizeRows = false;
            this.dgvMembers.BackgroundColor = System.Drawing.Color.White;
            this.dgvMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMembers.ContextMenuStrip = this.cmsPeople;
            this.dgvMembers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvMembers.Location = new System.Drawing.Point(22, 265);
            this.dgvMembers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvMembers.MultiSelect = false;
            this.dgvMembers.Name = "dgvMembers";
            this.dgvMembers.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMembers.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMembers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMembers.Size = new System.Drawing.Size(1029, 270);
            this.dgvMembers.TabIndex = 156;
            this.dgvMembers.TabStop = false;
            // 
            // cmsPeople
            // 
            this.cmsPeople.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.editMemberToolStripMenuItem,
            this.deleteMemberToolStripMenuItem,
            this.toolMemberTakeNextBeltTest,
            this.toolMemberPeriod,
            this.showMemberPeriodHistoryToolStripMenuItem,
            this.showPaymentToolStripMenuItem});
            this.cmsPeople.Name = "contextMenuStrip1";
            this.cmsPeople.Size = new System.Drawing.Size(211, 330);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.showDetailsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.showDetailsToolStripMenuItem.Image = global::KarateClub.Properties.Resources.PersonDetails_32;
            this.showDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(210, 38);
            this.showDetailsToolStripMenuItem.Text = "&Show Member Details";
            this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.Black;
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem1.Image = global::KarateClub.Properties.Resources.AddPerson_32;
            this.toolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(210, 38);
            this.toolStripMenuItem1.Text = "Add &New Member";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // editMemberToolStripMenuItem
            // 
            this.editMemberToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.editMemberToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.editMemberToolStripMenuItem.Image = global::KarateClub.Properties.Resources.edit_32;
            this.editMemberToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.editMemberToolStripMenuItem.Name = "editMemberToolStripMenuItem";
            this.editMemberToolStripMenuItem.Size = new System.Drawing.Size(210, 38);
            this.editMemberToolStripMenuItem.Text = "&Edit";
            this.editMemberToolStripMenuItem.Click += new System.EventHandler(this.editMemberToolStripMenuItem_Click);
            // 
            // deleteMemberToolStripMenuItem
            // 
            this.deleteMemberToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.deleteMemberToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.deleteMemberToolStripMenuItem.Image = global::KarateClub.Properties.Resources.Delete_32;
            this.deleteMemberToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deleteMemberToolStripMenuItem.Name = "deleteMemberToolStripMenuItem";
            this.deleteMemberToolStripMenuItem.Size = new System.Drawing.Size(210, 38);
            this.deleteMemberToolStripMenuItem.Text = "&Delete";
            this.deleteMemberToolStripMenuItem.Click += new System.EventHandler(this.deleteMemberToolStripMenuItem_Click);
            // 
            // toolMemberTakeNextBeltTest
            // 
            this.toolMemberTakeNextBeltTest.BackColor = System.Drawing.Color.Black;
            this.toolMemberTakeNextBeltTest.ForeColor = System.Drawing.Color.White;
            this.toolMemberTakeNextBeltTest.Image = global::KarateClub.Properties.Resources.Notes_32;
            this.toolMemberTakeNextBeltTest.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolMemberTakeNextBeltTest.Name = "toolMemberTakeNextBeltTest";
            this.toolMemberTakeNextBeltTest.Size = new System.Drawing.Size(210, 38);
            this.toolMemberTakeNextBeltTest.Text = "Take &Next Belt Test";
            this.toolMemberTakeNextBeltTest.Click += new System.EventHandler(this.toolMemberTakeNextBeltTest_Click);
            // 
            // toolMemberPeriod
            // 
            this.toolMemberPeriod.BackColor = System.Drawing.Color.Black;
            this.toolMemberPeriod.ForeColor = System.Drawing.Color.White;
            this.toolMemberPeriod.Image = global::KarateClub.Properties.Resources.Calendar_32;
            this.toolMemberPeriod.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolMemberPeriod.Name = "toolMemberPeriod";
            this.toolMemberPeriod.Size = new System.Drawing.Size(210, 38);
            this.toolMemberPeriod.Text = "&Show Period History ";
            this.toolMemberPeriod.Click += new System.EventHandler(this.toolMemberPeriod_Click);
            // 
            // showMemberPeriodHistoryToolStripMenuItem
            // 
            this.showMemberPeriodHistoryToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.showMemberPeriodHistoryToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.showMemberPeriodHistoryToolStripMenuItem.Image = global::KarateClub.Properties.Resources.Calendar_32;
            this.showMemberPeriodHistoryToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showMemberPeriodHistoryToolStripMenuItem.Name = "showMemberPeriodHistoryToolStripMenuItem";
            this.showMemberPeriodHistoryToolStripMenuItem.Size = new System.Drawing.Size(210, 38);
            this.showMemberPeriodHistoryToolStripMenuItem.Text = "&Show Test History ";
            this.showMemberPeriodHistoryToolStripMenuItem.Click += new System.EventHandler(this.showMemberPeriodHistoryToolStripMenuItem_Click);
            // 
            // showPaymentToolStripMenuItem
            // 
            this.showPaymentToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.showPaymentToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.showPaymentToolStripMenuItem.Image = global::KarateClub.Properties.Resources.money_32;
            this.showPaymentToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showPaymentToolStripMenuItem.Name = "showPaymentToolStripMenuItem";
            this.showPaymentToolStripMenuItem.Size = new System.Drawing.Size(210, 38);
            this.showPaymentToolStripMenuItem.Text = "&Show Payment History";
            this.showPaymentToolStripMenuItem.Click += new System.EventHandler(this.showPaymentToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label2.Location = new System.Drawing.Point(379, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 37);
            this.label2.TabIndex = 155;
            this.label2.Text = "Manage Memeber";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddNewMember
            // 
            this.btnAddNewMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewMember.Image = global::KarateClub.Properties.Resources.Add_Person_72;
            this.btnAddNewMember.Location = new System.Drawing.Point(963, 182);
            this.btnAddNewMember.Name = "btnAddNewMember";
            this.btnAddNewMember.Size = new System.Drawing.Size(88, 75);
            this.btnAddNewMember.TabIndex = 162;
            this.btnAddNewMember.UseVisualStyleBackColor = true;
            this.btnAddNewMember.Click += new System.EventHandler(this.btnAddNewMember_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::KarateClub.Properties.Resources.judo;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(421, 12);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(179, 113);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 154;
            this.guna2PictureBox1.TabStop = false;
            // 
            // cbIsActive
            // 
            this.cbIsActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIsActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIsActive.FormattingEnabled = true;
            this.cbIsActive.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.cbIsActive.Location = new System.Drawing.Point(318, 228);
            this.cbIsActive.Name = "cbIsActive";
            this.cbIsActive.Size = new System.Drawing.Size(121, 24);
            this.cbIsActive.TabIndex = 163;
            this.cbIsActive.Visible = false;
            this.cbIsActive.SelectedIndexChanged += new System.EventHandler(this.cbIsActive_SelectedIndexChanged);
            // 
            // cbRankName
            // 
            this.cbRankName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRankName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRankName.FormattingEnabled = true;
            this.cbRankName.Location = new System.Drawing.Point(318, 228);
            this.cbRankName.Name = "cbRankName";
            this.cbRankName.Size = new System.Drawing.Size(178, 24);
            this.cbRankName.TabIndex = 164;
            this.cbRankName.Visible = false;
            this.cbRankName.SelectedIndexChanged += new System.EventHandler(this.cbRankName_SelectedIndexChanged);
            // 
            // frmListMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1061, 607);
            this.Controls.Add(this.cbRankName);
            this.Controls.Add(this.cbIsActive);
            this.Controls.Add(this.btnAddNewMember);
            this.Controls.Add(this.cbFilterByMemebr);
            this.Controls.Add(this.txtFilterValueMember);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblRecordsCountMemeber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvMembers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guna2PictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListMembers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmListMembers";
            this.Load += new System.EventHandler(this.frmListMembers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).EndInit();
            this.cmsPeople.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddNewMember;
        private System.Windows.Forms.ComboBox cbFilterByMemebr;
        private System.Windows.Forms.TextBox txtFilterValueMember;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRecordsCountMemeber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvMembers;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.ContextMenuStrip cmsPeople;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolMemberTakeNextBeltTest;
        private System.Windows.Forms.ToolStripMenuItem toolMemberPeriod;
        private System.Windows.Forms.ToolStripMenuItem showMemberPeriodHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPaymentToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbIsActive;
        private System.Windows.Forms.ComboBox cbRankName;
    }
}