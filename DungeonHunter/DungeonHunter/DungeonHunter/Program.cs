using System;

namespace DungeonHunter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Game game = new Game();
            game.GameLogic();

            GameOver gameOver = new GameOver();
            gameOver.Over();

        }
    }
}
