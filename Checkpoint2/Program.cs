
using Checkpoint2;
using System.Runtime.InteropServices;

List<Product> productList = new List<Product>();

while (true)
{
    Console.WriteLine("-------------------------------------------------------------------------");
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("Registrera en produkt genom att följa stegen | Avsluta genom att skriva Q");
    Console.ResetColor();

    Console.Write("Kategori: ");
    string category = Console.ReadLine();

    if (category.ToLower().Trim() == "q")
    {
        break;
    }

    Console.Write("Produktnamn: ");
    string productName = Console.ReadLine();

    Console.Write("Pris (heltal): ");
    int price;
    while (!int.TryParse(Console.ReadLine(), out price))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Ange pris (heltal): ");
        Console.ResetColor();
    }

    Product newProduct = new Product
    {
        Category = category,
        ProductName = productName,
        Price = price
    };

    productList.Add(newProduct);
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Produkten lades till");
    Console.ResetColor();
}

Console.WriteLine("-------------------------------------------------------------------------");
Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine("Kategori".PadRight(15) + "Produktnamn".PadRight(15) + "Pris");
Console.ResetColor();

foreach (Product product in productList)
{
    Console.WriteLine(product.Print());
}

Console.ReadLine();