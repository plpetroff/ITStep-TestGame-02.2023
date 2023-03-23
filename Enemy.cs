namespace ITStep_TestGame_02._2023
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Enemy : GameObject
    {
        public const string enemyBody = "\\!/";
        private const int moveInterval = 500;

        private DateTime lastMove;

        public Enemy(Game game, string enemyBody, int row, int col) : base(game, enemyBody, row, col)
        {

            lastMove = DateTime.Now;
        }

        public override void Draw()
        {
            Console.SetCursorPosition(Col, Row);
            Console.WriteLine(enemyBody);
        }

        public override void Update()
        {
            if ((DateTime.Now - lastMove).Milliseconds > moveInterval)
            {
                Move(Direction.Down);
                base.Update();
                lastMove = DateTime.Now;
            }
        }
    }
}
