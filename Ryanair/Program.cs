using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace Ryanair
{
    internal class Program
    {
        static void Main(string[] args)
        {

            HomePage home = new HomePage();
            home.AgreeWithUsingCookies();
            home.InputDepartureStation("Sofia");
            home.InputDestinationStation("Malta");
            home.ChooseDayCurrentMonth("2023-06-18");
            home.ChooseDayCurrentMonth("2023-06-21");
            home.AddAdultPassenger(1);
            home.AddChildrenPassenger(2);
            home.ConfirmSelection();

            FlightSelect flightSelect = new FlightSelect();
            flightSelect.ChoiceSelectFrom();
            flightSelect.ChoiceSelectTo();
            flightSelect.ChoiceTypeFamilyPlus();
            flightSelect.ChoiceButtonBasket();

            //Logger.CreateLog(@"C:\Users\Irina\source\repos\SeleniumRyanair\LoggerXML\bin\Debug\net6.0\LoggerXML.dll", flightSelect.GetDataFlight().GetDataFlightString());
            Logger.CreateLog(@"C:\Users\Irina\source\repos\SeleniumRyanair\LoggerDb\bin\Debug\net6.0\LoggerDb.dll", flightSelect.GetDataFlight().GetDataFlightString()); 

            home.DriverClose();
        }
    }
}