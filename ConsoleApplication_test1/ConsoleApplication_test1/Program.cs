using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_test1
{
	class Program
	{
		static void Main(string[] args)
		{
			const string title = "Kalkulator v. 1.0";
			// nadanie wartości dla właściwości
			Console.Title = title;
			
			//const string message = "Nacisnij klawisz Enter, aby obliczyć kwadrat liczby ";
			//string liczba;
			//int x = 3;
			//string imie = "Rafal";
			
			//// określenie koloru tła (niebieski)
			//Console.BackgroundColor = ConsoleColor.Blue;
			////ustaw położenie tekstu
			//Console.SetCursorPosition(1, 5);
			//Console.WriteLine("Semka podaj liczbę, aby obliczyć jej kwadrat");
			//liczba = Console.ReadLine();
			//Console.WriteLine(message+liczba);
			//Console.WriteLine("Podaj wartość dla X");
			
			//if (x >= 5)
			//{
			//	Console.WriteLine("Zmienna x ma wartość 5 lub wiecej !");
			//	if (x > 10)
			//	{
			//		Console.WriteLine("Zmienna x ma wartość wiekszą niż 10");
			//	}
			//}
			//else
			//{
			//	Console.WriteLine("Zmienna x ma wartosc mniejsza niz 5 !");
			//}
			
			
			//Console.WriteLine("Indeks 0 dla zmiennej Foo to:"+imie[0]);

			////////////////////////////////////////////////////////////////////
			//Console.Read();
			//Console.WriteLine("PRZYKLAD z LENGTH-1");
			//string Foo;
			//int FooLength;

			//Foo = "Adam";
			//FooLength = Foo.Length; // mamy długość łańcucha

			//Console.WriteLine(Foo[FooLength - 1]);

			////////////////////////////////////////////////////////////////////
			//Console.WriteLine("PRZYKLAD indeksu [LENGHT-]");

			//string Foo;
			//int FooLength;

			//Foo = "Adam";
			//FooLength = Foo.Length; // mamy długość łańcucha

			//Console.WriteLine(Foo[FooLength - 1]);

			////////////////////////////////////////////////////////////////////
			Console.WriteLine("PRZYKLAD petli WHILE !");
			int X = 1;

			while (X <= 10)
			{
				Console.WriteLine("Odliczanie..." + X);
				++X;
			}
			Console.Read();


			////////////////////////////////////////////////////////////////////
			//Console.WriteLine("PRZYKLAD: petla While z bool-em");
			//bool Done = false;

			//while (Done == false)
			//{
			//	Console.WriteLine("Podaj imię kobiece: ");
			//	string name = Console.ReadLine();

			//	if (name[name.Length - 1] == 'a')
			//	{
			//		Done = true; // użytkownik podał prawidłowe imię
			//		Console.WriteLine("Cześć " + name);
			//	}
			//	else
			//	{
			//		Console.WriteLine("Podałeś imię męskie :[");
			//	}
			//}
			

			Console.ReadKey();
			Console.Beep();
		}
	}
}
