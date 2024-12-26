public class program{
    public static void Main(string[]arges){
        instrument[]ins = new instrument[3] ;
        Guitar g = new Guitar("classic Guitar",5);
        paino p =new paino("modren paino",20);
drum d = new drum ("rock drum" , 10);
 
 ins  [0] =g;
 ins  [1] =p;
  ins  [2] =d;
  for (int i = 0; i < ins.Length; i++)
  {
    ins[i].play();
  }
  ins  [0].AdjustVolume(5);
 ins  [1].AdjustVolume(10);
  ins  [2].AdjustVolume(15);
    for (int i = 0; i < ins.Length; i++)
  {
    ins[i].GetVolume();
  }
  Console.WriteLine("the total number of instruments is:"+instrument.TotalInstruments);
    }
}