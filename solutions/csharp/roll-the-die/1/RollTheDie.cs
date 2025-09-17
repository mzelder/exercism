public class Player
{
    private Random dice = new Random();
    
    public int RollDie() => dice.Next(1, 18);

    public double GenerateSpellStrength() => dice.NextDouble() * 100.0;
}
