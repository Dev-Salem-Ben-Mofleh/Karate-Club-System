using clsKarateBussinse;
using KarateClub.Global;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KarateClub
{
    public partial class frmChangePassword : Form
    {
        private int _UserID;
        private clsUsers _User;
        private bool _IsSavedLoginInfo;
        public frmChangePassword(int UserID,bool IsSavedLoginInfo)
        {
            _UserID = UserID;
            _IsSavedLoginInfo = IsSavedLoginInfo;
            InitializeComponent();
        }
        private void _ResetDefualtValues()
        {
            txtCurrentPassword.Text = "";
            txtNewPassword.Text = "";
            txtConfirm.Text = "";
        }
        private void _Save()
        {

            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _User.Password = clsUtil.ComputeHash(txtNewPassword.Text.Trim());


            if (_User.Save())
            {

                if (_IsSavedLoginInfo)
                    clsGlobal.RememberUsernameAndPassword(_User.UserName, txtNewPassword.Text.Trim());



                MessageBox.Show("Password Changed Successfully.",
                   "Saved.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _ResetDefualtValues();
            }
            else
            {
                MessageBox.Show("An Erro Occured, Password did not change.",
                   "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            _Save();
        } 
        private void frmChangePassword_Load_1(object sender, EventArgs e)
        {
            _ResetDefualtValues();

            _User = clsUsers.FindByUserID(_UserID);

            if (_User == null)
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Could not Find User with id = " + _UserID,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();

                return;

            }
            cltUserDetails1.LoadUserInfo(_UserID);
        }
        private void txtCurrentPassword_Validating(object sender, CancelEventArgs e)
        {
            string HashPassword;

            if (string.IsNullOrEmpty(txtCurrentPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCurrentPassword, "Username cannot be blank");
                return;
            }
            else
            {
                errorProvider1.SetError(txtCurrentPassword, null);
            };

            HashPassword = clsUtil.ComputeHash(txtCurrentPassword.Text.Trim());

            if (_User.Password.Trim() != HashPassword)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCurrentPassword, "Current password is wrong!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtCurrentPassword, null);
            };
        }
        private void txtNewPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNewPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNewPassword, "New Password cannot be blank");
            }
            else
            {
                errorProvider1.SetError(txtNewPassword, null);
            };
        }
        private void txtConfirm_Validating(object sender, CancelEventArgs e)
        {
            if (txtConfirm.Text.Trim() != txtNewPassword.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirm, "Password Confirmation does not match New Password!");
            }
            else
            {
                errorProvider1.SetError(txtConfirm, null);
            };
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
