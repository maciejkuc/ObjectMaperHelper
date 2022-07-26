using System;
using System.Collections.Generic;
using System.Data;
using ObjectMaper.Interfaces;

namespace ObjectMaper.Interactors
{
    class Reader : IReader
    {
        public string this[int index] => throw new NotImplementedException();

        public string this[string name] => throw new NotImplementedException();

        public IReaderConfiguration Configuration => throw new NotImplementedException();

        public string[] GetColumnHeaders()
        {
            throw new NotImplementedException();
        }

        public string GetField(int index)
        {
            throw new NotImplementedException();
        }

        public string GetField(string name)
        {
            throw new NotImplementedException();
        }

        public T GetField<T>(int index)
        {
            throw new NotImplementedException();
        }

        public T GetField<T>(string name)
        {
            throw new NotImplementedException();
        }

        public string GetFileHeader()
        {
            throw new NotImplementedException();
        }

        public string GetFooter()
        {
            throw new NotImplementedException();
        }

        public DataTable GetRecords()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetRecords<T>()
        {
            throw new NotImplementedException();
        }
    }
}
