using static Ryanair.XpathRyanair;
using System.Text;

namespace Ryanair
{
    internal class FlightSelect : BasePage
    {
        public FlightSelect() : base()
        {

        }

        public void ChoiceSelectFrom()
        {
            FindElementsWithWaiter(CHOICE_SELECT)[0].Click();
        }

        public void ChoiceSelectTo()
        {
            FindElementsWithWaiter(CHOICE_SELECT)[1].Click();
        }

        public void ChoiceTypeValue() 
        {
            FindElementWithWaiter(CHOICE_TYPE_VALUE).Click();
            FindElementWithWaiter(CONTINUE_VALUE).Click();
        }

        public void ChoiceTypeRegular() 
        {
            FindElementWithWaiter(CHOICE_TYPE_REGULAR).Click();
        }

        public void ChoiceTypePlus()
        {
            FindElementWithWaiter(CHOICE_TYPE_PLUS).Click();
        }

        public void ChoiceTypeFlexiPlus()
        {
            FindElementWithWaiter(CHOICE_TYPE_FLEXI_PLUS).Click();
        }

        public void ChoiceTypeFamilyPlus()
        {
            FindElementWithWaiter(CHOICE_TYPE_FAMILY_PLUS).Click();
        }

        public void ChoiceButtonBasket() 
        {
            FindElementWithWaiter(BUTTON_BASKET).Click();
        }

        public void GetInformationAboutFlightInTheBasket() 
        {
            Log(FindElementWithWaiter(INFORMATION_ABOUT_FLIGHT_IN_THE_BASKET).Text);
        }

        public void GetInformationAboutFlightXml()
        {
            Log(GetDataFlight());
        }

        public void GetInformationAboutFlightTXT () 
        {
            Log(GetDataFlight().GetDataFlightTXT());
        }

        public DataFlight GetDataFlight()
        {
            string dayDepart = FindElementWithWaiter(GET_DAY_DEPART_FROM).Text.ToString();
            string timeAndCityDepartFrom = FindElementWithWaiter(GET_TIME_AND_CITY_DEPART_FROM).Text.ToString();
            string timeAndCityDepartTo = FindElementWithWaiter(GET_TIME_AND_CITY_ARRIVE_TO).Text.ToString();
            string dayReturn = FindElementWithWaiter(GET_DAY_RETURN_FROM).Text.ToString();
            string timeAndCityReturnFrom = FindElementWithWaiter(GET_TIME_AND_CITY_RETURN_FROM).Text.ToString();
            string timeAndCityReturnTo = FindElementWithWaiter(GET_TIME_AND_CITY_RETURN_TO).Text.ToString();
            string costGeneral = FindElementWithWaiter(GET_COST_GENERAL).Text.ToString();
            return new DataFlight(dayDepart, timeAndCityDepartFrom, timeAndCityDepartTo, dayReturn, timeAndCityReturnFrom, timeAndCityReturnTo, costGeneral);
        }
    }
}
