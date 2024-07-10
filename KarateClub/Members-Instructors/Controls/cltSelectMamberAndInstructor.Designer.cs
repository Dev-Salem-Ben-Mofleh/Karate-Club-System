namespace KarateClub
{
    partial class cltSelectMamberAndInstructor
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tcSelected = new Guna.UI2.WinForms.Guna2TabControl();
            this.tcSelectMember = new System.Windows.Forms.TabPage();
            this.btnNext = new System.Windows.Forms.Button();
            this.cltFilterMember1 = new KarateClub.cltFilterMember();
            this.tcSelectInstructor = new System.Windows.Forms.TabPage();
            this.cltFilterInstuctor1 = new KarateClub.cltFilterInstuctor();
            this.groupBox1.SuspendLayout();
            this.tcSelected.SuspendLayout();
            this.tcSelectMember.SuspendLayout();
            this.tcSelectInstructor.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tcSelected);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(862, 572);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Member And Instructor";
            // 
            // tcSelected
            // 
            this.tcSelected.Controls.Add(this.tcSelectMember);
            this.tcSelected.Controls.Add(this.tcSelectInstructor);
            this.tcSelected.ItemSize = new System.Drawing.Size(180, 40);
            this.tcSelected.Location = new System.Drawing.Point(6, 21);
            this.tcSelected.Name = "tcSelected";
            this.tcSelected.SelectedIndex = 0;
            this.tcSelected.Size = new System.Drawing.Size(850, 549);
            this.tcSelected.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tcSelected.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tcSelected.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcSelected.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tcSelected.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tcSelected.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tcSelected.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tcSelected.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcSelected.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.tcSelected.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tcSelected.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tcSelected.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.tcSelected.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcSelected.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tcSelected.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.tcSelected.TabButtonSize = new System.Drawing.Size(180, 40);
            this.tcSelected.TabIndex = 1;
            this.tcSelected.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tcSelected.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tcSelectMember
            // 
            this.tcSelectMember.Controls.Add(this.btnNext);
            this.tcSelectMember.Controls.Add(this.cltFilterMember1);
            this.tcSelectMember.Location = new System.Drawing.Point(4, 44);
            this.tcSelectMember.Name = "tcSelectMember";
            this.tcSelectMember.Padding = new System.Windows.Forms.Padding(3);
            this.tcSelectMember.Size = new System.Drawing.Size(842, 501);
            this.tcSelectMember.TabIndex = 1;
            this.tcSelectMember.Text = "Select Member";
            this.tcSelectMember.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Enabled = false;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Image = global::KarateClub.Properties.Resources.Next_32;
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNext.Location = new System.Drawing.Point(710, 458);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(126, 37);
            this.btnNext.TabIndex = 170;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // cltFilterMember1
            // 
            this.cltFilterMember1.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.cltFilterMember1.BackColor = System.Drawing.Color.White;
            this.cltFilterMember1.FilterEnabled = true;
            this.cltFilterMember1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cltFilterMember1.Location = new System.Drawing.Point(6, 6);
            this.cltFilterMember1.Name = "cltFilterMember1";
            this.cltFilterMember1.ShowAddPerson = true;
            this.cltFilterMember1.Size = new System.Drawing.Size(833, 457);
            this.cltFilterMember1.TabIndex = 0;
            this.cltFilterMember1.OnMemberSelected += new System.EventHandler<KarateClub.cltFilterMember.MemberSelectedEventArgs>(this.cltFilterMember1_OnMemberSelected);
            // 
            // tcSelectInstructor
            // 
            this.tcSelectInstructor.Controls.Add(this.cltFilterInstuctor1);
            this.tcSelectInstructor.Location = new System.Drawing.Point(4, 44);
            this.tcSelectInstructor.Name = "tcSelectInstructor";
            this.tcSelectInstructor.Size = new System.Drawing.Size(842, 501);
            this.tcSelectInstructor.TabIndex = 2;
            this.tcSelectInstructor.Text = "Select Instructor";
            this.tcSelectInstructor.UseVisualStyleBackColor = true;
            // 
            // cltFilterInstuctor1
            // 
            this.cltFilterInstuctor1.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.cltFilterInstuctor1.BackColor = System.Drawing.Color.White;
            this.cltFilterInstuctor1.Enabled = false;
            this.cltFilterInstuctor1.FilterEnabled = true;
            this.cltFilterInstuctor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cltFilterInstuctor1.Location = new System.Drawing.Point(4, 4);
            this.cltFilterInstuctor1.Margin = new System.Windows.Forms.Padding(4);
            this.cltFilterInstuctor1.Name = "cltFilterInstuctor1";
            this.cltFilterInstuctor1.ShowAddPerson = true;
            this.cltFilterInstuctor1.Size = new System.Drawing.Size(834, 426);
            this.cltFilterInstuctor1.TabIndex = 0;
            this.cltFilterInstuctor1.OnInstructorSelected += new System.EventHandler<KarateClub.cltFilterInstuctor.InstructorSelectedEventArgs>(this.cltFilterInstuctor1_OnInstructorSelected);
            // 
            // cltSelectMamberAndInstructor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "cltSelectMamberAndInstructor";
            this.Size = new System.Drawing.Size(886, 581);
            this.groupBox1.ResumeLayout(false);
            this.tcSelected.ResumeLayout(false);
            this.tcSelectMember.ResumeLayout(false);
            this.tcSelectInstructor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2TabControl tcSelected;
        private System.Windows.Forms.TabPage tcSelectMember;
        private System.Windows.Forms.TabPage tcSelectInstructor;
        private cltFilterMember cltFilterMember1;
        private System.Windows.Forms.Button btnNext;
        private cltFilterInstuctor cltFilterInstuctor1;
    }
}
