﻿using System;

namespace loppoint
{
    class Program
    {
        static void Main(string[] args)
        {
           Point2D point2D = new Point2D();
            point2D.SetXY(5,4);
            Console.WriteLine(point2D.ToString());
            Point3D point3D = new Point3D();
            point3D.SetXYZ(4,7,9);
            Console.WriteLine(point3D.ToString());
            Console.ReadKey();
        }
    }
}
