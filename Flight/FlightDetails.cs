﻿using System.Text;

namespace Flight
{
    public class FlightDetails
    {
        public int Id { get; set; }
        public DateTime DayTimeFrom { get; set; }
        public string? CityFrom { get; set; }
        public DateTime DayTimeTo { get; set; }
        public string? CityTo { get; set; }

        public FlightDetails(DateTime? dayTimeFrom, string? cityFrom, DateTime? dayTimeTo, string? cityTo)
        {
            DayTimeFrom = (DateTime)dayTimeFrom;
            DayTimeTo = (DateTime)dayTimeTo;
            CityFrom = cityFrom;
            CityTo = cityTo;
        }

        public FlightDetails()
        {
        }

        public string GetFlightDetailsString()
        {
            var sb = new StringBuilder();
            sb.Append("Day and time depart : ");
            sb.Append(DayTimeFrom + " \n ");
            sb.Append("City depart : ");
            sb.Append(CityFrom + " \n ");
            sb.Append("Day and time to : ");
            sb.Append(DayTimeTo + " \n ");
            sb.Append("City to : ");
            sb.Append(CityTo + " \n ");
            return sb.ToString();
        }
    }
}
