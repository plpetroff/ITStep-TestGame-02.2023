namespace ITStep_TestGame_02._2023
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Game
    {
        private const int spawnInterval = 3000;
        private DateTime lastSpawn;

        private Random random;
        public Game(int mapRow, int mapCol)
        {
            Map = new Map(mapRow, mapCol);
            Ship = new Ship(this, Ship.playerBody, 21, 21);
            Bullets = new List<Bullet>();
            random = new Random();
            Enemies = new List<Enemy>();
        }
        public Ship Ship { get; set; }
        public IList<Enemy> Enemies { get; set; }
        public IList<Bullet> Bullets { get; set; }
        public Map Map { get; set; }


        public bool IsPlaying
        {
            get { return Ship != null; }
        }

        public void Draw()
        {
            Map.Draw();
            if (Ship != null)
            {
                Ship.Draw();
            }
        }

        public void Update()
        {
            if (Ship != null)
            {
                if ((DateTime.Now - lastSpawn).TotalMilliseconds > spawnInterval)
                {
                    SpawnEnemy();
                }
            }



            for (int b = 0; b < Bullets.Count; b++)
            {
                Bullets[b].Update();
                Bullets[b].Clear();

                if (Bullets[b].IsInMap)
                {
                    for (int e = 0; e < Enemies.Count; e++)
                    {   
                        if (Enemies[e].IsAtCoordinates(Bullets[b].Row, Bullets[b].Col) ||
                            Enemies[e].IsAtCoordinates(Bullets[b].LastRow, Bullets[b].LastCol))
                        {
                             Console.SetCursorPosition(Enemies[e].Col-1, Enemies[e].Row+2);
                            Console.Write("@");
                            Enemies.RemoveAt(e);
                            Bullets.RemoveAt(b);
                        }
                        else
                        {
                            Bullets[b].Redraw();
                        }
                        break;
                            
                    }
                    
                }
                else
                {
                    Bullets.RemoveAt(b);
                }               
            }

            if (Ship != null)
            {
                Ship.Update();
                Ship.Clear();
                Ship.Redraw();

            }

        }

        private void SpawnEnemy()
        {
            int x = random.Next(Map.Col - 2 * Map.BeginPoint) + Map.BeginPoint;
            var enemy = new Enemy(this, "\\!/", Map.BeginPoint, x);
            enemy.Draw();
            Enemies.Add(enemy);

            lastSpawn = DateTime.Now;
        }
    }
}
