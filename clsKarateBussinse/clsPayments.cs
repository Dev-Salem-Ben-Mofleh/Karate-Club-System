using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using clsKarateDataAccesse;
using static clsKarateBussinse.clsSubscriptionPeriods;

namespace clsKarateBussinse
{
    public class clsPayments
    {
        public enum enMode { eAddNew = 0, eUpdate = 1 }
        public enMode mode = enMode.eAddNew;
        public enum enPaymentFoer{ SubscriptionPeriod = 1, BeltTest = 2 };
        public int PaymentID { get; set; }
        public float Amount { get; set; }
        public DateTime Date { get; set; }
        public int MemberID { get; set; }
        public clsMembers MembersInfo;
        public enPaymentFoer PaymentFor { get; set; }
        public string PaymentForText
        {
            get
            {
                return GetPaymentForText(this.PaymentFor);
            }
        }

        public clsPayments()
        {
            PaymentID = -1;
            Amount = -1;
            Date = DateTime.MinValue;
            MemberID = -1;
            PaymentFor = enPaymentFoer.SubscriptionPeriod;
            mode = enMode.eAddNew;
        }
        private clsPayments(int PaymentID, float Amount, DateTime Date, int MemberID,enPaymentFoer paymentFoer)
        {

            this.PaymentID = PaymentID;
            this.Amount = Amount;
            this.Date = Date;
            this.MemberID = MemberID;
            MembersInfo = clsMembers.FindByMemberID(MemberID);
            this.PaymentFor = paymentFoer;
            mode = enMode.eUpdate;

        }

        bool _AddNewRow()
        {

            this.PaymentID = clsDataPayments.AddNewRow(this.Amount, this.Date, this.MemberID,(byte)this.PaymentFor);

            return this.PaymentID != -1;

        }
        bool _UpdateRow()
        {

            return clsDataPayments.UpdateRow(this.PaymentID, this.Amount, this.Date, this.MemberID, (byte)this.PaymentFor);


        }
        public static clsPayments FindByPaymentID(int PaymentID)
        {

            float Amount = -1;
            DateTime Date = DateTime.MinValue;
            int MemberID = -1;
            byte PaymentFor = 1;

            if (clsDataPayments.GetRowInfoByPaymentID(PaymentID, ref Amount, ref Date, ref MemberID,ref PaymentFor))
            {

                return new clsPayments(PaymentID, Amount, Date, MemberID,(enPaymentFoer)PaymentFor);
            }
            else
                return null;
        }
        public static string GetPaymentForText(enPaymentFoer IssueReason)
        {

            switch (IssueReason)
            {
                case enPaymentFoer.SubscriptionPeriod:
                    return "Subscription Period";
                case enPaymentFoer.BeltTest:
                    return "Belt Test";
                default:
                    return "Subscription Period";
            }
        }
        public static int CountPayments()
        {
            return clsDataPayments.CountPayments();
        }
        public static int GetPaymentPayForWhat(int PaymentID,byte Choose)
        {
            return clsDataPayments.GetPaymentPayForWhat(PaymentID, Choose);
        }
        public static DataTable GetAllRows()
        {
            DataTable DT = clsDataPayments.GetAllRows();
            return DT;
        }
        public static DataTable GetAllRows(int MemberID)
        {
            DataTable DT = clsDataPayments.GetAllRows(MemberID);
            return DT;
        }
        public static bool DeleteRow(int PaymentID)
        {
            return (clsDataPayments.DeleteRow(PaymentID));
        }
        public static bool DoesRowExist(int PaymentID)
        {
            return (clsDataPayments.DoesRowExist(PaymentID));
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
