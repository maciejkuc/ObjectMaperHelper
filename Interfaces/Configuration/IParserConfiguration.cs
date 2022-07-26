namespace ObjectMaper
{
    internal interface IParserConfiguration
    {
        int FileHeaderLineCount { get; set; }
        int FileTailLineCount { get; set; }
    }
}