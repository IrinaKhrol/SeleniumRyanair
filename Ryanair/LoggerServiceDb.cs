namespace Ryanair
{
    public class LoggerServiceDb : ILogDb
    {
        public void Create(DataFlight dataFlight) 
        {
            using (var db = ApplicationDbContext.GetApplicationContext())
            {
                db.dataFlights.Add(dataFlight);
                db.SaveChanges();
            }
        }
    }
}
