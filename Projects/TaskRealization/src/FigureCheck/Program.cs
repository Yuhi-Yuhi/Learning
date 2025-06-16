namespace FigureCheck
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int a = 4;
            int b = 5;

            Figure figure1 = new Rectangle();
            Figure figure2 = new Triangle();
            Rectangle rectangle = new Rectangle();
            Triangle triangle = new Triangle();

            //figure1.GetArea()
            //Console.WriteLine(figure1.GetName());
            //Console.WriteLine(figure2.GetName());

            //Console.WriteLine(triangle.GetName());

            //var figure3 = (Figure)rectangle;


            /* Те методы или свойства, или переменные мы можем использовать только те, которые указаны У ТИПА ПЕРЕМЕННОЙ СЛЕВА !!!!!!  
             * А реализация методов уже от того, что справа "= ..." 
             * 
            */
            


            //OutputFigureArea(rectangle);
            //OutputFigureArea(triangle);
            OutputFigureArea(figure1);
            OutputFigureArea(figure2);

            //Do(rectangle);
            //Do(figure1); - //ошибка, потому что невозможно неявно преобразловать Figure в тип Rectangle




            Console.ReadKey();

        }

        public static void OutputFigureArea(Figure f)
        {
            Console.WriteLine(f.GetArea());
        }

        public static void Do(Rectangle f)
        {
            Console.WriteLine(f.GetArea());
        }

    }
}