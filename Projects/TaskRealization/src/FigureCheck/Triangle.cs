namespace FigureCheck
{
    public class Triangle : Figure
    {
        public Triangle(double a, double b) : base(a, b)
        {
            Console.WriteLine("Треугольник принимает два параметра");
        }

        public Triangle() : this(2, 5)
        {
            Console.WriteLine("Треугольник без параметров");
        }

        public override double GetArea()
        {
            return ((A * B) / 2);
        }

        public double GetArea(double a)
        {
            return ((a * a * Math.Sqrt(3)) / 4);
        }
    }
}
