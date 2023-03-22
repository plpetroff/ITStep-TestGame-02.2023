namespace ITStep_TestGame_02._2023
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Bullet : GameObject
    {
        private Direction direction;
        public Bullet(Game game, string gameObjectBody, int row, int col) : base(game, "|", row, col)
        {

        }
    }
}
