using ILogger;
using Flight;
using System.Xml.Serialization;

namespace LoggerXML
{
    public class LoggerServiceXML : ILog
    {
        private string PATH = @"C:\Users\Irina\Documents\LogXML.xml";
        public LoggerServiceXML()
        {

        }

        public void Log(string dataToLog)
        {
            DataFlight dataFlightSelect = new(dataToLog);
            XmlSerializer xmlSerializer = new XmlSerializer(dataFlightSelect.GetType());

            using StreamWriter writer = new StreamWriter(PATH);
            xmlSerializer.Serialize(writer, dataFlightSelect);
        }
    }
}


