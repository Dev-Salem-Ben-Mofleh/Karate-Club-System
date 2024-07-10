using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using clsKarateBussinseLayer;
using clsKarateDataAccesse;

namespace clsKarateBussinse
{
    public class clsInstructors: clsPersons
    {
        public enum enMode { eAddNew = 0, eUpdate = 1 }
        public enMode mode = enMode.eAddNew;
        public int InstructorID { get; set; }
        public string Qualification { get; set; }

        public clsInstructors()
        {
            InstructorID = -1;
            Qualification = "";

            mode = enMode.eAddNew;
        }
        private clsInstructors(int InstructorID, int PersonID, string Qualification
                        ,string Name, string Address, string Phone, DateTime DateOfBirth, byte Gender, string Email, string ImagePath)
        {

            this.InstructorID = InstructorID;
            this.PersonID = PersonID;
            this.Qualification = Qualification;
            this.Name = Name;
            this.Address = Address;
            this.Phone = Phone;
            this.DateOfBirth = DateOfBirth;
            this.Gender = Gender;
            this.ImagePath = ImagePath;
            this.Email = Email;

            mode = enMode.eUpdate;

        }

        bool _AddNewRow()
        {

            this.InstructorID = clsDataInstructors.AddNewRow(this.PersonID, this.Qualification);

            return this.InstructorID != -1;

        }
        bool _UpdateRow()
        {

            return clsDataInstructors.UpdateRow(this.InstructorID, this.PersonID, this.Qualification);


        }
        public static clsInstructors FindByInstructorID(int InstructorID)
        {

            string Qualification = "";
            int PersonID = -1;

            bool IsFound = clsDataInstructors.GetRowInfoByInstructorID(InstructorID, ref PersonID, ref Qualification);
            if (IsFound)
            {
                clsPersons persons = clsPersons.FindByPersonID(PersonID);

                return new clsInstructors(InstructorID, PersonID,Qualification, persons.Name, persons.Address, persons.Phone
                    , persons.DateOfBirth, persons.Gender, persons.Email, persons.ImagePath);
            }
            else
                return null;

            
        }
        public static DataTable GetAllRows()
        {
            DataTable DT = clsDataInstructors.GetAllRows();
            return DT;
        }
        public static DataTable GetAllRows(int InstructorID)
        {
            DataTable DT = clsDataInstructors.GetAllRows(InstructorID);
            return DT;
        }
        public static int CountInstructors()
        {
            return (clsDataInstructors.CountInstructors());
        }
        public static bool DeleteRow(int InstructorID)
        {
            return (clsDataInstructors.DeleteRow(InstructorID));
        }
        public static bool DoesRowExist(int InstructorID)
        {
            return (clsDataInstructors.DoesRowExist(InstructorID));
        }
        public bool Save()
        {
            base.mode = (clsPersons.enMode)mode;
            if (!base.Save())
                return false;

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
