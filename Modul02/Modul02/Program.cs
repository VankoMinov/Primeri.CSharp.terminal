using System;

namespace Modul02
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Дефинирене на променливи
			int a = 0;
			int b = 0;
			int sum = 0;

			//Събиране на числа
			a = 10;
			b = 5;
			sum = a + b;


			//Писане в конзола

			Console.Write (a);
			Console.Write (" + ");
			Console.Write (b);
			Console.Write (" = ");


			Console.WriteLine (sum);

			//Допълнителни оператори

			Console.WriteLine (" \n Izpolzvane na += ");
			a += b; //a = 10 + 5;  a = a+b;
			Console.WriteLine (a);

			Console.WriteLine (" \n Izpolzvane na -= ");
			a -= b; //a = 10 - 5;  a = a-b;
			Console.WriteLine (a);

			Console.WriteLine (" \n Izpolzvane na *= ");
			a *= b; //a = 10 * 5;  a = a*b;
			Console.WriteLine (a);

			Console.WriteLine (" \n Izpolzvane na ++ ");
			a++ ; //a = a+1;
			Console.WriteLine (a);

			Console.WriteLine (" standartno delene " + (7 / 3).ToString ()  );
			Console.WriteLine (" ostatuk ot delene " + (7 % 3).ToString ()  );



		}
	}
}
