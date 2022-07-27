
namespace ObjectMaper.Interfaces
{
    internal interface IParser
    {
        IInputData InputData { get; set; }
        IParserConfiguration ParserConfiguration { get; set; }
        string GetDataSource();
        string AutoCut();
        string GetFileHeader();
        string GetFileFooter();
    }
}