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

namespace KarateClub.subscription_Period.Controls
{
    public partial class cltFilterPeriod : UserControl
    {
        public cltFilterPeriod()
        {
            InitializeComponent();
        }
        #region Declare Event
        public class PeriodSelectedEventArgs : EventArgs
        {
            public int PeriodID { get; }

            public PeriodSelectedEventArgs(int PeriodID)
            {
                this.PeriodID = PeriodID;
            }
        }

        public event EventHandler<PeriodSelectedEventArgs> OnPeriodSelected;

        public void RaiseOnPeriodSelected(int PeriodID)
        {
            RaiseOnPeriodSelected(new PeriodSelectedEventArgs(PeriodID));
        }

        protected virtual void RaiseOnPeriodSelected(PeriodSelectedEventArgs e)
        {
            OnPeriodSelected?.Invoke(this, e);
        }
        #endregion

        private bool _FilterEnabled = true;
        public bool FilterEnabled
        {
            get => _FilterEnabled;

            set
            {
                _FilterEnabled = value;
                gbFilters.Enabled = _FilterEnabled;
            }
        }
        public int PeriodID => cltPeriodDetails1.PeriodID;

        public clsSubscriptionPeriods SelectedPeriodInfo=> cltPeriodDetails1.SelectedPeriodInfo;

        public void LoadPeriodInfo(int InstuctorID)
        {

            txtFilterValue.Text = InstuctorID.ToString();
            FindNow();

        }
        private void FindNow()
        {
            cltPeriodDetails1.LoadPeriodInfo(int.Parse(txtFilterValue.Text));

            if (cltPeriodDetails1.PeriodID == -1)
                return;

            if (OnPeriodSelected != null && FilterEnabled)
            {
                // Raise the event with a parameter
                RaiseOnPeriodSelected(cltPeriodDetails1.PeriodID);
            }
        }
        public void FilterFocus()
        {
            txtFilterValue.Focus();
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            FindNow();
        }
        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {

                btnFind.PerformClick();
            }

            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void txtFilterValue_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFilterValue.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFilterValue, "This field is required!");
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(txtFilterValue, null);
            }
        }
        private void cltFilterPeriod_Load(object sender, EventArgs e)
        {
            txtFilterValue.Focus();

        }

    }
}
