using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class Circle : Figures
    {
        public int Radius { get; set; }
        public double P = Math.PI;
        public override double Calculate()
        {
            return P * Radius * Radius;
        }
    }
}
