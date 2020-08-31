using System;

public static class ResistorColor
{
    public static int ColorCode(string color)
    {
        int code = Array.IndexOf(Colors(), color.ToLower());
        return code;
    }

    public static string[] Colors()
    {
        return new[] { "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white" };
    }
}