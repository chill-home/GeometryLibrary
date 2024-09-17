

namespace GeometryLibrary
{
    public interface IShape
    {
        double GetArea();
    }
    public abstract class Shape : IShape
    {
        public abstract double GetArea();
    }
}
