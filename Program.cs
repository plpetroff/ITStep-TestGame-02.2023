// See https://aka.ms/new-console-template for more information

class Program
{
    private static List<Element> gun;

    private static Element[] directions = new Element[]
    {
        new Element(0,1), // right
        new Element(0,-1), // left
    };

    private const int right = 0;
    private const int left = 1;
    private const char symbol = '*';


    static void Main(string[] args)
    {
        SetUpConsole();
        SetUpGun(5);
        DrowGun();

        
    }

    static void DrowGun()
    {
        foreach (var item in gun)
        {
            Console.SetCursorPosition(item.Row, item.Col);
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