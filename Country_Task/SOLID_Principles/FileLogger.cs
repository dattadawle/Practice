using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles
{
    public class FileLogger
    {
    public  void logger(string ErrorMessage)
        {
            File.AppendAllText(@"Logs/Errors.txt", $"{ErrorMessage}");
        }
    }

}
