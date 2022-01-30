using System;

namespace TicTacToeRefactoring
{
    class Program
    {
        public char winPerson { get; set; }
        public bool isWin { get; set; }
        public bool isY { get; set; }
        public bool _error { get; set; }

        private static int wymiarTablicy = 5;
        private char[,] box = new char[wymiarTablicy, wymiarTablicy];

        public void WriteBoard()
        {
            for (int i = 0; i < wymiarTablicy; i++)
            {
                for (int j = 0; j < wymiarTablicy; j++)
                {
                    if (j == wymiarTablicy - 1)
                        Console.Write($" {box[i, j]} ");
                    else
                        Console.Write($" {box[i, j]} |");
                }
                if (i < wymiarTablicy - 1)
                {
                    Console.WriteLine(" ");
                    for (int p = 0; p < wymiarTablicy; p++)
                    {
                        Console.Write("----");
                    }
                    Console.WriteLine();
                }
            }
        }

        public void CheckWin()
        {
            int licznik;
            for (int liniaX = 0; liniaX < wymiarTablicy; liniaX++)
            {
                licznik = 0;
                for (int liniaY = 0; liniaY < wymiarTablicy; liniaY++)
                {
                    if (box[liniaX, liniaY] == 'X')
                        licznik++;
                    else if (box[liniaX, liniaY] == 'Y')
                        licznik--;
                }
                WIN(licznik);
            }

            for (int liniaY = 0; liniaY < wymiarTablicy; liniaY++)
            {
                licznik = 0;
                for (int liniaX = 0; liniaX < wymiarTablicy; liniaX++)
                {
                    if (box[liniaX, liniaY] == 'X')
                        licznik++;
                    else if (box[liniaX, liniaY] == 'Y')
                        licznik--;
                }
                WIN(licznik);
            }

            licznik = 0;
            for (int liniaX = 0; liniaX < wymiarTablicy; liniaX++)
            {
                for (int liniaY = 0; liniaY < wymiarTablicy; liniaY++)
                {
                    if (liniaX == liniaY)
                    {
                        if (box[liniaX, liniaY] == 'X')
                            licznik++;
                        else if (box[liniaX, liniaY] == 'Y')
                            licznik--;
                    }
                }
                WIN(licznik);
            }

            licznik = 0;
            for (int liniaX = 0; liniaX < wymiarTablicy; liniaX++)
            {
                for (int liniaY = 0; liniaY < wymiarTablicy; liniaY++)
                {
                    if (liniaX + liniaY == wymiarTablicy - 1)
                    {
                        if (box[liniaX, liniaY] == 'X')
                            licznik++;
                        else if (box[liniaX, liniaY] == 'Y')
                            licznik--;
                    }
                }
                WIN(licznik);
            }
        }

        private char WIN(int licznik)
        {
            if (licznik > wymiarTablicy - 1 || licznik < -1 * (wymiarTablicy - 1))
            {
                isWin = true;
                if (licznik > 0)
                    winPerson = 'X';
                else
                    winPerson = 'Y';
            }
            return winPerson;
        }

        static void Main()
        {
            int moveCount = 0; // check loss
            char askMove; // display X or Y in question
            int selTemp;
            Program prog = new Program();
            prog._error = false;
            for (int i = 0; i < wymiarTablicy; i++)
            {
                for (int j = 0; j < wymiarTablicy; j++)
                {
                    prog.box[i, j] = ' ';
                }
            }
            prog.isY = true;
            while (!prog.isWin)
            {
                if (moveCount == wymiarTablicy * wymiarTablicy)
                {
                    Console.WriteLine("\nNo one won.");
                    Console.ReadKey();
                    Environment.Exit(1);
                }
                if (prog.isY == true) // if is X
                    askMove = 'X';
                else
                    askMove = 'Y';

                Console.Clear();
                prog.WriteBoard();
                Console.Write($"\nWhat box do you want to place {askMove} in? (1-{wymiarTablicy * wymiarTablicy})\n> ");
                prog._error = !int.TryParse(Console.ReadLine(), out selTemp);
                if (selTemp > 0 && selTemp < wymiarTablicy * wymiarTablicy + 1)
                {
                    int Xowa = (selTemp - 1) / wymiarTablicy;
                    int Yowa = (selTemp - 1) % wymiarTablicy;
                    if (prog.box[Xowa, Yowa] == ' ')
                    {
                        prog.box[Xowa, Yowa] = askMove;
                        moveCount++;
                    }
                    else
                    {
                        prog._error = true;
                        Console.WriteLine("\nError: box not vacant!\nPress any key to try again..");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.WriteLine("Wrong selection entered!\nPress any key to try again..");
                    Console.ReadKey();
                    prog._error = true;
                }

                if (prog._error)
                {
                    prog.CheckWin(); // if error, just check win
                    prog._error = !prog._error;
                }
                else
                {
                    prog.isY = !prog.isY; // flip boolean
                    prog.CheckWin();
                }
            }
            Console.Clear();
            prog.WriteBoard();
            Console.WriteLine($"\nThe winner is {prog.winPerson}!");
            Console.ReadKey();
        }
    }
}