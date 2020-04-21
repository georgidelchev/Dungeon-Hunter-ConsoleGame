using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DungeonHunter
{
    public class GameOver
    {        
        public void Over()
        {
            for (int i = 0; i < GameStatistics.gameOver.Length; i++)
            {
                Console.Write($"{GameStatistics.gameOver[i]}");
                Thread.Sleep(200);
            }

            Console.Clear();
           
            Console.WriteLine("         GAME OVER!");
            Console.WriteLine();
            Console.WriteLine($"Health Diff: {Math.Abs(GameStatistics.playerHealth)}");
            Console.WriteLine($"Total attack damage: {GameStatistics.playerAttack}");
            Console.WriteLine($"Coins Left: {GameStatistics.playerCoins}");
            Console.WriteLine($"Total Wins: {GameStatistics.winsCount}");
            Console.WriteLine($"Total Damage Dealt: {Math.Abs(GameStatistics.damageDealt):f2}");
            Console.WriteLine($"Total Damage Took: {Math.Abs(GameStatistics.damageTook):f2}");
            
            Console.WriteLine();
            
            Console.WriteLine($"Your last equipment: ");
            Console.WriteLine($"Sword: {GameStatistics.currentSword}");
            Console.WriteLine($"Helmet: {GameStatistics.currentHelmet}");
            Console.WriteLine($"Chestplate: {GameStatistics.currentChestplate}");
            Console.WriteLine($"Pants: {GameStatistics.currentPants}");
            Console.WriteLine($"Boots: {GameStatistics.currentBoots}");
        
        }
    }
}
