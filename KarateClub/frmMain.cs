using KarateClub.Global;
using KarateClub.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KarateClub
{
    public partial class frmMain : Form
    {
        frmLogin _frmLogin;
        bool _IsSavedLoginInfo;
        public frmMain(frmLogin frmLogin,bool IsSavedLoginInfo)
        {
            _frmLogin = frmLogin;
            _IsSavedLoginInfo = IsSavedLoginInfo;
            InitializeComponent();
        }
        private void _LoadDeful()
        {
            lblUserName.Text = clsGlobal.CurrentUser.UserName;
            if (clsGlobal.CurrentUser.ImagePath != "")
                pbUser.ImageLocation = clsGlobal.CurrentUser.ImagePath;
            else
            {
                pbUser.Image = clsGlobal.CurrentUser.Gender == 1 ? Resources.profile : Resources.profile__1_;//Woman Picture;

            }
            
        }
        private void _GetMeesageAccessDenied()
        {
            MessageBox.Show("Access Denied: You do not have permission to use this feature. " +
                   "Please contact you administrator for assistance", "Access Denied", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

        }
        public void LoadForm(Object from )
        {
            if (this.MainPanel.Controls.Count > 0)
                this.MainPanel.Controls.RemoveAt(0);
            Form f = from as Form;
            f.TopLevel = false;
            f.Dock= DockStyle.Fill;
            this.MainPanel.Controls.Add(f );
            this.MainPanel.Tag = f;
            f.Show();
        }

        private void btnMembers_Click(object sender, EventArgs e)
        {
            if (clsPemission.pMamnageMembers|| clsPemission.pALL)
                LoadForm(new frmListMembers());
            else
                _GetMeesageAccessDenied();
            
        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            LoadForm(new frmDashboard());
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            _LoadDeful();
            LoadForm(new frmDashboard());
        }
        private void btnInstructors_Click(object sender, EventArgs e)
        {
            if (clsPemission.pMamnageInstructors || clsPemission.pALL)
                LoadForm(new frmLisInstructors());
            else
                _GetMeesageAccessDenied();

        }
        private void btnUsers(object sender, EventArgs e)
        {
            if (clsPemission.PManageUsers || clsPemission.pALL)
                LoadForm(new frmListUsers(_IsSavedLoginInfo));
            else
                _GetMeesageAccessDenied();

        }
        private void btnMemersInstructors(object sender, EventArgs e)
        {
            if (clsPemission.pManageMembersInstructors || clsPemission.pALL)
                LoadForm(new frmListMembersInstructors());
            else
                _GetMeesageAccessDenied();

        }
        private void btnBeltRnaks_Click(object sender, EventArgs e)
        {
            if (clsPemission.pManageBeltRanks || clsPemission.pALL)
                LoadForm(new frmListBeltRanks());
            else
                _GetMeesageAccessDenied();

        }
        private void btnSubscriptionPeriod_Click(object sender, EventArgs e)
        {
            if (clsPemission.pManageSubscriptionPeriod || clsPemission.pALL)
                LoadForm(new frmListSubscriptionPeriod());
            else
                _GetMeesageAccessDenied();

        }
        private void btnBeltTests_Click(object sender, EventArgs e)
        {
            if (clsPemission.pManageBeltTest || clsPemission.pALL)
                LoadForm(new frmListBeltTests());
            else
                _GetMeesageAccessDenied();

        }
        private void btnPayment_Click(object sender, EventArgs e)
        {
            if (clsPemission.pManagePayment || clsPemission.pALL)
                LoadForm(new frmListPayments());
            else
                _GetMeesageAccessDenied();
        }
        private void toolShowUserDetails_Click(object sender, EventArgs e)
        {

            frmUserDetails frm = new frmUserDetails(clsGlobal.CurrentUser.UserID);
            frm.ShowDialog();
        }
        private void toolEditUser_Click(object sender, EventArgs e)
        {
            frmAddAndUpdateUser frm = new frmAddAndUpdateUser(clsGlobal.CurrentUser.UserID);
            frm.ShowDialog();

        }
        private void toolChabgePassword_Click(object sender, EventArgs e)
        {
            frmChangePassword frm = new frmChangePassword(clsGlobal.CurrentUser.UserID, _IsSavedLoginInfo);
            frm.ShowDialog();
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            clsGlobal.CurrentUser = null;
            _frmLogin.Show();
            this.Close();

        }
        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsGlobal.CurrentUser = null;
            _frmLogin.Show();
            this.Close();
        }

        
    }
}
