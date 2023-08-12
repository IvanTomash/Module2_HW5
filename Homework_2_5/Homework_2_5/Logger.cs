using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2_5
{
    internal class Logger
    {
        /// <summary>
        /// Store all logs in RAM.
        /// </summary>
        private string allLogs;
        public string AllLogs
        {
            get { return allLogs; }
        }

        private static readonly Logger Example = new Logger();

        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit
        static Logger()
        {
        }

        private Logger()
        {
        }

        /// <summary>
        /// Gets the instance. Used for Implementing the Singleton Pattern.
        /// </summary>
        public static Logger Instance
        {
            get
            {
                return Example;
            }
        }

        public void LogInfo(LogTypes type, string message)
        {
            string buf = $"{DateTime.Now.ToString()}\t{type}\t{message}";
            Console.WriteLine(buf);
            allLogs += buf;
        }
    }
}
