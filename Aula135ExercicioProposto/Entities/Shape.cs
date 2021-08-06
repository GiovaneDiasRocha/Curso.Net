using Aula135ExercicioProposto.Enums;

namespace Aula135ExercicioProposto.Entities
{
    public abstract class Shape
    {
        public Color Color { get; set; }
        
        

        public abstract double getArea();
    }
}