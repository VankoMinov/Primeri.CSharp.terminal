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

			string test = "1";
			test += ", 2";
			test += ", 100";
			test += ", 4";
			test += ", 5";

			Console.WriteLine ("Sabirane s += :" + test + "\n");
			test = test.Replace (",", ";");

			Console.WriteLine ("Rabota s replace" + test + "\n");
			Console.WriteLine ("Treti znak" + test.Split (';') [2]);



		}
	}
}
