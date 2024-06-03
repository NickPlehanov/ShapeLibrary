using System;
using System.Linq;

namespace ShapeLibrary.Models.Parameters
{
    public sealed class TriangleParameters
    {
        public TriangleParameters(double[] sides)
        {
            if (sides.Length > 3)
                throw new ArgumentException("У треугольника не может быть больше трех сторон");
            if (sides.Length == 3)
            {
                if (sides.Max() < sides.Sum(x => x) - sides.Max())
                    Sides = sides;
                else
                    throw new ArgumentException("Сумма длин двух сторон, должна быть больше третьей");
            }
        }
        public double[] Sides { get; set; }
    }
}
