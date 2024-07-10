using clsKarateBussinse;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KarateClub
{
    public partial class cltSelectMamberAndInstructor : UserControl
    {
        public cltSelectMamberAndInstructor()
        {
            InitializeComponent();
        }

        public  Action<int> OnMemberSelected;
       
        public  Action<int> OnInstructorSelected;


        public clsMembers SelectedMemberInfo => cltFilterMember1.SelectedMemberInfo;
        public clsInstructors SelectedInstructorInfo => cltFilterInstuctor1.SelectedInstrctorInfo;

        public int SelectedMemberID = -1;
        public int SelectedInstructorID = -1;

        private bool _FilterEnabledMember = true;
        public bool FilterEnabledMember
        {
            get => _FilterEnabledMember;

            set
            {
                _FilterEnabledMember = value;
                cltFilterMember1.FilterEnabled = _FilterEnabledMember;
            }
        }

        private bool _FilterEnabledInstructor = true;
        public bool FilterEnabledInstructor
        {
            get => _FilterEnabledMember;

            set
            {
                _FilterEnabledInstructor = value;
                cltFilterInstuctor1.FilterEnabled = _FilterEnabledInstructor;
            }
        }
        public void LoadDate(int MemberID,int InstrctorID)
        {
            SelectedMemberID = MemberID;
            SelectedInstructorID = InstrctorID; 
            cltFilterInstuctor1.LoadInstructorInfo(InstrctorID);
            cltFilterMember1.LoadMemberInfo(MemberID);
            cltFilterInstuctor1.Enabled = true;

        }
        public void LoadDate(int MemberID)
        {
            SelectedMemberID = MemberID;
            cltFilterMember1.LoadMemberInfo(MemberID);
            cltFilterInstuctor1.Enabled = true;

        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            cltFilterInstuctor1.Enabled = true;
            tcSelected.SelectedIndex = 1;

        }
        

        private void cltFilterMember1_OnMemberSelected(object sender, cltFilterMember.MemberSelectedEventArgs e)
        {
            SelectedMemberID = e.MemberID;
            btnNext.Enabled = true;
            if (OnMemberSelected != null)
                // Raise the event with a parameter
                OnMemberSelected(cltFilterMember1.MemberID);
        }

        private void cltFilterInstuctor1_OnInstructorSelected(object sender, cltFilterInstuctor.InstructorSelectedEventArgs e)
        {

            SelectedInstructorID = e.InstructorID;
            if (OnInstructorSelected != null)
                // Raise the event with a parameter
                OnInstructorSelected(cltFilterInstuctor1.InstructorID);
        }
    }
}
