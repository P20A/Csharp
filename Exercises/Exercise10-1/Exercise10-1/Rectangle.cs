using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exercise10_1
{
    internal class Rectangle
    {
        float length = 1f;
        float width = 1f;
        public Rectangle(){}
        public Rectangle(float length, float width)
        {
            this.length = length;
            this.width = width;
        }
        public void setLength(float length)
        {
            if (length > 0)
            {
                this.length = length;
            }
            else
            {
                Console.WriteLine("the value is not valid.");
            }
        }
        public float getLength()
        {
            return this.length;
        }
        public void setWidth(float width)
        {
            if (width > 0)
            {
                this.width = width;
            }
            else
            {
                Console.WriteLine("the value is not valid.");
            }
        }
        public float getWidth()
        {
            return this.width;
        }
        public double getArea()
        {
            return this.width * this.length ;
        }
        public double getPerimeter()
        {
            return this.width * 2 + this.length * 2;
        }
        public string toString()
        {
            return $"the length is {this.length}\nthe width is {this.width}";
        }
    }
}
