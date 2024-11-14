Console.WriteLine("enter your text: ");
string message = Console.ReadLine();

string cleanMessage = message.Replace(" ", "");

Console.WriteLine("Your text without spaces: ");
Console.WriteLine(cleanMessage);