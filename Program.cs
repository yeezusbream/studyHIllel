
        int number1st = GetValidNumber("Put 1st number: ");
        int number2nd = GetValidNumber("Put 2nd number: ");

        Console.Write("Put the operator (+, -, /, *): ");
        string operation = Console.ReadLine();

        try
        {
            switch (operation)
            {
                case "+":
                    Console.WriteLine($"Result: {number1st} + {number2nd} = {number1st + number2nd}");
                    break;

                case "-":
                    Console.WriteLine($"Result: {number1st} - {number2nd} = {number1st - number2nd}");
                    break;

                case "/":
                    if (number2nd == 0)
                    {
                        throw new DivideByZeroException();
                    }
                    Console.WriteLine($"Result: {number1st} / {number2nd} = {(double)number1st / number2nd}");
                    break;

                case "*":
                    Console.WriteLine($"Result: {number1st} * {number2nd} = {number1st * number2nd}");
                    break;

                default:
                    Console.WriteLine("Error: Invalid operator.");
                    break;
            }
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    
    static int GetValidNumber(string message)
    {
        int validNumber;
        while (true)
        {
            Console.Write(message);
            try
            {
                validNumber = int.Parse(Console.ReadLine());
                return validNumber;  
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input, please enter a valid number.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error: The number is too large or too small.");
            }
        }
    }
