using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace clsKarateDataAccesse
{
    public class clsDataSubscriptionPeriods
    {
        public static bool GetRowInfoByPeriodID(int PeriodID, ref DateTime StartDate, ref DateTime EndDate, ref float Fees, ref bool Paid, ref int MemberID,
            ref Nullable<int> PaymentID,ref byte IssueReason,ref byte  SubscrpitonDays, ref bool IsActive)
        {

            bool IsFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsAccesseSetting.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand Command = new SqlCommand("sp_GetSubscriptionPeriodsByID", connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("@PeriodID", PeriodID);


                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {

                            if (Reader.Read())
                            {
                                IsFound = true;
                                StartDate = (DateTime)Reader["StartDate"];
                                EndDate = (DateTime)Reader["EndDate"];
                                Fees = Convert.ToSingle(Reader["Fees"]);
                                Paid = (bool)Reader["Paid"];
                                MemberID = (int)Reader["MemberID"];
                                IssueReason = (byte)Reader["IssueReason"];
                                SubscrpitonDays = (byte)Reader["SubscrpitonDays"];
                                IsActive = (bool)Reader["IsActive"];


                                if (Reader["PaymentID"] != DBNull.Value)
                                {
                                    PaymentID = (int)Reader["PaymentID"];
                                }
                                else
                                {
                                    PaymentID = null;
                                }


                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clsLoggingEvent.LoogingEvent("Error: " + ex.Message);
            }


            return IsFound;


        }
        public static int AddNewRow(DateTime StartDate, DateTime EndDate, float Fees, bool Paid, int MemberID, Nullable<int> PaymentID,byte IssueReason, byte SubscrpitonDays, bool IsActive)
        {

            int PeriodID = -1;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsAccesseSetting.ConnectionString))
                {
                    connection.Open();


                    using (SqlCommand Command = new SqlCommand("sp_AddNewSubscriptionPeriods", connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("@StartDate", StartDate);
                        Command.Parameters.AddWithValue("@EndDate", EndDate);
                        Command.Parameters.AddWithValue("@Fees", Fees);
                        Command.Parameters.AddWithValue("@Paid", Paid);
                        Command.Parameters.AddWithValue("@MemberID", MemberID);
                        Command.Parameters.AddWithValue("@IssueReason", IssueReason);
                        Command.Parameters.AddWithValue("@SubscrpitonDays", SubscrpitonDays);
                        Command.Parameters.AddWithValue("@IsActive", IsActive);


                        if (PaymentID.HasValue)
                            Command.Parameters.AddWithValue("@PaymentID", PaymentID);
                        else
                            Command.Parameters.AddWithValue("@PaymentID", DBNull.Value);


                        SqlParameter outputIdParam = new SqlParameter("@PeriodID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        Command.Parameters.Add(outputIdParam);

                        Command.ExecuteNonQuery();

                        PeriodID = (int)Command.Parameters["@PeriodID"].Value;

                    }
                }
            }
            catch (Exception ex)
            {
                clsLoggingEvent.LoogingEvent("Error: " + ex.Message);
            }



            return PeriodID;

        }
       public static bool UpdateRow(int PeriodID, DateTime StartDate, DateTime EndDate, float Fees, bool Paid, int MemberID, Nullable<int> PaymentID, byte IssueReason, byte SubscrpitonDays, bool IsActive)
        {

            int RowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsAccesseSetting.ConnectionString))
                {
                    connection.Open();


                    using (SqlCommand Command = new SqlCommand("sp_UpadteSubscriptionPeriods", connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("@PeriodID", PeriodID);
                        Command.Parameters.AddWithValue("@StartDate", StartDate);
                        Command.Parameters.AddWithValue("@EndDate", EndDate);
                        Command.Parameters.AddWithValue("@Fees", Fees);
                        Command.Parameters.AddWithValue("@Paid", Paid);
                        Command.Parameters.AddWithValue("@MemberID", MemberID);
                        Command.Parameters.AddWithValue("@IssueReason", IssueReason);
                        Command.Parameters.AddWithValue("@SubscrpitonDays", SubscrpitonDays);
                        Command.Parameters.AddWithValue("@IsActive", IsActive);


                        if (PaymentID.HasValue)
                            Command.Parameters.AddWithValue("@PaymentID", PaymentID);
                        else
                            Command.Parameters.AddWithValue("@PaymentID", DBNull.Value);


                        RowsAffected = Command.ExecuteNonQuery();

                    }
                }
            }
            catch (Exception ex)
            {
                clsLoggingEvent.LoogingEvent("Error: " + ex.Message);

                return false;
            }
        
            return (RowsAffected > 0);

        }
        public static DataTable GetAllRows()
        {

            DataTable DT = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsAccesseSetting.ConnectionString))
                {
                    connection.Open();


                    using (SqlCommand Command = new SqlCommand("sp_GetALLSubscriptionPeriods", connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {

                            while (Reader.HasRows)
                            {
                                DT.Load(Reader);
                            }

                        }
                    }
                }

            }
            catch (Exception ex)
            {
                clsLoggingEvent.LoogingEvent("Error: " + ex.Message);
            }


            return DT;

        }
        public static DataTable GetAllRows(int MemberID)
        {

            DataTable DT = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsAccesseSetting.ConnectionString))
                {
                    connection.Open();


                    using (SqlCommand Command = new SqlCommand("sp_GetALLSubscriptionPeriodsByMemberID", connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@MemberID", MemberID);

                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {

                            while (Reader.HasRows)
                            {
                                DT.Load(Reader);
                            }

                        }
                    }
                }

            }
            catch (Exception ex)
            {
                clsLoggingEvent.LoogingEvent("Error: " + ex.Message);
            }


            return DT;

        }
        public static bool DeleteRow(int PeriodID)
        {

            int RowsAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsAccesseSetting.ConnectionString))
                {
                    connection.Open();


                    using (SqlCommand Command = new SqlCommand("sp_DELETESubscriptionPeriods", connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("@PeriodID", PeriodID);



                        RowsAffected = Command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                clsLoggingEvent.LoogingEvent("Error: " + ex.Message);
            }


            return (RowsAffected > 0);

        }
        public static bool DoesRowExist(int PeriodID)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsAccesseSetting.ConnectionString))
                {
                    connection.Open();


                    using (SqlCommand Command = new SqlCommand("sp_CheckSubscriptionPeriodsExite", connection))
                    {
                        Command.CommandType=CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("@PeriodID", PeriodID);



                        SqlParameter returnParameter = new SqlParameter(@"ReturnVal", SqlDbType.TinyInt)
                        {
                            Direction = ParameterDirection.ReturnValue
                        };
                        Command.Parameters.Add(returnParameter);

                        Command.ExecuteNonQuery();

                        IsFound = ((int)returnParameter.Value == 1);
                    }
                }

            }
            catch (Exception ex)
            {
                clsLoggingEvent.LoogingEvent("Error: " + ex.Message);
            }


            return IsFound;
        }
        public static int CountSubscriptionPeriods()
        {

            int countSubscriptionPeriods = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsAccesseSetting.ConnectionString))
                {
                    connection.Open();


                    using (SqlCommand Command = new SqlCommand("dbo.CountSubscriptionPeriods", connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;


                        SqlParameter returnParameter = new SqlParameter(@"ReturnVal", SqlDbType.TinyInt)
                        {
                            Direction = ParameterDirection.ReturnValue
                        };
                        Command.Parameters.Add(returnParameter);

                        Command.ExecuteNonQuery();

                        countSubscriptionPeriods = (int)returnParameter.Value;


                    }
                }
            }

            catch (Exception ex)
            {
                clsLoggingEvent.LoogingEvent("Error: " + ex.Message);
            }

            return countSubscriptionPeriods;

        }
        public static bool CheckSubscriptionsIsNotPaid(int MemberID)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsAccesseSetting.ConnectionString))
                {
                    connection.Open();


                    using (SqlCommand Command = new SqlCommand("SP_CheckSubscriptionsIsNotPaid", connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("@MemberID", MemberID);



                        SqlParameter returnParameter = new SqlParameter(@"ReturnVal", SqlDbType.TinyInt)
                        {
                            Direction = ParameterDirection.ReturnValue
                        };
                        Command.Parameters.Add(returnParameter);

                        Command.ExecuteNonQuery();

                        IsFound = ((int)returnParameter.Value == 1);
                    }
                }

            }
            catch (Exception ex)
            {
                clsLoggingEvent.LoogingEvent("Error: " + ex.Message);
            }


            return IsFound;
        }
        public static bool CheckIsActiveAndIsPaid(int PeriodID)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsAccesseSetting.ConnectionString))
                {
                    connection.Open();


                    using (SqlCommand Command = new SqlCommand("SP_CheckIsActiveAndIsPaid", connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("@PeriodID", PeriodID);



                        SqlParameter returnParameter = new SqlParameter(@"ReturnVal", SqlDbType.TinyInt)
                        {
                            Direction = ParameterDirection.ReturnValue
                        };
                        Command.Parameters.Add(returnParameter);

                        Command.ExecuteNonQuery();

                        IsFound = ((int)returnParameter.Value == 1);
                    }
                }

            }
            catch (Exception ex)
            {
                clsLoggingEvent.LoogingEvent("Error: " + ex.Message);
            }


            return IsFound;
        }
        public static bool CheckForDeletePeriod(int PeriodID)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsAccesseSetting.ConnectionString))
                {
                    connection.Open();


                    using (SqlCommand Command = new SqlCommand("SP_CheckForDeletePeriod", connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("@PeriodID", PeriodID);



                        SqlParameter returnParameter = new SqlParameter(@"ReturnVal", SqlDbType.TinyInt)
                        {
                            Direction = ParameterDirection.ReturnValue
                        };
                        Command.Parameters.Add(returnParameter);

                        Command.ExecuteNonQuery();

                        IsFound = ((int)returnParameter.Value == 1);
                    }
                }

            }
            catch (Exception ex)
            {
                clsLoggingEvent.LoogingEvent("Error: " + ex.Message);
            }


            return IsFound;
        }
        public static bool CheckForPayPeriod(int PeriodID)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsAccesseSetting.ConnectionString))
                {
                    connection.Open();


                    using (SqlCommand Command = new SqlCommand("SP_CheckForPayPeriod", connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("@PeriodID", PeriodID);



                        SqlParameter returnParameter = new SqlParameter(@"ReturnVal", SqlDbType.TinyInt)
                        {
                            Direction = ParameterDirection.ReturnValue
                        };
                        Command.Parameters.Add(returnParameter);

                        Command.ExecuteNonQuery();

                        IsFound = ((int)returnParameter.Value == 1);
                    }
                }

            }
            catch (Exception ex)
            {
                clsLoggingEvent.LoogingEvent("Error: " + ex.Message);
            }


            return IsFound;
        }
        public static bool CheckForRenewPeriod(int PeriodID)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsAccesseSetting.ConnectionString))
                {
                    connection.Open();


                    using (SqlCommand Command = new SqlCommand("SP_CheckForRenewPeriod", connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("@PeriodID", PeriodID);



                        SqlParameter returnParameter = new SqlParameter(@"ReturnVal", SqlDbType.TinyInt)
                        {
                            Direction = ParameterDirection.ReturnValue
                        };
                        Command.Parameters.Add(returnParameter);

                        Command.ExecuteNonQuery();

                        IsFound = ((int)returnParameter.Value == 1);
                    }
                }

            }
            catch (Exception ex)
            {
                clsLoggingEvent.LoogingEvent("Error: " + ex.Message);
            }


            return IsFound;
        }
        public static bool CheckMemberHasPeriod(int MemberID)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsAccesseSetting.ConnectionString))
                {
                    connection.Open();


                    using (SqlCommand Command = new SqlCommand("sp_CheckMemberHasPeriod", connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("@MemberID", MemberID);

                        SqlParameter returnParameter = new SqlParameter(@"ReturnVal", SqlDbType.TinyInt)
                        {
                            Direction = ParameterDirection.ReturnValue
                        };
                        Command.Parameters.Add(returnParameter);

                        Command.ExecuteNonQuery();

                        IsFound = ((int)returnParameter.Value == 1);
                    }
                }

            }
            catch (Exception ex)
            {
                clsLoggingEvent.LoogingEvent("Error: " + ex.Message);
            }


            return IsFound;
        }

    }
}
