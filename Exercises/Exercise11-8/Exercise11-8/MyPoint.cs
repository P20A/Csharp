using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Exercise11_8
{
    internal class MyPoint
    {
        private int x;
        private int y;
        private int[] xy = new int[2];
        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        public MyPoint(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public int[] getXY()
        {
            this.xy[0] = this.X;
            this.xy[1] = this.Y;
            return xy;
        }
        public void setXY(int x, int y)
        {
            this.xy[0] = x;
            this.xy[1] = y;
        }
        public string toString()
        {
            return $"({this.X},{this.Y})";
        }
        public double distance(int x, int y)
        {
            return Math.Sqrt(Math.Pow(this.X + x, 2) + Math.Pow(this.Y + y, 2));
        }
        public double distance(MyPoint point)
        {
            return Math.Sqrt(Math.Pow(this.X + point.X, 2) + Math.Pow(this.Y + point.Y, 2));
        }
        public double distance()
        {
            return Math.Sqrt(Math.Pow(this.X, 2) + Math.Pow(this.Y, 2));
        }
    }
}
