using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionOneGroupTwoAdv
{
    internal class Point: IComparable<Point>
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x , int y)
        {
            X = x;
            Y = y;
        }
        public override string ToString()
        {
            return $"X = {X} , Y = {Y}";
        }
        //Comapre based on X , Y
        //public int CompareTo(object? obj)
        //{
        //    //this.X == obj.X ==> Compare based on Y
        //    //this.X != obj.X ==> Compare based on X
        //    Point? point = obj as Point;
        //    if(this.X == point?.X)
        //    {
        //        return this.Y.CompareTo(point.Y);
        //    }
        //    else
        //    {
        //        return this.X.CompareTo(point.X);
        //    }
        //}
        public Point()
        {
            
        }
        public int CompareTo(Point? point)
        {
            if (this.X == point?.X)
            {
                return this.Y.CompareTo(point?.Y);
            }
            else
            {
                return this.X.CompareTo(point?.X);
            }
        }
    }
}
