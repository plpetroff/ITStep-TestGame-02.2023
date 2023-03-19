namespace ITStep_TestGame_02._2023
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Ship: GameObject
    {
        public const string playerBody = "/!\\";

        public Ship(string playerBody, int row, int col) : base(playerBody, row, col)   
        {
            this.GameObjectBody = playerBody;
            this.Row = row;
            this.Col = col;

        }

        public override void Drow()
        {
            Console.SetCursorPosition(Col, Row);
            Console.WriteLine(playerBody); 
        }
    }
}
