using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Task2.Tests
{
    [TestFixture]
    class SquareTests
    {
        [TestCase(new int[] { 10}, Result = 40.0)]
        [TestCase(new int[] { 2 }, Result = 8.0)]
        public double GetPerimeter_returnedValue(int[] sides)
        {
            Task2.Square square = new Square(sides[0]);
            return Math.Round(square.GetPerimeter(), 2);
        }

        [TestCase(new int[] { 10 }, Result = 100.0)]
        [TestCase(new int[] { 2 }, Result = 4.0)]
        public double GetSquare_returnedValue(int[] sides)
        {
            Task2.Square square = new Square(sides[0]);
            return Math.Round(square.GetSquare(), 2);
        }
    }
}
