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
    public class clsBeltTests
    {
        public enum enMode { eAddNew = 0, eUpdate = 1 }
        public enMode mode = enMode.eAddNew;
        public int TestID { get; set; }
        public int MemberID { get; set; }
        public clsMembers MemberInfo;
        public int RankID { get; set; }
        public clsBeltRanks BeltRanksInfo;
        public bool Result { get; set; }
        public DateTime Date { get; set; }
        public int TestedByInstructorID { get; set; }
        public clsInstructors InstructorInfo;
        public Nullable< int> PaymentID { get; set; }

        public clsBeltTests()
        {
            TestID = -1;
            MemberID = -1;
            RankID = -1;
            Result = false;
            Date = DateTime.MinValue;
            TestedByInstructorID = -1;
            PaymentID = null;
            mode = enMode.eAddNew;
        }
        private clsBeltTests(int TestID, int MemberID, int RankID, bool Result, DateTime Date, int TestedByInstructorID, Nullable<int> PaymentID)
        {

            this.TestID = TestID;
            this.MemberID = MemberID;
            MemberInfo = clsMembers.FindByMemberID(MemberID);
            this.RankID = RankID;
            BeltRanksInfo = clsBeltRanks.FindByRankID(RankID);
            this.Result = Result;
            this.Date = Date;
            this.TestedByInstructorID = TestedByInstructorID;
            InstructorInfo = clsInstructors.FindByInstructorID(TestedByInstructorID);
            this.PaymentID = PaymentID;
            mode = enMode.eUpdate;

        }
        bool _AddNewRow()
        {

            this.TestID = clsDataBeltTests.AddNewRow(this.MemberID, this.RankID, this.Result, this.Date, this.TestedByInstructorID, this.PaymentID);

            return this.TestID != -1;

        }
        bool _UpdateRow()
        {

            return clsDataBeltTests.UpdateRow(this.TestID, this.MemberID, this.RankID, this.Result, this.Date, this.TestedByInstructorID, this.PaymentID);


        }
        public static clsBeltTests FindByTestID(int TestID)
        {

            int MemberID = -1;
            int RankID = -1;
            bool Result = false;
            DateTime Date = DateTime.MinValue;
            int TestedByInstructorID = -1;
            Nullable<int> PaymentID = null;

            if (clsDataBeltTests.GetRowInfoByTestID(TestID, ref MemberID, ref RankID, ref Result, ref Date, ref TestedByInstructorID, ref PaymentID))
            {

                return new clsBeltTests(TestID, MemberID, RankID, Result, Date, TestedByInstructorID, PaymentID);
            }
            else
                return null;
        }
        public static DataTable GetAllRows()
        {
            DataTable DT = clsDataBeltTests.GetAllRows();
            return DT;
        }
        public static DataTable GetAllRows(int MemberID)
        {
            DataTable DT = clsDataBeltTests.GetAllRows(MemberID);
            return DT;
        }
        public static int CountBeltTests()
        {
            return (clsDataBeltTests.CountBeltTests());
        }
        public static bool DeleteRow(int TestID)
        {
            return (clsDataBeltTests.DeleteRow(TestID));
        }
        public static bool DoesRowExist(int TestID)
        {
            return (clsDataBeltTests.DoesRowExist(TestID));
        }
        public static bool GetPassLastRankNameForTests(int MemberID, int RankID)
        {
            return (clsDataBeltTests.GetPassLastRankNameForTests(MemberID,  RankID));
        }
        public int SavePayment(float fees)
        {
            clsPayments payments = new clsPayments();

            if (this.mode == enMode.eAddNew || this.PaymentID == null)
            {
                payments.Amount = fees;
                payments.PaymentFor = clsPayments.enPaymentFoer.BeltTest;
                payments.Date = DateTime.Now;
                payments.MemberID = this.MemberID;

                if (payments.Save())
                    return payments.PaymentID;
                else
                    return -1;
            }
            else
            {
                payments = clsPayments.FindByPaymentID((int)this.PaymentID);
                payments.Amount = this.BeltRanksInfo.TestFees;
                payments.Date = DateTime.Now;

                if (payments.Save())
                    return payments.PaymentID;
                else
                    return -1;
            }
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
