using System;

namespace RefaktoryzacjaKolkoKrzyzyk
{
    class Program
    {
        private char winChar;
        public char winPerson
        {
            get { return winChar; }
            set { winChar = value; }
        }
        private bool hasWon;
        public bool isWin
        {
            get { return hasWon; }
            set { hasWon = value; }
        }
        private bool isX;
        public bool isY
        {
            get { return isX; }
            set { isX = value; }
        }
        static int wymiarTablicy = 3;
        public char[,] box = new char[wymiarTablicy, wymiarTablicy];
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

            for (int liniaX = 0; liniaX < wymiarTablicy; liniaX++)
            {
                int licznik = 0;
                for (int liniaY = 0; liniaY < wymiarTablicy; liniaY++)
                {
                    if (box[liniaX, liniaY] == 'X')
                        licznik++;
                    else if(box[liniaX, liniaY] == 'Y')
                    {
                        licznik--;
                    }
                }

                if (licznik > wymiarTablicy-1 || licznik < -1*(wymiarTablicy-1))
                {
                    isWin = true;
                    if(licznik > 0)
                        winPerson = 'X';
                    else
                        winPerson = 'Y';
                    break;
                }
            }

            for (int liniaY = 0; liniaY < wymiarTablicy; liniaY++)
            {
                int licznik = 0;
                for (int liniaX = 0; liniaX < wymiarTablicy; liniaX++)
                {
                    if (box[liniaX, liniaY] == 'X')
                        licznik++;
                    else if (box[liniaX, liniaY] == 'Y')
                    {
                        licznik--;
                    }
                }

                if (licznik > wymiarTablicy - 1 || licznik < -1 * (wymiarTablicy - 1))
                {
                    isWin = true;
                    if (licznik > 0)
                        winPerson = 'X';
                    else
                        winPerson = 'Y';
                    break;
                }
            }
            
            
        }

        public void NotVacantError()
        {
            _error = true;
            Console.WriteLine();
            Console.WriteLine("Error: box not vacant!");
            Console.WriteLine("Press any key to try again..");
            Console.ReadKey();
            return;
        }

        public void DisplayLoss()
        {
            Console.WriteLine();
            Console.WriteLine("No one won.");
            Console.ReadKey();
            Environment.Exit(1);
        }

        private bool hasError;

        public bool _error
        {
            get { return hasError; }
            set { hasError = value; }
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
            Console.WriteLine(" -- Tic Tac Toe -- ");
            Console.Clear();
            while (!prog.isWin)
            {
                if (moveCount == wymiarTablicy * wymiarTablicy)
                {
                    prog.DisplayLoss();
                }
                if ((prog.isY) == true) // if is X
                {
                    askMove = 'X';
                }
                else
                {
                    askMove = 'Y';
                }
                Console.Clear();
                prog.WriteBoard();
                Console.WriteLine();
                Console.WriteLine("What box do you want to place {0} in? (1-9)", askMove);
                Console.Write("> ");
                selTemp = int.Parse(Console.ReadLine());
                
                for(int iteracja = 0;iteracja < prog.box.Length;iteracja++)
                {

                }

                switch (selTemp)
                {
                    case 1:
                        if (prog.box[0, 0] == ' ')
                        {
                            prog.box[0, 0] = askMove;
                            moveCount++;
                        }
                        else
                        {
                            prog.NotVacantError();
                        }
                        break;
                    case 2:
                        if (prog.box[0, 1] == ' ')
                        {
                            prog.box[0, 1] = askMove;
                            moveCount++;
                        }
                        else
                        {
                            prog.NotVacantError();
                        }
                        break;
                    case 3:
                        if (prog.box[0, 2] == ' ')
                        {
                            prog.box[0, 2] = askMove;
                            moveCount++;
                        }
                        else
                        {
                            prog.NotVacantError();
                        }
                        break;
                    case 4:
                        if (prog.box[1, 0] == ' ')
                        {
                            prog.box[1, 0] = askMove;
                            moveCount++;
                        }
                        else
                        {
                            prog.NotVacantError();
                        }
                        break;
                    case 5:
                        if (prog.box[1, 1] == ' ')
                        {
                            prog.box[1, 1] = askMove;
                            moveCount++;
                        }
                        else
                        {
                            prog.NotVacantError();
                        }
                        break;
                    case 6:
                        if (prog.box[1, 2] == ' ')
                        {
                            prog.box[1, 2] = askMove;
                            moveCount++;
                        }
                        else
                        {
                            prog.NotVacantError();
                        }
                        break;
                    case 7:
                        if (prog.box[2, 0] == ' ')
                        {
                            prog.box[2, 0] = askMove;
                            moveCount++;
                        }
                        else
                        {
                            prog.NotVacantError();
                        }
                        break;
                    case 8:
                        if (prog.box[2, 1] == ' ')
                        {
                            prog.box[2, 1] = askMove;
                            moveCount++;
                        }
                        else
                        {
                            prog.NotVacantError();
                        }
                        break;
                    case 9:
                        if (prog.box[2, 2] == ' ')
                        {
                            prog.box[2, 2] = askMove;
                            moveCount++;
                        }
                        else
                        {
                            prog.NotVacantError();
                        }
                        break;
                    default:
                        Console.WriteLine("Wrong selection entered!");
                        Console.WriteLine("Press any key to try again..");
                        Console.ReadKey();
                        prog._error = true;
                        break;
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
            Console.WriteLine();
            Console.WriteLine("The winner is {0}!", prog.winPerson);
            Console.ReadKey();
        }
    }
}
