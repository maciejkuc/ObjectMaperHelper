using System.Collections.Generic;
using System.Data;

namespace ObjectMaper.Interfaces
{
    internal interface IReader : IReaderRow
    {
        DataTable GetRecords();
        IEnumerable<T> GetRecords<T>();        
        string[] GetColumnHeaders();     
    }
}