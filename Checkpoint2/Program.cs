
using Checkpoint2;
using System.Runtime.InteropServices;

//Product list / inventory
Inventory myInventory = new Inventory();

//Adding user input to product list
while (true)
{
    Console.WriteLine("-------------------------------------------------------------------------");
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("Registrera en produkt genom att följa stegen | Avsluta genom att skriva Q");
    Console.ResetColor();

    Console.Write("Kategori: "); //Category input - quit if entering 'q'
    string category = Console.ReadLine();

    if (category.ToLower().Trim() == "q")
    {
        break;
    }

    Console.Write("Produktnamn: "); //Product name input - quit if entering 'q'
    string productName = Console.ReadLine();

    if (productName.ToLower().Trim() == "q")
    {
        break;
    }

    Console.Write("Pris (heltal): "); //Price input
    int price;
    while (!int.TryParse(Console.ReadLine(), out price))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Ange pris (heltal): ");
        Console.ResetColor();
    }

    //Add new product to product list
    myInventory.Products.Add(new Product(category, productName, price));

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Produkten lades till");
    Console.ResetColor();
}

Console.WriteLine("-------------------------------------------------------------------------");
Console.ForegroundColor = ConsoleColor.DarkMagenta; //Header for display table
Console.WriteLine("Kategori".PadRight(20) + "Produktnamn".PadRight(20) + "Pris");
Console.ResetColor();

List<Product> sortedList = myInventory.sortList(); //List sorted from smallest to largest price
int sumOfProducts = myInventory.summarizeProducts(); //Summarize the price

//Display registered products in a sorted list with the total sum
foreach (Product product in sortedList)
{
    Console.WriteLine(product.Print());
}
Console.WriteLine();
Console.WriteLine("".PadRight(20) + "Totalsumma:".PadRight(20) + sumOfProducts);

Console.ReadLine();