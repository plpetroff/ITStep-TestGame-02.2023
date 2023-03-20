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

        public Enemy(Game game, string enemyBody, int row, int col) : base(game, enemyBody, row, col)
        {

            
        }

        public override void Draw()
        {
            Console.SetCursorPosition(Col, Row);
            Console.WriteLine(enemyBody);
        }
    }
}
