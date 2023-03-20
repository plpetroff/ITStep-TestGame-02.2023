namespace ITStep_TestGame_02._2023
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Map
    {
        public int Row { get; set; }
        public int Col { get; set; }

        public int BeginPoint { get { return 1; } }

        public void Draw()
        {
            Console.SetCursorPosition(0,0);
            Console.Write("*");
            for (int i = 0; i < Col; i++)
            {
                Console.Write("=");
            }
            Console.Write("*");

            for (int i = BeginPoint; i < BeginPoint + Row; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write("\"");
                Console.SetCursorPosition(BeginPoint + Col, i);
                Console.Write("\"");
            }

            Console.SetCursorPosition(0, BeginPoint + Row);
            Console.Write("*");
            for (int i = 0; i < Col; i++)
            {
                Console.Write("=");
                Console.Write("*");
            }

        }
    }
}
