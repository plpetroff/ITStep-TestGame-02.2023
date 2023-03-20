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

        public Ship(Game game, string playerBody, int row, int col) : base(game, playerBody, row, col)   
        {
            

        }

        public override void Draw()
        {
            Console.SetCursorPosition(Col, Row);
            Console.WriteLine(playerBody); 
        }
    }
}
