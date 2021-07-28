using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Point
    {
        public int X { get; }
        public int Y { get; }

        public Point(int x, int y) => (X, Y) = (x, y);
        public string EE()
        {
            return "32";
        }
    }
    public struct Point1
    {
        public double X { get; }
        public double Y { get; }

        public Point1(double x, double y) => (X, Y) = (x, y);
    }
    public class Point3D :Point
    {
        public int Z { get; set; }

        public Point3D(int x, int y, int z) : base(x, y)
        {
            Z = z;
        }
        ~Point3D()
        { 
            
        }
    }
    public static class Ess {
        static Ess()
        {
        }
        
        public static string ss()
        {
            return "";
        }
    }
     
}
