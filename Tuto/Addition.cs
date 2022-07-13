using System;
using System.Collections.Generic;
using System.Text;

namespace Tuto
{
    class Addition : IOperation
    {
        private double val1, val2;
        public double Value1 { get { return val1; } }
        public double Value2 { get { return val2; } }

        public Addition() { }
        double IOperation.Execute()
        {
            return Value1 + Value2;
        }

        void IOperation.TakeInput()
        {
            Console.Write("Insert first value: ");
            val1 = Double.Parse(Console.ReadLine());
            Console.Write("Insert second value: ");
            val2 = Double.Parse(Console.ReadLine());
        }
    }
}
