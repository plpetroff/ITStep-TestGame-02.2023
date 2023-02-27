// See https://aka.ms/new-console-template for more information

class Program
{
    private static List<Element> gun;

    private const int rightDirection = 0;
    private const int leftDirection = 1;
    private const string symbol = "*";


    private static Element[] directions = new Element[]
    {
        new Element(0,1), // right
        new Element(0,-1), // left
    };



    static void Main(string[] args)
    {
        SetUpConsole();
        SetUpGun(5);
        DrowGun();

        int direction = rightDirection;

        while (true)
        {
            MoveGun(direction);

            Thread.Sleep(70);
        }


    }


    static void MoveGun(int direction)
    {
        Element removedElement = gun.First();
        ClearPoint(removedElement);
        gun.Remove(removedElement);

        Element currentHead = gun.Last();
        Element currenDirection = directions[direction];
        Element addedElement = new Element(currentHead.Row + currenDirection.Row, currentHead.Col + currenDirection.Col);

        gun.Add(addedElement);
        DrowPoint(addedElement, symbol);

    }

    private static void ClearPoint(Element el)
    {
        Console.SetCursorPosition(el.Col, el.Row);
        Console.Write(" ");
    }


    private static void DrowPoint(Element el, string symbol)
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
        gun = new List<Element>();
        for (int i = 0; i < size; i++)
        {
            gun.Add(new Element(0, i));
        }
    }


    static void SetUpConsole()
    {
        Console.CursorVisible = false;

    }



    class Element
    {
        public Element(int row, int col)
        {
            Row = row;
            Col = col;
        }

        public int Row { get; set; }
        public int Col { get; set; }
    }
}