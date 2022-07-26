using System;
using System.Collections.Generic;
using ObjectMaper.Interfaces;

namespace ObjectMaper.Interactors
{
    class Maper : iMaper
    {
        public IEnumerable<Dictionary<IObjectInfo, IMapping>> Maps { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public IEnumerable<T> GetCollection<T>()
        {
            throw new NotImplementedException();
        }

        public string GetCollection()
        {
            throw new NotImplementedException();
        }

        public IMapping GetMap(IObjectInfo objectInfo)
        {
            throw new NotImplementedException();
        }

        public T GetObject<T>(IObjectInfo objectInfo)
        {
            throw new NotImplementedException();
        }

        public string GetObject(IObjectInfo objectInfo)
        {
            throw new NotImplementedException();
        }

        public void SetMap(Dictionary<IObjectInfo, IMapping> maps)
        {
            throw new NotImplementedException();
        }
    }
}
