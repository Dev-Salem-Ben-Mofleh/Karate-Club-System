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
    public partial class cltBeltTestInformation : UserControl
    {
        public cltBeltTestInformation()
        {
            InitializeComponent();
        }

        private clsBeltTests _BeltTest;

        private int _BeltTestID = -1;

        public int BeltTestID => _BeltTestID;


        public clsBeltTests SelectedBeltTestInfo => _BeltTest;
       
        public void LoadBeltTestInfo(int BeltTestID)
        {
            //if(PersonID == -1)
            //{
            //    ResetPeriodInfo();
            //    return;
            //}

            _BeltTest = clsBeltTests.FindByTestID(BeltTestID);
            if (_BeltTest == null)
            {
                ResetBeltTestInfo();
                MessageBox.Show("No Test with BeltTestID = " + BeltTestID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillBeltTestInfo();

        }
        private void _FillBeltTestInfo()
        {
            lblTestID.Text = _BeltTest.TestID.ToString();
            lblMemberID.Text = _BeltTest.MemberID.ToString();
            lblMemberName.Text = _BeltTest.MemberInfo.Name;
            lblInstructorName.Text = _BeltTest.InstructorInfo.Name;
            lblGendor.Text = _BeltTest.MemberInfo.Gender == 1 ? "Male" : "Female";
            pbGendor.Image = _BeltTest.Result == true ? Resources.Man_32 : Resources.Woman_32;
            lblBeltRankName.Text = _BeltTest.BeltRanksInfo.RankName;
            lblFees.Text = _BeltTest.BeltRanksInfo.TestFees.ToString();
            lblPaymentID.Text = _BeltTest.PaymentID.ToString();
            lblResult.Text = _BeltTest.Result == true ? "Yes" : "No";
            pbResult.Image = _BeltTest.Result == true ? Resources.Yes : Resources.cancel;
            lblTestDate.Text = clsFormat.DateToShort(_BeltTest.Date);


        }
        public void ResetBeltTestInfo()
        {
            lblTestID.Text = "[????]";
            lblMemberID.Text = "[????]";
            lblMemberName.Text= "[????]";
            lblInstructorName.Text = "[????]";
            lblGendor.Text = "[????]";
            pbGendor.Image = Resources.Man_32;
            lblBeltRankName.Text = "[????]";
            lblFees.Text = "[????]";
            lblPaymentID.Text = "[????]";
            lblResult.Text = "[????]";
            pbResult.Image =  Resources.Yes;
            lblTestDate.Text = "[????]";
        }
        private void lEShowMemberInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmMemberDetails frm = new frmMemberDetails(_BeltTest.MemberID);
            frm.ShowDialog();
            LoadBeltTestInfo(_BeltTest.MemberID);
        }
        private void LEShowInstructorInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmInstuctorDetails frm = new frmInstuctorDetails(_BeltTest.TestedByInstructorID);
            frm.ShowDialog();
            LoadBeltTestInfo(_BeltTest.TestedByInstructorID);
        }
    }
}
