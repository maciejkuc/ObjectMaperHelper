using System.Data;
using System.IO;

namespace ObjectMappingHelper.Interfaces
{
    public interface IInputData
    {
        string Filename { get; set; }
        DataTable Datatable { get; set; }
        Stream Stream { get; set; }
    }
}