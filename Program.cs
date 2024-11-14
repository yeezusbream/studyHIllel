using System.Text;

StringBuilder reportBuilder = new StringBuilder();

Console.WriteLine("Enter Title for report: ");
string title = Console.ReadLine();

Console.WriteLine("Enter the date: ");
string date = Console.ReadLine();


reportBuilder.AppendLine("****REPORT****");
reportBuilder.AppendLine($"Title: {title}");
reportBuilder.AppendLine($"Date: {date}");
reportBuilder.AppendLine("Events: ");

while (true)
{
    Console.WriteLine("enter the event (or put nothing and press enter to finish) ");
    string eventText = Console.ReadLine();

    if (string.IsNullOrEmpty(eventText))
    {
        break;
    }
    reportBuilder.AppendLine($"-{eventText}");
}
Console.WriteLine("Your report is ready");
Console.WriteLine((reportBuilder.ToString()));