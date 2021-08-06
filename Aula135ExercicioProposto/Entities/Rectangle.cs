namespace Aula135ExercicioProposto.Entities
{
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        
        override public double getArea() {
            return Width * Height;
        }
    }
}