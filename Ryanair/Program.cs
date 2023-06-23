namespace Ryanair
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Logger listLoggers = new(@"C:\Users\Irina\source\repos\SeleniumRyanair\AllAddressDll.txt");
            HomePage home = new HomePage();
            home.AgreeWithUsingCookies();
            home.InputDepartureStation("Sofia");
            home.InputDestinationStation("Malta");
            home.ChooseDayCurrentMonth("2023-06-25");
            home.ChooseDayCurrentMonth("2023-06-28");
            home.AddAdultPassenger(1);
            home.AddChildrenPassenger(2);
            home.ConfirmSelection();

            FlightSelect flightSelect = new FlightSelect();
            flightSelect.ChoiceSelectFrom();
            flightSelect.ChoiceSelectTo();
            flightSelect.ChoiceTypeFamilyPlus();
            flightSelect.ChoiceButtonBasket();

            listLoggers.CreateLog(flightSelect.GetDataFlight().GetDataFlightString());
           
            home.DriverClose();
        }
    }
}