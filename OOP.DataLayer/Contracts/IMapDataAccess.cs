using OOP.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.DataLayer.Contracts
{
    public interface IMapDataAccess
    {
        IEnumerable<IMap> GetAll();

        IMap Get(Guid mapId);

        void Save(IMap map);
    }
}
