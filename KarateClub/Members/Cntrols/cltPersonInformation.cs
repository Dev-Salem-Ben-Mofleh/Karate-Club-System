using clsKarateBussinseLayer;
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
    public partial class cltPersonInformation : UserControl
    {
        private clsPersons _Person;

        private int _PersonID = -1;

        public int PersonID
        {
            get { return _PersonID; }
        }

        public clsPersons SelectedPersonInfo
        {
            get { return _Person; }
        }

        public void LoadPersonInfo(int PersonID)
        {
            //if(PersonID == -1)
            //{
            //    ResetPeriodInfo();
            //    return;
            //}

            _Person = clsPersons.FindByPersonID(PersonID);
            if (_Person == null)
            {
                ResetPersonInfo();
                MessageBox.Show("No Person with PersonID = " + PersonID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillPersonInfo();
        }

        private void _LoadPersonImage()
        {
            if (_Person.Gender == 1)
                pbPersonImage.Image = Resources.profile;//Man Picture
            else
                pbPersonImage.Image = Resources.profile__1_;//Woman Picture

            string ImagePath = _Person.ImagePath;
            if (ImagePath != "")
                if (File.Exists(ImagePath))
                    pbPersonImage.ImageLocation = ImagePath;
                else
                    MessageBox.Show("Could not find this image: = " + ImagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void _FillPersonInfo()
        {
            _PersonID = _Person.PersonID;
            lblPersonID.Text = _Person.PersonID.ToString();
            lblFullName.Text = _Person.Name;
            lblGendor.Text = _Person.Gender == 1 ? "Male" : "Female";
            pbGendor.Image = lblGendor.Text=="Male"? Resources.Man_32: Resources.Woman_32;
            lblEmail.Text = _Person.Email==""?"No Email": _Person.Email;
            lblPhone.Text = _Person.Phone;
            lblDateOfBirth.Text = _Person.DateOfBirth.ToShortDateString();
            lblAddress.Text = _Person.Address;
            _LoadPersonImage();

        }

        public void ResetPersonInfo()
        {
            _PersonID = -1;
            lblPersonID.Text = "[????]";
            lblFullName.Text = "[????]";
            pbGendor.Image = Resources.Man_32;
            lblGendor.Text = "[????]";
            lblEmail.Text = "[????]";
            lblPhone.Text = "[????]";
            lblDateOfBirth.Text = "[????]";
            lblAddress.Text = "[????]";
            pbPersonImage.Image = Resources.profile;

        }
        public cltPersonInformation()
        {
            InitializeComponent();
        }



    }
}
