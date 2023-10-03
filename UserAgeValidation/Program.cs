// See https://aka.ms/new-console-template for more information

//rakendus küsib kasutajal valida tema sugu (m/f)
//rakendus küsib kasutajal sisestada tema nime
//lähtudes kasutaja valikust, rakendus tervitab kasutajat järgmiselt:
//"Welcome, Mr. [kasutaja nimi]" / "Welcome, Ms. [kasutaja nimi]"


Console.WriteLine("Please,select your gender (m/f)");

char usergender = Char.Parse( Console.ReadLine()); //loeb konsoolist maha andmeid string formaadis


Console.WriteLine("Please, enter your last name: ") ;
string username = Console.ReadLine();



if (usergender == 'm')
{
    Console.WriteLine($"Welcome, Mr. {username}!");
}
else if (usergender == 'f')
{
    Console.WriteLine($"Welcome, Ms. {username}!");
}
else
{
    Console.WriteLine($"Welcome, {username}! ");
}