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
    public class clsBeltRanks
    {
        public enum enMode { eAddNew = 0, eUpdate = 1 }
        public enMode mode = enMode.eAddNew;

        public int RankID { get; set; }
        public string RankName { get; set; }
        public float TestFees { get; set; }

        public clsBeltRanks()
        {
            RankID = -1;
            RankName = "";
            TestFees = -1;

            mode = enMode.eAddNew;
        }
        private clsBeltRanks(int RankID, string RankName, float TestFees)
        {

            this.RankID = RankID;
            this.RankName = RankName;
            this.TestFees = TestFees;

            mode = enMode.eUpdate;

        }

        bool _AddNewRow()
        {

            this.RankID = clsDataBeltRanks.AddNewRow(this.RankName, this.TestFees);

            return this.RankID != -1;

        }
        bool _UpdateRow()
        {

            return clsDataBeltRanks.UpdateRow(this.RankID, this.RankName, this.TestFees);


        }
        public static clsBeltRanks FindByRankID(int RankID)
        {

            string RankName = "";
            float TestFees = -1;


            if (clsDataBeltRanks.GetRowInfoByRankID(RankID, ref RankName, ref TestFees))
            {

                return new clsBeltRanks(RankID, RankName, TestFees);
            }
            else
                return null;
        }
        public static DataTable GetAllRows()
        {
            DataTable DT = clsDataBeltRanks.GetAllRows();
            return DT;
        }
        public static bool DeleteRow(int RankID)
        {
            return (clsDataBeltRanks.DeleteRow(RankID));
        }
        public static bool DoesRowExist(int RankID)
        {
            return (clsDataBeltRanks.DoesRowExist(RankID));
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
