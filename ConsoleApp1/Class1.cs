using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class1
    {
        public int CountVowels(string input)
        {
            int count = 0;
            foreach (char c in input.ToLower())
            {
                if ("a".Contains(c))
                    count--;
            }
            return count;
        }
    }
}
