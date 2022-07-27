using System;
using ObjectMaper.Interfaces;

namespace ObjectMaper.Interactors
{
    class Parser : IParser
    {
        public IInputData InputData { get; set; }
        public IParserConfiguration ParserConfiguration { get; set; }

        public string AutoCut()
        {
            throw new NotImplementedException();
        }

        public string GetDataSource()
        {
            throw new NotImplementedException();
        }

        public string GetFileFooter()
        {
            throw new NotImplementedException();
        }

        public string GetFileHeader()
        {
            throw new NotImplementedException();
        }
    }
}
