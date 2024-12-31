using System;

namespace TicTacToe
{
    class Program
    {
        
        static int[] board = new int[9];

        static void Main(string[] args)
        {
            for (int i = 0; i < 9; i++)
            {
                board[i] = 0;
            }

            Console.WriteLine("Welcome to Tic-Tac-Toe!");

            int player = 1;
            int moves = 0;

            while (moves < 9)
            {
                PrintBoard();
                Console.Write($"{GetPlayerSymbol(player)}'s move > ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out int position) || position < 1 || position > 9)
                {
                    Console.WriteLine("Illegal move! Try again.");
                    continue;
                }

                int index = position - 1;

                if (board[index] != 0)
                {
                    Console.WriteLine("Illegal move! Try again.");
                    continue;
                }

                board[index] = player;
                moves++;

                if (moves == 9) break;

                player = (player == 1) ? 2 : 1;
            }

            PrintBoard();
            Console.WriteLine("Game over!");
        }

        static void PrintBoard()
        {
            Console.WriteLine();
            Console.WriteLine($"{GetSymbol(board[0])} | {GetSymbol(board[1])} | {GetSymbol(board[2])}");
            Console.WriteLine("--+---+--");
            Console.WriteLine($"{GetSymbol(board[3])} | {GetSymbol(board[4])} | {GetSymbol(board[5])}");
            Console.WriteLine("--+---+--");
            Console.WriteLine($"{GetSymbol(board[6])} | {GetSymbol(board[7])} | {GetSymbol(board[8])}");
            Console.WriteLine();
        }

        static string GetSymbol(int value)
        {
            if (value == 1) return "X";
            if (value == 2) return "O";
            return " ";
        }

        static string GetPlayerSymbol(int player)
        {
            return (player == 1) ? "X" : "O";
        }
    }
}
