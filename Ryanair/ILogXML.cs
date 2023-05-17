namespace Ryanair
{
    internal interface ILogXML
    {
        public Task WriteLogAsyncXML(DataFlight dataFlight);
    }
}
