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

        public override void Move(Direction direction)
        {
            switch (direction)
            {
                case Direction.Left:
                    Col = Math.Max(Col - 1, Game.Map.BeginPoint);
                    break;
                case Direction.Right:
                    Col = Math.Min(Col+1, Game.Map.BeginPoint + Game.Map.Col - Length );
                    break;
                case Direction.Up:
                    Row = Math.Max(Row - 1, Game.Map.BeginPoint);
                    break;
                case Direction.Down:
                    Row = Math.Min(Row +1, Game.Map.BeginPoint + Game.Map.Row - 1 );
                    break;
                default:
                    break;
            }
        }

        public override void Clear()
        {
            if (Row != LastRow || Col != LastRow)
            {
                Console.SetCursorPosition(LastRow, LastRow);
                Console.Write(new String(' ', Length));
            }
        }


        public void Fire(Direction direction)
        {

        }
    }
}
