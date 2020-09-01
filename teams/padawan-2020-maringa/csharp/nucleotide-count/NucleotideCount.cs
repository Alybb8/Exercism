using System;
using System.Collections.Generic;

public static class NucleotideCount
{
    public static IDictionary<char, int> Count(string sequence)
    {
        var countA = 0;
        var countC = 0;
        var countG = 0;
        var countT = 0;

        for(int i = 0; i < sequence.Length; i++)
        {
            if (sequence[i] == 'A')
                countA++;
            else if (sequence[i] == 'C')
                countC++;
            else if (sequence[i] == 'G')
                countG++;
            else if (sequence[i] == 'T')
                countT++;
            else throw new ArgumentException();
        }

        IDictionary<char, int> dictionary = new Dictionary<char, int>();
            dictionary.Add('A', countA);
            dictionary.Add('C', countC);
            dictionary.Add('G', countG);
            dictionary.Add('T', countT);

        return dictionary;
    }
}