public class paino : instrument
{
    public paino(string name, int volume) : base(name, volume)
    {
    }
      public override void play()
    {
       Console.WriteLine("The piano produces harmonious notes!");

    }
         public override void AdjustVolume(int level){
            if(level < 10)
            base.AdjustVolume(level);
         }
 
}
