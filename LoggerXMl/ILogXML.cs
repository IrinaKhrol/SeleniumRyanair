namespace LoggerXMl
{
    public interface ILogXML<T>
    {
        public void WriteLogAsyncXML(T dataFlight);
    }
}
