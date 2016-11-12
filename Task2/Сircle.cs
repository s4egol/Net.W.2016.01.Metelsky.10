using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Сircle : Ellipse
    {
        public override int Radius { get; }

        public Сircle(int radius)
        {
            if (radius <= 0)
                throw  new ArgumentException();

            Radius = radius;
        }

        public override double GetPerimeter()
        {
            return 2 * Math.PI * Radius;
        }

        public override double GetSquare()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
