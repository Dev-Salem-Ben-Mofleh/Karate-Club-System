namespace KarateClub
{
    partial class frmListPayments
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
            this.lblCountPaymentsnt = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.cbPayments = new System.Windows.Forms.ComboBox();
            this.txtcbPayments = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.dgvPayments = new System.Windows.Forms.DataGridView();
            this.cmPayment = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolShowPaymentDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.toolHistoryPayment = new System.Windows.Forms.ToolStripMenuItem();
            this.label19 = new System.Windows.Forms.Label();
            this.guna2PictureBox7 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).BeginInit();
            this.cmPayment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCountPaymentsnt
            // 
            this.lblCountPaymentsnt.AutoSize = true;
            this.lblCountPaymentsnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountPaymentsnt.Location = new System.Drawing.Point(108, 560);
            this.lblCountPaymentsnt.Name = "lblCountPaymentsnt";
            this.lblCountPaymentsnt.Size = new System.Drawing.Size(21, 16);
            this.lblCountPaymentsnt.TabIndex = 170;
            this.lblCountPaymentsnt.Text = "??";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(6, 556);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(96, 20);
            this.label29.TabIndex = 169;
            this.label29.Text = "# Records:";
            // 
            // cbPayments
            // 
            this.cbPayments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPayments.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPayments.FormattingEnabled = true;
            this.cbPayments.Items.AddRange(new object[] {
            "None",
            "Payment ID",
            "Member Name"});
            this.cbPayments.Location = new System.Drawing.Point(82, 233);
            this.cbPayments.Name = "cbPayments";
            this.cbPayments.Size = new System.Drawing.Size(210, 24);
            this.cbPayments.TabIndex = 168;
            this.cbPayments.SelectedIndexChanged += new System.EventHandler(this.cbPayments_SelectedIndexChanged);
            // 
            // txtcbPayments
            // 
            this.txtcbPayments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcbPayments.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcbPayments.Location = new System.Drawing.Point(299, 235);
            this.txtcbPayments.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtcbPayments.Name = "txtcbPayments";
            this.txtcbPayments.Size = new System.Drawing.Size(256, 22);
            this.txtcbPayments.TabIndex = 167;
            this.txtcbPayments.TextChanged += new System.EventHandler(this.txtcbPayments_TextChanged);
            this.txtcbPayments.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcbPayments_KeyPress);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(6, 234);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(80, 20);
            this.label18.TabIndex = 166;
            this.label18.Text = "Filter By:";
            // 
            // dgvPayments
            // 
            this.dgvPayments.AllowUserToAddRows = false;
            this.dgvPayments.AllowUserToDeleteRows = false;
            this.dgvPayments.AllowUserToResizeRows = false;
            this.dgvPayments.BackgroundColor = System.Drawing.Color.White;
            this.dgvPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayments.ContextMenuStrip = this.cmPayment;
            this.dgvPayments.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPayments.Location = new System.Drawing.Point(5, 267);
            this.dgvPayments.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvPayments.MultiSelect = false;
            this.dgvPayments.Name = "dgvPayments";
            this.dgvPayments.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPayments.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPayments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPayments.Size = new System.Drawing.Size(1054, 270);
            this.dgvPayments.TabIndex = 165;
            this.dgvPayments.TabStop = false;
            // 
            // cmPayment
            // 
            this.cmPayment.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolShowPaymentDetails,
            this.toolHistoryPayment});
            this.cmPayment.Name = "contextMenuStrip1";
            this.cmPayment.Size = new System.Drawing.Size(214, 102);
            // 
            // toolShowPaymentDetails
            // 
            this.toolShowPaymentDetails.BackColor = System.Drawing.Color.Black;
            this.toolShowPaymentDetails.ForeColor = System.Drawing.Color.White;
            this.toolShowPaymentDetails.Image = global::KarateClub.Properties.Resources.PersonDetails_32;
            this.toolShowPaymentDetails.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolShowPaymentDetails.Name = "toolShowPaymentDetails";
            this.toolShowPaymentDetails.Size = new System.Drawing.Size(213, 38);
            this.toolShowPaymentDetails.Text = "&Show Payment Details";
            this.toolShowPaymentDetails.Click += new System.EventHandler(this.toolShowPaymentDetails_Click);
            // 
            // toolHistoryPayment
            // 
            this.toolHistoryPayment.BackColor = System.Drawing.Color.Black;
            this.toolHistoryPayment.ForeColor = System.Drawing.Color.White;
            this.toolHistoryPayment.Image = global::KarateClub.Properties.Resources.Calendar_32;
            this.toolHistoryPayment.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolHistoryPayment.Name = "toolHistoryPayment";
            this.toolHistoryPayment.Size = new System.Drawing.Size(213, 38);
            this.toolHistoryPayment.Text = "&Show Payment History ";
            this.toolHistoryPayment.Click += new System.EventHandler(this.toolHistoryPayment_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label19.Location = new System.Drawing.Point(396, 128);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(297, 37);
            this.label19.TabIndex = 164;
            this.label19.Text = "Manage Payments";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2PictureBox7
            // 
            this.guna2PictureBox7.Image = global::KarateClub.Properties.Resources.Payment;
            this.guna2PictureBox7.ImageRotate = 0F;
            this.guna2PictureBox7.Location = new System.Drawing.Point(451, 12);
            this.guna2PictureBox7.Name = "guna2PictureBox7";
            this.guna2PictureBox7.Size = new System.Drawing.Size(179, 113);
            this.guna2PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox7.TabIndex = 163;
            this.guna2PictureBox7.TabStop = false;
            // 
            // frmListPayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1061, 607);
            this.Controls.Add(this.lblCountPaymentsnt);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.cbPayments);
            this.Controls.Add(this.txtcbPayments);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.dgvPayments);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.guna2PictureBox7);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListPayments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmListPayments";
            this.Load += new System.EventHandler(this.frmListPayments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).EndInit();
            this.cmPayment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCountPaymentsnt;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.ComboBox cbPayments;
        private System.Windows.Forms.TextBox txtcbPayments;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridView dgvPayments;
        private System.Windows.Forms.Label label19;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox7;
        private System.Windows.Forms.ContextMenuStrip cmPayment;
        private System.Windows.Forms.ToolStripMenuItem toolShowPaymentDetails;
        private System.Windows.Forms.ToolStripMenuItem toolHistoryPayment;
    }
}