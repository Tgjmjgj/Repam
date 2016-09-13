using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
       
        static void Main(string[] args)
        {
            bool isExit = false;
            int commandNumber = 0;
            double firstNumber = 0;
            double secondNumber = 0;
            double result = 0;
            while (!isExit)
            {
                try
                {
                    if ((commandNumber = Interface.ChooseAction()) != 0)
                    {
                        Interface.GetNumbers(ref firstNumber, ref secondNumber);
                        result  = Interface.Calculate(firstNumber, secondNumber, commandNumber);
                        Console.WriteLine("Your answer is : {0}", result);
                    }
                    else isExit = true;
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            Console.WriteLine("Good bye");
        }
    }
}
