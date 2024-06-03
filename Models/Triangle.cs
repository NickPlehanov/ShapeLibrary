using ShapeLibrary.Models.Parameters;
using System;
using System.Linq;

namespace ShapeLibrary.Models
{
    public class Triangle : Shape<TriangleParameters>
    {
        private double? Perimeter { get; set; }
        private double? Square { get; set; }
        private readonly TriangleParameters _TriangleParameters;
        public Triangle(TriangleParameters triangleParameters)
        {
            _TriangleParameters = triangleParameters;
        }

        public override double? GetSquare()
        {
            if (_TriangleParameters.Sides.Length == 3) //по трем сторонам
            {
                this.Perimeter = _TriangleParameters.Sides.AsEnumerable().Sum(x => x);
                this.Square = Math.Sqrt((double)(Perimeter / 2 * (Perimeter / 2 - _TriangleParameters.Sides[0]) * (Perimeter / 2 - _TriangleParameters.Sides[1]) * (Perimeter / 2 - _TriangleParameters.Sides[2])));
                return Square;
            }
            else
                return null;
        }

        public override double? GetPerimeter()
        {
            if (_TriangleParameters.Sides.Length == 3) //по трем сторонам
            {
                Perimeter = _TriangleParameters.Sides.AsEnumerable().Sum(x => x);
                return Perimeter;
            }
            else
                return null;
        }
    }
}
