using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace QzX
{
    public class Logger
    {
        private static string logPath = "config//log.txt";

        public static void Log(string message)
        {
            string logLine = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} | {message}";
            File.AppendAllText(logPath, logLine + Environment.NewLine);
        }

        public static void LogStart()
        {
            File.AppendAllText(logPath, "--------------------------------------" + Environment.NewLine);
        }

        public static void LogResult(List<string> names, int[] points)
        {
            string braker = "----------------------------------------";
            string logLine = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - End Game Results:";
            File.AppendAllText(logPath, braker + Environment.NewLine);
            File.AppendAllText(logPath, logLine + Environment.NewLine);

            for (int i = 0; i < names.Count; i++)
            {
                logLine = $"{names[i]}-{points[i]}";
                File.AppendAllText(logPath, logLine + Environment.NewLine);
            }
        }


    }
}
