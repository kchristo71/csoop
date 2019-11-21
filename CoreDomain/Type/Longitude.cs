using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Domain.Type
{
    public class Longitude : Coordinate
    {
        public Longitude(double coord) : base(coord)
        {
        }

        protected override bool IsValid(double value)
        {
            return value >= 0 && value <= 360;
        }
    }
}
