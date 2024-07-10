using clsKarateBussinse;
using KarateClub.Global;
using KarateClub.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KarateClub
{
    public partial class frmAddAndUpdateUser : Form
    {
        public frmAddAndUpdateUser()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;

        }


        public frmAddAndUpdateUser(int MemberID)
        {
            InitializeComponent();
            _UserID = MemberID;
            _Mode = enMode.Update;
        }

        public enum enMode { AddNew = 0, Update = 1 };
        public enum enGendor { Female = 0, Male = 1 };
        private enMode _Mode;
        private int _UserID = -1;
        private short Permissions = 0;
        clsUsers _User;
        private void _ResetDefualtValues()
        {
            if (_Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New User";
                _User = new clsUsers();
            }
            else
            {
                lblTitle.Text = "Update User";
            }

            if (rbMale.Checked)
                pbPersonImage.Image = Resources.profile;//Man Picture
            else
                pbPersonImage.Image = Resources.profile__1_;//Woman Picture

            llRemoveImage.Visible = (pbPersonImage.ImageLocation != null);


            //should not allow adding age more than 100 years
            dtpDateOfBirth.MinDate = DateTime.Now.AddYears(-100);
            dtpDateOfBirth.MaxDate = DateTime.Now;



            txtName.Text = "";
            txtUserName.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";
            txtPassword.Text = "";
            txtConfirm.Text = "";

            rbMale.Checked = true;

        }
        private void _CheckAll()
        {
            chAllPermissions.Checked = true;
            chManageBeltRanks.Checked = true;
            chManageBeltTests.Checked = true;
            chManageInstructor.Checked = true;
            chManageMembers.Checked = true;
            chManageMembersInstuctors.Checked = true;
            chManagePayments.Checked = true;
            chManageSubscriptionPeriod.Checked = true;
            chManageUsers.Checked = true;
        }
        private void _LoadPermission()
        {
            if(_User.Permission == (byte)clsPemission.enMainMenuePermissions.pAll)
            {

                _CheckAll();
                return;
            }

            if ((_User.Permission & (byte)clsPemission.enMainMenuePermissions.pMamnageMembers)== (byte)clsPemission.enMainMenuePermissions.pMamnageMembers)
                chManageMembers.Checked = true;


            if ((_User.Permission & (byte)clsPemission.enMainMenuePermissions.pMamnageInstructors)== (byte)clsPemission.enMainMenuePermissions.pMamnageInstructors)
                chManageInstructor.Checked = true;

            if ((_User.Permission & (byte)clsPemission.enMainMenuePermissions.PManageUsers) == (byte)clsPemission.enMainMenuePermissions.PManageUsers) 
                chManageUsers.Checked = true;


            if ((_User.Permission & (byte)clsPemission.enMainMenuePermissions.pManageBeltRanks)== (byte)clsPemission.enMainMenuePermissions.pManageBeltRanks)
                chManageBeltRanks.Checked = true;


            if ((_User.Permission & (byte)clsPemission.enMainMenuePermissions.pManageMembersInstructors)== (byte)clsPemission.enMainMenuePermissions.pManageMembersInstructors)
                chManageMembersInstuctors.Checked = true;


            if ((_User.Permission & (byte)clsPemission.enMainMenuePermissions.pManageSubscriptionPeriod)== (byte)clsPemission.enMainMenuePermissions.pManageSubscriptionPeriod)
                chManageSubscriptionPeriod.Checked = true;


            if ((_User.Permission & (byte)clsPemission.enMainMenuePermissions.pManageBeltTest)== (byte)clsPemission.enMainMenuePermissions.pManageBeltTest)
                chManageBeltTests.Checked = true;


            if ((_User.Permission & (byte)clsPemission.enMainMenuePermissions.pManagePayment)== (byte)clsPemission.enMainMenuePermissions.pManagePayment)
                chManagePayments.Checked = true;


        }
        private void _LoadData()
        {

            _User = clsUsers.FindByUserID(_UserID);

            if (_User == null)
            {
                MessageBox.Show("No User with ID = " + _UserID, "User  Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }

            lbUserId.Text = _UserID.ToString();
            txtName.Text = _User.Name;
            txtUserName.Text = _User.UserName;
            txtPassword.Text = "";
            txtConfirm.Text = "";
            txtEmail.Text = _User.Email;
            txtAddress.Text = _User.Address;

            if (_User.Gender == 1)
                rbMale.Checked = true;
            else
                rbFemale.Checked = true;

            txtPhone.Text = _User.Phone;


            if (_User.ImagePath != "")
            {
                pbPersonImage.ImageLocation = _User.ImagePath;

            }
            llRemoveImage.Visible = (_User.ImagePath != "");

            dtpDateOfBirth.Value = _User.DateOfBirth;
            cbIsActive.Checked = (_User.IsActive);
            _LoadPermission();


        }
        private void _LoadImage()
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Process the selected file
                string selectedFilePath = openFileDialog1.FileName;
                pbPersonImage.Load(selectedFilePath);
                llRemoveImage.Visible = true;
                // ...
            }
        }
        private void frmAddAndUpdateUser_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();

            if (_Mode == enMode.Update)
                _LoadData();
        }
        private bool _HandlePersonImage()
        {

            //this procedure will handle the person image,
            //it will take care of deleting the old image from the folder
            //in case the image changed. and it will rename the new image with guid and 
            // place it in the images folder.


            //_Period.ImagePath contains the old Image, we check if it changed then we copy the new image
            if (_User.ImagePath != pbPersonImage.ImageLocation)
            {
                if (_User.ImagePath != "")
                {
                    //first we delete the old image from the folder in case there is any.

                    try
                    {
                        File.Delete(_User.ImagePath);
                    }
                    catch (IOException)
                    {
                        // We could not delete the file.
                        //log it later   
                    }
                }

                if (pbPersonImage.ImageLocation != null)
                {
                    //then we copy the new image to the image folder after we rename it
                    string SourceImageFile = pbPersonImage.ImageLocation.ToString();

                    if (clsUtil.CopyImageToProjectImagesFolder(ref SourceImageFile))
                    {
                        pbPersonImage.ImageLocation = SourceImageFile;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Error Copying Image File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }

            }
            return true;
        }
        private void _RemoveImage()
        {
            pbPersonImage.ImageLocation = null;

            if (rbMale.Checked)
                pbPersonImage.Image = Resources.profile;//Man Picture
            else
                pbPersonImage.Image = Resources.profile__1_;//Woman Picture


            llRemoveImage.Visible = false;
        }
        private void _Save()
        {
            if (!this.ValidateChildren() && Permissions!=-1)
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro Or see permissions", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!_HandlePersonImage())
                return;


            _User.Name = txtName.Text.Trim();
            _User.Address = txtAddress.Text.Trim();

            if(txtPassword.Text!="")
            _User.Password = clsUtil.ComputeHash(txtPassword.Text.Trim());

            _User.Email = txtEmail.Text.Trim();
            _User.Phone = txtPhone.Text.Trim();
            _User.DateOfBirth = dtpDateOfBirth.Value;
            _User.UserName = txtUserName.Text;
            if (rbMale.Checked)
                _User.Gender = (byte)enGendor.Male;
            else
                _User.Gender = (byte)enGendor.Female;

            if (pbPersonImage.ImageLocation != null)
                _User.ImagePath = pbPersonImage.ImageLocation;
            else
                _User.ImagePath = "";
            _User.IsActive = (cbIsActive.Checked);

            _ReadPermissionsToSet();
            _User.Permission =(byte) Permissions;

            if (_User.Save())
            {
                lbUserId.Text = _User.UserID.ToString();
                //change form mode to update.
                _Mode = enMode.Update;
                lblTitle.Text = "Update User";

                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }
        private void _ReadPermissionsToSet()
        {

            if (!chAllPermissions.Checked)
            {

                if (chManageMembers.Checked)
                    Permissions += (byte)clsPemission.enMainMenuePermissions.pMamnageMembers;

                if (chManageInstructor.Checked)
                    Permissions += (byte)clsPemission.enMainMenuePermissions.pMamnageInstructors;

                if (chManageUsers.Checked)
                    Permissions += (byte)clsPemission.enMainMenuePermissions.PManageUsers;

                if (chManageBeltRanks.Checked)
                    Permissions += (byte)clsPemission.enMainMenuePermissions.pManageBeltRanks;

                if (chManageMembersInstuctors.Checked)
                    Permissions += (byte)clsPemission.enMainMenuePermissions.pManageMembersInstructors;

                if (chManageSubscriptionPeriod.Checked)
                    Permissions += (byte)clsPemission.enMainMenuePermissions.pManageSubscriptionPeriod;

                if (chManageBeltTests.Checked)
                    Permissions += (byte)clsPemission.enMainMenuePermissions.pManageBeltTest;

                if (chManagePayments.Checked)
                    Permissions += (byte)clsPemission.enMainMenuePermissions.pManagePayment;

                if (Permissions > 0)
                    return;
            }
            else
            {
                Permissions = 0;
                return;

            }
            if (Permissions == 255 )
            {
                Permissions = 0;
                chAllPermissions.Checked = true;
                return;
            }

                Permissions = -1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _Save();

        }
        private void txtConfirm_Validating(object sender, CancelEventArgs e)
        {
            if (txtConfirm.Text.Trim() != txtPassword.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirm, "Password Confirmation does not match Password!");
            }
            else
            {
                errorProvider1.SetError(txtConfirm, null);
            };
        }
        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtUserName, "Username cannot be blank");
                return;
            }
            else
            {
                errorProvider1.SetError(txtUserName, null);
            };


            if (_Mode == enMode.AddNew)
            {

                if (clsUsers.DoesRowExist(txtUserName.Text.Trim()))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtUserName, "username is used by another user");
                }
                else
                {
                    errorProvider1.SetError(txtUserName, null);
                };
            }
            else
            {
                //incase update make sure not to use anothers user name
                if (_User.UserName != txtUserName.Text.Trim())
                {
                    if (clsUsers.DoesRowExist(txtUserName.Text.Trim()))
                    {
                        e.Cancel = true;
                        errorProvider1.SetError(txtUserName, "username is used by another user");
                        return;
                    }
                    else
                    {
                        errorProvider1.SetError(txtUserName, null);
                    };
                }
            }
        }
        private void ValditionEmptystring(object sender, CancelEventArgs e)
        {
            // First: set AutoValidate property of your Form to EnableAllowFocusChange in designer 
            TextBox Temp = ((TextBox)sender);
            if (string.IsNullOrEmpty(Temp.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp, "This field is required!");
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(Temp, null);
            }
        }
        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            if (pbPersonImage.ImageLocation == null)
                pbPersonImage.Image = Resources.profile;//Man Picture
        }
        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (pbPersonImage.ImageLocation == null)
                pbPersonImage.Image = Resources.profile__1_;// Woman Picture
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }
        private void llRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _RemoveImage();
        }
        private void llSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _LoadImage();
        }
        private void chAllPermissions_CheckedChanged(object sender, EventArgs e)
        {
            if(chAllPermissions.Checked)
            {
                _CheckAll();
            }
            else
            {
                chManageBeltRanks.Checked = false;
                chManageBeltTests.Checked = false;
                chManageInstructor.Checked = false;
                chManageMembers.Checked = false;
                chManageMembersInstuctors.Checked = false;
                chManagePayments.Checked = false;
                chManageSubscriptionPeriod.Checked = false;
                chManageUsers.Checked = false;
            }
        }

    }
}
