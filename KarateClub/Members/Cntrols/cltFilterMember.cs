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
    public partial class cltFilterMember : UserControl
    {

        public class MemberSelectedEventArgs : EventArgs
        {
            public int MemberID { get; }

            public MemberSelectedEventArgs(int MemberID)
            {
                this.MemberID = MemberID;
            }
        }

        public event EventHandler<MemberSelectedEventArgs> OnMemberSelected;

        public void RaiseOnMemberSelected(int MemberID)
        {
            RaiseOnMemberSelected(new MemberSelectedEventArgs(MemberID));
        }

        protected virtual void RaiseOnMemberSelected(MemberSelectedEventArgs e)
        {
            OnMemberSelected?.Invoke(this, e);
        }


        private bool _ShowAddPerson = true;
        public bool ShowAddPerson
        {
            get => _ShowAddPerson;

            set
            {
                _ShowAddPerson = value;
                btnAddNewMember.Visible = _ShowAddPerson;
            }
        }

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

        public cltFilterMember()
        {
            InitializeComponent();
        }


        public int MemberID => cltMemberInformation1.MemberID;

        public clsMembers SelectedMemberInfo => cltMemberInformation1.SelectedMemberInfo;

        public void LoadMemberInfo(int MemberID)
        {

            txtFilterValue.Text = MemberID.ToString();
            FindNow();

        }
        private void FindNow()
        {
          cltMemberInformation1.LoadMemberInfo(int.Parse(txtFilterValue.Text));

            if (cltMemberInformation1.MemberID == -1)
                return;

            if (OnMemberSelected != null && FilterEnabled)
            {
                // Raise the event with a parameter
                RaiseOnMemberSelected(cltMemberInformation1.MemberID);
            }
        }
        private void btnFind_Click_1(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            FindNow();
        }
        private void cltFilterMember_Load(object sender, EventArgs e)
        {
            txtFilterValue.Focus();

        }
    
        public void FilterFocus()
        {
            txtFilterValue.Focus();
        }


        private void txtFilterValue_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {

                btnFind.PerformClick();
            }

            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
   
        private void btnAddNewMember_Click(object sender, EventArgs e)
        {
            frmAddAndUpdateMembers frm1 = new frmAddAndUpdateMembers();
            frm1.DataBack += DataBackEvent; // Subscribe to the event
            frm1.ShowDialog();
        }

        private void DataBackEvent(object sender, int MemberID)
        {
            // Handle the data received

            txtFilterValue.Text = MemberID.ToString();
            cltMemberInformation1.LoadMemberInfo(MemberID);

            if (OnMemberSelected != null && FilterEnabled)
            {
                // Raise the event with a parameter
                RaiseOnMemberSelected(cltMemberInformation1.MemberID);
            }
        }

        private void txtFilterValue_Validating_1(object sender, CancelEventArgs e)
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

    }
}
