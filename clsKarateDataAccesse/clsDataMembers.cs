using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsKarateDataAccesse
{
    public class clsDataMembers
    {
        public static bool GetRowInfoByMemberID(int MemberID, ref int PersonID, ref string EmergencyContactInfo, ref int LastBeltRank, ref bool IsActive)
        {

            bool IsFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsAccesseSetting.ConnectionString))
                {
                    connection.Open();

                    string Query = "";

                    using (SqlCommand Command = new SqlCommand("sp_GetMemberByID", connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("@MemberID", MemberID);


                        using (SqlDataReader   Reader = Command.ExecuteReader())
                        {

                            if (Reader.Read())
                            {
                                IsFound = true;
                                PersonID = (int)Reader["PersonID"];
                                EmergencyContactInfo = (string)Reader["EmergencyContactInfo"];
                                LastBeltRank = (int)Reader["LastBeltRank"];
                                IsActive = (bool)Reader["IsActive"];


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
        public static int AddNewRow(int PersonID, string EmergencyContactInfo, int LastBeltRank, bool IsActive)
        {

            int MemberID = -1;
            try
            {

                using (SqlConnection connection = new SqlConnection(clsAccesseSetting.ConnectionString))
                {
                    connection.Open();


                    using (SqlCommand Command = new SqlCommand("sp_AddNewMember", connection))
                    {
                        Command.CommandType= CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("@PersonID", PersonID);
                        Command.Parameters.AddWithValue("@EmergencyContactInfo", EmergencyContactInfo);
                        Command.Parameters.AddWithValue("@LastBeltRank", LastBeltRank);
                        Command.Parameters.AddWithValue("@IsActive", IsActive);



                        SqlParameter outputIdParam = new SqlParameter("@MemberID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        Command.Parameters.Add(outputIdParam);

                        Command.ExecuteNonQuery();

                        MemberID = (int)Command.Parameters["@MemberID"].Value;

                    }
                }

            }
            catch (Exception ex)
            {
                clsLoggingEvent.LoogingEvent("Error: " + ex.Message);
            }



            return MemberID;

        }
        public static bool UpdateRow(int MemberID, int PersonID, string EmergencyContactInfo, int LastBeltRank, bool IsActive)
        {

            int RowsAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsAccesseSetting.ConnectionString))
                {
                    connection.Open();



                    using (SqlCommand Command = new SqlCommand("sp_UpdateMember", connection))
                    {

                        Command.CommandType= CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("@MemberID", MemberID);
                        Command.Parameters.AddWithValue("@PersonID", PersonID);
                        Command.Parameters.AddWithValue("@EmergencyContactInfo", EmergencyContactInfo);
                        Command.Parameters.AddWithValue("@LastBeltRank", LastBeltRank);
                        Command.Parameters.AddWithValue("@IsActive", IsActive);



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


                    using (SqlCommand Command = new SqlCommand("sp_GetAllMember", connection))
                    {
                        Command.CommandType= CommandType.StoredProcedure;

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


                    using (SqlCommand Command = new SqlCommand("GetAllMembersTrainedByInstructor", connection))
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
        public static bool DeleteRow(int MemberID)
        {

            int RowsAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsAccesseSetting.ConnectionString))
                {
                    connection.Open();


                    using (SqlCommand Command = new SqlCommand("sp_DeleteMember", connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("@MemberID", MemberID);



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
        public static bool DoesRowExist(int MemberID)
        {
            bool IsFound = false;
            try
            {

                using (SqlConnection connection = new SqlConnection(clsAccesseSetting.ConnectionString))
                {
                    connection.Open();


                    using (SqlCommand Command = new SqlCommand("sp_CheckMemberExite", connection))
                    {
                        Command.CommandType=CommandType.StoredProcedure;

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
        public static bool CheckMemberIsActive(int MemberID)
        {
            bool IsFound = false;
            try
            {

                using (SqlConnection connection = new SqlConnection(clsAccesseSetting.ConnectionString))
                {
                    connection.Open();


                    using (SqlCommand Command = new SqlCommand("SP_CheckMemberIsActive", connection))
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
        public static int CountMembers()
        {

            int countMembers = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsAccesseSetting.ConnectionString))
                {
                    connection.Open();


                    using (SqlCommand Command = new SqlCommand("dbo.CountMembers", connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;


                        SqlParameter returnParameter = new SqlParameter(@"ReturnVal", SqlDbType.TinyInt)
                        {
                            Direction = ParameterDirection.ReturnValue
                        };
                        Command.Parameters.Add(returnParameter);

                        Command.ExecuteNonQuery();

                        countMembers = (int)returnParameter.Value;


                    }
                }
            }

            catch (Exception ex)
            {
                clsLoggingEvent.LoogingEvent("Error: " + ex.Message);
            }

            return countMembers;

        }

    }
}
