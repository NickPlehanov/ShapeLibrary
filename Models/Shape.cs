namespace ShapeLibrary.Models
{
    public abstract class Shape<P>
    {
        public abstract double? GetSquare();
        public virtual double? GetPerimeter()
        {
            return null;
        }
    }
}
