using clsKarateBussinse;
using clsKarateBussinseLayer;
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
using static KarateClub.frmAddAndUpdateMembers;

namespace KarateClub
{
    public partial class cltMemberInformation : UserControl
    {
        public cltMemberInformation()
        {
            InitializeComponent();
        }
        private clsMembers _Member;

        private int _MemberID = -1;

        public int MemberID => _MemberID;

        public clsMembers SelectedMemberInfo => _Member;

        public void LoadMemberInfo(int MemberID)
        {
            //if(PersonID == -1)
            //{
            //    ResetPeriodInfo();
            //    return;
            //}
            
            _Member = clsMembers.FindByMemberID(MemberID);
            if (_Member == null)
            {
                ResetMemberInfo();
                MessageBox.Show("No Member with MemberID = " + MemberID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillMemberInfo();

        }

        private void _FillMemberInfo()
        {
            cltPersonInformation1.LoadPersonInfo(_Member.PersonID);
            _MemberID = _Member.MemberID;
            lblMemberID.Text = _Member.MemberID.ToString();
            lblEmergency.Text = _Member.EmergencyContactInfo;
            lblLastBeltRank.Text = _Member.BeltRankInfo.RankName;
            lblIsActive.Text = _Member.IsActive == true ? "Yes" : "No";
            pbisActive.Image = lblIsActive.Text == "Yes" ? Resources.Yes : Resources.cancel;

        }

        public void ResetMemberInfo()
        {
            cltPersonInformation1.ResetPersonInfo();
            _MemberID = -1;
            lblLastBeltRank.Text = "[????]";
            lblEmergency.Text = "[????]";
            pbisActive.Image = Resources.Yes;
            lblIsActive.Text = "[????]";
            lblLastBeltRank.Text = "[????]";
            
        }


        private void llEditPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddAndUpdateMembers frm = new frmAddAndUpdateMembers(_Member.MemberID);
            frm.ShowDialog();
            LoadMemberInfo(_Member.MemberID);
        }
    }
}
