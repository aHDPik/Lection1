using System;

namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = new Shape[4];
            shapes[0] = new Rectangle(3, 4);
            shapes[1] = new Circle(3);
            shapes[2] = new Rectangle(10, 3);
            shapes[3] = new Circle(15);



            foreach(Shape shape in shapes)
            {
                Console.WriteLine($"p={shape.Perimeter} s={shape.Area}");
            }

            ComplexNumber a = new ComplexNumber(1, 3);
            a = a + a;
            Console.WriteLine($"{a}");
        }
    }
}
