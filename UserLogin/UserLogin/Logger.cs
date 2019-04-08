using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace UserLogin
{
    static class Logger
    {
        private static List<string> currentSessionActivities = new List<string>();
        static string LOG_FILE = "log.txt";

        public static void LogActivity(string activity)
        {
            string activityLine = DateTime.Now + ";" + LoginValidation.currentUserUsername + ";" +
                LoginValidation.currentUserRole + ";" + activity; currentSessionActivities.Add(activityLine);
            writeToLogFile(activityLine);
        }

        public static void writeToLogFile(string activityLine)
        {
            if (File.Exists(LOG_FILE) == true)
            {
                File.AppendAllText(LOG_FILE, activityLine);
            }
        }

    }
}
