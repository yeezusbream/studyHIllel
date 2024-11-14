Console.Write("Enter your First name : ");
string firstName = Console.ReadLine();

Console.Write("Enter your Last name : ");
string lastName = Console.ReadLine();

if (!string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(lastName))
{
    char nameLetter = firstName.ToCharArray()[0];
    char lastLetter = lastName.ToCharArray()[0];

    if (char.ToUpper(nameLetter) == char.ToUpper(lastLetter))
    {
        Console.WriteLine("First letters are same");
    }
    else 
    {
    Console.WriteLine("Firs letters are different");
    }
}