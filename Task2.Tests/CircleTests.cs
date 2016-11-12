using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Task2;

namespace Task2.Tests
{
    [TestFixture]
    public class CircleTests
    {
        [TestCase(10, Result = 62.83)]
        [TestCase(3, Result = 18.85)]
        public double GetPerimeter_returnedValue(int radius)
        {
            Task2.Сircle circle = new Сircle(radius);
            return Math.Round(circle.GetPerimeter(), 2);
        }

        [TestCase(10, Result = 314.16)]
        [TestCase(3, Result = 28.27)]
        public double GetSquare_returnedValue(int radius)
        {
            Task2.Сircle circle = new Сircle(radius);
            return Math.Round(circle.GetSquare(), 2);
        }
    }
}
