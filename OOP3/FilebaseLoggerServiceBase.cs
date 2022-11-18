 namespace OOP3
{
    internal class FilebaseLoggerServiceBase:ILoggerService
    {
        public void Log()
        {
            System.Console.WriteLine("Dosyaya loglandı");
        }
    }
}