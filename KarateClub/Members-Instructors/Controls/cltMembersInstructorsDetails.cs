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
    public partial class cltMembersInstructorsDetails : UserControl
    {
        int _MemberID;
        int _InstructorID;
        public cltMembersInstructorsDetails()
        {
            InitializeComponent();
        }

        public void LoadMemberAndInsstuctorInfo(int MemberID,int InstructorID)
        {
            _MemberID= MemberID;
            _InstructorID= InstructorID;
            cltInstructorDetails1.LoadInstructorInfo(_InstructorID);
            cltMemberInformation1.LoadMemberInfo(_MemberID);
        }
        private void lEShowTrainedMembers_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowTrainedMembers frm = new frmShowTrainedMembers(_InstructorID);
            frm.ShowDialog();
            cltInstructorDetails1.LoadInstructorInfo(_InstructorID);

        }
    }
}
