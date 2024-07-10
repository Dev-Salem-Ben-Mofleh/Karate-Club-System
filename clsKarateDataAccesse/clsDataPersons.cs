using clsKarateDataAccesse;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsKarateDataAccesseLayer
{
    public class clsDataPerson
    {
        public static bool GetRowInfoByPersonID(int PersonID, ref string Name, ref string Address, ref string Phone, ref DateTime DateOfBirth, ref byte Gender, ref string Email,ref string ImagePath)
        {

            bool IsFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsAccesseSetting.ConnectionString))
                {
                    connection.Open();


                    using (SqlCommand Command = new SqlCommand("sp_GetPersonByID", connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("@PersonID", PersonID);


                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {

                            if (Reader.Read())
                            {
                                IsFound = true;
                                Name = (string)Reader["Name"];
                                Address = (string)Reader["Address"];
                                Phone = (string)Reader["Phone"];
                                DateOfBirth = (DateTime)Reader["DateOfBirth"];
                                Gender = (byte)Reader["Gender"];
                                ImagePath = (string)Reader["ImagePath"];
                                if (Reader["Email"] != DBNull.Value)
                                {
                                    Email = (string)Reader["Email"];
                                }
                                else
                                {
                                    Email = "";
                                }
                                if (Reader["ImagePath"] != DBNull.Value)
                                {
                                    ImagePath = (string)Reader["ImagePath"];
                                }
                                else
                                {
                                    ImagePath = "";
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
        public static int AddNewRow(string Name, string Address, string Phone, DateTime DateOfBirth, byte Gender, string Email, string ImagePath)
        {

            int PersonID = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsAccesseSetting.ConnectionString))

                {
                    connection.Open();


                    using (SqlCommand Command = new SqlCommand("SP_AddNewPerson", connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("@Name", Name);
                        Command.Parameters.AddWithValue("@Address", Address);
                        Command.Parameters.AddWithValue("@Phone", Phone);
                        Command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                        Command.Parameters.AddWithValue("@Gender", Gender);

                        if (Email != null && Email.ToString() != string.Empty)
                            Command.Parameters.AddWithValue("@Email", Email);
                        else
                            Command.Parameters.AddWithValue("@Email", DBNull.Value);


                        if (ImagePath != "" && ImagePath != null)
                            Command.Parameters.AddWithValue("@ImagePath", ImagePath);
                        else
                            Command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);


                        SqlParameter outputIdParam = new SqlParameter("@PersonID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        Command.Parameters.Add(outputIdParam);

                        Command.ExecuteNonQuery();

                        PersonID = (int)Command.Parameters["@PersonID"].Value;

                    }
                }
            }
            catch (Exception ex)
            {
                clsLoggingEvent.LoogingEvent("Error: " + ex.Message);
            }


            return PersonID;

        }
        public static bool UpdateRow(int PersonID, string Name, string Address, string Phone, DateTime DateOfBirth, byte Gender, string Email, string ImagePath)
        {

            int RowsAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsAccesseSetting.ConnectionString))
                {
                    connection.Open();



                    using (SqlCommand Command = new SqlCommand("sp_UpdatePerson", connection))
                    {

                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("@PersonID", PersonID);
                        Command.Parameters.AddWithValue("@Name", Name);
                        Command.Parameters.AddWithValue("@Address", Address);
                        Command.Parameters.AddWithValue("@Phone", Phone);
                        Command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                        Command.Parameters.AddWithValue("@Gender", Gender);

                        if (Email != null && Email.ToString() != string.Empty)
                            Command.Parameters.AddWithValue("@Email", Email);
                        else
                            Command.Parameters.AddWithValue("@Email", DBNull.Value);

                        if (ImagePath != null && ImagePath.ToString() != string.Empty)
                            Command.Parameters.AddWithValue("@ImagePath", ImagePath);
                        else
                            Command.Parameters.AddWithValue("@ImagePath", DBNull.Value);



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


                    using (SqlCommand Command = new SqlCommand("sp_GetAllPeople", connection))
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
        public static bool DoesRowExist(int PersonID)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsAccesseSetting.ConnectionString))
                {
                    connection.Open();


                    using (SqlCommand Command = new SqlCommand("SP_CheckPersonExists", connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("@PersonID", PersonID);


                        int Result=(int)Command.ExecuteScalar();

                        IsFound = (Result > 0);
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
