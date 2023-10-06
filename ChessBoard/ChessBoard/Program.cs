using System;

namespace ChessBoard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare variables to store user input
            int row;
            string svart, vita;
            int xpice, ypice;
            string Pice;

            Console.WriteLine("Chass Game");
            Console.WriteLine("==========\n\n");


            // Prompt the user to enter chessboard size
            Console.WriteLine("Enter the Size of Chessboard:");
            row = Convert.ToInt32(Console.ReadLine());
        

            // Prompt the user to enter characters for black and white squares

            Console.WriteLine("Enter the character for black squares:");
            svart = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter the character for white squares:");
            vita = Convert.ToString(Console.ReadLine());

            // Prompt the user to enter the coordinates of the pice

            Console.WriteLine("Enter the X-coordinate of the pice");
            xpice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Y-coordinate of the pice");
            ypice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Caracther you wish for Pice");
            Pice = Console.ReadLine();
            Console.WriteLine("===========================\n\n");
            // Loop through rows
            for (int i = 0; i < row; i++)
            {
                Console.WriteLine(); // Start a new row

                // Loop through columns
                for (int j = 0; j < row; j++)
                {
                    // Check if the current position matches the pice's coordinates
                    if (i == xpice && j == ypice)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(Pice); // Place the pice
                    }
                    // Loop through Rows
                    else if (i % 2 != 0 && j % 2 != 0 || i % 2 == 0 && j % 2 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(svart); // Black symbol
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(vita); // White symbol
                    }
                }
            }

            // Wait for user input before exiting
            Console.ReadLine();
        }
    }
}
