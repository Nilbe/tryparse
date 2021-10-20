using System;

int gold = 100;
string item;
string howMany;

Console.WriteLine("You have " + gold + " gold. What du you want to buy? Skooma(10 gold), Book (30 gold) or Helmet (70 gold)");
item = Console.ReadLine();

item = item.ToLower();

if(item == "skooma" || item == "book" || item == "helmet")
{
    Console.WriteLine("How may would you like to buy?");
    howMany = Console.ReadLine();


}



Console.ReadLine();