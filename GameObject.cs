namespace ITStep_TestGame_02._2023
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class GameObject
    {
        public GameObject(Game game, string gameObjectBody, int row, int col)
        {
            this.Game = game;
            this.GameObjectBody = gameObjectBody;
            this.Row = row; 
            this.Col = col;
        }

        public Game Game { get; set; }
        public string GameObjectBody { get; set; }
        public int Row { get; set; }
        public int Col { get; set; }


        public void Move(Direction direction)
        {
            switch (direction)
            {
                case Direction.Left:
                    Col = Col - 1;
                    break;
                case Direction.Right:
                    Col = Col + 1;
                    break;
                case Direction.Up:
                    Row = Row - 1;
                    break;
                case Direction.Down:
                    Row = Row + 1;
                    break;
                default:
                    break;
            }
        }

        public virtual void Drow()
        {
            Console.SetCursorPosition(Col, Row);
            Console.Write(GameObjectBody);
        }
    }
}
