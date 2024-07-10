namespace KarateClub
{
    partial class ctlTrainedHistory
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.guna2TabControl1 = new Guna.UI2.WinForms.Guna2TabControl();
            this.tcPeriodHistory = new System.Windows.Forms.TabPage();
            this.dgvTrainedHistory = new System.Windows.Forms.DataGridView();
            this.cmsPeople = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMemberTakeNextBeltTest = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMemberPeriod = new System.Windows.Forms.ToolStripMenuItem();
            this.showMemberPeriodHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCountTrained = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.guna2TabControl1.SuspendLayout();
            this.tcPeriodHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrainedHistory)).BeginInit();
            this.cmsPeople.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.guna2TabControl1);
            this.groupBox1.Location = new System.Drawing.Point(2, -4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(736, 179);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // guna2TabControl1
            // 
            this.guna2TabControl1.Controls.Add(this.tcPeriodHistory);
            this.guna2TabControl1.ItemSize = new System.Drawing.Size(180, 40);
            this.guna2TabControl1.Location = new System.Drawing.Point(3, 7);
            this.guna2TabControl1.Name = "guna2TabControl1";
            this.guna2TabControl1.SelectedIndex = 0;
            this.guna2TabControl1.Size = new System.Drawing.Size(734, 197);
            this.guna2TabControl1.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.guna2TabControl1.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.guna2TabControl1.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl1.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.guna2TabControl1.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl1.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.guna2TabControl1.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.guna2TabControl1.TabButtonSize = new System.Drawing.Size(180, 40);
            this.guna2TabControl1.TabIndex = 1;
            this.guna2TabControl1.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl1.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tcPeriodHistory
            // 
            this.tcPeriodHistory.Controls.Add(this.dgvTrainedHistory);
            this.tcPeriodHistory.Location = new System.Drawing.Point(4, 44);
            this.tcPeriodHistory.Name = "tcPeriodHistory";
            this.tcPeriodHistory.Padding = new System.Windows.Forms.Padding(3);
            this.tcPeriodHistory.Size = new System.Drawing.Size(726, 149);
            this.tcPeriodHistory.TabIndex = 0;
            this.tcPeriodHistory.Text = "List Member";
            this.tcPeriodHistory.UseVisualStyleBackColor = true;
            // 
            // dgvTrainedHistory
            // 
            this.dgvTrainedHistory.AllowUserToAddRows = false;
            this.dgvTrainedHistory.AllowUserToDeleteRows = false;
            this.dgvTrainedHistory.AllowUserToResizeRows = false;
            this.dgvTrainedHistory.BackgroundColor = System.Drawing.Color.White;
            this.dgvTrainedHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrainedHistory.ContextMenuStrip = this.cmsPeople;
            this.dgvTrainedHistory.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvTrainedHistory.Location = new System.Drawing.Point(7, 8);
            this.dgvTrainedHistory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvTrainedHistory.MultiSelect = false;
            this.dgvTrainedHistory.Name = "dgvTrainedHistory";
            this.dgvTrainedHistory.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTrainedHistory.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTrainedHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTrainedHistory.Size = new System.Drawing.Size(710, 120);
            this.dgvTrainedHistory.TabIndex = 166;
            this.dgvTrainedHistory.TabStop = false;
            // 
            // cmsPeople
            // 
            this.cmsPeople.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem,
            this.editMemberToolStripMenuItem,
            this.toolMemberTakeNextBeltTest,
            this.toolMemberPeriod,
            this.showMemberPeriodHistoryToolStripMenuItem,
            this.showPaymentToolStripMenuItem});
            this.cmsPeople.Name = "contextMenuStrip1";
            this.cmsPeople.Size = new System.Drawing.Size(211, 232);
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
            // editMemberToolStripMenuItem
            // 
            this.editMemberToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.editMemberToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.editMemberToolStripMenuItem.Image = global::KarateClub.Properties.Resources.edit_32;
            this.editMemberToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.editMemberToolStripMenuItem.Name = "editMemberToolStripMenuItem";
            this.editMemberToolStripMenuItem.Size = new System.Drawing.Size(210, 38);
            this.editMemberToolStripMenuItem.Text = "Edit";
            this.editMemberToolStripMenuItem.Click += new System.EventHandler(this.editMemberToolStripMenuItem_Click);
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
            this.showPaymentToolStripMenuItem.Text = "&Show _Payment History";
            this.showPaymentToolStripMenuItem.Click += new System.EventHandler(this.showPaymentToolStripMenuItem_Click);
            // 
            // lblCountTrained
            // 
            this.lblCountTrained.AutoSize = true;
            this.lblCountTrained.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountTrained.Location = new System.Drawing.Point(117, 187);
            this.lblCountTrained.Name = "lblCountTrained";
            this.lblCountTrained.Size = new System.Drawing.Size(21, 16);
            this.lblCountTrained.TabIndex = 173;
            this.lblCountTrained.Text = "??";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(15, 182);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(96, 20);
            this.label31.TabIndex = 172;
            this.label31.Text = "# Records:";
            // 
            // ctlTrainedHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblCountTrained);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.groupBox1);
            this.Name = "ctlTrainedHistory";
            this.Size = new System.Drawing.Size(742, 220);
            this.groupBox1.ResumeLayout(false);
            this.guna2TabControl1.ResumeLayout(false);
            this.tcPeriodHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrainedHistory)).EndInit();
            this.cmsPeople.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2TabControl guna2TabControl1;
        private System.Windows.Forms.TabPage tcPeriodHistory;
        private System.Windows.Forms.Label lblCountTrained;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.DataGridView dgvTrainedHistory;
        private System.Windows.Forms.ContextMenuStrip cmsPeople;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolMemberTakeNextBeltTest;
        private System.Windows.Forms.ToolStripMenuItem toolMemberPeriod;
        private System.Windows.Forms.ToolStripMenuItem showMemberPeriodHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPaymentToolStripMenuItem;
    }
}
