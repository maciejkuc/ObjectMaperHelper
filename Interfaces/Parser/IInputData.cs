using System.Data;
using System.IO;

namespace ObjectMaper.Interfaces
{
    internal interface IInputData
    {
        string Filename { get; set; }
        DataTable Datatable { get; set; }
        Stream Stream { get; set; }
    }
}