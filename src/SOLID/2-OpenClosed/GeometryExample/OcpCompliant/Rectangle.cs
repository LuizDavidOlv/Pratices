﻿namespace src.SOLID._2_OpenClosed.GeometryExample.OcpCompliant
{
    public class Rectangle : Shape
    {
        public double Height { get; set; }
        public double Width { get; set; }

        public override double Area()
        {
            return Height * Width;
        }
    }
}
