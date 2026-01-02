using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise11_8
{
    internal class MyCircle
    {
        private MyPoint center = new MyPoint(0, 0);
        private int radius = 1;
        public int Radius
        {
            get {  return radius; }
            set { radius = value; }
        }
        public MyPoint Center
        {
            get { return center; }
            set { center = value; }
        }
        public int getCenterX()
        { return this.center.X; }
        public void setCenterX(int x)
        {
            this.center.X = x;
        }
        public int getCenterY()
        { return this.center.Y; }
        public void setCenterY(int y)
        {
            this.center.Y = y;
        }
        public int[] getCenterXY()
        {
            int[] XY = {this.center.X,this.center.Y};
            return XY; 
        }
        public void setCenterXY(int x, int y)
        {
            this.center.X = x;
            this.center.Y = y;
        }
        public MyCircle() { }

        public MyCircle(int x, int y, int radius)
        {
            this.center = new MyPoint(x, y);
            this.radius = radius;
        }
        public string toString()
        {
            return $"radius: {this.Radius} , center: {center.toString()}";
        }
        public double getArea()
        {
            return Math.PI * Math.Pow(Radius,2);
        }
        public double getCircumference()
        {
            return Math.PI * Radius * 2;
        }
        public double distance(MyCircle circle)
        {
            return Math.Sqrt(Math.Pow(center.X - circle.center.X, 2) + Math.Pow(center.Y - circle.center.Y, 2));
        }
    }   
}
