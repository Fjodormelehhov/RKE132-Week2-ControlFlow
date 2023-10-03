// See https://aka.ms/new-console-template for more information

//rakendus küsib kasutajal sisestada tema vanuse
//kui kasutaja vanus on võiksem kui 13, siis konsoolis kuvatakse
//"You are too young to use instagram"
//muul juhul
//Konsoolis kuvatakse "Welcome to instagram"

using System.Diagnostics;

Console.WriteLine("Enter your age: ");

string userage = Console.ReadLine();

int useragenum = 0;

//boolean - true/false

bool isagenumber = Int32.TryParse(userage, out useragenum);

//int userage = Int32.Parse(Console.ReadLine()); //"13" - heap, 13 stack



if (isagenumber)
{
    if (useragenum >= 13)
    {
        Console.WriteLine("Welcome to instagram!");
    }
    else
    {
        Console.WriteLine("You are too young to use instagram.");
    }
} 
else
{
    Console.WriteLine("Could not read your age.");
}