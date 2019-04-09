using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace UserLogin
{
    public static class Logger
    {
        private static List<string> currentSessionActivities = new List<string>();
        public static string LOG_FILE = "log.txt";

        public static void LogActivity(string activity)
        {
            string activityLine = DateTime.Now + "; " + LoginValidation.currentUserUsername + "; " +
                LoginValidation.currentUserRole + "; " + activity + "\n"; 
            currentSessionActivities.Add(activityLine);
            writeToLogFile(activityLine);
        }

        public static void writeToLogFile(string activityLine)
        {
            if (File.Exists(LOG_FILE) == true)
            {
                File.AppendAllText(LOG_FILE, activityLine);
            }
        }

        public static void viewLogActivity()
        {
            if (File.Exists(LOG_FILE) == true)
            {
                string text = File.ReadAllText(LOG_FILE);
                Console.WriteLine(text);
            }
        }

        public static void getCurrentSessionActivities(string filter)
        {
            StringBuilder stringBuilder = new StringBuilder();
            List<string> filteredActivities = (from activity in currentSessionActivities
                                               where activity.Contains(filter)
                                               select activity).ToList();

            foreach (var action in filteredActivities) 
            {    
                stringBuilder.Append(action);
            }

            Console.WriteLine(stringBuilder.ToString());
        }
    }
}
