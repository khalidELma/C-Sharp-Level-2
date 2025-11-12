using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegation_test1__Delegation_
{

   public class Logger
    {
        public delegate void LogAction(string message);

         LogAction _logAction;

        public Logger(LogAction logAction)
        {
            _logAction = logAction;
        }

        public void Log(string message) { 

            _logAction(message);

        }


    }
    internal class Program
    {

        static void LogToConsole(string message) { 
        
            Console.WriteLine(message);
        
        }
        static void LogToFile(string message) {

            string FileName = "Log.txt";
            using (StreamWriter writer = new StreamWriter(FileName, true))
            {
                writer.WriteLine(message);
            }
                
        
        }

        static void DBLog(string message)
        {
            //You can to write your code her 
            Console.WriteLine(message);

        }
        static void Main(string[] args)
        {
            Logger Console = new Logger(LogToConsole);
            Logger LogFile = new Logger(LogToFile);



            Console.Log("Hello Im Her in the Console");

            LogFile.Log("Hello Im Her in the File");
        }
    }
}
