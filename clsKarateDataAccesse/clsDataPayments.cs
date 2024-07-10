using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsKarateDataAccesse
{
    public class clsDataPayments
    {
        public static bool GetRowInfoByPaymentID(int PaymentID, ref float Amount, ref DateTime Date, ref int MemberID,ref byte PaymentFor)
        {

            bool IsFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsAccesseSetting.ConnectionString))
                {
                    connection.Open();


                    using (SqlCommand Command = new SqlCommand("sp_GetPaymentsByID", connection))
                    {

                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("@PaymentID", PaymentID);


                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {

                            if (Reader.Read())
                            {
                                IsFound = true;
                                Amount = Convert.ToSingle(Reader["Amount"]);
                                Date = (DateTime)Reader["Date"];
                                MemberID = (int)Reader["MemberID"];
                                PaymentFor = (byte)Reader["PaymentFor"];


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
        public static int AddNewRow(float Amount, DateTime Date, int MemberID,byte PaymentFor)
        {

            int PaymentID = -1;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsAccesseSetting.ConnectionString))
                {
                    connection.Open();


                    using (SqlCommand Command = new SqlCommand("sp_AddNewPayment", connection))
                    {
                        Command.CommandType= CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("@Amount", Amount);
                        Command.Parameters.AddWithValue("@Date", Date);
                        Command.Parameters.AddWithValue("@MemberID", MemberID);
                        Command.Parameters.AddWithValue("@PaymentFor", PaymentFor);




                        SqlParameter outputIdParam = new SqlParameter("@PaymentID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        Command.Parameters.Add(outputIdParam);

                        Command.ExecuteNonQuery();

                        PaymentID = (int)Command.Parameters["@PaymentID"].Value;


                    }
                }
            }
            catch (Exception ex)
            {
                clsLoggingEvent.LoogingEvent("Error: " + ex.Message);
            }



            return PaymentID;

        }
        public static bool UpdateRow(int PaymentID, float Amount, DateTime Date, int MemberID, byte PaymentFor)
        {

            int RowsAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsAccesseSetting.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand Command = new SqlCommand("sp_UpdatePayment", connection))
                    {
                        Command.CommandType=CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("@PaymentID", PaymentID);
                        Command.Parameters.AddWithValue("@Amount", Amount);
                        Command.Parameters.AddWithValue("@Date", Date);
                        Command.Parameters.AddWithValue("@MemberID", MemberID);
                        Command.Parameters.AddWithValue("@PaymentFor", PaymentFor);



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


                    using (SqlCommand Command = new SqlCommand("sp_GetAllPayments", connection))
                    {

                        Command.CommandType=CommandType.StoredProcedure;

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


                    using (SqlCommand Command = new SqlCommand("sp_GetAllPaymentsByMemberID", connection))
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
        public static bool DeleteRow(int PaymentID)
        {

            int RowsAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsAccesseSetting.ConnectionString))
                {
                    connection.Open();


                    using (SqlCommand Command = new SqlCommand("sp_DeletePayments", connection))
                    {

                        Command.CommandType= CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@PaymentID", PaymentID);

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
        public static bool DoesRowExist(int PaymentID)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsAccesseSetting.ConnectionString))
                {
                    connection.Open();


                    using (SqlCommand Command = new SqlCommand("sp_CheckPaymentExite", connection))
                    {
                        Command.CommandType=CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("@PaymentID", PaymentID);

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
        public static int CountPayments()
        {

            int countCountPayments = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsAccesseSetting.ConnectionString))
                {
                    connection.Open();


                    using (SqlCommand Command = new SqlCommand("dbo.CountPayments", connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;


                        SqlParameter returnParameter = new SqlParameter(@"ReturnVal", SqlDbType.TinyInt)
                        {
                            Direction = ParameterDirection.ReturnValue
                        };
                        Command.Parameters.Add(returnParameter);

                        Command.ExecuteNonQuery();

                        countCountPayments = (int)returnParameter.Value;


                    }
                }
            }

            catch (Exception ex)
            {
                clsLoggingEvent.LoogingEvent("Error: " + ex.Message);
            }

            return countCountPayments;

        }
        public static int GetPaymentPayForWhat(int PaymentID,byte Choose)
        {

            int ID =-1;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsAccesseSetting.ConnectionString))
                {
                    connection.Open();


                    using (SqlCommand Command = new SqlCommand("SP_GetPaymentPayForWhat", connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("@PaymentID", PaymentID);
                        Command.Parameters.AddWithValue("@Choose", Choose);

                        SqlParameter returnParameter = new SqlParameter(@"ReturnVal", SqlDbType.TinyInt)
                        {
                            Direction = ParameterDirection.ReturnValue
                        };
                        Command.Parameters.Add(returnParameter);

                        Command.ExecuteNonQuery();

                        ID = (int)returnParameter.Value;


                    }
                }
            }

            catch (Exception ex)
            {
                clsLoggingEvent.LoogingEvent("Error: " + ex.Message);
            }

            return ID;

        }

    }
}
