using clsKarateBussinse;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace KarateClub
{
    public partial class frmAddNewSubscription : Form
    {

        public frmAddNewSubscription()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;

        }
        public frmAddNewSubscription(int PeriodID)
        {
            InitializeComponent();
            _PeriodID = PeriodID;
            _Mode = enMode.Update;
        }
        public enum enMode { AddNew = 0, Update = 1 };

        private enMode _Mode;
        private int _PeriodID = -1;
        private int _MemberID = -1;
        clsSubscriptionPeriods _Period;

        private void _ResetDefualtValues()
        {
            if (_Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New Subscription Period";
                _Period = new clsSubscriptionPeriods();
            }
            else
            {
                lblTitle.Text = "Update Subscription Period";
            }


            txtFees.Text = "";
            lblMemberID.Text = "";
            lblPeriodID.Text = "";
            lblPymentID.Text = "";
            rdYes.Checked = true;
            dtSatrtDate.Value = DateTime.Now;
            dtEndDate.Value = DateTime.Now.AddDays(clsSettting.PeriodDay());
            linkShowPeriodHistory.Enabled = false;

        }
        private void _LoadData()
        {

            _Period = clsSubscriptionPeriods.FindByPeriodID(_PeriodID);

            if (_Period == null)
            {
                MessageBox.Show("No Period with ID = " + _PeriodID, "Period Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }
            cltFilterMember1.LoadMemberInfo(_Period.MemberID);
            cltFilterMember1.FilterEnabled = false;
            rdYes.Enabled = false;
            rdNo.Enabled = false;

            lblPeriodID.Text = _PeriodID.ToString();
            txtFees.Text = _Period.Fees.ToString();
            lblMemberID.Text = _Period.MemberID.ToString();
            lblPymentID.Text = _Period.PaymentID.ToString();
            dtSatrtDate.Value = _Period.StartDate;
            dtEndDate.Value = _Period.EndDate;

            if (_Period.Paid)
                rdYes.Checked = true;
            else
                rdNo.Checked = true;

        }
        private void _Save()
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            _Period.Fees = Convert.ToSingle(txtFees.Text.Trim());
            _Period.StartDate = dtSatrtDate.Value;
            _Period.EndDate = dtEndDate.Value;
            _Period.MemberID = _MemberID;
            _Period.Paid = rdYes.Checked;
            if (_Period.Paid)
            {
                _Period.PaymentID = _Period.SavePayment();
            }
            else
            {
                _Period.PaymentID = null;
            }
            _Period.SubscrpitonDays = (byte)_Period.GetSubscriptionDays();
            _Period.IsActive = true;

            if (_Period.Save())
            {
                lblPeriodID.Text = _Period.PeriodID.ToString();
                lblMemberID.Text = _Period.MemberID.ToString();
                lblPymentID.Text = _Period.PaymentID == null ? "No Paid" : _Period.PaymentID.ToString();
                linkShowPeriodHistory.Enabled = true;

                //change form mode to update.
                _Mode = enMode.Update;
                lblTitle.Text = "Update Subscription Period";

                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }
        private void frmAddNewSubscription_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();

            if (_Mode == enMode.Update)
                _LoadData();
        }
        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txtFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }
        private void txtFees_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFees.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFees, "This field is required!");
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(txtFees, null);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            _Save();
        }
        private void linkShowPeriodHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmSubscriptionPireodHistory frm = new frmSubscriptionPireodHistory(_Period.PeriodID);
            frm.ShowDialog();
        }

        private void cltFilterMember1_OnMemberSelected(object sender, cltFilterMember.MemberSelectedEventArgs e)
        {
            _MemberID = e.MemberID;
            clsMembers _Member = clsMembers.FindByMemberID(_MemberID);

            if (_Mode == enMode.Update)
                return;

                if (_Member == null)
            {
                linkShowPeriodHistory.Enabled = false;
                btnSave.Enabled = false;
                return;
            }
            if (!_Member.IsActive)
            {
                MessageBox.Show("That member is not Active , ", "Active", MessageBoxButtons.OK, MessageBoxIcon.Error);
                linkShowPeriodHistory.Enabled = false;
                btnSave.Enabled = false;
                return;

            }

            if (clsSubscriptionPeriods.CheckMemberHasPeriod(_Member.MemberID))
            {
                MessageBox.Show("This Member is  has a Period   ,choose Another one", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                linkShowPeriodHistory.Enabled = false;
                btnSave.Enabled = false;
                return;

            }
            if (clsSubscriptionPeriods.CheckSubscriptionsIsNotPaid(_Member.MemberID))
            {
                MessageBox.Show("You have Period not paid yet,first pay for it ", "Pay", MessageBoxButtons.OK, MessageBoxIcon.Error);
                linkShowPeriodHistory.Enabled = false;
                btnSave.Enabled = false;
                return;

            }
            else
            {
                btnSave.Enabled = true;
            }
        }
    }
}
