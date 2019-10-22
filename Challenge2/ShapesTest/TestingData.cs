using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Shapes;

namespace UnitTestProject1
{
    [TestFixture]
    public class tests
    {
        [Test]
        [TestCase(5, 25, 20)]
        [TestCase(15, 225, 60)]
        [TestCase(7, 49, 28)]
        public void iShapeCalc_test_Square(double side1, double areaExpected, double perExpected)
        {
            var sq = new Square("red", side1);
            var sqArea = sq.GetArea(side1);
            var sqPer = sq.GetPerimeter(side1);

            Assert.AreEqual(areaExpected, sqArea);
            Assert.AreEqual(perExpected, sqPer);
        }

        [Test]
        [TestCase(5, 10, 50, 30)]
        [TestCase(4, 6, 24, 20)]
        [TestCase(9, 7, 63, 32)]
        public void iShapeCalc_test_Rectangle(double side1, double side2, double areaExpected, double perExpected)
        {
            var rec = new Rectangle("red", side1, side2);
            //double area = side1 * side2;
            //double per = side1 + side2 + side1 + side2;
            var recArea = rec.GetArea(side1);
            var recPer = rec.GetPerimeter(side1);

            Assert.AreEqual(areaExpected, recArea);
            Assert.AreEqual(perExpected, recPer);
        }

        [Test]
        [TestCase(5, 10.83, 15)]
        [TestCase(15, 97.43, 45)]
        [TestCase(7, 21.22, 21)]
        public void iShapeCalc_test_Equilateral(double side1, double areaExpected, double perExpected)
        {
            var equil = new Equilateral("red", side1);
            var equilArea = equil.GetArea(side1);
            var equilPer = equil.GetPerimeter(side1);

            Assert.AreEqual(areaExpected, equilArea);
            Assert.AreEqual(perExpected, equilPer);
        }

        [Test]
        [TestCase(5, 10, 25, 26.18)]
        [TestCase(4, 6, 12, 17.21)]
        [TestCase(9, 7, 31.5, 27.4)]
        public void iShapeCalc_test_RightAngled(double side1, double side2, double areaExpected, double perExpected)
        {
            var ra = new RightAngled("red", side1, side2);
            ra.SetHypotenuse(side1, side2);
            var raArea = ra.GetArea(side1);
            var raPer = ra.GetPerimeter(side1);

            Assert.AreEqual(areaExpected, raArea);
            Assert.AreEqual(perExpected, raPer);
        }

        [Test]
        [TestCase(5, 78.54, 31.42)]
        [TestCase(15, 706.86, 94.25)]
        [TestCase(7, 153.94, 43.98)]
        public void iShapeCalc_test_Circle(double side1, double areaExpected, double perExpected)
        {
            var circ = new Circle("red", side1);
            var circArea = circ.GetArea(side1);
            var circPer = circ.GetPerimeter(side1);

            Assert.AreEqual(areaExpected, circArea);
            Assert.AreEqual(perExpected, circPer);
        }
    }
}
