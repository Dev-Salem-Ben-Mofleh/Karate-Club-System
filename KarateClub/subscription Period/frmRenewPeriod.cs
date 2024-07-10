using clsKarateBussinse;
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
    public partial class frmRenewPeriod : Form
    {
       private int _PeriodID=-1;
        private clsSubscriptionPeriods _Period;
        private clsSubscriptionPeriods _NewPeriod = new clsSubscriptionPeriods();
        public frmRenewPeriod()
        {
            InitializeComponent();
        }
        public frmRenewPeriod(int PeriodID)
        {
            _PeriodID= PeriodID;
            InitializeComponent();
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        private void _LoadData()
        {
            linkShowPeriodHistory.Enabled = false;

            _Period = clsSubscriptionPeriods.FindByPeriodID(_PeriodID);
            if (_Period == null)
            {
                MessageBox.Show("No Period With ID  " + _PeriodID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                btnSave.Enabled = false;
                linkShowPeriodHistory.Enabled = false;
                this.Close();
            }

            if (HandlePeriod())
            {
                cltFilterPeriod1.LoadPeriodInfo(_PeriodID);
                cltFilterPeriod1.FilterEnabled = false;
                btnSave.Enabled = true;
            }
            else
            {
                this.Close();

            }
        }
        private void _Save()
        {
             
                if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Are you sure you want to Renew Period if you have any Period Active Will be not Active", "Confirm Save", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                
                _NewPeriod.StartDate = DateTime.Now;
                _NewPeriod.EndDate = DateTime.Now.AddDays(clsSettting.PeriodDay());
                _NewPeriod.Paid = true;
                _NewPeriod.Fees = _Period.Fees;
                _NewPeriod.SubscrpitonDays = (byte)_Period.GetSubscriptionDays();
                _NewPeriod.IsActive = true;
                _NewPeriod.IssueReason = clsSubscriptionPeriods.enIssueReason.Renew;
                _NewPeriod.MemberID = _Period.MemberID;
                _NewPeriod.PaymentID = _NewPeriod.SavePayment();

                if (_NewPeriod.Save())
                {
                    cltFilterPeriod1.LoadPeriodInfo(_NewPeriod.PeriodID);
                    MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    linkShowPeriodHistory.Enabled = true;

                }
                else
                    MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private bool HandlePeriod()
        {
            if (_Period.IsActive)
            {
                MessageBox.Show("That Period is Active and you still have days in your Period,choose Another one ", "Active", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (clsSubscriptionPeriods.CheckSubscriptionsIsNotPaid(_Period.MemberID))
            {
                MessageBox.Show("You have Period not paid yet,first pay for it ", "Pay", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
            return true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            _Save();
        }
        private void linkShowPeriodHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmSubscriptionPireodHistory frm = new frmSubscriptionPireodHistory(_Period.PeriodID);
            frm.ShowDialog();
            cltFilterPeriod1.LoadPeriodInfo(_NewPeriod.PeriodID);

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

            if (!clsValidation.IsNumber(txtFees.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFees, "Invalid Number.");
            }
            else
            {
                errorProvider1.SetError(txtFees, null);
            };

        }
        private void frmRenewPeriod_Load(object sender, EventArgs e)
        {
            if (_PeriodID == -1)
                return;

              _LoadData();
        }

        private void cltFilterPeriod1_OnPeriodSelected(object sender, subscription_Period.Controls.cltFilterPeriod.PeriodSelectedEventArgs e)
        {
            _PeriodID = e.PeriodID;
            _Period = clsSubscriptionPeriods.FindByPeriodID(_PeriodID);
            if (_Period == null)
            {
                MessageBox.Show("No Period With ID  " + _PeriodID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                btnSave.Enabled = false;
                linkShowPeriodHistory.Enabled = false;
            }

            if (HandlePeriod())
            {
                btnSave.Enabled = true;
            }
            else
            {
                btnSave.Enabled = false;
                linkShowPeriodHistory.Enabled = false;

            }
        }
    }
}
