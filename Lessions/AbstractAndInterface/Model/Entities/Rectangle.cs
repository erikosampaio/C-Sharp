using System;
using System.Globalization;

namespace AbstractAndInterface.Model.Entities
{
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double Area()
        {
            return Width * Height;
        }

        public override string ToString()
        {
            return "Rectangle color = "
                + Color
                + ", width = "
                + Width.ToString("f2", CultureInfo.InvariantCulture)
                + ", area = "
                + Area().ToString("f2", CultureInfo.InvariantCulture);
        }

    }
}
