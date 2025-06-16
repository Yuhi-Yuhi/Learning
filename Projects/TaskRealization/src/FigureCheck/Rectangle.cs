namespace FigureCheck
{
    public class Rectangle : Figure
    {
        public Rectangle(double a, double b) : base(a, b)
        {
            Console.WriteLine("Прямоугольник принимает два параметра");
        }

        public Rectangle() : base(2, 5)
        {
            Console.WriteLine("Прямоугольник без параметров");
        }

        public override double GetArea()
        {
            return (A * B);
        }

        public double GetArea(double a)
        {
            return (a * a);
        }

        public override string GetName()
        {
            return "rectangle";
        }

        public void DoSomething()
        {
        }
    }
}
