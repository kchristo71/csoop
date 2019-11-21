using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Domain.Contracts
{
    public interface IMapLayer: INameAndId, IBoundingBox
    {
        int LayerType { get; }
    }
}
