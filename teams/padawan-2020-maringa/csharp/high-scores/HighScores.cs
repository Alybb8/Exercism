using System;
using System.Collections.Generic;
using System.Linq;

public class HighScores
{
    public List<int> highScores;
    public HighScores(List<int> list)
    {
        highScores = list;
    }

    public List<int> Scores()
    {
        return highScores;
    }

    public int Latest()
    {
        return highScores.Last();
    }

    public int PersonalBest()
    {
        return highScores.Max();
    }

    public List<int> PersonalTopThree()
    {
        return highScores.OrderByDescending(q => q).Take(3).ToList();
    }
}