using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_03
{
    public class Shape
    {
        public string ShapeType;
        public double Area;

        public void CalculateArea(double val1, double val2)
        {
            Area = val1 * val2;

        }

        public virtual void DisplayShapeInfo()
        {
            Console.WriteLine($"Shape Type : {ShapeType}");
            Console.WriteLine($"Area : {Area}");
        }

        public void shape()
        {
            ShapeType = " ";
            Area = 0;
        }
    }

    public class Rectangle : Shape
    {
        public double length;
        public double width;

        public void SetDimention(double length, double width)
        {
            this.length = length;
            this.width = width;

            ShapeType = "Rectangle";
            CalculateArea(length, width);
        }

        public override void DisplayShapeInfo()
        {
            base.DisplayShapeInfo(); //call the method in parent class
            Console.WriteLine($"Length : {length}");
            Console.WriteLine($"Width : {width}");
        }

    }

    public class Circle : Shape
    {
        public double radius;

        public void SetRadius(double radius)
        {
            this.radius = radius;

            ShapeType = "Circle";
            CalculateArea(radius, radius);
            Area = Math.PI * radius * radius;
        }

        public override void DisplayShapeInfo()
        {
            base.DisplayShapeInfo(); //call the method in parent class
            Console.WriteLine($"Radius : {radius}");
        }
    }

    internal class Q_04
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.SetDimention(5,3);
            rectangle.DisplayShapeInfo();

            Console.WriteLine();

            Circle circle = new Circle();
            circle.SetRadius(4);
            circle.DisplayShapeInfo();

            Console.ReadLine();

        }
    }
}
