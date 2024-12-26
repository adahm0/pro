public class Guitar : instrument
{
    public int StringCount{set;get;}
    public Guitar(string name, int volume) : base(name, volume)
    {
    }
    public override void play()
    {
       Console.WriteLine("The guitar strums a melody!");

    }

}