using System;
using System.Collections.Generic;

Console.Title = "C#";
Console.ForegroundColor = ConsoleColor.Blue;

int things;

Console.WriteLine("How many things do you want to sort?");

string[] thing = new string [things = Convert.ToInt32(Console.ReadLine())];

Console.WriteLine("Enter some things to sort alphabetically.");

for (int i = 0; i < thing.Length; i++)
{
    thing[i] = Console.ReadLine();
}

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine();
Console.WriteLine("Done.");

Array.Sort(thing);

for (int i = 0; i < thing.Length; i++)
{
    Console.WriteLine(thing[i]);
}
Console.ReadKey();