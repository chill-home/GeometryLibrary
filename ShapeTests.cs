using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace GeometryLibrary
{
    public class ShapeTests
    {
        [Fact]
        public void CircleAreaTest()
        {
            Circle circle = new Circle(10);
            Assert.Equal(Math.PI * 100, circle.GetArea(), 5);
        }

        [Fact]
        public void TriangleAreaTest()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Assert.Equal(6, triangle.GetArea(), 5);
        }

        [Fact]
        public void IsRightTriangleTest()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Assert.True(triangle.IsRightTriangle());
        }

        [Fact]
        public void ShapeFactoryTest()
        {
            ShapeFactory factory = new ShapeFactory();
            Shape circle = factory.CreateShape("Circle", new double[] { 10 });
            Shape triangle = factory.CreateShape("Triangle", new double[] { 3, 4, 5 });

            Assert.Equal(Math.PI * 100, circle.GetArea(), 5);
            Assert.Equal(6, triangle.GetArea(), 5);
        }
    }
}
