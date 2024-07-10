using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using clsKarateDataAccesse;
using static clsKarateBussinse.clsSubscriptionPeriods;

namespace clsKarateBussinse
{
    public class clsSubscriptionPeriods
    {
        public enum enMode { eAddNew = 0, eUpdate = 1 }
        public enMode mode = enMode.eAddNew;
        public enum enIssueReason { FirstTime = 1, Renew = 2 };
        public int PeriodID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public float Fees { get; set; }
        public bool Paid { get; set; }
        public int MemberID { get; set; }
        public clsMembers MemberInfo;
        public enIssueReason IssueReason { get; set; }
        public string IssueReasonText
        {
            get
            {
                return GetIssueReasonText(this.IssueReason);
            }
        }
        public byte SubscrpitonDays { get; set; }
        public Nullable< int> PaymentID { get; set; }
        public bool IsActive { get; set; }

        public clsSubscriptionPeriods()
        {
            PeriodID = -1;
            StartDate = DateTime.MinValue;
            EndDate = DateTime.MinValue;
            Fees = -1;
            Paid = false;
            MemberID = -1;
            PaymentID =null;
            IssueReason = enIssueReason.FirstTime;
            SubscrpitonDays = 1;
            IsActive = false;
            mode = enMode.eAddNew;
        }
        private clsSubscriptionPeriods(int PeriodID, DateTime StartDate, DateTime EndDate, float Fees, bool Paid, int MemberID, Nullable<int> PaymentID,enIssueReason issueReason,
            byte subscrpitonDays,bool IsActive)
        {

            this.PeriodID = PeriodID;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            this.Fees = Fees;
            this.Paid = Paid;
            this.MemberID = MemberID;
            MemberInfo = clsMembers.FindByMemberID(MemberID);
            this.PaymentID = PaymentID;
            this.IssueReason = issueReason;
            mode = enMode.eUpdate;
            this.SubscrpitonDays = subscrpitonDays;
            this.IsActive = IsActive;
        }

        bool _AddNewRow()
        {

            this.PeriodID = clsDataSubscriptionPeriods.AddNewRow(this.StartDate, this.EndDate, this.Fees, this.Paid, this.MemberID, this.PaymentID,(byte)this.IssueReason,this.SubscrpitonDays,this.IsActive);

            return this.PeriodID != -1;

        }
        bool _UpdateRow()
        {

            return clsDataSubscriptionPeriods.UpdateRow(this.PeriodID, this.StartDate, this.EndDate, this.Fees, this.Paid, this.MemberID, this.PaymentID, (byte)this.IssueReason, this.SubscrpitonDays,this.IsActive);


        }
        public static clsSubscriptionPeriods FindByPeriodID(int PeriodID)
        {

            DateTime StartDate = DateTime.MinValue;
            DateTime EndDate = DateTime.MinValue;
            float Fees = -1;
            bool Paid = false;
            int MemberID = -1;
            Nullable<int> PaymentID = null;
            byte IssueReason = 1;
            byte SubscrpitonDays = 1;
            bool IsActive = false;

            if (clsDataSubscriptionPeriods.GetRowInfoByPeriodID(PeriodID, ref StartDate, ref EndDate, ref Fees, ref Paid, ref MemberID, ref PaymentID, ref IssueReason,ref SubscrpitonDays,ref IsActive))
            {

                return new clsSubscriptionPeriods(PeriodID, StartDate, EndDate, Fees, Paid, MemberID, PaymentID, (enIssueReason)IssueReason, SubscrpitonDays,IsActive);
            }
            else
                return null;
        }
        public static string GetIssueReasonText(enIssueReason IssueReason)
        {

            switch (IssueReason)
            {
                case enIssueReason.FirstTime:
                    return "First Time";
                case enIssueReason.Renew:
                    return "Renew";
                default:
                    return "First Time";
            }
        }
        public static DataTable GetAllRows()
        {
            DataTable DT = clsDataSubscriptionPeriods.GetAllRows();
            return DT;
        }
        public static DataTable GetAllRows(int MemberID)
        {
            DataTable DT = clsDataSubscriptionPeriods.GetAllRows(MemberID);
            return DT;
        }
        public static int CountSubscriptionPeriods()
        {
            return (clsDataSubscriptionPeriods.CountSubscriptionPeriods());
        }
        public static bool DeleteRow(int PeriodID)
        {
            return (clsDataSubscriptionPeriods.DeleteRow(PeriodID));
        }
        public static bool DoesRowExist(int PeriodID)
        {
            return (clsDataSubscriptionPeriods.DoesRowExist(PeriodID));
        }
        public static bool CheckSubscriptionsIsNotPaid(int MemberID)
        {
            return (clsDataSubscriptionPeriods.CheckSubscriptionsIsNotPaid(MemberID));
        }
        public  bool CheckSubscriptionsIsNotPaid()
        {
            return (clsDataSubscriptionPeriods.CheckSubscriptionsIsNotPaid(this.MemberID));
        }
        public static bool CheckMemberHasPeriod(int MemberID)
        {
            return (clsDataSubscriptionPeriods.CheckMemberHasPeriod(MemberID));
        }
        public  bool CheckMemberHasPeriod()
        {
            return (clsDataSubscriptionPeriods.CheckMemberHasPeriod(this.MemberID));
        }
        public static bool CheckIsActiveAndIsPaid(int PeriodID)
        {
            return (clsDataSubscriptionPeriods.CheckIsActiveAndIsPaid(PeriodID));
        }
        public  bool CheckIsActiveAndIsPaid( )
        {
            return (clsDataSubscriptionPeriods.CheckIsActiveAndIsPaid(this.PeriodID));
        }
        public static bool CheckForDeletePeriod(int PeriodID)
        {
            return (clsDataSubscriptionPeriods.CheckForDeletePeriod(PeriodID));
        }
        public static bool CheckForPayPeriod(int PeriodID)
        {
            return (clsDataSubscriptionPeriods.CheckForPayPeriod(PeriodID));
        }
        public static bool CheckForRenewPeriod(int PeriodID)
        {
            return (clsDataSubscriptionPeriods.CheckForRenewPeriod(PeriodID));
        }
        public int SavePayment()
        {
            clsPayments payments = new clsPayments();

            if (this.mode == enMode.eAddNew|| this.PaymentID==null)
            {
                payments.Amount = this.Fees;
                payments.PaymentFor = clsPayments.enPaymentFoer.SubscriptionPeriod;
                payments.Date = DateTime.Now;
                payments.MemberID = this.MemberID;

                if (payments.Save())
                    return payments.PaymentID;
                else
                    return -1;
            }
            else
            {
                 payments =clsPayments.FindByPaymentID((int)this.PaymentID);
                payments.Amount = this.Fees;
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
        public int GetSubscriptionDays()
        {
            TimeSpan ts = new TimeSpan();
            ts = this.EndDate-this.StartDate ;
            return ts.Days;
        }
    }
}
