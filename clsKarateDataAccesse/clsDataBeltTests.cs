using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsKarateDataAccesse
{
    public class clsDataBeltTests
    {
        public static bool GetRowInfoByTestID(int TestID, ref int MemberID, ref int RankID, ref bool Result, ref DateTime Date, ref int TestedByInstructorID, ref Nullable<int> PaymentID)
        {

            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsAccesseSetting.ConnectionString))
                {
                    connection.Open();


                    using (SqlCommand Command = new SqlCommand("sp_GetBeltTestByID", connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("@TestID", TestID);

                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {

                            if (Reader.Read())
                            {
                                IsFound = true;
                                MemberID = (int)Reader["MemberID"];
                                RankID = (int)Reader["RankID"];
                                Result = (bool)Reader["Result"];
                                Date = (DateTime)Reader["Date"];
                                TestedByInstructorID = (int)Reader["TestedByInstructorID"];

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
        public static int AddNewRow(int MemberID, int RankID, bool Result, DateTime Date, int TestedByInstructorID, Nullable<int> PaymentID)
        {

            int TestID = -1;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsAccesseSetting.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand Command = new SqlCommand("sp_AddNewTest", connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("@MemberID", MemberID);
                        Command.Parameters.AddWithValue("@RankID", RankID);
                        Command.Parameters.AddWithValue("@Result", Result);
                        Command.Parameters.AddWithValue("@Date", Date);
                        Command.Parameters.AddWithValue("@TestedByInstructorID", TestedByInstructorID);


                        if (PaymentID.HasValue)
                            Command.Parameters.AddWithValue("@PaymentID", PaymentID);
                        else
                            Command.Parameters.AddWithValue("@PaymentID", DBNull.Value);



                        //  object Result = Command.ExecuteScalar();

                        SqlParameter outputIdParam = new SqlParameter("@TestID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        Command.Parameters.Add(outputIdParam);

                        Command.ExecuteNonQuery();

                        TestID = (int)Command.Parameters["@TestID"].Value;

                    }
                }
            }
            catch (Exception ex)
            {
                clsLoggingEvent.LoogingEvent("Error: " + ex.Message);
            }


            return TestID;

        }
        public static bool UpdateRow(int TestID, int MemberID, int RankID, bool Result, DateTime Date, int TestedByInstructorID, Nullable<int> PaymentID)
        {

            int RowsAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsAccesseSetting.ConnectionString))
                {
                    connection.Open();




                    using (SqlCommand Command = new SqlCommand("sp_UpdateTest", connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("@TestID", TestID);
                        Command.Parameters.AddWithValue("@MemberID", MemberID);
                        Command.Parameters.AddWithValue("@RankID", RankID);
                        Command.Parameters.AddWithValue("@Result", Result);
                        Command.Parameters.AddWithValue("@Date", Date);
                        Command.Parameters.AddWithValue("@TestedByInstructorID", TestedByInstructorID);


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


                    using (SqlCommand Command = new SqlCommand("sp_GetAllBeltTests", connection))
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


                    using (SqlCommand Command = new SqlCommand("sp_GetAllBeltTestsByMemberID", connection))
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
        public static bool DeleteRow(int TestID)
        {

            int RowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsAccesseSetting.ConnectionString))
                {
                    connection.Open();


                    using (SqlCommand Command = new SqlCommand("sp_DeleteBeltTest", connection))
                    {
                        Command.CommandType=CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@TestID", TestID);


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
        public static bool DoesRowExist(int TestID)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsAccesseSetting.ConnectionString))
                {
                    connection.Open();


                    using (SqlCommand Command = new SqlCommand("sp_CheckBeltTestExist", connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@TestID", TestID);



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
        public static int CountBeltTests()
        {

            int countBeltTests = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsAccesseSetting.ConnectionString))
                {
                    connection.Open();


                    using (SqlCommand Command = new SqlCommand("dbo.CountBeltTests", connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;


                        SqlParameter returnParameter = new SqlParameter(@"CountBeltTests", SqlDbType.TinyInt)
                        {
                            Direction = ParameterDirection.ReturnValue
                        };
                        Command.Parameters.Add(returnParameter);

                        Command.ExecuteNonQuery();

                        countBeltTests = (int)returnParameter.Value;


                    }
                }
            }

            catch (Exception ex)
            {
                clsLoggingEvent.LoogingEvent("Error: " + ex.Message);
            }

            return countBeltTests;

        }
        public static bool GetPassLastRankNameForTests(int MemberID,int RankID )
        {

            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsAccesseSetting.ConnectionString))
                {
                    connection.Open();


                    using (SqlCommand Command = new SqlCommand("CheckPassLastRankNameForTest", connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("@MemberID", MemberID);
                        Command.Parameters.AddWithValue("@RankID", RankID);

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
