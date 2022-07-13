using System;
using System.Collections.Generic;
using System.Text;

namespace Tuto
{
    enum OperationType{ 
        Addition, Substraction, Multiplication, Division
    }
    class OperationHelper
    {
        public static IOperation Factory(int opId) {
            if (opId == 1)
            {
                return new Addition();
            }
            else if (opId == 2)
            {
                return new Substraction();
            }
            else if (opId == 3)
            {
                return new Multiplication();
            }
            else if (opId == 4)
            {
                return new Division();
            }
            else if (opId == 5)
            {
                return new Sine();
            }
            else {
                return null;
            }
        }

        public static int ChooseOperation() {
            int opId = 0;
            Console.WriteLine(@"
Enter which operation you want to carry out:
1 -> Adition
2 -> Substraction
3 -> Multiplication
4 -> Division
5 -> Sine

Or enter -1 to stop
");
            opId = !int.TryParse(Console.ReadLine(), out opId) ? 0 : opId;

            return opId;
        }
    }
}
