using System;

public class Heater		
{
    public static void Main(string[] args)
    {
        HeaterNotification heated = new HeaterNotification();
        heated.Heated += new HeaterNotification.BoilingComplete(ShowNotification);  
        heated.TriggerNotification();
    }      
    static void ShowNotification()
    {
        Console.WriteLine("5 seconds up,Geyser Heated");
    }
}
class HeaterNotification
{        
    public delegate void BoilingComplete();
    public event BoilingComplete Heated;
 		
    public void TriggerNotification()
    {		
		int Timer = 0;
		while(Timer < 5)
		{	
			Timer++;
		}
       	if(Timer == 5)
        {
           	Heated();
       	}          
    }
}
