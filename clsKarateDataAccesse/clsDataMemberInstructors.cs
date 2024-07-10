using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsKarateDataAccesse
{
    public class clsDataMemberInstructors
    {
        public static bool GetRowInfoByMemberID(int MemberInstructorID ,ref int MemberID, ref int InstructorID, ref DateTime AssignDate)
        {

            bool IsFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsAccesseSetting.ConnectionString))
                {
                    connection.Open();


                    using (SqlCommand Command = new SqlCommand("sp_GetMemberInstructorByID", connection))
                    {
                        Command.CommandType=CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("@MemberInstructorID", MemberInstructorID);


                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {

                            if (Reader.Read())
                            {
                                IsFound = true;
                                MemberID = (int)Reader["MemberID"];
                                InstructorID = (int)Reader["InstructorID"];
                                AssignDate = (DateTime)Reader["AssignDate"];


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
        public static int AddNewRow(int MemberID,int InstructorID, DateTime AssignDate)
        {

            int MemberInstructorID = -1;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsAccesseSetting.ConnectionString))
                {
                    connection.Open();


                    using (SqlCommand Command = new SqlCommand("sp_AddNewMemberInstructors", connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("@MemberID", MemberID);
                        Command.Parameters.AddWithValue("@InstructorID", InstructorID);
                        Command.Parameters.AddWithValue("@AssignDate", AssignDate);




                        SqlParameter outputIdParam = new SqlParameter("@MemberInstructorID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        Command.Parameters.Add(outputIdParam);

                        Command.ExecuteNonQuery();

                        MemberInstructorID = (int)Command.Parameters["@MemberInstructorID"].Value;


                    }
                }
            }
            catch (Exception ex)
            {
                clsLoggingEvent.LoogingEvent("Error: " + ex.Message);
            }


            return MemberInstructorID;

        }
        public static bool UpdateRow(int MemberInstructorID,int MemberID, int InstructorID, DateTime AssignDate)
        {

            int RowsAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsAccesseSetting.ConnectionString))
                {
                    connection.Open();



                    using (SqlCommand Command = new SqlCommand("sp_UpdateMemberInstructors", connection))
                    {

                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("@MemberInstructorID", MemberInstructorID);
                        Command.Parameters.AddWithValue("@MemberID", MemberID);
                        Command.Parameters.AddWithValue("@InstructorID", InstructorID);
                        Command.Parameters.AddWithValue("@AssignDate", AssignDate);



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


                    using (SqlCommand Command = new SqlCommand("sp_GetAllMemberInstructors", connection))
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
        public static bool DeleteRow(int MemberInstructorID)
        {

            int RowsAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsAccesseSetting.ConnectionString))
                {
                    connection.Open();


                    using (SqlCommand Command = new SqlCommand("sp_DeleteMemberInstructor", connection))
                    {
                        Command.CommandType=CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("@MemberInstructorID", MemberInstructorID);



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
        public static bool DoesRowExist(int MemberInstructorID)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsAccesseSetting.ConnectionString))
                {
                    connection.Open();


                    using (SqlCommand Command = new SqlCommand("sp_CheckMemberInstructorExist", connection))
                    {
                        Command.CommandType= CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@MemberInstructorID", MemberInstructorID);


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
        public static bool CheckMemberHasSameInstructor(int MemberID,int InstructorID)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsAccesseSetting.ConnectionString))
                {
                    connection.Open();


                    using (SqlCommand Command = new SqlCommand("SP_CheckMemberHasSameInstructor", connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@MemberID", MemberID);
                        Command.Parameters.AddWithValue("@InstructorID", InstructorID);


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
