using LoggerTXT;

namespace Ryanair.LoggerServices
{
    public sealed class LoggerServiceTXT : ILogTXT
    {
        private const string PATH = @"C:\Users\Irina\Documents\MyLog.txt";

        public LoggerServiceTXT()
        {
            File.WriteAllText(PATH, string.Empty);
        }

        public void WriteLogAsyncTXT(string message)
        {
            using StreamWriter sw = new(PATH, true, System.Text.Encoding.Default);
            sw.WriteLineAsync(message);
        }
    }
}
