// See https://aka.ms/new-console-template for more information

using System.ComponentModel;
using System.Security.AccessControl;

Console.WriteLine("Hello, World!");

// Task 6

//Write a console app which accepts string from the console and print back the count of the unique symbols in that string

string input = Console.ReadLine();

Dictionary<char, int> result = new Dictionary<char, int>();

for (int i = 0; i < input.Length; i++)
{
	if (result.ContainsKey(input[i]))
	{
		result[input[i]]++;
	}
	else
	{
		result.Add(input[i], 1);
	}

}

foreach (var item in result)
{
	Console.WriteLine(item);
}