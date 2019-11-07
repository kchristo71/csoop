using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Domain.Contracts
{
    public interface INameAndId
    {
        string Name { get; }
        Guid Id { get; }

        void SetId(Guid? objectId = null);
    }
}
