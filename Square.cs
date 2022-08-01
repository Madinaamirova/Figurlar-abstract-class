using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class Square : Figures
    {
        public int Size { get; set; }
        public override double Calculate()
        {
            return Size * Size;
        }
    }
}
