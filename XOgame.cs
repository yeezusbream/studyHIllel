class TicTacToe
{
    static char[] board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    static char currentPlayer = 'X';

    static void Main()
    {
        int turncount = 0;
        bool isGameWon = false;

        while (!isGameWon && turncount < 9)
        {
            Console.Clear();
            PrintBoard();
            PlayerMove();
            isGameWon = CheckWin();
            if (!isGameWon)
            {
                turncount++;
                SwitchPlayer();

            }
        }
        Console.Clear();
        PrintBoard();

        if (isGameWon)
        {
            Console.WriteLine($"Player {currentPlayer} wins!");
        }
        else
        {
            Console.WriteLine("It`s a draw!");
        }
    }

    static void PrintBoard()
    {
        Console.WriteLine("{0} | {1} | {2}", board[0], board[1], board[2]);
        Console.WriteLine("{0} | {1} | {2}", board[3], board[4], board[5]);
        Console.WriteLine("{0} | {1} | {2}", board[6], board[7], board[8]);

    }

    static void PlayerMove()
    {
        int choice;
        bool validMove = false;

        while (!validMove)
        {
            Console.WriteLine($"Player {currentPlayer}, enter same numbere where you wish put a mark; ");
            choice = int.Parse(Console.ReadLine()!);

            if (choice >= 1 && choice <= 9 && board[choice - 1] != 'X' && board[choice - 1] != 'O')
            {
                board[choice - 1] = currentPlayer;
                validMove = true;
            }

            else
            {
                Console.WriteLine("Invalid move, try again.");
            }
        }
    }

    static void SwitchPlayer()
    {
        currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
    }

    static bool CheckWin()
    {
        int[,] winningCombinations = new int[,]
        {
            { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 },
            { 0, 3, 6 }, { 1, 4, 7 }, { 2, 5, 8 },
            { 0, 4, 8 }, { 2, 4, 6 }
        };
        for (int i = 0; i < winningCombinations.GetLength(0); i++)
        {
            int a = winningCombinations[i, 0];
            int b = winningCombinations[i, 1];
            int c = winningCombinations[i, 2];

            if (board[a] == currentPlayer && board[b] == currentPlayer && board[c] == currentPlayer)
            {
                return true;
            }
        }
        return false;
    }
}
