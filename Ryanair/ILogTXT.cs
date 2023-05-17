namespace Ryanair
{
    internal interface ILogTXT
    {
        public Task WriteLogAsyncTXT(string message);
    }
}
