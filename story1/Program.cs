// See https://aka.ms/new-console-template for more information


Console.WriteLine("Vad heter du?");
string name = Console.ReadLine();
Console.WriteLine("Välkommen " + name);
Console.WriteLine("Är du redo att börja äventyret?, " + name);
string svar = Console.ReadLine();
if(svar == "ja" || svar == "Ja" || svar == "JA")
{  
    Console.WriteLine("Härligt, du ställs nu inför ett val, vill du gå höger eller vänster?");
    string answer = Console.ReadLine();
    if(answer == "höger")
    {
        Console.WriteLine("Du dog");
    }
    else if(answer == "vänster")
    {
        Console.WriteLine("Du har tagit dig vidare in mot bålsta centrum, du ser benim stå där i sina shorts i -17 grader, vill du prata med han?");
            string svar2 = Console.ReadLine();
            if(svar2 == "ja" || svar2 == "Ja" || svar2 == "JA")
            {
                Console.WriteLine("Benim bemöter dig på ett väldigt trevligt sätt och börjar prata om sin favoritmusikstil, reggae.");
            }
    }
        
    Console.ReadLine();

}
else if (svar == "nej")
{
    Console.WriteLine("tråkigt");
}

Console.ReadLine();