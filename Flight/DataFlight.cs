
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
