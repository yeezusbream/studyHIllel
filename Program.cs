Console.WriteLine("put 1st number");
int number1st = int.Parse(Console.ReadLine());

Console.WriteLine("put 2nd number");
int number2nd = int.Parse(Console.ReadLine());

Console.Write("Put the operator(+,-,/,*):");
string operation = Console.ReadLine();

switch (operation)
{
    case "+":
        Console.WriteLine($"Result: {number1st} + {number2nd} = {number1st + number2nd}");
        break;

    case "-":
        Console.WriteLine($"Result: {number1st} - {number2nd} = {number1st - number2nd}");
        break;

    case "/":
        Console.WriteLine($"Result: {number1st} / {number2nd} = {number1st / number2nd}");
        break;

    case "*":
        Console.WriteLine($"Result: {number1st} * {number2nd} = {number1st * number2nd}");
        break;



}