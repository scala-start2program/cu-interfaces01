using Scala.Interfaces.Shapes.Core.Interfaces;

namespace Scala.Interfaces.Shapes.Core.Entities
{
    public class Triangle : IShape
    {
        public float Base { get; }
        public float Height { get; }

        public Triangle(float triangleBase, float height)
        {
            Base = triangleBase;
            Height = height;
        }

        public float CalculateArea()
        {
            return (Base * Height) / 2;
        }
    }
}
