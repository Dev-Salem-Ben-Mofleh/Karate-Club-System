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
    public partial class frmAddNewAndUpdateInstructor : Form
    {
        public Action<int> GetInstructorID;

        public enum enMode { AddNew = 0, Update = 1 };
        public enum enGendor { Female = 0, Male = 1 };

        private enMode _Mode;
        private int _InstructorID = -1;
        clsInstructors _Instructor;

        public frmAddNewAndUpdateInstructor()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }

        public frmAddNewAndUpdateInstructor(int MemberID)
        {
            InitializeComponent();
            _InstructorID = MemberID;
            _Mode = enMode.Update;
        }
        private void _ResetDefualtValues()
        {
            //this will initialize the reset the defaule values

            if (_Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New Instructor";
                _Instructor = new clsInstructors();
            }
            else
            {
                lblTitle.Text = "Update Instructor";
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
            txtQualification.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";
            txtPhone.Text = "";
            rbMale.Checked = true;

        }
        private void _LoadData()
        {

            _Instructor = clsInstructors.FindByInstructorID(_InstructorID);

            if (_Instructor == null)
            {
                MessageBox.Show("No Instructor with ID = " + _InstructorID, "Instructor Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }

            lblMemberId.Text = _InstructorID.ToString();
            txtName.Text = _Instructor.Name;
            txtQualification.Text = _Instructor.Qualification;
            txtEmail.Text = _Instructor.Email;
            txtAddress.Text = _Instructor.Address;

            if (_Instructor.Gender == 1)
                rbMale.Checked = true;
            else
                rbFemale.Checked = true;

            txtPhone.Text = _Instructor.Phone;


            if (_Instructor.ImagePath != "")
            {
                pbPersonImage.ImageLocation = _Instructor.ImagePath;

            }
            llRemoveImage.Visible = (_Instructor.ImagePath != "");

            dtpDateOfBirth.Value = _Instructor.DateOfBirth;


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
        private void frmAddAndUpdateMembers_Load(object sender, EventArgs e)
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
            if (_Instructor.ImagePath != pbPersonImage.ImageLocation)
            {
                if (_Instructor.ImagePath != "")
                {
                    //first we delete the old image from the folder in case there is any.

                    try
                    {
                        File.Delete(_Instructor.ImagePath);
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


            _Instructor.Name = txtName.Text.Trim();
            _Instructor.Address = txtAddress.Text.Trim();
            _Instructor.Qualification = txtQualification.Text.Trim();
            _Instructor.Email = txtEmail.Text.Trim();
            _Instructor.Phone = txtPhone.Text.Trim();
            _Instructor.DateOfBirth = dtpDateOfBirth.Value;

            if (rbMale.Checked)
                _Instructor.Gender = (byte)enGendor.Male;
            else
                _Instructor.Gender = (byte)enGendor.Female;


            if (pbPersonImage.ImageLocation != null)
                _Instructor.ImagePath = pbPersonImage.ImageLocation;
            else
                _Instructor.ImagePath = "";


            if (_Instructor.Save())
            {
                lblMemberId.Text = _Instructor.InstructorID.ToString();
                //change form mode to update.
                _Mode = enMode.Update;
                lblTitle.Text = "Update Insturctor";

                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetInstructorID?.Invoke( _Instructor.InstructorID);

            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);



        }


        private void frmAddNewAndUpdateInstructor_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();

            if (_Mode == enMode.Update)
                _LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _Save();
        }

        private void llSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _LoadImage();

        }

        private void llRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _RemoveImage();
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void ValidateEmptyTextBox(object sender, CancelEventArgs e)
        {
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
                pbPersonImage.Image = Resources.profile;// Man Picture
        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (pbPersonImage.ImageLocation == null)
                pbPersonImage.Image = Resources.profile__1_;// Woman Picture
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
    }
}
