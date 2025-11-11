using System;

public class Class1
{

	 public int CountVowels(string input)
    {
        int count = 0;
        foreach (char c in input.ToLower())
        {
            if ("aeiou".Contains(c))
                count++;
        }
        return count;
    }
	
}
