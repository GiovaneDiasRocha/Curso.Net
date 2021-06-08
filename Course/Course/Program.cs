using System;
using System.Globalization;
namespace Course

{
    class Program
    {
        static void Main(string[] args)
        {
            
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            Console.Write("Digite o lado A do triângulo x: ");
            x.a = double.Parse(Console.ReadLine());

            Console.Write("Digite o lado B do triângulo x: ");
            x.b = double.Parse(Console.ReadLine());

            Console.Write("Digite o lado C do triângulo x: ");
            x.c = double.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Digite o lado A do triângulo x: ");
            y.a = double.Parse(Console.ReadLine());

            Console.Write("Digite o lado B do triângulo x: ");
            y.b = double.Parse(Console.ReadLine());

            Console.Write("Digite o lado C do triângulo x: ");
            y.c = double.Parse(Console.ReadLine());

            Console.WriteLine("Área do Triângulo X = " + areaTriangulo(x.a, x.b, x.c).ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área do Triângulo Y = " + areaTriangulo(y.a, y.b, y.c).ToString("F4", CultureInfo.InvariantCulture));

            /*if (resultadoA > resultadoB) {
                Console.WriteLine("A maior área é: " + resultadoA);
            } else {
                Console.WriteLine("A maior área é: " + resultadoB);
            }*/
        }

        static double areaTriangulo (double a, double b, double c) {
                    double area, p;
                    p = (a + b + c) / 2;
                    area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                    return area;
        }
        
    }
}
