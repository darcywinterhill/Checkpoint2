using Checkpoint2;

//Product list / inventory
Inventory myInventory = new Inventory();

//* Adding user input to product list
while (true)
{
    Console.WriteLine("-------------------------------------------------------------------------");
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("Registrera en produkt genom att följa stegen | Avsluta genom att skriva Q");
    Console.ResetColor();

    //** Category input
    Console.Write("Kategori: ");
    string category = Console.ReadLine();

    if (category.ToLower().Trim() == "q") //Quit if entering 'q'
    {
        break;
    }

    bool isCategoryEmpty = string.IsNullOrWhiteSpace(category); //Error message if empty
    while (isCategoryEmpty)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Ange kategori: ");
        Console.ResetColor();
        category = Console.ReadLine();
        isCategoryEmpty = string.IsNullOrWhiteSpace(category);
    }

    //** Product name input
    Console.Write("Produktnamn: ");
    string productName = Console.ReadLine();

    if (productName.ToLower().Trim() == "q") //Quit if entering q
    {
        break;
    }

    bool isProductEmpty = string.IsNullOrWhiteSpace(productName); //Error message if empty
    while (isProductEmpty)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Ange produktnamn: ");
        Console.ResetColor();
        productName = Console.ReadLine();
        isProductEmpty = string.IsNullOrWhiteSpace(productName);
    }

    //** Price input
    Console.Write("Pris (heltal): ");
    string userInput = Console.ReadLine();

    if (userInput.ToLower().Trim() == "q") // Exit the loop and end the program
    {
        break; 
    }

    bool isInt = int.TryParse(userInput, out int price); //Error message if input is not integer
    if (!isInt)
    {
        while (!isInt)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Ange pris (heltal): ");
            Console.ResetColor();
            userInput = Console.ReadLine();
            isInt = int.TryParse(userInput, out price);
        }
    }

    if (isInt) //Add  product to list
    {
        myInventory.Products.Add(new Product(category, productName, price));

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Produkten lades till");
        Console.ResetColor();
    }
}

Console.WriteLine("-------------------------------------------------------------------------");
Console.ForegroundColor = ConsoleColor.DarkMagenta; //Header for display table
Console.WriteLine("Kategori".PadRight(20) + "Produktnamn".PadRight(20) + "Pris");
Console.ResetColor();

List<Product> sortedList = myInventory.SortList(); //List sorted from smallest to largest price
int sumOfProducts = myInventory.SummarizeProducts(); //Summarize the price

//* Display registered products in a sorted list with the total sum
foreach (Product product in sortedList)
{
    Console.WriteLine(product.Print());
}
Console.WriteLine();
Console.WriteLine("".PadRight(20) + "Totalsumma:".PadRight(20) + sumOfProducts);

Console.ReadLine();