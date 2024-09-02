using Mindbox_Intern_test;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var firstFigure = new Circle(2);
            Console.WriteLine(firstFigure.Calculate());
            var secondFigure = new Triangle(3,4,5);
            Console.WriteLine(secondFigure.Calculate());
            Console.WriteLine(secondFigure.IsRightAngle());
        }
    }
}
