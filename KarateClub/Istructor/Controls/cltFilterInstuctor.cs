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
    public partial class cltFilterInstuctor : UserControl
    {
        public cltFilterInstuctor()
        {
            InitializeComponent();
        }
        public class InstructorSelectedEventArgs : EventArgs
        {
            public int InstructorID { get; }

            public InstructorSelectedEventArgs(int InstructorID)
            {
                this.InstructorID = InstructorID;
            }
        }

        public event EventHandler<InstructorSelectedEventArgs> OnInstructorSelected;

        public void RaiseOnInstructorSelected(int InstructorID)
        {
            RaiseOnInstructorSelected(new InstructorSelectedEventArgs(InstructorID));
        }

        protected virtual void RaiseOnInstructorSelected(InstructorSelectedEventArgs e)
        {
            OnInstructorSelected?.Invoke(this, e);
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
        public int InstructorID=> cltInstructorDetails1.InstructorID;
          public clsInstructors SelectedInstrctorInfo=> cltInstructorDetails1.SelectedInstructorInfo;
        
        public void LoadInstructorInfo(int InstuctorID)
        {

            txtFilterValue.Text = InstuctorID.ToString();
            FindNow();

        }
        private void FindNow()
        {
            cltInstructorDetails1.LoadInstructorInfo(int.Parse(txtFilterValue.Text));

            if (cltInstructorDetails1.InstructorID == -1)
                return;

            if (OnInstructorSelected != null && FilterEnabled)
            {
                // Raise the event with a parameter
                RaiseOnInstructorSelected(cltInstructorDetails1.InstructorID);
            }
        }
        private void cltFilterInstuctor_Load(object sender, EventArgs e)
        {
            txtFilterValue.Focus();

        }
        public void FilterFocus()
        {
            txtFilterValue.Focus();
        }
        private void DataBackEvent( int InstuctorID)
        {
            // Handle the data received

            txtFilterValue.Text = InstuctorID.ToString();
            cltInstructorDetails1.LoadInstructorInfo(InstuctorID);

            if (OnInstructorSelected != null && FilterEnabled)
            {
                // Raise the event with a parameter
                RaiseOnInstructorSelected(cltInstructorDetails1.InstructorID);
            }
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
        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {

                btnFind.PerformClick();
            }

            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void btnAddNewInstructor_Click(object sender, EventArgs e)
        {
            frmAddNewAndUpdateInstructor frm1 = new frmAddNewAndUpdateInstructor();
            frm1.GetInstructorID += DataBackEvent; // Subscribe to the event
            frm1.ShowDialog();

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
   }
}

