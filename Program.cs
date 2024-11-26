
    string secretWord = "batman";
    int wordlength = secretWord.Length;
    int maxAttempts = 6;
    int attemptsleft = maxAttempts;

    char[] guessWord = new string('_', wordlength).ToArray();
    HashSet<char> guessedLetters = new HashSet<char>();

    Console.WriteLine("Welcome to game 'Visilitsya'!");
    Console.WriteLine($"Numbers of letters in word: {wordlength}");
    Console.WriteLine($"Numbers of wrong attempts: {maxAttempts}\n");

    while (attemptsleft > 0 && Array.Exists(guessWord, c => c == '_'))
    {
        Console.WriteLine("Game word: " + string.Join(" ", guessWord));
        Console.WriteLine($"Attempts left : {attemptsleft}");
        Console.WriteLine("Put your Letter: ");
        char guess;

        try
        {
            guess = char.ToLower(Console.ReadKey().KeyChar);
            Console.WriteLine();
        }
        catch
        {
            Console.WriteLine("Error, please put just one letter. ");
            continue;
        }

        guessedLetters.Add(guess);

        if (secretWord.Contains(guess))
        {
            Console.WriteLine("this word contains this letter");
            for (int i = 0; i < wordlength; i++)
            {
                if (secretWord[i] == guess)
                {
                    guessWord[i] = guess;
                }
            }
        }
        else
        {
            attemptsleft--;
            Console.WriteLine($"Word doesn`t contains this letter. You have {attemptsleft}\n attempts");
        }
    }

    if (!Array.Exists(guessWord, c => c == '_'))
    {
        Console.WriteLine($"\nYou won secret word was: {secretWord}.");
    }
    else
    {
        Console.WriteLine($"\nYou loose, secret word was: {secretWord}.");
    }
