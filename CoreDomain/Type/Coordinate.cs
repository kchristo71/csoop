using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace OOP.Domain.Type
{
    public abstract class Coordinate
    {
        public double Value { get; }
        protected Coordinate(double value)
        {
            if (!IsValid(value))
            {
                throw new ArgumentOutOfRangeException($"{value} is not a valid {GetType().Name}");
            }
            Value = value;
        }

        protected abstract bool IsValid(double value);
    }
}
