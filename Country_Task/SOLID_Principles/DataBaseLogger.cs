namespace SOLID_Principles
{
    public class DataBaseLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("message logged to Database");
        }
    }
}
