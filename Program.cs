class Program
{
    static void Main()
    {
        Console.WriteLine(" Put the number of Fibonacci: ");
        int n;

        if (int.TryParse(Console.ReadLine(), out n) && n >= 0)
        {
            int result = Fibonacci.Calculate(n);
            Console.WriteLine($"Fibonacci number for order {n}: {result}");
        }
        else
        {
            Console.WriteLine("Put valid number positive number.");
        }
    }
}
    
        static class Fibonacci
    {
        public static int Calculate(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return Calculate(n - 1) + Calculate(n - 2);
        }
    }
