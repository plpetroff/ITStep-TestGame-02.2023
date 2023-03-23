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
        public Bullet(Game game, int row, int col, Direction direction) : base(game, "|", row, col)
        {
            this.direction = direction;
            Draw();
        }

        public override void Update()
        {
            Move(Direction.Up);
            if (IsInMap)
            {
                base.Update();
            }

        }
        public override void Draw()
        {
            base.Draw();
        }
    }
}
