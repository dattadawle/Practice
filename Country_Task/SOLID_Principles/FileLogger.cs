using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles
{
    public class FileLogger :ILogger
    {
        public void Log(string message)
        {
            File.AppendAllText(@"Logs/Errors.txt", $"{message}");
            Console.WriteLine("message logged to File");
        }

        /* public  void logger(string ErrorMessage)
         {
             File.AppendAllText(@"Logs/Errors.txt", $"{ErrorMessage}");
         }*/
    }

}
