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
    public partial class frmAddAndUpdateTest : Form
    {

        int _MemberID=-1;
        int _InstructorID=-1;
        clsBeltTests _BeltTest;
        public frmAddAndUpdateTest()
        {
            InitializeComponent();

        }
        public frmAddAndUpdateTest(int MemberID)
        {
            _MemberID = MemberID;
            InitializeComponent();

        }

        private bool CheckMemberIsActive()
        {
            return (!clsMembers.CheckMemberIsActive(_MemberID));
        }
        private void _ResetDefualtValues()
        {
                lblTitle.Text = "Add New Belt Test";
                _BeltTest = new clsBeltTests();
           
            lblBeltRankID.Text = "";
            lblBeltRankName.Text = "";
            lblFees.Text = "";
            lblPaymentID.Text = "";
            lblTestID.Text = "";
            rdYes.Checked = true;
            pbResult.Image = Resources.Yes;
            dtTestDate.Value = DateTime.Now;
        }
        private void _LoadDataByScreenList()
        {

            lEShowTestHistory.Enabled = true;
            cltSelectMamberAndInstructor1.FilterEnabledMember = false;
            cltSelectMamberAndInstructor1.LoadDate(_MemberID);
            HandleMember();


        }
        private void HandleMember()
        {
            clsMembers members = clsMembers.FindByMemberID(_MemberID);
            if (members == null)
            {
                MessageBox.Show("Error: Member is not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            if (CheckMemberIsActive())
            {
                MessageBox.Show("This Member is Not Active ,choose Another one", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();

            }
            if (!clsSubscriptionPeriods.CheckMemberHasPeriod(members.MemberID))
            {
                MessageBox.Show("This Member is Not has a Period  ,choose Another one", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();

            }

            if (clsSubscriptionPeriods.CheckSubscriptionsIsNotPaid(members.MemberID))
            {
                MessageBox.Show("You Can not Take Test becuase you have  a period not paid yet,first pay for it ", "Pay", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();

            }


            if (clsBeltTests.GetPassLastRankNameForTests(members.MemberID, members.BeltRankInfo.RankID))
            {
                if (members.BeltRankInfo.RankID == 17)
                {
                    MessageBox.Show("You can not Take a new Test becuase yor Finshed all tests , Now you are Karate lader", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                _BeltTest.RankID = members.BeltRankInfo.RankID + 1;
                lblBeltRankID.Text = _BeltTest.RankID.ToString();
                lblBeltRankName.Text = _BeltTest.BeltRanksInfo.RankName;
                lblFees.Text = members.BeltRankInfo.TestFees.ToString();
                btnSave.Enabled = true;
                lEShowTestHistory.Enabled = true;

            }
            else
            {
                _BeltTest.RankID = members.BeltRankInfo.RankID;
                lblBeltRankID.Text = _BeltTest.RankID.ToString();
                lblBeltRankName.Text = members.BeltRankInfo.RankName;
                lblFees.Text = members.BeltRankInfo.TestFees.ToString();
                btnSave.Enabled = true;
                lEShowTestHistory.Enabled = true;

            }
        }
        private void _Save()
        {
            if (_InstructorID == -1)
            {
                MessageBox.Show("Please Choose Instructor to Test you.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _BeltTest.Date = dtTestDate.Value;
            _BeltTest.TestedByInstructorID =_InstructorID;
            _BeltTest.MemberID = _MemberID;
            _BeltTest.Result = (rdYes.Checked);
            _BeltTest.PaymentID = _BeltTest.SavePayment(Convert.ToSingle( lblFees.Text));

            if (_BeltTest.Save())
            {
                lblTestID.Text = _BeltTest.TestID.ToString();
                lblPaymentID.Text = _BeltTest.PaymentID.ToString();
                //change form mode to update.
                lblTitle.Text = "Update Belt Test";

                MessageBox.Show(" Data Is Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cltSelectMamberAndInstructor1.FilterEnabledMember = false;
                cltSelectMamberAndInstructor1.FilterEnabledInstructor = false;
                lEShowNewBeltTestDetails.Enabled = true;
                btnSave.Enabled = false;

            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


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
        private void OnMemberSelected(int MEmberID)
        {
                _MemberID = MEmberID;

            HandleMember();
        }
        private void OnInstructorSelected(int InstructorID)
        {
            _InstructorID = InstructorID;
        }
        private void frmAddAndUpdateTest_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();


            if (_MemberID!=-1)
                _LoadDataByScreenList();

            cltSelectMamberAndInstructor1.OnMemberSelected += OnMemberSelected;
            cltSelectMamberAndInstructor1.OnInstructorSelected += OnInstructorSelected;

        }
        private void rdYes_CheckedChanged(object sender, EventArgs e)
        {
            if(rdYes.Checked)
            pbResult.Image = Resources.Yes;
        }
        private void rdNo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdNo.Checked)
                pbResult.Image = Resources.cancel;
        }
        private void lEShowNewBeltTestDetails_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowTestDetails frm = new frmShowTestDetails(_BeltTest.TestID);
            frm.ShowDialog();
        }


    }
}
