// See https://aka.ms/new-console-template for more information

class Program
{
    private static List<Coordinates> gun;

    private const int rightDirection = 0;
    private const int leftDirection = 1;
    private const string symbol = "*";


    private static Coordinates[] directions = new Coordinates[]
    {
        new Coordinates(0,1), // rightDirection
        new Coordinates(0,-1), // leftDirection
    };



    static void Main(string[] args)
    {
        SetUpConsole();
        SetUpGun(5);
        DrowGun();

        int direction = leftDirection;

        while (true)
        {
            if (Console.KeyAvailable)
            {
                ConsoleKey key = Console.ReadKey().Key;

                if (key == ConsoleKey.RightArrow && direction != rightDirection)
                {
                    direction = rightDirection;
                }
                if (key == ConsoleKey.LeftArrow && direction != leftDirection)
                {
                    direction = leftDirection;
                }
            }



            MoveGun(direction);

            Thread.Sleep(105);
        }


    }


    static void MoveGun(int direction)
    {
        if (direction == rightDirection)
        {
            Coordinates removedElement = gun.First();
            ClearPoint(removedElement);
            gun.Remove(removedElement);

            Coordinates currentHead = gun.Last();
            Coordinates currenDirection = directions[direction];
            Coordinates addedElement = new Coordinates(currentHead.Row + currenDirection.Row,                                               currentHead.Col + currenDirection.Col);

            if (addedElement.Col >= Console.BufferWidth)
            {
                addedElement.Col = Console.BufferWidth - 1;
            }

            gun.Add(addedElement);
            DrowPoint(addedElement, symbol);
        }
        else if (direction == leftDirection)
        {
            Coordinates addedElement;
            
                Coordinates removedElement = gun.Last();
                ClearPoint(removedElement);
                gun.Remove(removedElement);

                Coordinates currentHead = gun.First();
                Coordinates currenDirection = directions[direction];
                addedElement = new Coordinates(currentHead.Row + currenDirection.Row,                                           currentHead.Col + currenDirection.Col);



            if (addedElement.Col < 0)
            {
                addedElement.Col = 0;

            }
            gun.Insert(0, addedElement);
            DrowPoint(addedElement, symbol);

        }


    }

    private static void ClearPoint(Coordinates el)
    {
        Console.SetCursorPosition(el.Col, el.Row);
        Console.Write(" ");
    }


    private static void DrowPoint(Coordinates el, string symbol)
    {
        Console.SetCursorPosition(el.Col, el.Row);
        Console.WriteLine(symbol);
    }


    static void DrowGun()
    {
        foreach (var item in gun)
        {
            Console.SetCursorPosition(item.Col, item.Row);

            Console.Write(symbol);
        }
    }


    static void SetUpGun(int size)
    {
        gun = new List<Coordinates>();
        for (int i = 30; i < 30 + size; i++)
        {
            gun.Add(new Coordinates(20, i));
        }
    }


    static void SetUpConsole()
    {
        Console.Clear();
        Console.CursorVisible = false;
        Console.BufferHeight = Console.WindowHeight;
        Console.BufferWidth = Console.WindowWidth;

    }



    class Coordinates
    {
        public Coordinates(int row, int col)
        {
            Row = row;
            Col = col;
        }

        public int Row { get; set; }
        public int Col { get; set; }
    }
}