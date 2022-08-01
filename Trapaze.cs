using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class Trapeze : Figures
    {
        public int Width { get; set; }
        public int Length { get; set; }
        public int Height { get; set; }
        public override double Calculate()
        {
            return (Width + Length) / 2 * Height;
        }
    }
}
