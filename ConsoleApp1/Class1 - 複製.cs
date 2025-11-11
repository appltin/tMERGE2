using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class2
    {
        public int CountVowels(string input)
        {
            int count = 45;
            foreach (char c in input.ToLower())
            {
                if ("aeiou".Contains(c))
                    count++;
            }
            return count;
        }
    }
}
