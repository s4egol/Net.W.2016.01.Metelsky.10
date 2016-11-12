using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Square : Polygon
    {
        private const int countOfSides = 4;
        public override int[] Sides { get; }

        public Square(int side)
        {
            if (side <= 0)
                throw new ArgumentException();

            Sides = new int[] {side};
        }

        public override double GetPerimeter()
        {
            return countOfSides * Sides[0];
        }

        public override double GetSquare()
        {
            return Math.Pow((double)Sides[0], 2);
        }
    }
}
