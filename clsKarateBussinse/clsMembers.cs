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
    public class clsMembers:clsPersons
    {
        public enum enMode { eAddNew = 0, eUpdate = 1 }
        public enMode mode = enMode.eAddNew;
        public int MemberID { get; set; }
        public string EmergencyContactInfo { get; set; }
        public int LastBeltRank { get; set; }
        public clsBeltRanks BeltRankInfo; 
        public bool IsActive { get; set; }

        public clsMembers()
        {
            MemberID = -1;
            EmergencyContactInfo = "";
            LastBeltRank = -1;
            IsActive = false;

            mode = enMode.eAddNew;
        }
        private clsMembers(int MemberID, int PersonID, string EmergencyContactInfo, int LastBeltRank, bool IsActive, 
            string Name, string Address, string Phone, DateTime DateOfBirth, byte Gender, string Email, string ImagePath)
        {

            this.MemberID = MemberID;
            this.PersonID = PersonID;
            BeltRankInfo = clsBeltRanks.FindByRankID(LastBeltRank);
            this.EmergencyContactInfo = EmergencyContactInfo;
            this.LastBeltRank = LastBeltRank;
            this.IsActive = IsActive;
            this.Name = Name;
            this.Address= Address;
            this.Phone = Phone;
            this.DateOfBirth = DateOfBirth;
            this.Gender = Gender;
            this.ImagePath= ImagePath;
            this.Email = Email;
            mode = enMode.eUpdate;

        }

        bool _AddNewRow()
        {

            this.MemberID = clsDataMembers.AddNewRow(this.PersonID, this.EmergencyContactInfo, this.LastBeltRank, this.IsActive);

            return this.MemberID != -1;

        }
        bool _UpdateRow()
        {

            return clsDataMembers.UpdateRow(this.MemberID, this.PersonID, this.EmergencyContactInfo, this.LastBeltRank, this.IsActive);


        }
        public static clsMembers FindByMemberID(int MemberID)
        {

            int PersonID = -1;
            string EmergencyContactInfo = "";
            int LastBeltRank = -1;
            bool IsActive = false;

            bool IsFound = clsDataMembers.GetRowInfoByMemberID(MemberID, ref PersonID, ref EmergencyContactInfo, ref LastBeltRank, ref IsActive);
            if (IsFound)
            {
                clsPersons persons = clsPersons.FindByPersonID(PersonID);

                return new clsMembers(MemberID, PersonID, EmergencyContactInfo, LastBeltRank, IsActive, persons.Name, persons.Address, persons.Phone
                    , persons.DateOfBirth, persons.Gender, persons.Email, persons.ImagePath);
            }
            else
                return null;
        }
        public static DataTable GetAllRows()
        {
            DataTable DT = clsDataMembers.GetAllRows();
            return DT;
        }
        public static DataTable GetAllRows(int MemberID)
        {
            DataTable DT = clsDataMembers.GetAllRows(MemberID);
            return DT;
        }
        public static int CountMembers()
        {
            return (clsDataMembers.CountMembers());
        }
        public static bool DeleteRow(int MemberID)
        {
            return (clsDataMembers.DeleteRow(MemberID));
        }
        public static bool DoesRowExist(int MemberID)
        {
            return (clsDataMembers.DoesRowExist(MemberID));
        }
        public static bool CheckMemberIsActive(int MemberID)
        {
            return (clsDataMembers.CheckMemberIsActive(MemberID));
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
