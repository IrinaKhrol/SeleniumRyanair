﻿using System.Xml.Linq;
using ILogger;

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
            string[] flight = dataToLog.Split(" ");

            var xmlTree = new XElement("Flight", new XAttribute("Price", flight[56]),
                new XElement("FlightDepart",
                    new XElement("Day", flight[5]),
                    new XElement("Time", flight[6]),
                    new XElement("City", flight[12]),
                    new XElement("Day", flight[19]),
                    new XElement("Time", flight[20]),
                    new XElement("City", flight[26])
                ),
                new XElement("FlightReturn",
                    new XElement("Day", flight[33]),
                    new XElement("Time", flight[34]),
                    new XElement("City", flight[40]),
                    new XElement("Day", flight[47]),
                    new XElement("Time", flight[48]),
                    new XElement("City", flight[54])
                ));

            using StreamWriter writer = new StreamWriter(PATH);
            writer.Write(xmlTree);
        }
    }
}


