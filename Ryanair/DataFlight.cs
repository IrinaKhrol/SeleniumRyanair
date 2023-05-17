using System.Text;

namespace Ryanair
{
    public class DataFlight 
    {
        public string DayDepart { get; set; }
        public string TimeAndCityDepartFrom { get; set; }
        public string TimeAndCityDepartTo { get; set; }
        public string DayReturn { get; set; }
        public string TimeAndCityReturnFrom { get; set; }
        public string TimeAndCityReturnTo { get; set; }
        public string CostGeneral { get; set; }

        public DataFlight(string dayDepart, string timeAndCityDepartFrom, string timeAndCityDepartTo, string dayReturn, string timeAndCityReturnFrom, string timeAndCityReturnTo, string costGeneral)
        {
            DayDepart = dayDepart;
            TimeAndCityDepartFrom = timeAndCityDepartFrom;
            TimeAndCityDepartTo = timeAndCityDepartTo;
            DayReturn = dayReturn;
            TimeAndCityReturnFrom = timeAndCityReturnFrom;
            TimeAndCityReturnTo = timeAndCityReturnTo;
            CostGeneral = costGeneral;
        }

        public DataFlight()
        {
        }

        public string GetDataFlightTXT()
        {
            var sb = new StringBuilder();
            sb.Append("Day depart : ");
            sb.Append(DayDepart + "\n");
            sb.Append("Time and city depart from: ");
            sb.Append(TimeAndCityDepartFrom + "\n");
            sb.Append("Time and city depart to : ");
            sb.Append(TimeAndCityDepartTo + "\n");
            sb.Append("Day return : ");
            sb.Append(DayReturn + "\n");
            sb.Append("Time and city return from: ");
            sb.Append(TimeAndCityReturnFrom + "\n");
            sb.Append("Time and city return to : ");
            sb.Append(TimeAndCityReturnTo + "\n");
            sb.Append("Cost general : ");
            sb.Append(CostGeneral + "\n");
            return sb.ToString();
        }
    }
}
