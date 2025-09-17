public class SpaceAge
{
    private double seconds;
    
    public SpaceAge(int seconds)
    {
        this.seconds = seconds;
    }

    public double OnEarth() => Years();

    public double OnMercury() => Years() / 0.2408467;

    public double OnVenus() => Years() / 0.61519726;

    public double OnMars() => Years() / 1.8808158;

    public double OnJupiter() => Years() / 11.862615;
    
    public double OnSaturn() => Years() / 29.447498;

    public double OnUranus() => Years() / 84.016846;
    
    public double OnNeptune() => Years() / 164.79132;

    public double Years() => seconds / 60 / 60 / 24 / 365.25;
}