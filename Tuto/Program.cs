using System;

namespace Tuto
{
    //Simple calcutor

    class Program
    {
        static void Main(string[] args)
        {
            MakeCalculation();
        }

        public static void MakeCalculation() {

            while (true)
            {
                int opId = OperationHelper.ChooseOperation();
                IOperation op = OperationHelper.Factory(opId);
                if (op == null) break;
                op.TakeInput();
                Console.WriteLine($"Results: {op.Execute()}");
            }

        }
    }

}
