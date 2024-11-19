class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Chose an option:");
            Console.WriteLine("1 - Find the second largest element in an array");
            Console.WriteLine("2 - Sort a two-dimensional array in ascending order");
            Console.WriteLine("3 - Remove element from array by index");
            Console.WriteLine("4 - Find the sum of the elements along the diagonal of a two-dimensional array");
            Console.WriteLine("0 - Exit");
            int choice = int.Parse(Console.ReadLine()!);

            switch (choice)
            {
                case 1:
                    FindSecondLargestElement();
                    break;
                case 2:
                    Sort2DArray();
                    break;
                case 3:
                    RemoveArrayElement();
                    break;
                case 4:
                    DiagonalSum2DArray();
                    break;
                case 0:
                    Console.WriteLine("Exit programm...");
                    return;
                default:
                    Console.WriteLine("Error 404, what the hell?.");
                    break;
            }
        }
    }

    static void FindSecondLargestElement()
    {
        int[] numbers = GenerateRandomArray(10);
        Console.WriteLine("Array:");
        PrintArray(numbers);

        int max = int.MinValue;
        int secondMax = int.MinValue;

        foreach (int num in numbers)
        {
            if (num > max)
            {
                secondMax = max;
                max = num;
            }
            else if (num > secondMax && num != max)
            {
                secondMax = num;
            }
        }

        Console.WriteLine($"The second largest element: {secondMax}");
    }

    static void Sort2DArray()
    {
        int[,] matrix = GenerateRandom2DArray(3, 3);
        Console.WriteLine("Source array:");
        Print2DArray(matrix);

        int[] flatArray = FlattenMatrix(matrix);
        Array.Sort(flatArray);
        FillMatrixFromArray(matrix, flatArray);

        Console.WriteLine("Sorted array:");
        Print2DArray(matrix);
    }

    static void RemoveArrayElement()
    {
        int[] numbers = GenerateRandomArray(10);
        Console.WriteLine("Array:");
        PrintArray(numbers);

        Console.WriteLine("Put the index for deleting:");
        int index = int.Parse(Console.ReadLine()!);

        if (index < 0 || index >= numbers.Length)
        {
            Console.WriteLine("Incorrect index.");
            return;
        }

        int[] newArray = new int[numbers.Length - 1];
        int currentIndex = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (i != index)
            {
                newArray[currentIndex++] = numbers[i];
            }
        }

        Console.WriteLine("Array after element removal:");
        PrintArray(newArray);
    }

    static void DiagonalSum2DArray()
    {
        int[,] matrix = GenerateRandom2DArray(3, 3);
        Console.WriteLine("Array:");
        Print2DArray(matrix);

        int sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, i];
        }

        Console.WriteLine($"Sum of elements along the diagonal: {sum}");
    }

    static int[] GenerateRandomArray(int size)
    {
        Random random = new Random();
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            array[i] = random.Next(1, 101);
        }
        return array;
    }

    static int[,] GenerateRandom2DArray(int rows, int cols)
    {
        Random random = new Random();
        int[,] matrix = new int[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = random.Next(1, 101);
            }
        }
        return matrix;
    }

    static void PrintArray(int[] array)
    {
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }

    static void Print2DArray(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    static int[] FlattenMatrix(int[,] matrix)
    {
        int[] flatArray = new int[matrix.Length];
        int index = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                flatArray[index++] = matrix[i, j];
            }
        }
        return flatArray;
    }

    static void FillMatrixFromArray(int[,] matrix, int[] array)
    {
        int index = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = array[index++];
            }
        }
    }
}
