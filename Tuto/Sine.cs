using System;
using System.Collections.Generic;
using System.Text;

namespace Tuto
{
    class Sine : IOperation
    {
        private double val;
        public double Value { get; }
        public double Execute()
        {
            return Math.Sin(Value);
        }

        public void TakeInput()
        {
            Console.Write("Insert value: ");
            val = Double.Parse(Console.ReadLine());
        }
    }
}
