using System;

namespace ReadFromCommandLine
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Definirane na promenlivi
			int a = 5, b = 0;

			//vavaejdane na vhodni rezultati
			Console.Write ( "Vavedete a: " );
			b = Convert.ToInt32 (Console.ReadLine ());

			//kraen rezultat
			Console.WriteLine ( "\n Rezultata a + b e " +  (a + b).ToString () + "\n\n\n" );
		}
	}
}
