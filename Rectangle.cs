using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Rectangle : Figures
    {
        public int Length { get; set; }
        public int Width { get; set; }
        public override double Calculate()
        {
            return Length * Width;
        }
    }
}
