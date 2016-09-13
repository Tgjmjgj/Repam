using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculator
    {
        public static double Divide(double first, double second)
        {
            try
            {
                if (second == 0) throw (new Exception("Dividing by zero"));
                return first / second;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return -1;
        }
        public static double Multiplier(double first, double second)
        {
                return first * second;
            }
        public static double Add(double first, double second)
            {
                return first + second;
            }
        public static double Minus(double first, double second)
            {
              return first - second;
            }
    }
}
