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
            this.LastRow = row;
            this.LastCol = col;

        }

        public Game Game { get; set; }
        public string GameObjectBody { get; set; }
        public int Length { get { return GameObjectBody.Length; } }
        public int Row { get; set; }
        public int Col { get; set; }
        public int LastRow { get; set; }
        public int LastCol { get; set; }



        public virtual void Move(Direction direction)
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

        public virtual void Draw()
        {
            Console.SetCursorPosition(Col, Row);
            Console.Write(GameObjectBody);
        }

        public virtual void Update()
        {

        }

        public virtual void Clear()
        {
            Console.SetCursorPosition(LastCol, LastRow);
            Console.Write(new String(' ', Length));
        }

        public virtual void Redraw()
        {
            if (Row != LastRow || Col != LastCol)
            {
                Draw();
                LastRow = Row;
                LastCol = Col;
            }
        }

        public bool IsInMap
        {
            get { return Row >= Game.Map.BeginPoint && Row <= Game.Map.Row - Game.Map.BeginPoint; }
        }

        public bool IsAtCoordinates(int row, int col)
        {
            return row == Row && col >= Col && col < Col + Length;
        } 
    }
}
