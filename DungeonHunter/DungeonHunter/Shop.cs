using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DungeonHunter
{
    public class Shop
    {

        public int shopping;
        public int shopChoice;
        public int order;
        public double neededCoins;

        public void ShopImplementation()
        {
            Console.WriteLine("Do you want to shop?");
            Console.WriteLine("[0] YES");
            Console.WriteLine("[1] NO");
            shopping = int.Parse(Console.ReadLine());
            while (shopping < 0 || shopping > 1)
            {
                Console.WriteLine("Please enter an valid operation!");
                shopping = int.Parse(Console.ReadLine());
            }
            switch (shopping)
            {
                case 0:
                    Console.WriteLine("     WELCOME TO THE SHOP ROOM!");
                    Console.WriteLine($"     We have a couple of items." +
                        $"{Environment.NewLine}            Lets see!");
                    Thread.Sleep(3000);

                    Console.WriteLine("[0] to see the swords!");
                    Console.WriteLine("[1] to see the armors!");
                    Console.WriteLine("[2] to EXIT!");
                    Console.Write(">> ");
                    shopChoice = int.Parse(Console.ReadLine());
                    while (shopChoice < 0 || shopChoice > 2)
                    {
                        Console.WriteLine("Please enter an valid operation!");
                        Console.WriteLine(">> ");
                        shopChoice = int.Parse(Console.ReadLine());
                    }
                    if (shopChoice == 0)
                    {
                        Console.WriteLine("What you want to buy?");
                        Console.WriteLine();
                        Console.WriteLine($"      ╔════════════════════╗");
                        Console.WriteLine($"      ║ Current gold: " +
                                                    $"{GameStatistics.playerCoins}   ║");
                        Console.WriteLine($"      ╚════════════════════╝");
                        Console.WriteLine($"╔════════════════════════════════╗");
                        Console.WriteLine($"║       #=# Swords MENU #=#      ║");
                        Console.WriteLine($"║════════════════════════════════║");
                        Console.WriteLine($"║[0] - {GameStatistics.swords[0]} - [50G]        ║");
                        Console.WriteLine($"║      [+10 dmg][+1 deff]        ║");
                        Console.WriteLine($"║════════════════════════════════║");
                        Console.WriteLine($"║[1] - {GameStatistics.swords[1]} - [100G]       ║");
                        Console.WriteLine($"║      [+15 dmg][+3 deff]        ║");
                        Console.WriteLine($"║════════════════════════════════║");
                        Console.WriteLine($"║[2] - {GameStatistics.swords[2]} - [200G]   ║");
                        Console.WriteLine($"║      [+20 dmg][+5 deff]        ║");
                        Console.WriteLine($"╚════════════════════════════════╝");
                        Console.WriteLine($"   [3] - EXIT | [4] - PREV. PAGE                                ");

                        Console.Write(">> ");
                        order = int.Parse(Console.ReadLine());
                        while (order < 0 || order > 4)
                        {
                            Console.WriteLine("Please enter an valid operation!");
                            Console.WriteLine(">> ");
                            order = int.Parse(Console.ReadLine());
                        }
                        if (order == 4)
                        {
                            Console.Clear();
                            goto case 0;
                        }
                        else if (order == 3)
                        {
                            break;
                        }
                        else if (order == 0)
                        {
                            if (GameStatistics.playerCoins >= 50)
                            {
                                GameStatistics.playerCoins -= 50;
                                Console.WriteLine($"You bought an Wooden Sword! " +
                                $"{Environment.NewLine}Attack increased with: +10 Attack Damage! " +
                                $"{Environment.NewLine}Deff increased with: +1");
                                GameStatistics.playerAttack += 10;
                                GameStatistics.playerDefence += 1;
                                GameStatistics.currentSword = "Wooden Sword";
                            }
                            else
                            {
                                neededCoins = Math.Abs(GameStatistics.playerCoins - 50);
                                Console.WriteLine($"Not enough money!" +
                                $"{Environment.NewLine}You need {neededCoins} coins more!");
                            }
                        }
                        else if (order == 1)
                        {
                            if (GameStatistics.playerCoins >= 100)
                            {
                                GameStatistics.playerCoins -= 100;
                                Console.WriteLine($"You bought an Iron Sword! " +
                                $"{Environment.NewLine}Attack increased with: +15 Attack Damage! " +
                                $"{Environment.NewLine}Deff increased with: +3");
                                GameStatistics.playerAttack += 15;
                                GameStatistics.playerDefence += 3;
                                GameStatistics.currentSword = "Iron Sword";
                            }
                            else
                            {
                                neededCoins = Math.Abs(GameStatistics.playerCoins - 100);
                                Console.WriteLine($"Not enough money!" +
                                $"{Environment.NewLine}You need {neededCoins} coins more!");
                            }
                        }
                        else if (order == 2)
                        {
                            if (GameStatistics.playerCoins >= 200)
                            {
                                GameStatistics.playerCoins -= 200;
                                Console.WriteLine($"You bought an Obsidian Sword! " +
                                $"{Environment.NewLine}Attack increased with: +20 Attack Damage! " +
                                $"{Environment.NewLine}Deff increased with: +5");
                                GameStatistics.playerAttack += 20;
                                GameStatistics.playerDefence += 5;
                                GameStatistics.currentSword = "Obsidian Sword";
                            }
                            else
                            {
                                neededCoins = Math.Abs(GameStatistics.playerCoins - 200);
                                Console.WriteLine($"Not enough money!" +
                                $"{Environment.NewLine}You need {neededCoins} coins more!");
                            }
                        }
                    }
                    else if (shopChoice == 1)
                    {
                        Console.WriteLine("What you want to buy?");
                        Console.WriteLine();
                        Console.WriteLine($"      ╔════════════════════╗");
                        Console.WriteLine($"      ║ Current gold: " +
                                                    $"{GameStatistics.playerCoins}   ║");
                        Console.WriteLine($"      ╚════════════════════╝");
                        Console.WriteLine($"╔════════════════════════════════╗");     
                        Console.WriteLine($"║       #=# ARMORS MENU #=#      ║");     
                        Console.WriteLine($"║════════════════════════════════║");     
                        Console.WriteLine($"║[0] - Bronze Armor - [150G]     ║");     
                        Console.WriteLine($"║      [+10 deff]                ║");     
                        Console.WriteLine($"║════════════════════════════════║");     
                        Console.WriteLine($"║[1] - Iron Armor - [250G]       ║");     
                        Console.WriteLine($"║      [+18 deff]                ║");     
                        Console.WriteLine($"║════════════════════════════════║");     
                        Console.WriteLine($"║[2] - Obsidian Armor - [550G]   ║");     
                        Console.WriteLine($"║      [+35 deff]                ║");     
                        Console.WriteLine($"╚════════════════════════════════╝");     
                        Console.WriteLine($"   [3] - EXIT | [4] - PREV. PAGE                                ");

                        Console.Write(">> ");
                        order = int.Parse(Console.ReadLine());
                        while (order < 0 || order > 4)
                        {
                            Console.WriteLine("Please enter an valid operation!");
                            Console.WriteLine(">> ");
                            order = int.Parse(Console.ReadLine());
                        }

                        if (order == 4)
                        {
                            Console.Clear();
                            goto case 0;
                        }
                        else if (order == 3)
                        {
                            break;
                        }
                        else if (order == 0)
                        {
                            if (GameStatistics.playerCoins >= 150)
                            {
                                GameStatistics.playerCoins -= 150;
                                Console.WriteLine($"You bought an Bronze Armor for 150 Gold " +
                                    $"{Environment.NewLine}You have: +10 deff");
                                GameStatistics.playerDefence += 10;

                                GameStatistics.currentHelmet = GameStatistics.bronzeArmors[0];
                                GameStatistics.currentChestplate = GameStatistics.bronzeArmors[1];
                                GameStatistics.currentPants = GameStatistics.bronzeArmors[2];
                                GameStatistics.currentBoots = GameStatistics.bronzeArmors[3];
                            }
                            else
                            {
                                neededCoins = Math.Abs(GameStatistics.playerCoins - 150);
                                Console.WriteLine($"Not enough money!" +
                                $"{Environment.NewLine}You need {neededCoins} coins more!");
                            }
                        }
                        else if (order == 1)
                        {
                            if (GameStatistics.playerCoins >= 250)
                            {
                                GameStatistics.playerCoins -= 250;
                                Console.WriteLine($"You bought an Iron Armor for 250 Gold " +
                                    $"{Environment.NewLine}You have: +18 deff");
                                GameStatistics.playerDefence += 18;

                                GameStatistics.currentHelmet = GameStatistics.ironArmors[0];
                                GameStatistics.currentChestplate = GameStatistics.ironArmors[1];
                                GameStatistics.currentPants = GameStatistics.ironArmors[2];
                                GameStatistics.currentBoots = GameStatistics.ironArmors[3];
                            }
                            else
                            {
                                neededCoins = Math.Abs(GameStatistics.playerCoins - 250);
                                Console.WriteLine($"Not enough money!" +
                                $"{Environment.NewLine}You need {neededCoins} coins more!");
                            }
                        }
                        else if (order == 2)
                        {
                            if (GameStatistics.playerCoins >= 550)
                            {
                                GameStatistics.playerCoins -= 550;
                                Console.WriteLine($"You bought an Obsidian Armor for 550 Gold " +
                                    $"{Environment.NewLine}You have: +35 deff");
                                GameStatistics.playerDefence += 35;

                                GameStatistics.currentHelmet = GameStatistics.obsidianArmors[0];
                                GameStatistics.currentChestplate = GameStatistics.obsidianArmors[1];
                                GameStatistics.currentPants = GameStatistics.obsidianArmors[2];
                                GameStatistics.currentBoots = GameStatistics.obsidianArmors[3];
                            }
                            else
                            {
                                neededCoins = Math.Abs(GameStatistics.playerCoins - 550);
                                Console.WriteLine($"Not enough money!" +
                                $"{Environment.NewLine}You need {neededCoins} coins more!");
                            }
                        }
                    }
                    break;
            }
        }
    }
}
