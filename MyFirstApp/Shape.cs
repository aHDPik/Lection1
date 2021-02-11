using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstApp
{
    public abstract class Shape
    {
        public virtual double Perimeter { get; }
        public virtual double Area { get; }
    }

    public class Rectangle : Shape
    {
        private double length;
        private double width;

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public override double Perimeter 
        {
            get
            {
                return (length + width) * 2;
            }
        }

        public override double Area
        {
            get
            {
                return length*width;
            }
        }

    }

    public class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double Perimeter
        {
            get
            {
                return radius * 2 * Math.PI;
            }
        }

        public override double Area
        {
            get
            {
                return radius * Math.PI * Math.PI;
            }
        }
    }

}
