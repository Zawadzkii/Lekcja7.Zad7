using System;

class Program
{
	static void Main(string[] args)
	{
		// Pobieranie trzech liczb od użytkownika
		Console.WriteLine("Podaj pierwszą liczbę:");
		int liczba1 = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("Podaj drugą liczbę:");
		int liczba2 = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("Podaj trzecią liczbę:");
		int liczba3 = Convert.ToInt32(Console.ReadLine());

		// Sprawdzanie, która liczba jest największa
		int najwieksza = liczba1;
		if (liczba2 > najwieksza)
		{
			najwieksza = liczba2;
		}
		if (liczba3 > najwieksza)
		{
			najwieksza = liczba3;
		}

		// Wyświetlanie wyniku
		Console.WriteLine($"{najwieksza} jest największa z podanych.");
	}
}