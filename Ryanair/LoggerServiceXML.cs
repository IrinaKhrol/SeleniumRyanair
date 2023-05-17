using System.Xml.Serialization;

namespace Ryanair
{
    public class LoggerServiceXML : ILogXML
    {
        private string PATH = @"C:\Users\Irina\Documents\LogXML.xml";
        public async Task WriteLogAsyncXML(DataFlight dataFlight)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(DataFlight));
            using (TextWriter writer = new StreamWriter(PATH))
            {
                xmlSerializer.Serialize(writer, dataFlight);
            }
        }
    }
}
