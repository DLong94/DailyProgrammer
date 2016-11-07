using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DailyProgrammer
{
    static class Alliteration
    {
        private static string[] StopWords = new string[] { "I", "a", "about", "an", "and", "are", "as", "at", "be", "by", "com", "for", "from", "how", "in", "is", "it", "of", "on", "or", "that", "the", "this", "to", "was", "what", "when", "who", "will", "with", "the"};


        public static string Solve(string AlliterationText)
        {
            List<string> solution = new List<string>();

            StringReader reader = new StringReader(AlliterationText);
            string line;
            do
            {
                line = reader.ReadLine();


            } while (line != null);


            return solution.ToString();
        }
    }
}
