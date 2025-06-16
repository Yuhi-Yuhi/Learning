namespace FigureCheck
{
    public abstract class Figure
    {
        protected double A;
        protected double B;

        public Figure(double a, double b)
        {
            Console.WriteLine("figure");
            A = a;
            B = b;
        }

        public abstract double GetArea();

        public virtual string GetName()
        {
            return "figure";
        }
    }
}
