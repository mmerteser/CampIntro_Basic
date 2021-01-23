namespace OOP3
{
    internal class SmsLoggerService : ILoggerService
    {
        public void Log()
        {
            System.Console.WriteLine("Sms yollandı");
        }
    }
}