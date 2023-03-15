// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string[] favouriteFood = { "Pizza", "Pasta", "Patate", "Riso", "Frutta" };
Console.WriteLine(favouriteFood.Length);

for ( int i = 0; i < favouriteFood.Length; i++)
{
    Console.WriteLine( (i) + favouriteFood[i] );
}

Console.WriteLine("Al primo posto c'è:" + favouriteFood[0]);

Console.WriteLine("L'ultimo dei miei cibi preferiti è:" + favouriteFood[4]);
Console.WriteLine("A metà classifica c'è:" + favouriteFood[favouriteFood.Length / 2]);

