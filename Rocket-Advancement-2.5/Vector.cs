namespace Rocket_Advancement_2._5
{
    internal readonly struct Vector
    {
        public readonly double x;
        public readonly double y;
        public Vector(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public double Magnitude()
        {
            return Math.Sqrt(x * x + y * y);
        }
        public Vector Normalise()
        {
            double mag = Magnitude();

            if (mag == 0) return new Vector(0, 0);

            else return new Vector(x / mag, y / mag);
        }
        public Vector Rotate(double radians)
        {
            double x1 = x * Math.Cos(radians) - y * Math.Sin(radians);
            double y1 = y * Math.Cos(radians) + x * Math.Sin(radians);
            return new Vector(x1, y1);
        }
        public static Vector operator +(Vector a, Vector b)
        {
            return new Vector(a.x + b.x, a.y + b.y);
        }
        public static Vector operator -(Vector a)
        {
            return new Vector(-a.x, -a.y);
        }
        public static Vector operator *(Vector a, double scalar)
        {
            return new Vector(a.x * scalar, a.y * scalar);
        }
        public static Vector operator /(Vector a, double scalar)
        {
            return new Vector(a.x / scalar, a.y / scalar);
        }
    }
}
