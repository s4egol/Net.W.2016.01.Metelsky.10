using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2;
using NUnit.Framework;

namespace Task2.Tests
{
    [TestFixture]
    class RectangleTests
    {
        [TestCase(new int[] {10, 10}, Result = 40.0)]
        [TestCase(new int[] {10, 20}, Result = 60.0)]
        public double GetPerimeter_returnedValue(int[] sides)
        {
            Task2.Rectangle rectangle = new Rectangle(sides[0], sides[1]);
            return Math.Round(rectangle.GetPerimeter(), 2);
        }

        [TestCase(new int[] { 10, 10 }, Result = 100.0)]
        [TestCase(new int[] { 10, 20 }, Result = 200.0)]
        public double GetSquare_returnedValue(int[] sides)
        {
            Task2.Rectangle rectangle = new Rectangle(sides[0], sides[1]);
            return Math.Round(rectangle.GetSquare(), 2);
        }
    }
}
