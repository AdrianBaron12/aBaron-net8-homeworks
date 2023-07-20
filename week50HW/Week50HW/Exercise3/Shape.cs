using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPADV.Exercise3
{
    public abstract class Shape
    {
        public string Color { get; set; }
        public double Area { get; protected set; } = 0;

        public abstract void CalculateArea();
        public virtual double GetPerimeter()
        {
            return 0;
        }

    }

    public class Rectangle : Shape
    {
        private double Width { get; }
        private double Height { get; }

        public Rectangle(string color, double width, double height)
        {
            Color = color;
            Width = width;
            Height = height;
        }

        public override void CalculateArea()
        {
            Area = Width * Height;
        }

        public override double GetPerimeter()
        {
            return 2 * (Width + Height);
        }

        public void GetPerimeter(string measure)
        {
            double perimeter = GetPerimeter();
            switch (measure)
            {
                case "inches":
                    Console.WriteLine($"{perimeter} inches");
                    break;
                case "feet":
                    Console.WriteLine($"{perimeter} feet");
                    break;
                case "meters":
                    Console.WriteLine($"{perimeter} meters");
                    break;
                default:
                    Console.WriteLine($"{perimeter} meters");
                    break;
            }
        }


    }

    public class Circle : Shape
    {
        private double Radius { get; set; }
        private const double Pi = Math.PI;

        public Circle(string color, double radius)
        {
            this.Color = color;
            this.Radius = radius;
        }

        public override void CalculateArea()
        {
            Area = Radius * Radius * Pi;
        }

        public override double GetPerimeter()
        {
            return 2 * Pi * Radius;
        }

        public string GetPerimeter(string unit)
        {
            double perimeter = GetPerimeter();
            return $"{perimeter} {unit}";
        }

    }
}
