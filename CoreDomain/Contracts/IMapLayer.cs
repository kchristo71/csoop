using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Domain.Contracts
{
    public interface IMapLayer: INameAndId
    {
        int LayerType { get; }
    }
}
