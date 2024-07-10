using clsKarateBussinse;
using clsKarateBussinseLayer;
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

namespace KarateClub
{
    public partial class cltPeriodDetails : UserControl
    {
        public cltPeriodDetails()
        {
            InitializeComponent();
        }
        private clsSubscriptionPeriods _Period;

        private int _PeriodID = -1;
        public int PeriodID => _PeriodID;

        public clsSubscriptionPeriods SelectedPeriodInfo => _Period;

        public void LoadPeriodInfo(int PeriodID)
        {

            _Period = clsSubscriptionPeriods.FindByPeriodID(PeriodID);
            if (_Period == null)
            {
                ResetPeriodInfo();
                MessageBox.Show("No Period with PeriodID = " + PeriodID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillPeriodInfo();
        }
        private void _FillPeriodInfo()
        {
            _PeriodID = _Period.PeriodID;
            lblPeriodID.Text = _Period.PeriodID.ToString();
            lblFullName.Text = _Period.MemberInfo.Name;
            lblMemberID.Text = _Period.MemberID.ToString();
            lblGendor.Text = _Period.MemberInfo.Gender == 1 ? "Male" : "Female";
            pbGendor.Image = lblGendor.Text == "Male" ? Resources.Man_32 : Resources.Woman_32;
            lblLastBeltRank.Text = _Period.MemberInfo.BeltRankInfo.RankName;
            lblIssueReasson.Text = _Period.IssueReasonText;
            lblStartDate.Text =clsFormat.DateToShort(  _Period.StartDate);
            lblEndDate.Text = clsFormat.DateToShort(_Period.EndDate);
            lblIsPaid.Text = _Period.Paid == true ? "Yes" : "NO";
            lblIsActive.Text = _Period.IsActive == true ? "Yes" : "NO";
            lblPymentID.Text= _Period.PaymentID==null?"Not Paid Yet": _Period.PaymentID.ToString();
            lblFees.Text= _Period.Fees.ToString();

            if (!_Period.Paid || !_Period.IsActive)
                llEditPersonInfo.Enabled = false;
            else
                llEditPersonInfo.Enabled = true;

            _LoadMemberImage();
        }
        public void ResetPeriodInfo()
        {
            _PeriodID = -1;
            lblPeriodID.Text = "[????]";
            lblFullName.Text = "[????]";
            lblMemberID.Text = "[????]";
            pbGendor.Image = Resources.Man_32;
            lblGendor.Text = "[????]";
            lblLastBeltRank.Text = "[????]";
            lblIssueReasson.Text = "[????]";
            lblStartDate.Text = "[????]";
            lblIsPaid.Text = "[????]";
            lblIsActive.Text = "[????]";
            lblPymentID.Text = "[????]";
            lblFees.Text = "[????]";
            pbPersonImage.Image = Resources.profile;//Man Picture


        }
        private void _LoadMemberImage()
        {
            if (_Period.MemberInfo.Gender == 1)
                pbPersonImage.Image = Resources.profile;//Man Picture
            else
                pbPersonImage.Image = Resources.profile__1_;//Woman Picture

            string ImagePath = _Period.MemberInfo.ImagePath;
            if (ImagePath != "")
                if (File.Exists(ImagePath))
                    pbPersonImage.ImageLocation = ImagePath;
                else
                    MessageBox.Show("Could not find this image: = " + ImagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        private void llEditPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddNewSubscription frm = new frmAddNewSubscription(PeriodID);
            frm.ShowDialog();
            LoadPeriodInfo(PeriodID);
        }

    }
}
