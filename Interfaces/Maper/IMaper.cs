using System.Collections.Generic;

namespace ObjectMaper.Interfaces
{
    internal interface iMaper
    {
        IEnumerable<Dictionary<IObjectInfo, IMapping>> Maps { get; set; }

        IMapping GetMap(IObjectInfo objectInfo);
        void SetMap(Dictionary<IObjectInfo, IMapping> maps);
        T GetObject<T>(IObjectInfo objectInfo);
        string GetObject(IObjectInfo objectInfo);
        IEnumerable<T> GetCollection<T>();
        string GetCollection();
    }
}