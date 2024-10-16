
Console.WriteLine("Enter your name, product: ");

String Services1 = "Order";
String Services2 = "Client:";
String Services3 = "Product";
String Services4 = "Adress";
String Services5 = "Price";

String money = "EUR.";

String nameOrders = "Order No";
String nameProduct1 = "Smartphone";
String nameProduct2 = "Laptop";
String nameProduct3 = "Keyboard";

String nameHome1 = "Moon Street";
String nameHome2 = "Terra Street";
String nameHome3 = "Green Walley";

String name1 = "Alice";
String name2 = "Tom";
String name3 = "Jack";





byte order1 = 1;
byte order2 = 2;
byte order3 = 3;

byte adressnumb1 = 10;
byte adressnumb2 = 17;
byte adressnumb3 = 32;

double priceSmartphone = 305.99;
double pricelaptop = 570.95;
double priceKeyboard = 5.50;

string searchName = Console.ReadLine();

if (searchName == $"{name1} {nameProduct1}")
{
    Console.WriteLine($"{Services1} {order1}"); Console.BackgroundColor = ConsoleColor.Black;
    Console.ForegroundColor = ConsoleColor.Yellow; 
    Console.WriteLine($"{Services2} {name1}");
    Console.WriteLine($"{Services3}: {nameProduct1}, {Services5}: {priceSmartphone} {money}");
    Console.WriteLine($"{Services4}: {nameHome1}, {adressnumb1}");
}
else if (searchName == $"{name2} {nameProduct2}")
{
    Console.WriteLine($"{Services1} {order2}"); Console.BackgroundColor = ConsoleColor.Black;
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine($"{Services2} {name2}");
    Console.WriteLine($"{Services3}: {nameProduct2}, {Services5}: {pricelaptop} {money}");
    Console.WriteLine($"{Services4}: {nameHome2}, {adressnumb2}");
}
else if (searchName == $"{name3} {nameProduct3}")
{
    Console.WriteLine($"{Services1} {order3}"); Console.BackgroundColor = ConsoleColor.Black;
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine($"{Services2} {name3}");
    Console.WriteLine($"{Services3}: {nameProduct3}, {Services5}: {priceKeyboard} {money}");
    Console.WriteLine($"{Services4}: {nameHome3}, {adressnumb3}");
}
else
{
    Console.WriteLine("No matching order found.");
}








