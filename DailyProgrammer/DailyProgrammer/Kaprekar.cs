using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyProgrammer
{
    class Kaprekar
    {
        public void Solve(int start, int end)
        {
            List<int> KaprekarNumbers = new List<int>();

            for (int x = start; x <= end; x++)
            {
                if (Check(x))
                {
                    KaprekarNumbers.Add(x);
                }
            }
            Console.WriteLine(KaprekarNumbers.ToString());
        }

        private bool Check(int number)
        {
            return 1;
        }
    }
}
