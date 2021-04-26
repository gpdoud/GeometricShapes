using System;

namespace GeometricShapes {
    class Program {
        static void Main(string[] args) {

            var sqr1 = new Sqr(5);
            Console.WriteLine($"sqr1 perimeter is {sqr1.Perimeter()}, area is {sqr1.Area()}");
            Console.WriteLine($"sqr1 is a {sqr1.Print()}");

            var rect1 = new Rect(6, 4);
            Console.WriteLine($"rect1 perimeter is {rect1.Perimeter()}, area is {rect1.Area()}");
            var rect2 = new Rect(5, 8);
            Console.WriteLine($"rect2 perimeter is {rect2.Perimeter()}, area is {rect2.Area()}");

            var quad1 = new Quad(3, 4, 5, 6);
            var perimeter = quad1.Perimeter();
            Console.WriteLine($"quad1's perimeter is {perimeter}");
            var quad2 = new Quad();
            Console.WriteLine($"quad2's perimeter is {quad2.Perimeter()}");
        }
    }
}
