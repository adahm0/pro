public class instrument{
    public string name {set;get;}
    private int volume{set;get;}

    public static string  TotalInstruments;
    public instrument (string name , int volume){
this.name  = name;
this.volume  = volume;

    }
     public virtual void play(){
        Console.WriteLine("The instrument is playing!" );
        
     }
      
      public virtual void AdjustVolume(int level){
         Console.WriteLine(" the volume is :"+volume);
      }

      public int GetVolume(){
        return volume;
      }

}