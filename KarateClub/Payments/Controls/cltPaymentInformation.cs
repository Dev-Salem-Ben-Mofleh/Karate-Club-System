using clsKarateBussinse;
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
    public partial class cltPaymentInformation : UserControl
    {
        public cltPaymentInformation()
        {
            InitializeComponent();
        }
        private clsPayments _Payment;

        private int _PaymentID = -1;
        private int _PeriodID = -1;
        private int _BeltTestID = -1;


        public int PaymentID => _PaymentID;

        public clsPayments SelectedPaymentInfo => _Payment;
        
        public void LoadPaymentInfo(int PaymentID)
        {
           
            _Payment = clsPayments.FindByPaymentID(PaymentID);
            if (_Payment == null)
            {
                ResetPaymentnfo();
                MessageBox.Show("No Payment with PaymentID = " + PaymentID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillPaymentInfo();

        }
        private void ChooseForWhatPay(string PaymentForText)
        {

            if(PaymentForText== "Subscription Period")
            {
               _PeriodID= clsPayments.GetPaymentPayForWhat(_PaymentID,1);
                clsSubscriptionPeriods Period = clsSubscriptionPeriods.FindByPeriodID(_PeriodID);
                if (Period == null)
                {
                    ResetPaymentnfo();
                    MessageBox.Show("No Period with PeriodID = " + _PeriodID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                lblPeriodID.Visible = true;
                lblPeriod.Visible = true;
                leShowPeriodInfo.Visible = true;
                lblPeriodID.Text= Period.PeriodID.ToString();
                lblAmont.Text = Period.Fees.ToString();
            }
            else
            {
                _BeltTestID = clsPayments.GetPaymentPayForWhat(_PaymentID, 0);
                clsBeltTests Test= clsBeltTests.FindByTestID(_BeltTestID);
                if (Test == null)
                {
                    ResetPaymentnfo();
                    MessageBox.Show("No Test with BeltTestID = " + _BeltTestID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                lblBeltTestID.Visible = true;
                lblBeltTest.Visible = true;
                LEShowTestInfo.Visible = true;
                lblBeltTestID.Text = Test.TestID.ToString();
                lblAmont.Text = Test.BeltRanksInfo.TestFees.ToString();
            }
        }
        private void _FillPaymentInfo()
        {
            _PaymentID = _Payment.PaymentID;
            lblPaymentID.Text=_Payment.PaymentID.ToString();
            lblMemberID.Text = _Payment.MemberID.ToString();
            lblMemberName.Text = _Payment.MembersInfo.Name;
            lblPaynentDate.Text =clsFormat.DateToShort( _Payment.Date);
            lblGendor.Text = _Payment.MembersInfo.Gender == 1 ? "Male" : "Female";
            pbGendor.Image = lblGendor.Text == "Male" ? Resources.Man_32: Resources.Woman_32;
            lblPaymentFor.Text = _Payment.PaymentForText;
            ChooseForWhatPay(_Payment.PaymentForText);
            _LoadMemberImage();
        }
        public void ResetPaymentnfo()
        {
            _PaymentID = -1;
            lblPaymentID.Text = "[????]";
            lblMemberID.Text = "[????]";
            lblMemberName.Text = "[????]";
            lblPaynentDate.Text = "[????]";
            lblGendor.Text = "[????]";
            pbGendor.Image = Resources.Man_32 ;
            lblPaymentFor.Text = "[????]";
            lblPeriodID.Visible = false;
            lblPeriod.Visible = false;
            leShowPeriodInfo.Visible = false;
            lblBeltTestID.Visible = false;
            lblBeltTest.Visible = false;
            LEShowTestInfo.Visible = false;
            pbPersonImage.Image = Resources.profile;//Man Picture

        }
        private void _LoadMemberImage()
        {
            if (_Payment.MembersInfo.Gender == 1)
                pbPersonImage.Image = Resources.profile;//Man Picture
            else
                pbPersonImage.Image = Resources.profile__1_;//Woman Picture

            string ImagePath = _Payment.MembersInfo.ImagePath;
            if (ImagePath != "")
                if (File.Exists(ImagePath))
                    pbPersonImage.ImageLocation = ImagePath;
                else
                    MessageBox.Show("Could not find this image: = " + ImagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void leShowPeriodInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPeriodDetails frm = new frmPeriodDetails(_PeriodID);
            frm.ShowDialog();

        }
        private void LEShowTestInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowTestDetails frm = new frmShowTestDetails(_BeltTestID);
            frm.ShowDialog();
        }
        private void LEShowMemberInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmMemberDetails frm = new frmMemberDetails(_Payment.MemberID);
            frm.ShowDialog();
        }
        private void cltPaymentInformation_Load(object sender, EventArgs e)
        {
            ResetPaymentnfo();
        }

        
    }
}
