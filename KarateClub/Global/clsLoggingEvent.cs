using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarateClub
{
    public class clsLoggingEvent
    {
        public static void LoogingEvent(string ErrorMessage)
        {
            string sourceName = "KarateApp";

            if (!EventLog.SourceExists(sourceName))
            {
                EventLog.CreateEventSource(sourceName, "Application");
            }
            EventLog.WriteEntry(sourceName, ErrorMessage, EventLogEntryType.Error);
        }

    }
}
