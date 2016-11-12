using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Rectangle : Polygon
    {
        public override int[] Sides { get; }

        public Rectangle(int side1, int side2)
        {
            if (side1 <= 0 || side2 <= 0)
                throw new ArgumentException();

            Sides = new int[] {side1, side2};
        }
        public override double GetPerimeter()
        {
            return 2 * Sides.Sum();
        }

        public override double GetSquare()
        {
            return Sides[0] * Sides[1];
        }
    }
}
