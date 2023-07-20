using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPADV.Exercise6
{
    public interface IShape
    {
        double CalculateArea();
        string CalculateArea(string v);

    }

    public interface IColor
    {
        string Color { get; set; }
    }

    public class Circle : IShape, IColor
    {
        private double radius;
        public string Color { get; set; }

        public Circle(double radius)
        {
            this.radius = radius;
            Color = "Black";
        }

        public Circle(double radius, string color)
        {
            this.radius = radius;
            Color = color;
        }

        public double Radius
        {
            get { return radius; }
            set { this.radius = value; }
        }

        public double CalculateArea()
        {
            return radius * radius * Math.PI;
        }

        public string CalculateArea(string unit)
        {
            double area = CalculateArea();
            return $"Area : {area} {unit}";
        }

    }

    public class Rectangle : IShape, IColor
    {
        private double width;
        private double height;

        public double Width
        {
            get { return width; }
            set
            {
                width = value;
            }
        }

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        public string Color { get; set; }

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public Rectangle(double width, double height, string color)
        {
            this.width = width;
            this.height = height;
            Color = color;
        }

        public double CalculateArea()
        {
            return width * height;
        }

        public string CalculateArea(string unit)
        {
            double area = CalculateArea();
            return $"Area: {area} {unit}";
        }



    }

}
