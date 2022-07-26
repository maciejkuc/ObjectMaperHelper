namespace ObjectMaper
{
    internal interface IReaderConfiguration
    {
        string Quote { get; set; }
        string Delimeter { get; set; }
        bool DetectDelimeter { get; set; }
        TrimOptions TrimOptions { get; set; }
        bool HasHeaderRow { get; set; }
    }
}