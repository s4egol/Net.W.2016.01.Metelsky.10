using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Triangle : Polygon
    {
        public override int[] Sides { get; }

        public Triangle(int side1, int side2, int side3)
        {
            if (side1 <= 0 || side2 <= 0 || side3 <= 0)
                throw new ArgumentException();

            if ((side1 >= checked(side2 + side3)) || (side2 >= checked(side1 + side3)) || (side3 >= checked(side2 + side1)))
                throw new ArgumentException();

            Sides = new[] {side1, side2, side3};
        }

        public override double GetPerimeter()
        {
            return Sides.Sum();
        }

        public override double GetSquare()
        {
            double p = GetPerimeter() / 2.0;
            return Math.Sqrt(p*(p - Sides[0])*(p - Sides[1])*(p - Sides[2]));
        }
    }
}
