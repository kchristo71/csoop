using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using OOP.Domain.Contracts;

namespace OOP.Domain.Implementations
{
    public class Map : IMap
    {
        public static Map NewMap()
        {
            return new Map(Guid.NewGuid());
        }

        public Map()
        {
            Id = Guid.Empty;
        }

        private Map(Guid id)
        {
            Id = id;
        }

        public void SetId(Guid? mapId = null)
        {
            System.Diagnostics.Debug.Assert(Id.Equals(Guid.Empty));
            Id = mapId ?? Guid.NewGuid();
        }

        public Point SouthWest { get; set; }
        public Size MapSize { get; set; }

        public string Name { get; set; }

        public Guid Id { get; private set; }
    }
}
