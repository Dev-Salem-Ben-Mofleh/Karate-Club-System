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
    public partial class cltInstructorDetails : UserControl
    {
        public cltInstructorDetails()
        {
            InitializeComponent();
        }
        private clsInstructors _Instructor;

        private int _InstructorID = -1;

        public int InstructorID => _InstructorID;


        public clsInstructors SelectedInstructorInfo => _Instructor;

        public void LoadInstructorInfo(int InstructorID)
        {

            _Instructor = clsInstructors.FindByInstructorID(InstructorID);
            if (_Instructor == null)
            {
                ResetInstructorInfo();
                MessageBox.Show("No Instructor with InstructorID = " + InstructorID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillInstructorInfo();

        }

        private void _FillInstructorInfo()
        {
            cltPersonInformation1.LoadPersonInfo(_Instructor.PersonID);
            _InstructorID = _Instructor.InstructorID;
            lblInstructorID.Text = _Instructor.InstructorID.ToString();
            lblQualifiction.Text = _Instructor.Qualification==""? "No Qualification": _Instructor.Qualification;

        }

        public void ResetInstructorInfo()
        {
            cltPersonInformation1.ResetPersonInfo();
            _InstructorID = -1;
            lblInstructorID.Text = "[????]";
            lblQualifiction.Text = "[????]";

        }

        private void llEditInstrunctorInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddNewAndUpdateInstructor frm = new frmAddNewAndUpdateInstructor(_Instructor.InstructorID);
            frm.ShowDialog();
            LoadInstructorInfo(_Instructor.InstructorID);
        }

      
    }
}
