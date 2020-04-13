using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace rpg
{
    public class GameOver
    {
        public string[] gameOver = { "G", "A", "M", "E", " ", "O", "V", "E", "R", "!" };

        public void Over()
        {
            PlayerStats playerStats = new PlayerStats();
            for (int i = 0; i < gameOver.Length; i++)
            {
                Console.Write($"{gameOver[i]}");
                Thread.Sleep(200);
            }
            
            Console.Clear();
            Console.WriteLine("         GAME OVER!");
            Console.WriteLine();
            Console.WriteLine($"Health Diff: {Math.Abs(playerStats.playerHealth)}");
            Console.WriteLine($"Total attack damage: {playerStats.playerAttack}");
            Console.WriteLine($"Coins Left: {playerStats.playerCoins}");
            Console.WriteLine($"Total Wins: {playerStats.winsCount}");
            Console.WriteLine($"Total Damage Dealt: {Math.Abs(playerStats.damageDealt):f2}");
            Console.WriteLine($"Total Damage Took: {Math.Abs(playerStats.damageTook):f2}");
            Console.WriteLine();
            Console.WriteLine($"Your last equipment: ");
            Console.WriteLine($"Sword: {playerStats.currentSword}");
            Console.WriteLine($"Helmet: {playerStats.currentHelmet}");
            Console.WriteLine($"Chestplate: {playerStats.currentChestplate}");
            Console.WriteLine($"Pants: {playerStats.currentPants}");
            Console.WriteLine($"Boots: {playerStats.currentBoots}");
        }
    }
}
