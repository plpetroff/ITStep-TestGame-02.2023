// See https://aka.ms/new-console-template for more information

using ITStep_TestGame_02._2023;

class Program
{
    private static Game game;

    //private static List<Coordinates> gun;
    //private static Dictionary<int, List<Coordinates>> enemies;
    private static Random rnd = new Random();

    //private const int rightDirection = 0;
    //private const int leftDirection = 1;
    //private const string symbolOfGun = "*";
    //private const string bullet = "|";
    //private const int sizeOfGun = 5;
    //private const int rowPositionOfGun = 20;
    //private const int sizeOfEnemy = 5;
    //private const string symbolOfEnemy = "#";
    //private const int level = 3;


    //private static Coordinates[] directions = new Coordinates[]
    //{
    //    new Coordinates(0,1), // rightDirection
    //    new Coordinates(0,-1), // leftDirection
    //};



    static void Main(string[] args)
    {
        while (true)
        {
            InitGame();

            Console.WriteLine("Press Enter");
            game.Draw();

            while (game.IsPlaying)
            {
                ReadInput();

                game.Update();

                Thread.Sleep(50);
            }

            
        }

        //SetUpConsole();
        //SetUpGun(sizeOfGun);
        //DrowGun();
        //GenerateEnemy(level);


        //int direction = leftDirection;

        //while (true)
        //{
        //    if (Console.KeyAvailable)
        //    {
        //        ConsoleKey key = Console.ReadKey().Key;

        //        if (key == ConsoleKey.RightArrow && direction != rightDirection)
        //        {
        //            direction = rightDirection;
        //        }
        //        if (key == ConsoleKey.LeftArrow && direction != leftDirection)
        //        {
        //            direction = leftDirection;
        //        }
        //        if (key == ConsoleKey.Spacebar)
        //        {
        //            //Shoot();
        //        }
        //    }


        //    //MoveGun(direction);

        //    Thread.Sleep(100);
        //}


    }
    private static void InitGame()
    {
        int row = 22;
        int col = 60;

        game = new Game(row, col);
    }
    private static void ReadInput()
    {
        while (game.Ship != null && Console.KeyAvailable)
        {
            ConsoleKey key = Console.ReadKey().Key;

            switch (key)
            {
                case ConsoleKey.LeftArrow:
                    game.Ship.Move(Direction.Left);
                    break;
                case ConsoleKey.RightArrow:
                    game.Ship.Move(Direction.Right);
                    break;
                case ConsoleKey.UpArrow:
                    game.Ship.Move(Direction.Up);
                    break;
                case ConsoleKey.DownArrow:
                    game.Ship.Move(Direction.Down);
                    break;
                case ConsoleKey.Spacebar:
                    game.Ship.Fire(Direction.Up);
                    break;

                default:
                    break;
            }
        }

    }









    //static void MoveGun(int direction)
    //{
    //    if (direction == rightDirection)
    //    {
    //        Coordinates removedElement = gun.First();

    //        Coordinates currentHead = gun.Last();
    //        Coordinates currenDirection = directions[direction];
    //        Coordinates addedElement = new Coordinates(currentHead.Row + currenDirection.Row, currentHead.Col + currenDirection.Col);

    //        if (addedElement.Col < Console.BufferWidth)
    //        {
    //            ClearPoint(removedElement);
    //            gun.Remove(removedElement);
    //            gun.Add(addedElement);
    //            DrowPoint(addedElement, symbolOfGun);
    //        }


    //    }
    //    else if (direction == leftDirection)
    //    {
    //        Coordinates addedElement;

    //        Coordinates removedElement = gun.Last();

    //        Coordinates currentHead = gun.First();
    //        Coordinates currenDirection = directions[direction];
    //        addedElement = new Coordinates(currentHead.Row + currenDirection.Row,
    //                                       currentHead.Col + currenDirection.Col);


    //        if (addedElement.Col >= 0)
    //        {
    //            gun.Insert(0, addedElement);
    //            DrowPoint(addedElement, symbolOfGun);
    //            ClearPoint(removedElement);
    //            gun.Remove(removedElement);

    //        }


    //    }


    //}

    //private static void ClearPoint(Coordinates el)
    //{
    //    Console.SetCursorPosition(el.Col, el.Row);
    //    Console.Write(" ");
    //}


    //private static void DrowPoint(Coordinates el, string symbol)
    //{
    //    Console.SetCursorPosition(el.Col, el.Row);
    //    Console.Write(symbol);
    //}


    //static void DrowGun()
    //{
    //    foreach (var item in gun)
    //    {
    //        Console.SetCursorPosition(item.Col, item.Row);
    //        DrowPoint(item, symbolOfGun);

    //    }
    //}


    //static void SetUpGun(int size)
    //{
    //    game = new Game(50, 50);
    //    Ship ship = new Ship(game, "test", 10, 20);
    //    ship.Draw();

    //    gun = new List<Coordinates>();
    //    for (int i = Console.BufferWidth / 2; i < Console.BufferWidth / 2 + size; i++)
    //    {
    //        gun.Add(new Coordinates(rowPositionOfGun, i));
    //    }
    //}


    //static void SetUpConsole()
    //{
    //    Console.Clear();
    //    Console.CursorVisible = false;
    //    Console.BufferHeight = Console.WindowHeight;
    //    Console.BufferWidth = Console.WindowWidth;

    //}

    //static void GenerateEnemy(int level)
    //{
    //    enemies = new Dictionary<int, List<Coordinates>>();
    //    for (int i = 0; i < level; i++)
    //    {

    //        var currentEnemy = new List<Coordinates>();

    //        var enemyRow = rnd.Next(0, Console.BufferHeight / 4);
    //        var enemyCol = rnd.Next(5, Console.BufferWidth - 5);

    //        for (int j = 0; j < sizeOfEnemy; j++)
    //        {
    //            currentEnemy.Add(new Coordinates(enemyRow, enemyCol + j));
    //        }

    //        enemies.Add(i, currentEnemy);

    //        foreach (var item in currentEnemy)
    //        {
    //            Console.SetCursorPosition(item.Col, item.Row);
    //            DrowPoint(item, symbolOfEnemy);
    //        }

    //    }

    //}

    //static void Shoot()
    //{
    //    Coordinates midElementOfGun = gun[sizeOfGun / 2];

    //    for (int i = midElementOfGun.Row - 1; i >= 0; i--)
    //    {
    //        Console.SetCursorPosition(midElementOfGun.Col, i);
    //        Coordinates currentPositionOfBullet = new Coordinates(i, midElementOfGun.Col);
    //        DrowPoint(currentPositionOfBullet, bullet);

    //        foreach (var enemy in enemies)
    //        {
    //            foreach (var coord in enemy.Value)
    //            {
    //                if (currentPositionOfBullet.Row == coord.Row && currentPositionOfBullet.Col == coord.Col)
    //                {
    //                    Console.Write("@");
    //                }
    //            }

    //        }

    //        Console.SetCursorPosition(midElementOfGun.Col, i + 1);
    //        currentPositionOfBullet = new Coordinates(i + 1, midElementOfGun.Col);
    //        ClearPoint(currentPositionOfBullet);

    //        Thread.Sleep(30);
    //    }
    //}

    //class Coordinates
    //{
    //    public Coordinates(int row, int col)
    //    {
    //        Row = row;
    //        Col = col;
    //    }

    //    public int Row { get; set; }
    //    public int Col { get; set; }

    //    public override bool Equals(object? obj)
    //    {
    //        return base.Equals(obj);
    //    }
    //}
}