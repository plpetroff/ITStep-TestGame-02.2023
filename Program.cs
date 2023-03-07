// See https://aka.ms/new-console-template for more information

class Program
{
    private static List<Coordinates> gun;
    private static List<Coordinates> enemy;
    private static Random rnd = new Random();

    private const int rightDirection = 0;
    private const int leftDirection = 1;
    private const string symbol = "*";
    private const string bullet = "|";
    private const int sizeOfGun = 7;
    private const int rowPositionOfGun = 20;
    private const int sizeOfEnemy = 5;
    private const string symbolOfEnemy = "#";
    private const int level = 3;


    private static Coordinates[] directions = new Coordinates[]
    {
        new Coordinates(0,1), // rightDirection
        new Coordinates(0,-1), // leftDirection
    };



    static void Main(string[] args)
    {
        SetUpConsole();
        SetUpGun(sizeOfGun);
        DrowGun();
        GenerateEnemy(level);


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
                if (key == ConsoleKey.Spacebar)
                {
                    Shoot();
                }
            }


            MoveGun(direction);

            Thread.Sleep(90);
        }


    }


    static void MoveGun(int direction)
    {
        if (direction == rightDirection)
        {
            Coordinates removedElement = gun.First();

            Coordinates currentHead = gun.Last();
            Coordinates currenDirection = directions[direction];
            Coordinates addedElement = new Coordinates(currentHead.Row + currenDirection.Row, currentHead.Col + currenDirection.Col);

            if (addedElement.Col < Console.BufferWidth)
            {


                ClearPoint(removedElement);
                gun.Remove(removedElement);
                gun.Add(addedElement);
                DrowPoint(addedElement, symbol);
            }


        }
        else if (direction == leftDirection)
        {
            Coordinates addedElement;

            Coordinates removedElement = gun.Last();


            Coordinates currentHead = gun.First();
            Coordinates currenDirection = directions[direction];
            addedElement = new Coordinates(currentHead.Row + currenDirection.Row, currentHead.Col + currenDirection.Col);



            if (addedElement.Col >= 0)
            {
                gun.Insert(0, addedElement);
                DrowPoint(addedElement, symbol);
                ClearPoint(removedElement);
                gun.Remove(removedElement);

            }



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
        for (int i = Console.BufferWidth / 2; i < Console.BufferWidth / 2 + size; i++)
        {
            gun.Add(new Coordinates(rowPositionOfGun, i));
        }
    }


    static void SetUpConsole()
    {
        Console.Clear();
        Console.CursorVisible = false;
        Console.BufferHeight = Console.WindowHeight;
        Console.BufferWidth = Console.WindowWidth;

    }

    static void GenerateEnemy(int level)
    {

        for (int i = 0; i < level; i++)
        {

            enemy = new List<Coordinates>();
            var enemyRow = rnd.Next(0, Console.BufferHeight / 4);
            var enemyCol = rnd.Next(5, Console.BufferWidth - 5);


            for (int j = 0; j < sizeOfEnemy; j++)
            {
                enemy.Add(new Coordinates(enemyRow, enemyCol + j));
                Console.SetCursorPosition(enemy[j].Col, enemy[j].Row);
                Console.WriteLine(symbolOfEnemy);
            }




            

        }

    }

    static void Shoot()
    {
        Coordinates midElementOfGun = gun.FirstOrDefault();

        for (int i = midElementOfGun.Row - 1; i > 0; i--)
        {

            Console.SetCursorPosition(midElementOfGun.Col, i);
            Console.WriteLine(bullet);
            Console.SetCursorPosition(midElementOfGun.Col, i + 1);
            Console.Write(" ");
            Thread.Sleep(30);

        }
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