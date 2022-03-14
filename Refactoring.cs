using System;
					
public class Program
{
	public static void Main()
	{
		int[] eingabe = ZweiZahlenEingeben();
		
		bool istGroesser = Test(eingabe[0], eingabe[1]);
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

static int[] ZweiZahlenEingeben()
{
	int[] werte = new int[2];
	Console.WriteLine("Bitte geben Sie eine Zahl ein:");
	string eingabe = Console.ReadLine();
	werte[0] = Convert.ToInt32(eingabe);
	
	Console.WriteLine("Bitte geben Sie noch eine Zahl ein:");
	eingabe = Console.ReadLine();
	werte[1] = Convert.ToInt32(eingabe);
	return werte;
}