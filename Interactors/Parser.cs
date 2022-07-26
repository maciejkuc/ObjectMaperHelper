using System;
using ObjectMaper.Interfaces;

namespace ObjectMaper.Interactors
{
    class Parser : IParser
    {
        public IInputData InputData { get; set; }
        public IParserConfiguration ParserConfiguration { get; set; }

        public string GetDataSource()
        {
            throw new NotImplementedException();
        }
    }
}
