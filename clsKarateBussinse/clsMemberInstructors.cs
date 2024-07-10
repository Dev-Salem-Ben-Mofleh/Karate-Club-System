using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using clsKarateDataAccesse;

namespace clsKarateBussinse
{
    public class clsMemberInstructors
    {
        public enum enMode { eAddNew = 0, eUpdate = 1 }
        public enMode mode = enMode.eAddNew;
        public int MemberID { get; set; }
        public clsMembers MemberInfo;
        public int InstructorID { get; set; }
        public clsInstructors InstructorInfo;
        public DateTime AssignDate { get; set; }
        public int MemberInstructorID { get; set; }

        public clsMemberInstructors()
        {
            MemberInstructorID = -1;
            MemberID = -1;
            InstructorID = -1;
            AssignDate = DateTime.MinValue;

            mode = enMode.eAddNew;
        }
        private clsMemberInstructors(int MemberInstructorID, int MemberID, int InstructorID, DateTime AssignDate)
        {
           this.MemberInstructorID= MemberInstructorID;
            this.MemberID = MemberID;
            MemberInfo = clsMembers.FindByMemberID(MemberID);
            this.InstructorID = InstructorID;
            InstructorInfo = clsInstructors.FindByInstructorID(InstructorID);
            this.AssignDate = AssignDate;

            mode = enMode.eUpdate;

        }

        bool _AddNewRow()
        {

            this.MemberInstructorID = clsDataMemberInstructors.AddNewRow(this.MemberID,this.InstructorID, this.AssignDate);

            return this.MemberInstructorID != -1;

        }
        bool _UpdateRow()
        {

            return clsDataMemberInstructors.UpdateRow(this.MemberInstructorID,this.MemberID, this.InstructorID, this.AssignDate);


        }
        public static clsMemberInstructors FindByMemberInsturctorID(int MemberInstructorID)
        {
            int MemberID = -1;
            int InstructorID = -1;
            DateTime AssignDate = DateTime.MinValue;


            if (clsDataMemberInstructors.GetRowInfoByMemberID(MemberInstructorID,ref MemberID, ref InstructorID, ref AssignDate))
            {

                return new clsMemberInstructors(MemberInstructorID, MemberID, InstructorID, AssignDate);
            }
            else
                return null;
        }
        public static DataTable GetAllRows()
        {
            DataTable DT = clsDataMemberInstructors.GetAllRows();
            return DT;
        }
        public static bool DeleteRow(int MemberInstructorID)
        {
            return (clsDataMemberInstructors.DeleteRow(MemberInstructorID));
        }
        public static bool DoesRowExist(int MemberInstructorID)
        {
            return (clsDataMemberInstructors.DoesRowExist(MemberInstructorID));
        }
        public static bool CheckMemberHasSameInstructor(int MemberId,int InstructorID)
        {
            return (clsDataMemberInstructors.CheckMemberHasSameInstructor(MemberId, InstructorID));
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
