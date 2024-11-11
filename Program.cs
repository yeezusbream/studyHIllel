//task1,2

    static void Main()
    {
        int[] numbers = new int[10];
        Random random = new Random();


    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = random.Next(-10, 11);
    }

    Console.WriteLine("Array elements with even indices:");
    for (int i = 0; i < numbers.Length; i += 2)
    {
        Console.WriteLine($"Index {i}: {numbers[i]}");
    }


int sum = 0;
for (int i = 0; i < numbers.Length; i++)
{
    sum += numbers[i];
}

Console.WriteLine($"Sum of array elements: {sum}");
Console.WriteLine($"The sum is an integral number: {sum >= 0}");
}

//task3

int[,] multiplicationTable = new int[9, 9];

for (int i = 0; i < 9; i++)
{
    for (int j = 0; j < 9; j++)
    {
        multiplicationTable[i, j] = (i + 1) * (j + 1);
    }
}

Console.WriteLine("multiplication Table 9x9:");
for (int i = 0; i < 9; i++)
{
    for (int j = 0; j < 9; j++)
    {
        Console.Write($"{multiplicationTable[i, j],2} ");
    }
    Console.WriteLine();
}

//task4
int[,] array = new int[5, 5];
Random randomyse = new Random();

for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        array[i, j] = randomyse.Next(-10, 10);
    }
}

int max = array[0, 0];
int min = array[0, 0];
(int maxX, int maxY) = (0, 0);
(int minX, int minY) = (0, 0);

for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        if (array[i, j] > max)
        {
            max = array[i, j];
            maxX = i;
            maxY = j;
        }
        if (array[i, j] < min)
        {
            min = array[i, j];
            minX = i;
            minY = j;
        }
    }
}

Console.WriteLine($"Max element: {max} in position ({maxX},{maxY})");
Console.WriteLine($"Min element: {min} in position ({minX},{minY})");

//task5
enum DayOfWeek
{
    Monday = 1,
    Tuesday = 2,
    Wednesday = 3,
    Thursday = 4,
    Friday = 5,
    Saturday = 6,
    Sunday = 7
}

class DaysOfWeek
{
    static void Main()
    {
        Console.WriteLine("put the numbers of days:");
        int daysToAdd = int.Parse(Console.ReadLine()!);

        DayOfWeek startDay = DayOfWeek.Monday;
        int targetDayIndex = (int)startDay + (daysToAdd % 7) - 1;
        DayOfWeek targetDay = (DayOfWeek)((targetDayIndex % 7) + 1);

        Console.WriteLine($"via {daysToAdd} days will be {targetDay}");
    }
}