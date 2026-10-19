
Console.WriteLine ("Was für einen Artikel kaufst du?");
Console.ReadLine ();

Console.WriteLine ("Wie gross ist der Preis?");
string price = Console.ReadLine();
int priceNumber = int.Parse(price);

Console.WriteLine ("Wie viele Artikel kaufst du?");
string amount = Console.ReadLine();
int amountNumber = int.Parse(amount);

int preis = amountNumber * priceNumber;

Console.WriteLine ("Der Preis ist " + preis);