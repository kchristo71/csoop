using System.Drawing;

namespace OOP.Domain.Contracts
{
    public interface IBoundingBox
    {
        Point SouthWest { get; }
        Size MapSize { get; }
    }
}
