namespace KarateClub
{
    partial class frmListSubscriptionPeriod
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
            this.lblCountSubscription = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.cbSubscription = new System.Windows.Forms.ComboBox();
            this.txtSubscription = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.dgvSubscription = new System.Windows.Forms.DataGridView();
            this.cmPeriod = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolShowPeriodDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.toolAddNewPeriodr = new System.Windows.Forms.ToolStripMenuItem();
            this.toolEditePeriod = new System.Windows.Forms.ToolStripMenuItem();
            this.toolDeletePeriod = new System.Windows.Forms.ToolStripMenuItem();
            this.toolPayPeriod = new System.Windows.Forms.ToolStripMenuItem();
            this.toolRenewPeriod = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.label33 = new System.Windows.Forms.Label();
            this.cbIsActive = new System.Windows.Forms.ComboBox();
            this.cbIsPaid = new System.Windows.Forms.ComboBox();
            this.btnRenewPeriod = new System.Windows.Forms.Button();
            this.btnAddNewSubscription = new System.Windows.Forms.Button();
            this.guna2PictureBox8 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubscription)).BeginInit();
            this.cmPeriod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCountSubscription
            // 
            this.lblCountSubscription.AutoSize = true;
            this.lblCountSubscription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountSubscription.Location = new System.Drawing.Point(97, 571);
            this.lblCountSubscription.Name = "lblCountSubscription";
            this.lblCountSubscription.Size = new System.Drawing.Size(21, 16);
            this.lblCountSubscription.TabIndex = 181;
            this.lblCountSubscription.Text = "??";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(-2, 565);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(96, 20);
            this.label31.TabIndex = 180;
            this.label31.Text = "# Records:";
            // 
            // cbSubscription
            // 
            this.cbSubscription.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSubscription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSubscription.FormattingEnabled = true;
            this.cbSubscription.Items.AddRange(new object[] {
            "None",
            "Period ID",
            "Member Name",
            "Is Paid",
            "Is Active"});
            this.cbSubscription.Location = new System.Drawing.Point(71, 240);
            this.cbSubscription.Name = "cbSubscription";
            this.cbSubscription.Size = new System.Drawing.Size(210, 24);
            this.cbSubscription.TabIndex = 178;
            this.cbSubscription.SelectedIndexChanged += new System.EventHandler(this.cbSubscription_SelectedIndexChanged);
            // 
            // txtSubscription
            // 
            this.txtSubscription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubscription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubscription.Location = new System.Drawing.Point(288, 240);
            this.txtSubscription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSubscription.Name = "txtSubscription";
            this.txtSubscription.Size = new System.Drawing.Size(256, 22);
            this.txtSubscription.TabIndex = 177;
            this.txtSubscription.TextChanged += new System.EventHandler(this.txtSubscription_TextChanged);
            this.txtSubscription.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSubscription_KeyPress);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(-3, 240);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(80, 20);
            this.label32.TabIndex = 176;
            this.label32.Text = "Filter By:";
            // 
            // dgvSubscription
            // 
            this.dgvSubscription.AllowUserToAddRows = false;
            this.dgvSubscription.AllowUserToDeleteRows = false;
            this.dgvSubscription.AllowUserToResizeRows = false;
            this.dgvSubscription.BackgroundColor = System.Drawing.Color.White;
            this.dgvSubscription.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubscription.ContextMenuStrip = this.cmPeriod;
            this.dgvSubscription.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvSubscription.Location = new System.Drawing.Point(13, 276);
            this.dgvSubscription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvSubscription.MultiSelect = false;
            this.dgvSubscription.Name = "dgvSubscription";
            this.dgvSubscription.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSubscription.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSubscription.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSubscription.Size = new System.Drawing.Size(1038, 270);
            this.dgvSubscription.TabIndex = 175;
            this.dgvSubscription.TabStop = false;
            // 
            // cmPeriod
            // 
            this.cmPeriod.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolShowPeriodDetails,
            this.toolAddNewPeriodr,
            this.toolEditePeriod,
            this.toolDeletePeriod,
            this.toolPayPeriod,
            this.toolRenewPeriod,
            this.toolStripMenuItem7});
            this.cmPeriod.Name = "contextMenuStrip1";
            this.cmPeriod.Size = new System.Drawing.Size(201, 292);
            this.cmPeriod.Opening += new System.ComponentModel.CancelEventHandler(this.cmPeriod_Opening);
            // 
            // toolShowPeriodDetails
            // 
            this.toolShowPeriodDetails.BackColor = System.Drawing.Color.Black;
            this.toolShowPeriodDetails.ForeColor = System.Drawing.Color.White;
            this.toolShowPeriodDetails.Image = global::KarateClub.Properties.Resources.PersonDetails_32;
            this.toolShowPeriodDetails.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolShowPeriodDetails.Name = "toolShowPeriodDetails";
            this.toolShowPeriodDetails.Size = new System.Drawing.Size(200, 38);
            this.toolShowPeriodDetails.Text = "&Show Period Details";
            this.toolShowPeriodDetails.Click += new System.EventHandler(this.toolShowPeriodDetails_Click);
            // 
            // toolAddNewPeriodr
            // 
            this.toolAddNewPeriodr.BackColor = System.Drawing.Color.Black;
            this.toolAddNewPeriodr.ForeColor = System.Drawing.Color.White;
            this.toolAddNewPeriodr.Image = global::KarateClub.Properties.Resources.AddPerson_32;
            this.toolAddNewPeriodr.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolAddNewPeriodr.Name = "toolAddNewPeriodr";
            this.toolAddNewPeriodr.Size = new System.Drawing.Size(200, 38);
            this.toolAddNewPeriodr.Text = "Add &New Periodr";
            this.toolAddNewPeriodr.Click += new System.EventHandler(this.toolAddNewPeriodr_Click);
            // 
            // toolEditePeriod
            // 
            this.toolEditePeriod.BackColor = System.Drawing.Color.Black;
            this.toolEditePeriod.ForeColor = System.Drawing.Color.White;
            this.toolEditePeriod.Image = global::KarateClub.Properties.Resources.edit_32;
            this.toolEditePeriod.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolEditePeriod.Name = "toolEditePeriod";
            this.toolEditePeriod.Size = new System.Drawing.Size(200, 38);
            this.toolEditePeriod.Text = "&Edit";
            this.toolEditePeriod.Click += new System.EventHandler(this.toolEditePeriod_Click);
            // 
            // toolDeletePeriod
            // 
            this.toolDeletePeriod.BackColor = System.Drawing.Color.Black;
            this.toolDeletePeriod.ForeColor = System.Drawing.Color.White;
            this.toolDeletePeriod.Image = global::KarateClub.Properties.Resources.Delete_32;
            this.toolDeletePeriod.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolDeletePeriod.Name = "toolDeletePeriod";
            this.toolDeletePeriod.Size = new System.Drawing.Size(200, 38);
            this.toolDeletePeriod.Text = "&Delete";
            this.toolDeletePeriod.Click += new System.EventHandler(this.toolDeletePeriod_Click);
            // 
            // toolPayPeriod
            // 
            this.toolPayPeriod.BackColor = System.Drawing.Color.Black;
            this.toolPayPeriod.ForeColor = System.Drawing.Color.White;
            this.toolPayPeriod.Image = global::KarateClub.Properties.Resources.money_32;
            this.toolPayPeriod.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolPayPeriod.Name = "toolPayPeriod";
            this.toolPayPeriod.Size = new System.Drawing.Size(200, 38);
            this.toolPayPeriod.Text = "&Pay";
            this.toolPayPeriod.Click += new System.EventHandler(this.toolPayPeriod_Click);
            // 
            // toolRenewPeriod
            // 
            this.toolRenewPeriod.BackColor = System.Drawing.Color.Black;
            this.toolRenewPeriod.ForeColor = System.Drawing.Color.White;
            this.toolRenewPeriod.Image = global::KarateClub.Properties.Resources.Notes_32;
            this.toolRenewPeriod.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolRenewPeriod.Name = "toolRenewPeriod";
            this.toolRenewPeriod.Size = new System.Drawing.Size(200, 38);
            this.toolRenewPeriod.Text = "&Renew Period";
            this.toolRenewPeriod.Click += new System.EventHandler(this.toolRenewPeriod_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.BackColor = System.Drawing.Color.Black;
            this.toolStripMenuItem7.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem7.Image = global::KarateClub.Properties.Resources.Calendar_32;
            this.toolStripMenuItem7.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(200, 38);
            this.toolStripMenuItem7.Text = "&Show Period History ";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.BackColor = System.Drawing.Color.Transparent;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label33.Location = new System.Drawing.Point(295, 137);
            this.label33.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(462, 37);
            this.label33.TabIndex = 174;
            this.label33.Text = "Manage Subscription Peirods";
            this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.cbIsActive.Location = new System.Drawing.Point(287, 240);
            this.cbIsActive.Name = "cbIsActive";
            this.cbIsActive.Size = new System.Drawing.Size(121, 24);
            this.cbIsActive.TabIndex = 183;
            this.cbIsActive.SelectedIndexChanged += new System.EventHandler(this.cbIsActive_SelectedIndexChanged);
            // 
            // cbIsPaid
            // 
            this.cbIsPaid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIsPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIsPaid.FormattingEnabled = true;
            this.cbIsPaid.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.cbIsPaid.Location = new System.Drawing.Point(287, 240);
            this.cbIsPaid.Name = "cbIsPaid";
            this.cbIsPaid.Size = new System.Drawing.Size(121, 24);
            this.cbIsPaid.TabIndex = 184;
            this.cbIsPaid.SelectedIndexChanged += new System.EventHandler(this.cbIsPaid_SelectedIndexChanged);
            // 
            // btnRenewPeriod
            // 
            this.btnRenewPeriod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRenewPeriod.Image = global::KarateClub.Properties.Resources.renewal;
            this.btnRenewPeriod.Location = new System.Drawing.Point(869, 193);
            this.btnRenewPeriod.Name = "btnRenewPeriod";
            this.btnRenewPeriod.Size = new System.Drawing.Size(88, 75);
            this.btnRenewPeriod.TabIndex = 182;
            this.btnRenewPeriod.UseVisualStyleBackColor = true;
            this.btnRenewPeriod.Click += new System.EventHandler(this.btnRenewPeriod_Click);
            // 
            // btnAddNewSubscription
            // 
            this.btnAddNewSubscription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewSubscription.Image = global::KarateClub.Properties.Resources.New_Application_64;
            this.btnAddNewSubscription.Location = new System.Drawing.Point(963, 193);
            this.btnAddNewSubscription.Name = "btnAddNewSubscription";
            this.btnAddNewSubscription.Size = new System.Drawing.Size(88, 75);
            this.btnAddNewSubscription.TabIndex = 179;
            this.btnAddNewSubscription.UseVisualStyleBackColor = true;
            this.btnAddNewSubscription.Click += new System.EventHandler(this.btnAddNewSubscription_Click_1);
            // 
            // guna2PictureBox8
            // 
            this.guna2PictureBox8.Image = global::KarateClub.Properties.Resources.subscription_model;
            this.guna2PictureBox8.ImageRotate = 0F;
            this.guna2PictureBox8.Location = new System.Drawing.Point(440, 21);
            this.guna2PictureBox8.Name = "guna2PictureBox8";
            this.guna2PictureBox8.Size = new System.Drawing.Size(179, 113);
            this.guna2PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox8.TabIndex = 173;
            this.guna2PictureBox8.TabStop = false;
            // 
            // frmListSubscriptionPeriod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1061, 607);
            this.Controls.Add(this.cbIsPaid);
            this.Controls.Add(this.cbIsActive);
            this.Controls.Add(this.btnRenewPeriod);
            this.Controls.Add(this.lblCountSubscription);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.cbSubscription);
            this.Controls.Add(this.txtSubscription);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.dgvSubscription);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.btnAddNewSubscription);
            this.Controls.Add(this.guna2PictureBox8);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListSubscriptionPeriod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmListSubscriptionPeriod";
            this.Load += new System.EventHandler(this.frmListSubscriptionPeriod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubscription)).EndInit();
            this.cmPeriod.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRenewPeriod;
        private System.Windows.Forms.Label lblCountSubscription;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.ComboBox cbSubscription;
        private System.Windows.Forms.TextBox txtSubscription;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.DataGridView dgvSubscription;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Button btnAddNewSubscription;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox8;
        private System.Windows.Forms.ContextMenuStrip cmPeriod;
        private System.Windows.Forms.ToolStripMenuItem toolShowPeriodDetails;
        private System.Windows.Forms.ToolStripMenuItem toolAddNewPeriodr;
        private System.Windows.Forms.ToolStripMenuItem toolEditePeriod;
        private System.Windows.Forms.ToolStripMenuItem toolDeletePeriod;
        private System.Windows.Forms.ToolStripMenuItem toolPayPeriod;
        private System.Windows.Forms.ToolStripMenuItem toolRenewPeriod;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ComboBox cbIsActive;
        private System.Windows.Forms.ComboBox cbIsPaid;
    }
}