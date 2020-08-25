using System;

public class Geyser				//Subscriber
{
    public static void Main(string[] args)
    {
        HeaterNotifier notifier = new HeaterNotifier();			
        notifier.BoilingComplete += new HeaterNotifier.OnBoilingCompleted(ShowNotification);  	//calls function when the event is raised
        notifier.TriggerNotification();
    }      
    static void ShowNotification()
    {
        Console.WriteLine("5 seconds up,Geyser Heated");
    }
}
class HeaterNotifier		//Publisher
{        
    public delegate void OnBoilingCompleted();			//Delegate
    public event OnBoilingCompleted BoilingComplete;			//Event
 		
    public void TriggerNotification()
    {		
		int Timer = 0;
		while(Timer < 5)
		{	
			Timer++;
		}
       	if(Timer == 5)
        {
           	BoilingComplete();								//event triggered
       	}          
    }
}
