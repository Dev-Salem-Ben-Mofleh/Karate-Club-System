using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices.ComTypes;

namespace clsKarateDataAccesse
{
    public class clsDataSetting
    {
        public static byte GetRowInfoByPeriodID()
        {

            try
            {
                using (SqlConnection connection = new SqlConnection(clsAccesseSetting.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand Command = new SqlCommand("sp_GetNumberOfPeriod", connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;


                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {

                            if (Reader.Read())
                            {
                                return( (byte)Reader["PeriodDay"]);
                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clsLoggingEvent.LoogingEvent("Error: " + ex.Message);
            }


            return 1;

        }
    }
}
