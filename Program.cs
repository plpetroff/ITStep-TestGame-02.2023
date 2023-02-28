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
            else
            {
                Thread.Sleep(500);
            }


            MoveGun(direction);

            Thread.Sleep(70);
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
            Coordinates addedElement = new Coordinates(currentHead.Row + currenDirection.Row, currentHead.Col + currenDirection.Col);

            gun.Add(addedElement);
            DrowPoint(addedElement, symbol);
        }
        else if (direction == leftDirection)
        {
            Coordinates removedElement = gun.Last();
            ClearPoint(removedElement);
            gun.Remove(removedElement);

            Coordinates currentHead = gun.First();
            Coordinates currenDirection = directions[direction];
            Coordinates addedElement = new Coordinates(currentHead.Row + currenDirection.Row, currentHead.Col + currenDirection.Col);

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
        for (int i = 50; i < 50 + size; i++)
        {
            gun.Add(new Coordinates(0, i));
        }
    }


    static void SetUpConsole()
    {
        Console.CursorVisible = false;

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