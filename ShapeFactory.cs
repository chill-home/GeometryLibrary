using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLibrary
{
    public class ShapeFactory
    {
        private Dictionary<string, Func<double[], Shape>> shapeConstructors;

        public ShapeFactory()
        {
            shapeConstructors = new Dictionary<string, Func<double[], Shape>>
            {
                { "Circle", parameters => new Circle(parameters[0]) },
                { "Triangle", parameters => new Triangle(parameters[0], parameters[1], parameters[2]) }
            };
        }

        public void RegisterShape(string shapeName, Func<double[], Shape> constructor)
        {
            shapeConstructors[shapeName] = constructor;
        }

        public Shape CreateShape(string shapeName, double[] parameters)
        {
            if (shapeConstructors.ContainsKey(shapeName))
            {
                return shapeConstructors[shapeName](parameters);
            }
            throw new ArgumentException("Shape not registered.");
        }
        

    }
}
