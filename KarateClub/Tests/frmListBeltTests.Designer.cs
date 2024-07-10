namespace KarateClub
{
    partial class frmListBeltTests
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListBeltTests));
            this.lblCountBeltTest = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.cbBeltTests = new System.Windows.Forms.ComboBox();
            this.txtBeltTests = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.dgvBeltTests = new System.Windows.Forms.DataGridView();
            this.cmTests = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolShowTestDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTestTakeNext = new System.Windows.Forms.ToolStripMenuItem();
            this.toolHistoryTest = new System.Windows.Forms.ToolStripMenuItem();
            this.label17 = new System.Windows.Forms.Label();
            this.btnAddNewBeltTest = new System.Windows.Forms.Button();
            this.guna2PictureBox6 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.cbRankName = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBeltTests)).BeginInit();
            this.cmTests.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCountBeltTest
            // 
            this.lblCountBeltTest.AutoSize = true;
            this.lblCountBeltTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountBeltTest.Location = new System.Drawing.Point(100, 571);
            this.lblCountBeltTest.Name = "lblCountBeltTest";
            this.lblCountBeltTest.Size = new System.Drawing.Size(21, 16);
            this.lblCountBeltTest.TabIndex = 181;
            this.lblCountBeltTest.Text = "??";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(-2, 567);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(96, 20);
            this.label27.TabIndex = 180;
            this.label27.Text = "# Records:";
            // 
            // cbBeltTests
            // 
            this.cbBeltTests.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBeltTests.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBeltTests.FormattingEnabled = true;
            this.cbBeltTests.Items.AddRange(new object[] {
            "None",
            "Test ID",
            "Member Name",
            "Rank Name",
            "Instructor Name"});
            this.cbBeltTests.Location = new System.Drawing.Point(74, 239);
            this.cbBeltTests.Name = "cbBeltTests";
            this.cbBeltTests.Size = new System.Drawing.Size(210, 24);
            this.cbBeltTests.TabIndex = 179;
            this.cbBeltTests.SelectedIndexChanged += new System.EventHandler(this.cbBeltTests_SelectedIndexChanged);
            // 
            // txtBeltTests
            // 
            this.txtBeltTests.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBeltTests.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBeltTests.Location = new System.Drawing.Point(291, 239);
            this.txtBeltTests.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBeltTests.Name = "txtBeltTests";
            this.txtBeltTests.Size = new System.Drawing.Size(256, 22);
            this.txtBeltTests.TabIndex = 178;
            this.txtBeltTests.TextChanged += new System.EventHandler(this.txtBeltTests_TextChanged);
            this.txtBeltTests.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBeltTests_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(-2, 242);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(80, 20);
            this.label16.TabIndex = 177;
            this.label16.Text = "Filter By:";
            // 
            // dgvBeltTests
            // 
            this.dgvBeltTests.AllowUserToAddRows = false;
            this.dgvBeltTests.AllowUserToDeleteRows = false;
            this.dgvBeltTests.AllowUserToResizeRows = false;
            this.dgvBeltTests.BackgroundColor = System.Drawing.Color.White;
            this.dgvBeltTests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBeltTests.ContextMenuStrip = this.cmTests;
            this.dgvBeltTests.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvBeltTests.Location = new System.Drawing.Point(2, 275);
            this.dgvBeltTests.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvBeltTests.MultiSelect = false;
            this.dgvBeltTests.Name = "dgvBeltTests";
            this.dgvBeltTests.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBeltTests.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBeltTests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBeltTests.Size = new System.Drawing.Size(1055, 270);
            this.dgvBeltTests.TabIndex = 176;
            this.dgvBeltTests.TabStop = false;
            // 
            // cmTests
            // 
            this.cmTests.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolShowTestDetails,
            this.toolTestTakeNext,
            this.toolHistoryTest});
            this.cmTests.Name = "contextMenuStrip1";
            this.cmTests.Size = new System.Drawing.Size(197, 140);
            this.cmTests.Opening += new System.ComponentModel.CancelEventHandler(this.cmTests_Opening);
            // 
            // toolShowTestDetails
            // 
            this.toolShowTestDetails.BackColor = System.Drawing.Color.Black;
            this.toolShowTestDetails.ForeColor = System.Drawing.Color.White;
            this.toolShowTestDetails.Image = global::KarateClub.Properties.Resources.PersonDetails_32;
            this.toolShowTestDetails.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolShowTestDetails.Name = "toolShowTestDetails";
            this.toolShowTestDetails.Size = new System.Drawing.Size(196, 38);
            this.toolShowTestDetails.Text = "&Show Test Details";
            this.toolShowTestDetails.Click += new System.EventHandler(this.toolShowTestDetails_Click);
            // 
            // toolTestTakeNext
            // 
            this.toolTestTakeNext.BackColor = System.Drawing.Color.Black;
            this.toolTestTakeNext.ForeColor = System.Drawing.Color.White;
            this.toolTestTakeNext.Image = global::KarateClub.Properties.Resources.Notes_32;
            this.toolTestTakeNext.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolTestTakeNext.Name = "toolTestTakeNext";
            this.toolTestTakeNext.Size = new System.Drawing.Size(196, 38);
            this.toolTestTakeNext.Text = "Take &Next Belt Test";
            this.toolTestTakeNext.Click += new System.EventHandler(this.toolTestTakeNext_Click);
            // 
            // toolHistoryTest
            // 
            this.toolHistoryTest.BackColor = System.Drawing.Color.Black;
            this.toolHistoryTest.ForeColor = System.Drawing.Color.White;
            this.toolHistoryTest.Image = global::KarateClub.Properties.Resources.Calendar_32;
            this.toolHistoryTest.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolHistoryTest.Name = "toolHistoryTest";
            this.toolHistoryTest.Size = new System.Drawing.Size(196, 38);
            this.toolHistoryTest.Text = "&Show Test History ";
            this.toolHistoryTest.Click += new System.EventHandler(this.toolHistoryTest_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label17.Location = new System.Drawing.Point(400, 136);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(299, 37);
            this.label17.TabIndex = 175;
            this.label17.Text = "Manage Belt Tests";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddNewBeltTest
            // 
            this.btnAddNewBeltTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewBeltTest.Image = global::KarateClub.Properties.Resources.New_Application_64;
            this.btnAddNewBeltTest.Location = new System.Drawing.Point(961, 192);
            this.btnAddNewBeltTest.Name = "btnAddNewBeltTest";
            this.btnAddNewBeltTest.Size = new System.Drawing.Size(88, 75);
            this.btnAddNewBeltTest.TabIndex = 182;
            this.btnAddNewBeltTest.UseVisualStyleBackColor = true;
            this.btnAddNewBeltTest.Click += new System.EventHandler(this.btnAddNewBeltTest_Click);
            // 
            // guna2PictureBox6
            // 
            this.guna2PictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox6.Image")));
            this.guna2PictureBox6.ImageRotate = 0F;
            this.guna2PictureBox6.Location = new System.Drawing.Point(443, 20);
            this.guna2PictureBox6.Name = "guna2PictureBox6";
            this.guna2PictureBox6.Size = new System.Drawing.Size(179, 113);
            this.guna2PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox6.TabIndex = 174;
            this.guna2PictureBox6.TabStop = false;
            // 
            // cbRankName
            // 
            this.cbRankName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRankName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRankName.FormattingEnabled = true;
            this.cbRankName.Location = new System.Drawing.Point(290, 238);
            this.cbRankName.Name = "cbRankName";
            this.cbRankName.Size = new System.Drawing.Size(178, 24);
            this.cbRankName.TabIndex = 183;
            this.cbRankName.Visible = false;
            this.cbRankName.SelectedIndexChanged += new System.EventHandler(this.cbRankName_SelectedIndexChanged);
            // 
            // frmListBeltTests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1061, 607);
            this.Controls.Add(this.cbRankName);
            this.Controls.Add(this.btnAddNewBeltTest);
            this.Controls.Add(this.lblCountBeltTest);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.cbBeltTests);
            this.Controls.Add(this.txtBeltTests);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.dgvBeltTests);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.guna2PictureBox6);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListBeltTests";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmListBeltTests";
            this.Load += new System.EventHandler(this.frmListBeltTests_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBeltTests)).EndInit();
            this.cmTests.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddNewBeltTest;
        private System.Windows.Forms.Label lblCountBeltTest;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.ComboBox cbBeltTests;
        private System.Windows.Forms.TextBox txtBeltTests;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView dgvBeltTests;
        private System.Windows.Forms.Label label17;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox6;
        private System.Windows.Forms.ComboBox cbRankName;
        private System.Windows.Forms.ContextMenuStrip cmTests;
        private System.Windows.Forms.ToolStripMenuItem toolShowTestDetails;
        private System.Windows.Forms.ToolStripMenuItem toolTestTakeNext;
        private System.Windows.Forms.ToolStripMenuItem toolHistoryTest;
    }
}