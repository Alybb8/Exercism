using System;

public class SpaceAge
{
    public double secondsD;
    public double earthYears;

    public SpaceAge(int seconds)
    {
        //convertendo pra double
        secondsD = (double)seconds;
        earthYears = OnEarth();
    }

    public double OnEarth()
    {
        return secondsD / 31557600;
    }

    public double OnMercury()
    {
        return earthYears / 0.2408467;
    }

    public double OnVenus()
    {
        return earthYears / 0.61519726;
    }

    public double OnMars()
    {
        return earthYears / 1.8808158;
    }

    public double OnJupiter()
    {
        return earthYears / 11.862615;
    }

    public double OnSaturn()
    {
        return earthYears / 29.447498;
    }

    public double OnUranus()
    {
        return earthYears / 84.016846;
    }

    public double OnNeptune()
    {
        return earthYears / 164.79132;
    }
}