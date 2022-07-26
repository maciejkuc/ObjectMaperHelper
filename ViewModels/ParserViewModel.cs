using ObjectMaper.Interfaces;

namespace ObjectMaper.ViewModel
{
    internal class ParserViewModel
    {
        private IParser Parser { get; set; }
        IParserConfiguration Configuration { get; }
        public ParserViewModel(IParser parser, IParserConfiguration configuration)
        {
            Parser = parser;
            Configuration = configuration;
        }
        IParser GetParser() { return Parser; }
    }
}
