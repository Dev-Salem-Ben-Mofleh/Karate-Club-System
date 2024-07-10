using clsKarateBussinse;
using KarateClub.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KarateClub
{
    public partial class frmShowDetailsMembersInstructors : Form
    {
        int _MemberInstructorsID;
        clsMemberInstructors _MemberInstructors;
        public frmShowDetailsMembersInstructors(int MemberInstructorsID)
        {
            InitializeComponent();
            _MemberInstructorsID = MemberInstructorsID;

        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void ResetMemberInstructorsInfo()
        {
            _MemberInstructorsID = -1;
            lblMemberInstructorID.Text = "[????]";
            lblAssignDate.Text = "[????]";

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        private void LoadDate()
        {
            _MemberInstructors = clsMemberInstructors.FindByMemberInsturctorID(_MemberInstructorsID);

            if (_MemberInstructors == null)
            {
                MessageBox.Show("No Member-Instructors with ID = " + _MemberInstructorsID, "Member-Instructors  Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }

            cltMembersInstructorsDetails1.LoadMemberAndInsstuctorInfo(_MemberInstructors.MemberID, _MemberInstructors.InstructorID);
            lblMemberInstructorID.Text = _MemberInstructors.MemberInstructorID.ToString();
            lblAssignDate.Text = clsFormat.DateToShort(_MemberInstructors.AssignDate);

        }
        private void frmShowDetailsMembersInstructors_Load(object sender, EventArgs e)
        {
            LoadDate();
        }
        private void lEEdiMemberInstructorInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddAndUpdateMembersInstructors frm = new frmAddAndUpdateMembersInstructors(_MemberInstructorsID);
            frm.ShowDialog();
            LoadDate();
        }
    }
}
