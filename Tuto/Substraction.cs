using System;

namespace Tuto
{
    internal class Substraction : IOperation
    {
        private double val1, val2;
        public double Value1 { get { return val1; } }
        public double Value2 { get { return val2; } }
        public double Execute()
        {
            return Value1 - Value2;
        }

        public void TakeInput()
        {
            Console.Write("Insert first value: ");
            val1 = Double.Parse(Console.ReadLine());
            Console.Write("Insert second value: ");
            val2 = Double.Parse(Console.ReadLine());
        }
    }
}