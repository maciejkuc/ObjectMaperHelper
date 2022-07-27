using System.Collections.Generic;
using System.Data;

namespace ObjectMappingHelper.Interfaces
{
    public interface IReader : IReaderRow
    {
        DataTable GetRecords();
        IEnumerable<T> GetRecords<T>();        
        string[] GetColumnHeaders();     
    }
}