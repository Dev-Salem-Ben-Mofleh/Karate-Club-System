using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using clsKarateDataAccesseLayer;

namespace clsKarateBussinseLayer
{
    public class clsPersons
    {
        public enum enMode { eAddNew = 0, eUpdate = 1 }
        public enMode mode = enMode.eAddNew;
        public int PersonID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public DateTime DateOfBirth { get; set; }
        public byte Gender { get; set; }
        public string Email { get; set; }
        public string ImagePath { get; set; }

        public clsPersons()
        {
            PersonID = -1;
            Name = "";
            Address = "";
            Phone = "";
            DateOfBirth = DateTime.MinValue;
            Gender = 0;
            Email = "";
            ImagePath = "";

            mode = enMode.eAddNew;
        }
        private clsPersons(int PersonID, string Name, string Address, string Phone, DateTime DateOfBirth, byte Gender, string Email,string ImagePath)
        {

            this.PersonID = PersonID;
            this.Name = Name;
            this.Address = Address;
            this.Phone = Phone;
            this.DateOfBirth = DateOfBirth;
            this.Gender = Gender;
            this.Email = Email;
            this.ImagePath = ImagePath;

            mode = enMode.eUpdate;

        }

        bool _AddNewRow()
        {

            this.PersonID = clsDataPerson.AddNewRow(this.Name, this.Address, this.Phone, this.DateOfBirth, this.Gender, this.Email,this.ImagePath);

            return this.PersonID != -1;

        }
        bool _UpdateRow()
        {

            return clsDataPerson.UpdateRow(this.PersonID, this.Name, this.Address, this.Phone, this.DateOfBirth, this.Gender, this.Email, this.ImagePath);


        }
        public static clsPersons FindByPersonID(int PersonID)
        {

            string Name = "";
            string Address = "";
            string Phone = "";
            DateTime DateOfBirth = DateTime.MinValue;
            byte Gender = 0;
            string Email = "";
            string ImagePath = "";

            if (clsDataPerson.GetRowInfoByPersonID(PersonID, ref Name, ref Address, ref Phone, ref DateOfBirth, ref Gender, ref Email,ref ImagePath))
            {

                return new clsPersons(PersonID, Name, Address, Phone, DateOfBirth, Gender, Email, ImagePath);
            }
            else
                return null;
        }
        public static DataTable GetAllRows()
        {
            DataTable DT = clsDataPerson.GetAllRows();
            return DT;
        }
        public static bool DoesRowExist(int PersonID)
        {
            return (clsDataPerson.DoesRowExist(PersonID));
        }
        public bool Save()
        {
            switch (mode)
            {
                case enMode.eAddNew:
                    {
                        if (_AddNewRow())
                        {
                            mode = enMode.eUpdate;
                            return true;
                        }
                        else
                            return false;

                    }
                case enMode.eUpdate:

                    return _UpdateRow();

            }

            return false;
        }

    }
}
