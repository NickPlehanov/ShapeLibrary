namespace ShapeLibrary.Models.Parameters
{
    public sealed class CircleParameters
    {
        public CircleParameters(double? radius, double? diametr)
        {
            Radius = radius;
            Diametr = diametr;
        }

        public double? Radius { get; set; }
        public double? Diametr { get; set; }
    }
}
