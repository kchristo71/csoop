using System.Drawing;

namespace OOP.Domain.Contracts
{
    public interface IMap: INameAndId
    {
        Point SouthWest { get; }
        Size MapSize { get; }
    }
}
