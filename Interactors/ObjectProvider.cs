using System;
using System.Collections.Generic;
using ObjectMappingHelper.Interfaces;

namespace ObjectMappingHelper.Interactors
{
    public class ObjectProvider : IObjectProvider
    {
        public IEnumerable<IObjectInfo> Properties { get; set; }

        public IEnumerable<IObjectInfo> GetProperties()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IObjectInfo> GetPropertiesFrom<T>()
        {
            throw new NotImplementedException();
        }
    }
}
