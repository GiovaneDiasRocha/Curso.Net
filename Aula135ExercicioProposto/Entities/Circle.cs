using System;
namespace Aula135ExercicioProposto.Entities
{
    public class Circle : Shape
    {
        public static double pi = 3.1415;
        public double Radius { get; set; }
        
        override public double getArea () {
            return pi * (Math.Pow(Radius, 2));
        }
    }
}