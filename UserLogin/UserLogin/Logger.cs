using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    static class Logger
    {
        static private List<string> currentSessionActivities = new List<string>();

        static public void LogActivity(string activity)
        {
            string activityLine = DateTime.Now + ";" + LoginValidation.currentUserUsername + ";" +
                LoginValidation.currentUserRole + ";" + activity; currentSessionActivities.Add(activityLine); 
        }

    }
}
