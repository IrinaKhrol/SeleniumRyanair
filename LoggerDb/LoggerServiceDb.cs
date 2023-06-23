using Flight;
using ILogger;

namespace LoggerDb
{
    public class LoggerServiceDb : ILog
    {
        public void Log(string dataToLog)
        {
            using (var db = ApplicationDbContext.GetApplicationContext())
            {
                db.dataFlights.Add(new DataFlight(dataToLog));
                db.SaveChanges();
            }
        }
    }
}
