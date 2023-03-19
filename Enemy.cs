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

        public Enemy(string enemyBody, int row, int col) : base(enemyBody, row, col)
        {
            this.GameObjectBody = enemyBody;
            this.Row = row;
            this.Col = col;
        }

        public override void Drow()
        {
            Console.SetCursorPosition(Col, Row);
            Console.WriteLine(enemyBody);
        }
    }
}
