namespace KarateClub
{
    partial class cltTesstHistory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.guna2TabControl1 = new Guna.UI2.WinForms.Guna2TabControl();
            this.ctMemberTests = new System.Windows.Forms.TabPage();
            this.lblCountTest = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.dgvTestHistory = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.guna2TabControl1.SuspendLayout();
            this.ctMemberTests.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.guna2TabControl1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(736, 199);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // guna2TabControl1
            // 
            this.guna2TabControl1.Controls.Add(this.ctMemberTests);
            this.guna2TabControl1.ItemSize = new System.Drawing.Size(180, 40);
            this.guna2TabControl1.Location = new System.Drawing.Point(5, 19);
            this.guna2TabControl1.Name = "guna2TabControl1";
            this.guna2TabControl1.SelectedIndex = 0;
            this.guna2TabControl1.Size = new System.Drawing.Size(734, 180);
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
            // ctMemberTests
            // 
            this.ctMemberTests.Controls.Add(this.lblCountTest);
            this.ctMemberTests.Controls.Add(this.label31);
            this.ctMemberTests.Controls.Add(this.dgvTestHistory);
            this.ctMemberTests.Location = new System.Drawing.Point(4, 44);
            this.ctMemberTests.Name = "ctMemberTests";
            this.ctMemberTests.Padding = new System.Windows.Forms.Padding(3);
            this.ctMemberTests.Size = new System.Drawing.Size(726, 132);
            this.ctMemberTests.TabIndex = 0;
            this.ctMemberTests.Text = "Member Tests";
            this.ctMemberTests.UseVisualStyleBackColor = true;
            // 
            // lblCountTest
            // 
            this.lblCountTest.AutoSize = true;
            this.lblCountTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountTest.Location = new System.Drawing.Point(108, 111);
            this.lblCountTest.Name = "lblCountTest";
            this.lblCountTest.Size = new System.Drawing.Size(21, 16);
            this.lblCountTest.TabIndex = 173;
            this.lblCountTest.Text = "??";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(6, 106);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(96, 20);
            this.label31.TabIndex = 172;
            this.label31.Text = "# Records:";
            // 
            // dgvTestHistory
            // 
            this.dgvTestHistory.AllowUserToAddRows = false;
            this.dgvTestHistory.AllowUserToDeleteRows = false;
            this.dgvTestHistory.AllowUserToResizeRows = false;
            this.dgvTestHistory.BackgroundColor = System.Drawing.Color.White;
            this.dgvTestHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTestHistory.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvTestHistory.Location = new System.Drawing.Point(7, 0);
            this.dgvTestHistory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvTestHistory.MultiSelect = false;
            this.dgvTestHistory.Name = "dgvTestHistory";
            this.dgvTestHistory.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTestHistory.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTestHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTestHistory.Size = new System.Drawing.Size(710, 106);
            this.dgvTestHistory.TabIndex = 166;
            this.dgvTestHistory.TabStop = false;
            // 
            // cltTesstHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "cltTesstHistory";
            this.Size = new System.Drawing.Size(749, 205);
            this.groupBox1.ResumeLayout(false);
            this.guna2TabControl1.ResumeLayout(false);
            this.ctMemberTests.ResumeLayout(false);
            this.ctMemberTests.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2TabControl guna2TabControl1;
        private System.Windows.Forms.TabPage ctMemberTests;
        private System.Windows.Forms.Label lblCountTest;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.DataGridView dgvTestHistory;
    }
}
