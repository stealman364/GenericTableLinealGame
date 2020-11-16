namespace OcaBorracha.interfaces
{
    internal interface ILogger
    {
        public string FormatLog(string textToFormat);

        public void PrintLog(string formatedText);
    }
}