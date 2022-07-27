using ObjectMappingHelper.Interfaces;

namespace ObjectMappingHelper
{
    class TransformContext : ITransformContext
    {
        public IObjectProvider ObjectProvider { get; set; }
        public IReader Reader { get; set; }
        public iMaper Maper { get; set; }
        public IParser Parser { get; set; }
        public IWriter Writer { get; set; }
        public IConfiguration configuration { get; set; }
    }
}
