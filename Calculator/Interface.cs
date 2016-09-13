using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Calculator
{
    class Interface
    {
        public static void GetNumbers(ref double first, ref double second)
        {

            Console.Write("\nEnter First Number:");
            first = Double.Parse(Console.ReadLine());
            Console.Write("\nEnter Second Number:");
            second = Double.Parse(Console.ReadLine());

        }
        public static int ChooseAction()
        {
            int commandNumber = 0;
            Console.WriteLine("Choose Command:\n1:Sum\n2: Minus \n3: Multiplier \n4: Divide \nAny Other Symbol: Exit\n");
            Int32.TryParse(Console.ReadLine(), out commandNumber);
            if (commandNumber > 4 || commandNumber < 1) return 0;
            else return commandNumber;
        }
        public static double Calculate(double firstNumber,double secondNumber,int commandNumber)
        {
            double result = 0;
            switch (commandNumber)
            {
                case 1:
                    result = Calculator.Add(firstNumber, secondNumber);
                    break;
                case 2:
                    result = Calculator.Minus(firstNumber, secondNumber);
                    break;
                case 3:
                    result = Calculator.Multiplier(firstNumber, secondNumber);
                    break;
                case 4:
                    result = Calculator.Divide(firstNumber, secondNumber);
                    break;
            }
            return result;
        }
    }
}
