using System.Xml.Serialization;
using LoggerXMl;
using Ryanair.Flight;

namespace Ryanair.LoggerServices
{
    public class LoggerServiceXML<T> : ILogXML<T>
    {
        private string PATH = @"C:\Users\Irina\Documents\LogXML.xml";
        public void WriteLogAsyncXML(T dataFlight)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(DataFlight));
            using (TextWriter writer = new StreamWriter(PATH))
            {
                xmlSerializer.Serialize(writer, dataFlight);
            }
        }
    }
}
