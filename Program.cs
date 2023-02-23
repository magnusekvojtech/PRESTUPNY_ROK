// See https://aka.ms/new-console-template for more information
int rok;
Console.WriteLine("\n Zadejte rok:");
string z_klavesnice = Console.ReadLine();
rok = Convert.ToInt32(z_klavesnice);
if ((rok % 4) != 0)
    Console.WriteLine("Tento rok není přestupný");
else
    Console.WriteLine("Tento rok je přestupný");
