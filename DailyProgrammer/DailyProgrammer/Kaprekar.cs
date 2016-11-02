using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyProgrammer
{
    static class Kaprekar
    {
        public static void Solve(int start, int end)
        {
            List<int> KaprekarNumbers = new List<int>();
            for (int x = start; x <= end; x++)
            {
                if (Check(Convert.ToInt32(Math.Pow(x, 2))))
                {
                    KaprekarNumbers.Add(x);
                }
            }
            Console.WriteLine(String.Join(", ", KaprekarNumbers.ToArray()));
        }

        private static bool Check(int number)
        {
            int num1;
            int num2;

            for(int y = 1; y < number.ToString().Length; y++)
            {
                num1 = Convert.ToInt32(number.ToString().Substring(0, y));
                num2 = Convert.ToInt32(number.ToString().Substring(y));
                
                if (num2 == 0)
                {
                    continue;
                }

                if (num1 + num2 == number)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
