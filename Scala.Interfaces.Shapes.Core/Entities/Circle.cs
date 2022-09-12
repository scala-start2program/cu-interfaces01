using Scala.Interfaces.Shapes.Core.Interfaces;

namespace Scala.Interfaces.Shapes.Core.Entities
{
    public class Circle : IShape
    {
        public float Radius { get; }

        public Circle(float radius)
        {
            Radius = radius;
        }

        public float CalculateArea()
        {
            return (float)(Radius * Radius * Math.PI);
        }
    }

}
