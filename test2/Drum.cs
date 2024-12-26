public class drum : instrument
{
      public int DrumSize{set;get;}

    public drum(string name, int volume) : base(name, volume)
    {
    }
      public override void play()
    {
       Console.WriteLine("The drum beats with rhythm!");

    }
  
}