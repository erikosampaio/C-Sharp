using AbstractAndInterface.Model.Enums;

namespace AbstractAndInterface.Model.Entities
{
    abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }

        public abstract double Area();
    }
}
