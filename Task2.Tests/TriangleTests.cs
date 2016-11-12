using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Task2.Tests
{
    [TestFixture]
    class TriangleTests
    {
        [TestCase(new int[] { 10, 20, 29 }, Result = 59.0)]
        [TestCase(new int[] { 2, 2, 3 }, Result = 7.0)]
        public double GetPerimeter_returnedValue(int[] sides)
        {
            Task2.Triangle triangle = new Triangle(sides[0], sides[1], sides[2]);
            return Math.Round(triangle.GetPerimeter(), 2);
        }

        [TestCase(new int[] { 10, 20, 28 }, Result = 70.42)]
        public double GetSquare_returnedValue(int[] sides)
        {
            Task2.Triangle triangle = new Triangle(sides[0], sides[1], sides[2]);
            return Math.Round(triangle.GetSquare(), 2);
        }

        [TestCase(new int[] { 1, 2, 3 }, typeof(ArgumentException))]
        [TestCase(new int[] { 1, 0, 3 }, typeof(ArgumentException))]
        [TestCase(new int[] { -1, 1, 1 }, typeof(ArgumentException))]
        public void Ctor_Exception(int[] sides, Type exception)
        {
            Assert.Throws(exception, () => new Triangle(sides[0], sides[1], sides[2]));
        }
    }
}
