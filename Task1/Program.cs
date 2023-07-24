var time=new Time(23,59,59);
 time.nextSecond(); 
  time.nextSecond(); 
  time.nextSecond();


time.ToString();

public class Time{
   public int Second { get; set; }
    public int Minute { get; set; }
    public int Hour { get; set; }
     public Time(int h,int m,int s)
     {
      Hour=h;
      Minute=m;
      Second=s;
      
     }
    public Time nextSecond(){
      ++Second;
      if(Second>=60){
        Second=0;
        Minute++;
      
      if(Minute>=60){
        Minute=0;
        Hour++;
      
      if(Hour>=24){
        Hour=0;
      }
      }
      }
      return this;
    }

public void ToString(){
    System.Console.WriteLine($"{Hour/10}{Hour%10}:{Minute/10}{Minute%10}:{Second/10}{Second%10}");
}
}
