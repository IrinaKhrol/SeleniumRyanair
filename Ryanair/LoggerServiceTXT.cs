namespace Ryanair
{
    public sealed class LoggerServiceTXT : ILogTXT
    {
        private const string PATH = @"C:\Users\Irina\Documents\MyLog.txt";

        public  LoggerServiceTXT() 
        {
            File.WriteAllText(PATH, string.Empty);
        }

        public async Task WriteLogAsyncTXT(string message)
        {
            using StreamWriter sw = new(PATH, true, System.Text.Encoding.Default);
            await sw.WriteLineAsync(message);
        }
    }
}
