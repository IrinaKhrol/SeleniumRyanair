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
            home.ChooseDayCurrentMonth("2023-05-28");
            home.ChooseDayCurrentMonth("2023-06-25");
            home.AddAdultPassenger(1);
            home.AddChildrenPassenger(2);
            home.ConfirmSelection();

            FlightSelect flightSelect = new FlightSelect();
            flightSelect.ChoiceSelectFrom();
            flightSelect.ChoiceSelectTo();
            flightSelect.ChoiceTypeFamilyPlus();
            flightSelect.ChoiceButtonBasket();
            flightSelect.GetInformationAboutFlightInTheBasket();
            flightSelect.GetInformationAboutFlightXml();
            flightSelect.GetInformationAboutFlightTXT();
            flightSelect.LogInformationAboutFlightDataBase();

           //home.DriverClose();
        }
    }
}