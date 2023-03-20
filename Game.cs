namespace ITStep_TestGame_02._2023
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Game
    {

        public Game()
        {

            Ship = new Ship(this, Ship.playerBody, 20, 20);
        }
        public Ship Ship { get; set; }
        public IList<Enemy> Enemies { get; set; }


        public bool IsPlaying
        {
            get { return Ship != null; }
        }
    }
}
