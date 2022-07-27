using ObjectMappingHelper.Interfaces;

namespace ObjectMappingHelper.ViewModel
{
    internal class ReaderViewModel
    {
        private IReader Reader { get; set; }
        IReaderConfiguration Configuration { get; }
        public ReaderViewModel(IReader reader, IReaderConfiguration configuration)
        {
            Reader = reader;
            Configuration = configuration;
        }
        
        IReader GetReader() { return Reader; }
    }
}
