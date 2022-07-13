using System;

namespace Tuto
{
    internal class Division : IOperation
    {
        private double val1, val2;
        public double Value1 { get { return val1; } }
        public double Value2 { get { return val2; } }

        public double Execute()
        {
            return Value1 / Value2;
        }

        public void TakeInput()
        {
            Console.Write("Insert dividend: ");
            val1 = Double.Parse(Console.ReadLine());
            Console.Write("Insert divisor: ");
            val2 = Double.Parse(Console.ReadLine());
            while (val2==0)
            {
                Console.Write("Divisor cannot be 0. Please insert another value!");
                val2 = Double.Parse(Console.ReadLine());
            }
        }
    }
}