using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise11_9
{
    internal class MyTriangle
    {
        private MyPoint v1;
        private MyPoint v2;
        private MyPoint v3;

        public MyTriangle(int x1, int y1, int x2, int y2, int x3 ,int y3)
        {
            this.v1 = new MyPoint(x1, y1);
            this.v2 = new MyPoint(x2, y2);
            this.v3 = new MyPoint(x3, y3);
        }
        public MyTriangle(MyPoint v1, MyPoint v2, MyPoint v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }
        public string toString()
        {
            return $"v1 = {this.v1.toString()}, v2 = {this.v2.toString()}, v3 = {this.v3.toString()}";
        }
        public double getPerimeter()
        {
            double sum = 0;
            sum += this.v1.distance(v2);
            sum += this.v1.distance(v3);
            sum += this.v2.distance(v3);
            return sum;
        }
        public string getType()
        {
            if(this.v1.distance(v2) == this.v1.distance(v3) && this.v2.distance(v3) == this.v1.distance(v2))
            {
                return "equilateral";
            }
            else if(this.v1.distance(v2) == this.v1.distance(v3) || this.v2.distance(v1) == this.v2.distance(v3) || this.v3.distance(v2) == this.v3.distance(v1))
            {
                return "isosceles";
            }
            else
            {
                return "scalene";
            }
        }
    }
}
