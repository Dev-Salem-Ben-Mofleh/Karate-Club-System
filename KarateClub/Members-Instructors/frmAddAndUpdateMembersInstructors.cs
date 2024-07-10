using clsKarateBussinse;
using KarateClub.Global;
using KarateClub.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using TheArtOfDevHtmlRenderer.Adapters;

namespace KarateClub
{
    public partial class frmAddAndUpdateMembersInstructors : Form
    {

        int _MemberInstructorID;
        int _MemberID;
        int _instuctorID;
        public frmAddAndUpdateMembersInstructors()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;

        }
        public frmAddAndUpdateMembersInstructors(int MemberInstructorID )
        {
            _MemberInstructorID = MemberInstructorID;
            InitializeComponent();
            _Mode = enMode.Update;

        }
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;

        clsMemberInstructors _MemberInstructors;
        private void _ResetDefualtValues()
        {

            if (_Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New Members-Instructors";
                _MemberInstructors = new clsMemberInstructors();
            }
            else
            {
                lblTitle.Text = "Update Members-Instructors";
            }

            lblMemberInstuctorID.Text = "";
            dtAsssignDate.Value = DateTime.Now;
        }
        private void _LoadData()
        {

            _MemberInstructors = clsMemberInstructors.FindByMemberInsturctorID(_MemberInstructorID);

            if (_MemberInstructors == null)
            {
                MessageBox.Show("No Member-Instructor with ID = " + _MemberInstructorID, "Member-Instructor  Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }
            lblMemberInstuctorID.Text = _MemberInstructors.MemberInstructorID.ToString();
            dtAsssignDate.Value= _MemberInstructors.AssignDate;
            cltSelectMamberAndInstructor1.LoadDate(_MemberInstructors.MemberInfo.MemberID, _MemberInstructors.InstructorInfo.InstructorID);
            cltSelectMamberAndInstructor1.FilterEnabledMember = false;

        }
        private void _Save()
        {
            
            
            _MemberInstructors.AssignDate = dtAsssignDate.Value;
            _MemberInstructors.MemberID = _MemberID;
            _MemberInstructors.InstructorID = _instuctorID;

            if (_MemberInstructors.Save())
            {
                lblMemberInstuctorID.Text = _MemberInstructors.MemberInstructorID.ToString();
                //change form mode to update.
                _Mode = enMode.Update;
                lblTitle.Text = "Update Members-Instructors";

                MessageBox.Show($"Instructor with ID: [{_MemberInstructors.InstructorID}] is Assigned to Member with ID:[{_MemberInstructors.MemberID}] " +
                    $"at:[{_MemberInstructors.AssignDate}].", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cltSelectMamberAndInstructor1.FilterEnabledMember = false;
                cltSelectMamberAndInstructor1.FilterEnabledInstructor = false;
                btnSave.Enabled = false;

            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }
        private bool CheckMemberHasSameInstructor()
        {
            return clsMemberInstructors.CheckMemberHasSameInstructor(_MemberID, _instuctorID);
        }
        private bool CheckMemberIsActive()
        {
            return (!clsMembers.CheckMemberIsActive(_MemberID));
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _Save();
        }

        private void frmAddAndUpdateMembersInstructors_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();

            if (_Mode == enMode.Update)
                _LoadData();


            cltSelectMamberAndInstructor1.OnMemberSelected += ucMemberCardWithFilter1_OnMemberSelected;
            cltSelectMamberAndInstructor1.OnInstructorSelected += ucInstructorCardWithFilter1_OnInstructorSelected;

        }
        private void ucMemberCardWithFilter1_OnMemberSelected(int MemberID)
        {
            _MemberID = MemberID;
            if (!clsSubscriptionPeriods.CheckMemberHasPeriod(_MemberID))
            {
                MessageBox.Show("This Member is Not hass a Period  ,choose Another one", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (CheckMemberIsActive())
            {
                MessageBox.Show("This Member is Not Active ,choose Another one", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }
        private void ucInstructorCardWithFilter1_OnInstructorSelected(int InstructorID)
        {
            _instuctorID = InstructorID;
            if (CheckMemberHasSameInstructor() )
            {
                MessageBox.Show("This Instructor is Already training that Member, choose Another one", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                btnSave.Enabled = true;
            }

        }
            

    }
}
