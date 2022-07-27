using ObjectMappingHelper.Interfaces;

namespace ObjectMappingHelper.ViewModel
{
    internal class MaperViewModel
    {
        iMaper Maper { get; set; }
        IMaperConfiguration Configuration { get;  }
        public MaperViewModel(iMaper maper, IMaperConfiguration configuration)
        {
            Maper = maper;
            Configuration = configuration;
        }
        
        iMaper GetMaper() { return Maper; }
    }
}
