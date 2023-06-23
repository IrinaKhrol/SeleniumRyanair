using System.Reflection;
using ILogger;

namespace Ryanair
{
    internal class Logger
    {
        private List<ILog> loggers = new();
        public Logger(string fileName)
        {
            using var reader = new StreamReader(fileName);

            string? line;
            while ((line = reader.ReadLine()) != null)
            {
                var assem = Assembly.LoadFrom(line);

                Type types = assem.GetExportedTypes()[0];

                if (types.GetInterface("ILog") != null)
                {
                    loggers.Add((ILog)assem.CreateInstance(types.ToString()));
                }

            }
        }

        public void CreateLog(string message)
        {
            foreach(ILog myLogger in loggers) 
            {
                myLogger.Log(message);
            }
        }
    }
}
