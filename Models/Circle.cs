using ShapeLibrary.Models.Parameters;
using System;

namespace ShapeLibrary.Models
{
    public class Circle : Shape<CircleParameters>
    {
        private readonly CircleParameters _CircleParameters;
        public Circle(CircleParameters circleParameters)
        {
            _CircleParameters = circleParameters;
        }

        public override double? GetSquare()
        {
            if (_CircleParameters.Radius.HasValue)
            {
                return Math.PI * Math.Pow(_CircleParameters.Radius.Value, 2);
            }
            else if (_CircleParameters.Diametr.HasValue)
            {
                return Math.PI * _CircleParameters.Diametr.Value;
            }
            else
                return null;
        }
    }
}
