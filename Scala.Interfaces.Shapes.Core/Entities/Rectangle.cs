using Scala.Interfaces.Shapes.Core.Interfaces;

namespace Scala.Interfaces.Shapes.Core.Entities
{
    public class Rectangle : IShape
    {
        public float Length { get; }
        public float Width { get; }

        public Rectangle(float length, float width)
        {
            Length = length;
            Width = width;
        }

        public float CalculateArea()
        {
            return Length * Width;
        }
    }
}
