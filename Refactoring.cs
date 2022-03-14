using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Bitte geben Sie eine Zahl ein:");
		string eingabe = Console.ReadLine();
		int wert1 = Convert.ToInt32(eingabe);
		
		Console.WriteLine("Bitte geben Sie noch eine Zahl ein:");
		eingabe = Console.ReadLine();
		int wert2 = Convert.ToInt32(eingabe);
		
		bool istGroesser = Test(wert1, wert2);
		if(istGroesser == true)
		{
			Console.WriteLine("Die erste Zahl ist größer.");
		}
		if(istGroesser == false)
		{
			Console.WriteLine("Die zweite Zahl ist größer.");
		}
		
	}
	
	static bool Test(int a, int b)
	{
		if(a>b)
		{
			return true;	
		}
		
		if(b<a)
		{	
			return false;
		}
		
		return false;
	}
}