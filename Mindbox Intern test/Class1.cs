namespace Mindbox_Intern_test
{
    public interface IShape
    {
        double Calculate();
    }

    public class Circle : IShape
    {
        public double Radius { get; }
        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Радиус должен быть больше 0");
            }
            else
            {
                Radius = radius;
            }
        }
        public double Calculate()
        {
            return Math.PI * Radius * Radius;
        }
    }

    public class Triangle : IShape
    {
        public double A { get; }
        public double B { get; }
        public double C { get; }
        public Triangle(double a, double b, double c)
        {
            if ((a <= 0) || (b <= 0) || (c <= 0))
            {
                throw new ArgumentException("Стороны треугольника должны быть больше 0");
            }

            if (a + b <= c || a + c <= b || b + c <= a)
            {
                throw new ArgumentException("Сумма длинн любых двух сторон треугольника должна привышать длинну третьей");
            }

            A = a;
            B = b;
            C = c;
        }

        public double Calculate()
        {
            double semiPerimeter = (A + B + C) / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - A) * (semiPerimeter - B) * (semiPerimeter - C));
        }

        public bool IsRightAngle()
        {
            double a2 = A * A;
            double b2 = B * B;
            double c2 = C * C;
            return a2 + b2 == c2 || a2 + c2 == b2 || b2 + c2 == a2;
        }
    }
}
