using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public interface iShapeCalc
    {
        double GetArea(double Area);
        double GetPerimeter(double Per);
    }
    public abstract class Shape
    {
        public string color { get; set; }

        public Shape(string Color)
        {
            color = Color;
        }

        public void operation1()
        {
            throw new NotImplementedException();
        }
    }

    public abstract class Quadrilateral : Shape, iShapeCalc
    {
        public double width1 { get; set; }
        public double height1 { get; set; }
        public double width2 { get; set; }
        public double height2 { get; set; }

        public Quadrilateral(string Color, double w1, double h1, double w2, double h2) : base(Color)
        {
            width1 = w1;
            height1 = h1;
            width2 = w2;
            height2 = h2;
        }

        public double GetArea(double Area)
        {
            Area = width1 * height1;
            return Area;
        }

        public double GetPerimeter(double Per)
        {
            Per = width2 + height1 + width2 + height2;
            return Per;
        }
    }

    public class Square : Quadrilateral
    {
        public Square(string Color, double w1) : base(Color, w1, w1, w1, w1)
        {
            width1 = w1;
        }
    }

    public class Rectangle : Quadrilateral
    {
        public Rectangle(string Color, double w1, double h1) : base(Color, w1, h1, w1, h1)
        {
            width1 = w1;
            height1 = h1;
        }
    }

    public abstract class Triangle : Shape
    {
        public double side1 { get; set; }
        public double side2 { get; set; }
        public double side3 { get; set; }

        public Triangle(string Color, double s1, double s2, double s3) : base(Color)
        {
            side1 = s1;
            side2 = s2;
            side3 = s3;
        }
    }

    public class Equilateral : Triangle, iShapeCalc
    {
        public Equilateral(string Color, double s1) : base(Color, s1, s1, s1)
        {
            side1 = s1;
        }
        public double GetArea(double Area)
        {
            Area = (Math.Sqrt(3) / 4) * (side1 * side1);
            return Math.Round(Area, 2, MidpointRounding.AwayFromZero);
        }

        public double GetPerimeter(double Per)
        {
            Per = side1 * 3;
            return Per;
        }
    }

    public class RightAngled : Triangle, iShapeCalc
    {
        public RightAngled(string Color, double s1, double s2) : base(Color, s1, s1, s1)
        {
            side1 = s1;
            side2 = s2;
        }

        public void SetHypotenuse(double s1, double s2)
        {
            side3 = Math.Sqrt((s1 * s1) + (s2 * s2));

        }

        public double GetArea(double Area)
        {
            Area = (0.5) * (side1 * side2);
            return Math.Round(Area, 2, MidpointRounding.AwayFromZero);
        }

        public double GetPerimeter(double Per)
        {
            Per = side1 + side2 + Math.Round(side3, 2, MidpointRounding.AwayFromZero);
            return Per;
        }
    }

    public class Circle : Shape, iShapeCalc
    {
        public double Radius { get; set; }
        public double Pi = Math.PI;
        public Circle(string Color, double radius) : base(Color)
        {
            Radius = radius;
        }
        public double GetArea(double Area)
        {
            Area = Pi * (Radius * Radius);
            return Math.Round(Area, 2, MidpointRounding.AwayFromZero);
        }

        public double GetPerimeter(double Per)
        {
            Per = 2 * Pi * Radius;
            return Math.Round(Per, 2, MidpointRounding.AwayFromZero);
        }
    }
    public class InvalidIntException : Exception
    {
        public InvalidIntException(string message) : base("ERROR length is less than 1")
        {

        }
    }
    public class InvalidDecException : Exception
    {
        public InvalidDecException(string message) : base("Cannot use decimal numbers")
        {

        }
    }
}
