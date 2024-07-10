using clsKarateDataAccesse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsKarateBussinse
{
    public class clsSettting
    {
        public static byte PeriodDay ()
        {
            return (clsDataSetting.GetRowInfoByPeriodID());

        }

    }
}
