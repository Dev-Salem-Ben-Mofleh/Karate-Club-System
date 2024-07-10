namespace KarateClub
{
    partial class frmListBeltRanks
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
            this.lblCountBeltRank = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.cbBeltRanke = new System.Windows.Forms.ComboBox();
            this.txtBeltRank = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dgvBeltRank = new System.Windows.Forms.DataGridView();
            this.cmBeltRanks = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolEditBeltRank = new System.Windows.Forms.ToolStripMenuItem();
            this.label15 = new System.Windows.Forms.Label();
            this.guna2PictureBox5 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBeltRank)).BeginInit();
            this.cmBeltRanks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCountBeltRank
            // 
            this.lblCountBeltRank.AutoSize = true;
            this.lblCountBeltRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountBeltRank.Location = new System.Drawing.Point(100, 570);
            this.lblCountBeltRank.Name = "lblCountBeltRank";
            this.lblCountBeltRank.Size = new System.Drawing.Size(21, 16);
            this.lblCountBeltRank.TabIndex = 170;
            this.lblCountBeltRank.Text = "??";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(-2, 567);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(96, 20);
            this.label25.TabIndex = 169;
            this.label25.Text = "# Records:";
            // 
            // cbBeltRanke
            // 
            this.cbBeltRanke.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBeltRanke.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBeltRanke.FormattingEnabled = true;
            this.cbBeltRanke.Items.AddRange(new object[] {
            "None",
            "Belt Rank ID",
            "Belt Rank  Name"});
            this.cbBeltRanke.Location = new System.Drawing.Point(74, 239);
            this.cbBeltRanke.Name = "cbBeltRanke";
            this.cbBeltRanke.Size = new System.Drawing.Size(210, 24);
            this.cbBeltRanke.TabIndex = 168;
            this.cbBeltRanke.SelectedIndexChanged += new System.EventHandler(this.cbBeltRanke_SelectedIndexChanged);
            // 
            // txtBeltRank
            // 
            this.txtBeltRank.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBeltRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBeltRank.Location = new System.Drawing.Point(291, 239);
            this.txtBeltRank.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBeltRank.Name = "txtBeltRank";
            this.txtBeltRank.Size = new System.Drawing.Size(256, 22);
            this.txtBeltRank.TabIndex = 167;
            this.txtBeltRank.TextChanged += new System.EventHandler(this.txtBeltRank_TextChanged);
            this.txtBeltRank.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBeltRank_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(-2, 242);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 20);
            this.label14.TabIndex = 166;
            this.label14.Text = "Filter By:";
            // 
            // dgvBeltRank
            // 
            this.dgvBeltRank.AllowUserToAddRows = false;
            this.dgvBeltRank.AllowUserToDeleteRows = false;
            this.dgvBeltRank.AllowUserToResizeRows = false;
            this.dgvBeltRank.BackgroundColor = System.Drawing.Color.White;
            this.dgvBeltRank.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBeltRank.ContextMenuStrip = this.cmBeltRanks;
            this.dgvBeltRank.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvBeltRank.Location = new System.Drawing.Point(2, 269);
            this.dgvBeltRank.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvBeltRank.MultiSelect = false;
            this.dgvBeltRank.Name = "dgvBeltRank";
            this.dgvBeltRank.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBeltRank.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBeltRank.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBeltRank.Size = new System.Drawing.Size(1055, 270);
            this.dgvBeltRank.TabIndex = 165;
            this.dgvBeltRank.TabStop = false;
            // 
            // cmBeltRanks
            // 
            this.cmBeltRanks.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolEditBeltRank});
            this.cmBeltRanks.Name = "contextMenuStrip1";
            this.cmBeltRanks.Size = new System.Drawing.Size(163, 42);
            // 
            // toolEditBeltRank
            // 
            this.toolEditBeltRank.BackColor = System.Drawing.Color.Black;
            this.toolEditBeltRank.ForeColor = System.Drawing.Color.White;
            this.toolEditBeltRank.Image = global::KarateClub.Properties.Resources.edit_32;
            this.toolEditBeltRank.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolEditBeltRank.Name = "toolEditBeltRank";
            this.toolEditBeltRank.Size = new System.Drawing.Size(196, 38);
            this.toolEditBeltRank.Text = "&Edit Belt Rank";
            this.toolEditBeltRank.Click += new System.EventHandler(this.toolEditBeltRank_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label15.Location = new System.Drawing.Point(420, 136);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(236, 37);
            this.label15.TabIndex = 164;
            this.label15.Text = "Manage Users";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2PictureBox5
            // 
            this.guna2PictureBox5.Image = global::KarateClub.Properties.Resources.belts;
            this.guna2PictureBox5.ImageRotate = 0F;
            this.guna2PictureBox5.Location = new System.Drawing.Point(443, 20);
            this.guna2PictureBox5.Name = "guna2PictureBox5";
            this.guna2PictureBox5.Size = new System.Drawing.Size(179, 113);
            this.guna2PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox5.TabIndex = 163;
            this.guna2PictureBox5.TabStop = false;
            // 
            // frmListBeltRanks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1061, 607);
            this.Controls.Add(this.lblCountBeltRank);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.cbBeltRanke);
            this.Controls.Add(this.txtBeltRank);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dgvBeltRank);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.guna2PictureBox5);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListBeltRanks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmListBeltRanks";
            this.Load += new System.EventHandler(this.frmListBeltRanks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBeltRank)).EndInit();
            this.cmBeltRanks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCountBeltRank;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ComboBox cbBeltRanke;
        private System.Windows.Forms.TextBox txtBeltRank;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dgvBeltRank;
        private System.Windows.Forms.Label label15;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox5;
        private System.Windows.Forms.ContextMenuStrip cmBeltRanks;
        private System.Windows.Forms.ToolStripMenuItem toolEditBeltRank;
    }
}