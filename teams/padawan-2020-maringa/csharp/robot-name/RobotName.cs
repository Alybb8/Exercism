using System;
using System.Collections.Generic;

public class Robot
{
    private readonly Random random = new Random();
    private static HashSet<string> names = new HashSet<string>();
    public string Name
    {
            get;

            private set;
    }

    public Robot()
    {
        Reset();
    }

    public string GenName()
    {
        string robName = "";
        do
        {
            for (int x = 0; x < 5; x++)
            {
                robName += (x < 2) ? ((char)random.Next(65, 90)).ToString() : random.Next(0, 9).ToString();
            }
        } while (!OnlyName(robName));
        return robName.ToString();
    }

    public void Reset()
    {
        Name = GenName();
    }

    public bool OnlyName(string name)
    {
        return names.Add(name);
    }

}