using clsKarateBussinse;
using clsKarateBussinseLayer;
using KarateClub.Global;
using KarateClub.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KarateClub
{
    public partial class frmAddAndUpdateMembers : Form
    {

        public delegate void DataBackEventHandler(object sender, int MemberID);

        // Declare an event using the delegate
        public event DataBackEventHandler DataBack;

        public enum enMode { AddNew = 0, Update = 1 };
        public enum enGendor { Female  = 0, Male = 1 };

        private enMode _Mode;
        private int _MemberID = -1;
        clsMembers _Member;

        public frmAddAndUpdateMembers()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }
        private void _FillRanks()
        {
            DataTable RanksName = clsBeltRanks.GetAllRows();
            foreach (DataRow Row in RanksName.Rows)
            {
                cbBeltRank.Items.Add(Row["RankName"]);
            }
        }
        public frmAddAndUpdateMembers(int MemberID)
        {
            InitializeComponent();
            _MemberID = MemberID;
            _Mode = enMode.Update;
        }
        private void _ResetDefualtValues()
        {
            //this will initialize the reset the defaule values
            _FillRanks();
            cbBeltRank.SelectedIndex = 0;
            if (_Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New Member";
                _Member = new clsMembers();
            }
            else
            {
                lblTitle.Text = "Update Member";
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
            txtEmergency.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";
            txtPhone.Text = "";
            rbMale.Checked = true;

        }
        private void _LoadData()
        {

            _Member = clsMembers.FindByMemberID(_MemberID);

            if (_Member == null)
            {
                MessageBox.Show("No Member with ID = " + _MemberID, "Member Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }

            lblMemberId.Text = _MemberID.ToString();
            txtName.Text = _Member.Name;
            txtEmergency.Text = _Member.EmergencyContactInfo;
            txtEmail.Text = _Member.Email;
            txtAddress.Text = _Member.Address;

            if (_Member.Gender == 1)
                rbMale.Checked = true;
            else
                rbFemale.Checked = true;

            txtPhone.Text = _Member.Phone;
            cbBeltRank.SelectedIndex = cbBeltRank.FindString(_Member.BeltRankInfo.RankName);


            if (_Member.ImagePath != "")
            {
                pbPersonImage.ImageLocation = _Member.ImagePath;

            }
            llRemoveImage.Visible = (_Member.ImagePath != "");

            dtpDateOfBirth.Value = _Member.DateOfBirth;
            cbIsActive.Checked = (_Member.IsActive);


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
        private bool _HandlePersonImage()
        {

            //this procedure will handle the person image,
            //it will take care of deleting the old image from the folder
            //in case the image changed. and it will rename the new image with guid and 
            // place it in the images folder.


            //_Period.ImagePath contains the old Image, we check if it changed then we copy the new image
            if (_Member.ImagePath != pbPersonImage.ImageLocation)
            {
                if (_Member.ImagePath != "")
                {
                    //first we delete the old image from the folder in case there is any.

                    try
                    {
                        File.Delete(_Member.ImagePath);
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
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!_HandlePersonImage())
                return;

            int BeltRankID = cbBeltRank.SelectedIndex+1;

            _Member.Name = txtName.Text.Trim();
            _Member.Address = txtAddress.Text.Trim(); 
            _Member.EmergencyContactInfo = txtEmergency.Text.Trim();
            _Member.Email = txtEmail.Text.Trim();
            _Member.Phone = txtPhone.Text.Trim();
            _Member.DateOfBirth = dtpDateOfBirth.Value;

            if (rbMale.Checked)
                _Member.Gender = (byte)enGendor.Male;
            else
                _Member.Gender = (byte)enGendor.Female;

            _Member.LastBeltRank = BeltRankID;

            if (pbPersonImage.ImageLocation != null)
                _Member.ImagePath = pbPersonImage.ImageLocation;
            else
                _Member.ImagePath = "";
            _Member.IsActive = (cbIsActive.Checked);


            if (_Member.Save())
            {
                lblMemberId.Text = _Member.MemberID.ToString();
                //change form mode to update.
                _Mode = enMode.Update;
                lblTitle.Text = "Update Member";

                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataBack?.Invoke(this, _Member.MemberID);


            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }
        private void frmAddAndUpdateMembers_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();

            if (_Mode == enMode.Update)
                _LoadData();
        }

        private void llSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _LoadImage();
        }
        private void llRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _RemoveImage();
        }
        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (txtEmail.Text.Trim() == "")
                return;

            //validate email format
            if (!clsValidation.ValidateEmail(txtEmail.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtEmail, "Invalid Email Address Format!");
            }
            else
            {
                errorProvider1.SetError(txtEmail, null);
            };
        }
        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            _Save();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
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
        private void ValidateEmptyTextBox(object sender, CancelEventArgs e)
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

        private void txtEmergency_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }
    }
}
