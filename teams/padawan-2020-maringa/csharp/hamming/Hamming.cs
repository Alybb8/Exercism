using System;

public static class Hamming
{
    public static int Distance(string firstStrand, string secondStrand)
    {
        if(firstStrand.Length == secondStrand.Length)
        {
            var count = 0;
            var x = 0;
            foreach(var i in firstStrand)
            {
                if (i != secondStrand[x])
                    count++;
                x++;
            }
            return count;
        }
        else
        {
            throw new ArgumentException();
        }
    }
}