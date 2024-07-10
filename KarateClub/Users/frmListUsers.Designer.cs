namespace KarateClub
{
    partial class frmListUsers
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
            this.lblCountUsers = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.cbUsers = new System.Windows.Forms.ComboBox();
            this.txtUsers = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.cmUsers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolShowUserDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.toolAddUser = new System.Windows.Forms.ToolStripMenuItem();
            this.toolEditUser = new System.Windows.Forms.ToolStripMenuItem();
            this.toolDeleteUSer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolChabgePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.cbIsActive = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.cmUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCountUsers
            // 
            this.lblCountUsers.AutoSize = true;
            this.lblCountUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountUsers.Location = new System.Drawing.Point(99, 574);
            this.lblCountUsers.Name = "lblCountUsers";
            this.lblCountUsers.Size = new System.Drawing.Size(21, 16);
            this.lblCountUsers.TabIndex = 173;
            this.lblCountUsers.Text = "??";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(-2, 572);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(96, 20);
            this.label34.TabIndex = 172;
            this.label34.Text = "# Records:";
            // 
            // cbUsers
            // 
            this.cbUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUsers.FormattingEnabled = true;
            this.cbUsers.Items.AddRange(new object[] {
            "None",
            "User ID",
            "Name",
            "Gender",
            "User Name",
            "Is Active"});
            this.cbUsers.Location = new System.Drawing.Point(74, 233);
            this.cbUsers.Name = "cbUsers";
            this.cbUsers.Size = new System.Drawing.Size(210, 24);
            this.cbUsers.TabIndex = 170;
            this.cbUsers.SelectedIndexChanged += new System.EventHandler(this.cbUsers_SelectedIndexChanged);
            // 
            // txtUsers
            // 
            this.txtUsers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsers.Location = new System.Drawing.Point(291, 233);
            this.txtUsers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUsers.Name = "txtUsers";
            this.txtUsers.Size = new System.Drawing.Size(256, 22);
            this.txtUsers.TabIndex = 169;
            this.txtUsers.TextChanged += new System.EventHandler(this.txtUsers_TextChanged);
            this.txtUsers.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsers_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(-2, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 20);
            this.label7.TabIndex = 168;
            this.label7.Text = "Filter By:";
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.AllowUserToResizeRows = false;
            this.dgvUsers.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.ContextMenuStrip = this.cmUsers;
            this.dgvUsers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvUsers.Location = new System.Drawing.Point(2, 268);
            this.dgvUsers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvUsers.MultiSelect = false;
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(1054, 270);
            this.dgvUsers.TabIndex = 167;
            this.dgvUsers.TabStop = false;
            // 
            // cmUsers
            // 
            this.cmUsers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolShowUserDetails,
            this.toolAddUser,
            this.toolEditUser,
            this.toolDeleteUSer,
            this.toolChabgePassword});
            this.cmUsers.Name = "contextMenuStrip1";
            this.cmUsers.Size = new System.Drawing.Size(189, 194);
            // 
            // toolShowUserDetails
            // 
            this.toolShowUserDetails.BackColor = System.Drawing.Color.Black;
            this.toolShowUserDetails.ForeColor = System.Drawing.Color.White;
            this.toolShowUserDetails.Image = global::KarateClub.Properties.Resources.PersonDetails_32;
            this.toolShowUserDetails.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolShowUserDetails.Name = "toolShowUserDetails";
            this.toolShowUserDetails.Size = new System.Drawing.Size(188, 38);
            this.toolShowUserDetails.Text = "&Show Users Details";
            this.toolShowUserDetails.Click += new System.EventHandler(this.toolShowUserDetails_Click);
            // 
            // toolAddUser
            // 
            this.toolAddUser.BackColor = System.Drawing.Color.Black;
            this.toolAddUser.ForeColor = System.Drawing.Color.White;
            this.toolAddUser.Image = global::KarateClub.Properties.Resources.AddPerson_32;
            this.toolAddUser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolAddUser.Name = "toolAddUser";
            this.toolAddUser.Size = new System.Drawing.Size(188, 38);
            this.toolAddUser.Text = "Add &New User";
            this.toolAddUser.Click += new System.EventHandler(this.toolAddUser_Click);
            // 
            // toolEditUser
            // 
            this.toolEditUser.BackColor = System.Drawing.Color.Black;
            this.toolEditUser.ForeColor = System.Drawing.Color.White;
            this.toolEditUser.Image = global::KarateClub.Properties.Resources.edit_32;
            this.toolEditUser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolEditUser.Name = "toolEditUser";
            this.toolEditUser.Size = new System.Drawing.Size(188, 38);
            this.toolEditUser.Text = "&Edit";
            this.toolEditUser.Click += new System.EventHandler(this.toolEditUser_Click);
            // 
            // toolDeleteUSer
            // 
            this.toolDeleteUSer.BackColor = System.Drawing.Color.Black;
            this.toolDeleteUSer.ForeColor = System.Drawing.Color.White;
            this.toolDeleteUSer.Image = global::KarateClub.Properties.Resources.Delete_32;
            this.toolDeleteUSer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolDeleteUSer.Name = "toolDeleteUSer";
            this.toolDeleteUSer.Size = new System.Drawing.Size(188, 38);
            this.toolDeleteUSer.Text = "&Delete";
            this.toolDeleteUSer.Click += new System.EventHandler(this.toolDeleteUSer_Click);
            // 
            // toolChabgePassword
            // 
            this.toolChabgePassword.BackColor = System.Drawing.Color.Black;
            this.toolChabgePassword.ForeColor = System.Drawing.Color.White;
            this.toolChabgePassword.Image = global::KarateClub.Properties.Resources.Password_32;
            this.toolChabgePassword.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolChabgePassword.Name = "toolChabgePassword";
            this.toolChabgePassword.Size = new System.Drawing.Size(188, 38);
            this.toolChabgePassword.Text = "&Change Password";
            this.toolChabgePassword.Click += new System.EventHandler(this.toolChabgePassword_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label9.Location = new System.Drawing.Point(420, 130);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(236, 37);
            this.label9.TabIndex = 166;
            this.label9.Text = "Manage Users";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddUser
            // 
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Image = global::KarateClub.Properties.Resources.Add_Person_72;
            this.btnAddUser.Location = new System.Drawing.Point(961, 186);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(88, 75);
            this.btnAddUser.TabIndex = 171;
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.Image = global::KarateClub.Properties.Resources.People_400;
            this.guna2PictureBox3.ImageRotate = 0F;
            this.guna2PictureBox3.Location = new System.Drawing.Point(443, 14);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.Size = new System.Drawing.Size(179, 113);
            this.guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox3.TabIndex = 165;
            this.guna2PictureBox3.TabStop = false;
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
            this.cbIsActive.Location = new System.Drawing.Point(290, 232);
            this.cbIsActive.Name = "cbIsActive";
            this.cbIsActive.Size = new System.Drawing.Size(121, 24);
            this.cbIsActive.TabIndex = 174;
            this.cbIsActive.SelectedIndexChanged += new System.EventHandler(this.cbIsActive_SelectedIndexChanged);
            // 
            // frmListUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1061, 607);
            this.Controls.Add(this.cbIsActive);
            this.Controls.Add(this.lblCountUsers);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.cbUsers);
            this.Controls.Add(this.txtUsers);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.guna2PictureBox3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmListUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.cmUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCountUsers;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.ComboBox cbUsers;
        private System.Windows.Forms.TextBox txtUsers;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAddUser;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        private System.Windows.Forms.ContextMenuStrip cmUsers;
        private System.Windows.Forms.ToolStripMenuItem toolShowUserDetails;
        private System.Windows.Forms.ToolStripMenuItem toolAddUser;
        private System.Windows.Forms.ToolStripMenuItem toolEditUser;
        private System.Windows.Forms.ToolStripMenuItem toolDeleteUSer;
        private System.Windows.Forms.ToolStripMenuItem toolChabgePassword;
        private System.Windows.Forms.ComboBox cbIsActive;
    }
}