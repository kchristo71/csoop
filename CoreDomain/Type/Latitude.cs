namespace OOP.Domain.Type
{
    public class Latitude: Coordinate
    {
        public Latitude(double coord) : base(coord)
        {
        }

        protected override bool IsValid(double value)
        {
            return value >= -90 && value <= 90;
        }

        public static explicit operator Latitude(double value)
        {
            return new Latitude(value);
        }

        public static explicit operator double(Latitude instance)
        {
            return instance.Value;
        }
    }
}
