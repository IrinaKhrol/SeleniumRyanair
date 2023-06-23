using System.Text;

namespace Flight
{
    public class DataFlight
    {
        public int Id { get; set; }
        public List<FlightDetails> flightDepartAndReturn { get; set; } = new();
        public string CostGeneral { get; set; }

        public DataFlight(FlightDetails flightDepart, FlightDetails flightReturn, string costGeneral)
        {
            flightDepartAndReturn = new() { flightDepart, flightReturn };
            CostGeneral = costGeneral;
        }

        public DataFlight(string dataFlight)
        {
           string[] flight = dataFlight.Split(" ");

            var dayTimeDepartFrom = DateTime.Parse(flight[5] + " " + flight[6], System.Globalization.CultureInfo.InvariantCulture);
            var dayTimeDepartTo = DateTime.Parse(flight[19] + " " + flight[20], System.Globalization.CultureInfo.InvariantCulture);
            var dayTimeReturnFrom = DateTime.Parse(flight[33] + " " + flight[34], System.Globalization.CultureInfo.InvariantCulture);
            var dayTimeReturnTo = DateTime.Parse(flight[47] + " " + flight[48], System.Globalization.CultureInfo.InvariantCulture);

            flightDepartAndReturn = new() { new ( dayTimeDepartFrom, flight[12], dayTimeDepartTo, flight[26] ),
                new(dayTimeReturnFrom, flight[40], dayTimeReturnTo, flight[54])};
            CostGeneral = flight[56];
        }

        public DataFlight()
        {
        }

        public string GetDataFlightString()
        {
            var sb = new StringBuilder();
            sb.Append(flightDepartAndReturn[0].GetFlightDetailsString());
            sb.Append(flightDepartAndReturn[1].GetFlightDetailsString());
            sb.Append(CostGeneral + "\n");
            return sb.ToString();
        }
    }
}
