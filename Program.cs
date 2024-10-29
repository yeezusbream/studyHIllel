//1 zadanie

Console.Write("Put the number of employees: ");

decimal overallSalary = 0;

int HMuchEmployees = int.Parse(Console.ReadLine()!);

for (int i = 1; i <= HMuchEmployees; i++)
{
    Console.WriteLine($"Please enter {i} employee Salary: ");

    decimal EmployeeSalary = decimal.Parse(Console.ReadLine()!);

    overallSalary = +EmployeeSalary;

}
Console.WriteLine($"Average salary: {overallSalary / HMuchEmployees}");


//2 zadanie

Console.Write("Please enter the number of graphics rows: ");

int rows = int.Parse(Console.ReadLine()!);

for (int i = 1; i <= rows; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

//3 zadanie i 8 sdelano

Console.WriteLine("Please put your number: ");

int maxnumber = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Prime numbers till {maxnumber}: ");

for (int i = 2; i <= maxnumber; i++)
{
    if (IsPrime(i))
    {
        Console.WriteLine(i);
    }
}

static bool IsPrime(int number)
{
    if (number < 2)
        return false;

    for (int i = 2; i <= Math.Sqrt(number); i++)
    {
        if (number % i == 0)
            return false;
    }

    return true;
}



// 4 zadanie

Console.WriteLine("Please enter your password: ");

string password = Console.ReadLine();

char[] SpecialSymbols = { '!', '@', '#', '$', '%', '^', '?' };

if (password.Length < 8)
{
    Console.WriteLine("Password should be longer then 8 symbols.");
    return;
}

bool hasSpecialSymbol = false;
foreach (char symbol in SpecialSymbols)
{
    if (password.Contains(symbol))
    {
        hasSpecialSymbol = true;
        break;
    }
}
if (!hasSpecialSymbol)
{
    Console.WriteLine("Password should contains any one special symbol:!,@,#,$,%,^,?");

}

bool hasDigit = false;
foreach (char c in password)
{
    if (char.IsDigit(c))
    {
        hasDigit = true;
        break;
    }
}

if (!hasDigit)
{
    Console.WriteLine("Password should contains any number");
    return;
}

Console.WriteLine("Password is legal to use.");

//5 zadanie 


Console.WriteLine("Put the number of calculations Fibonacci numbers: ");

int fNumbers = int.Parse(Console.ReadLine()!);

int firstFN = 0;
int secondFN = 1;

Console.WriteLine("Fibonacci numbers: ");

for (int i = 0; i < fNumbers; i++)
{
    Console.WriteLine(firstFN + " ");

    int next = firstFN + secondFN;
    firstFN = secondFN;
    secondFN = next;
}

//6 zadanie 
Console.WriteLine("Put the number of work hours: ");
double workHour = int.Parse(Console.ReadLine()!);
if (workHour <= 0)
{
    Console.WriteLine("Work hours must be greater than zero.");
    return;
}

Console.WriteLine("Put your monthly salery: ");
double monthSalery = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Your payment per hour {monthSalery / workHour}");

//7 zadanie
Console.WriteLine("Put the number what you wish multiply: ");
int multNumber = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Multiplication table by {multNumber}");

for (int i = 0; i <= 10; i++)
{
    int result = multNumber * i;
    Console.WriteLine($"{multNumber} * {i}= {result}");
}