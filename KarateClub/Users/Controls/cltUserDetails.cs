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
    public partial class cltUserDetails : UserControl
    {
        public cltUserDetails()
        {
            InitializeComponent();
        }
        private clsUsers _User;

        private int _UserID = -1;

        public int UserID
        {
            get { return _UserID; }
        }

        public clsUsers SelectedUserInfo
        {
            get { return _User; }
        }

        public void LoadUserInfo(int UserID)
        {
            

            _User = clsUsers.FindByUserID(UserID);
            if (_User == null)
            {
                ResetMemberInfo();
                MessageBox.Show("No User with UserID = " + UserID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillUserInfo();

        }

        private void _FillUserInfo()
        {
            cltPersonInformation1.LoadPersonInfo(_User.PersonID);
            _UserID = _User.UserID;
            lblUserID.Text = _UserID.ToString();
            lblUserName.Text = _User.UserName;
            lblIsActive.Text = _User.IsActive == true ? "Yes" : "No";
            pbisActive.Image = lblIsActive.Text == "Yes" ? Resources.Yes : Resources.cancel;

        }

        public void ResetMemberInfo()
        {
            cltPersonInformation1.ResetPersonInfo();
            _UserID = -1;
            lblUserID.Text = "[????]";
            lblUserID.Text = "[????]";
            pbisActive.Image = Resources.Yes;
            lblIsActive.Text = "[????]";

        }
        private void llEditUserInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddAndUpdateUser frm = new frmAddAndUpdateUser(_User.UserID);
            frm.ShowDialog();
            LoadUserInfo(_User.UserID);
        }
    }
}
