
Console.WriteLine ("Was für einen Artikel kaufst du?");
Console.ReadLine ();

Console.WriteLine ("Wie gross ist der Preis?");
string price = Console.ReadLine();
double priceNumber = double.Parse(price);

Console.WriteLine ("Wie viele Artikel kaufst du?");
string amount = Console.ReadLine();
int amountNumber = int.Parse(amount);

Console.WriteLine ("Wie gross ist der Rabatt? (kann auch 0 sein) ");
string Rabatt = Console.ReadLine();
double RabattNumber = double.Parse(Rabatt);

double preis = amountNumber * priceNumber;

if (amountNumber > 0)
{

    Console.WriteLine ("Der Preis ist " + preis);

}
else
{
    Console.WriteLine("Error");
}

if (RabattNumber > 0)
{

    double totalRabatt = priceNumber / 100 * RabattNumber;
    double newPrice = preis - totalRabatt;
    Console.WriteLine("Der neue Preis ist " + newPrice);

}
else
{
    Console.WriteLine("Dieser Artikel hat keinen Rabatt");
}