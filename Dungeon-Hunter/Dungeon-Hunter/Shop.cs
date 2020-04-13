using System;
using System.Collections.Generic;
using System.Text;

namespace rpg
{
    public class Shop
    {
        
        public int shopping;
        public int shopChoice;
        public int order;

        public void ShopImplementation()
        {
            PlayerStats PlayerStats = new PlayerStats();
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
                    // Console.WriteLine("     WELCOME TO THE SHOP ROOM!");
                    // Console.WriteLine($"     We have a couple of items." +
                    //     $"{Environment.NewLine}            Lets see!");
                    // Thread.Sleep(3000);

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
                                                    $"{PlayerStats.playerCoins}   ║");
                        Console.WriteLine($"      ╚════════════════════╝");
                        Console.WriteLine($"╔════════════════════════════════╗");
                        Console.WriteLine($"║       #=# Swords MENU #=#      ║");
                        Console.WriteLine($"║════════════════════════════════║");
                        Console.WriteLine($"║[0] - {PlayerStats.swords[0]} - [50G]        ║");
                        Console.WriteLine($"║      [+10 dmg][+1 deff]        ║");
                        Console.WriteLine($"║════════════════════════════════║");
                        Console.WriteLine($"║[1] - {PlayerStats.swords[1]} - [100G]       ║");
                        Console.WriteLine($"║      [+15 dmg][+3 deff]        ║");
                        Console.WriteLine($"║════════════════════════════════║");
                        Console.WriteLine($"║[2] - {PlayerStats.swords[2]} - [200G]   ║");
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
                            if (PlayerStats.playerCoins >= 50)
                            {
                                PlayerStats.playerCoins -= 50;
                                Console.WriteLine($"You bought an Wooden Sword! " +
                                $"{Environment.NewLine}Attack increased with: +10 Attack Damage! " +
                                $"{Environment.NewLine}Deff increased with: +1");
                                PlayerStats.playerAttack += 10;
                                PlayerStats.playerDefence += 1;
                                PlayerStats.currentSword = "Wooden Sword";
                            }
                            else
                            {
                                double neededCoins = Math.Abs(PlayerStats.playerCoins - 50);
                                Console.WriteLine($"Not enough money!" +
                                $"{Environment.NewLine}You need {neededCoins} coins more!");
                            }
                        }
                        else if (order == 1)
                        {
                            if (PlayerStats.playerCoins >= 100)
                            {
                                PlayerStats.playerCoins -= 100;
                                Console.WriteLine($"You bought an Iron Sword! " +
                                $"{Environment.NewLine}Attack increased with: +15 Attack Damage! " +
                                $"{Environment.NewLine}Deff increased with: +3");
                                PlayerStats.playerAttack += 15;
                                PlayerStats.playerDefence += 3;
                                PlayerStats.currentSword = "Iron Sword";
                            }
                            else
                            {
                                double neededCoins = Math.Abs(PlayerStats.playerCoins - 100);
                                Console.WriteLine($"Not enough money!" +
                                $"{Environment.NewLine}You need {neededCoins} coins more!");
                            }
                        }
                        else if (order == 2)
                        {
                            if (PlayerStats.playerCoins >= 200)
                            {
                                PlayerStats.playerCoins -= 200;
                                Console.WriteLine($"You bought an Obsidian Sword! " +
                                $"{Environment.NewLine}Attack increased with: +20 Attack Damage! " +
                                $"{Environment.NewLine}Deff increased with: +5");
                                PlayerStats.playerAttack += 20;
                                PlayerStats.playerDefence += 5;
                                PlayerStats.currentSword = "Obsidian Sword";
                            }
                            else
                            {
                                double neededCoins = Math.Abs(PlayerStats.playerCoins - 200);
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
                                                    $"{PlayerStats.playerCoins}   ║");
                        Console.WriteLine($"      ╚════════════════════╝");
                        Console.WriteLine($"╔════════════════════════════════╗");     ///// TO BUILD THIS  !!!!!!!
                        Console.WriteLine($"║       #=# ARMORS MENU #=#      ║");     ///// TO BUILD THIS  !!!!!!!
                        Console.WriteLine($"║════════════════════════════════║");     ///// TO BUILD THIS  !!!!!!!
                        Console.WriteLine($"║[0] - Bronze Armor - [150G]     ║");     ///// TO BUILD THIS  !!!!!!!
                        Console.WriteLine($"║      [+10 deff]                ║");     ///// TO BUILD THIS  !!!!!!!
                        Console.WriteLine($"║════════════════════════════════║");     ///// TO BUILD THIS  !!!!!!!
                        Console.WriteLine($"║[1] - Iron Armor - [250G]       ║");     ///// TO BUILD THIS  !!!!!!!
                        Console.WriteLine($"║      [+18 deff]                ║");     ///// TO BUILD THIS  !!!!!!!
                        Console.WriteLine($"║════════════════════════════════║");     ///// TO BUILD THIS  !!!!!!!
                        Console.WriteLine($"║[2] - Obsidian Armor - [550G]   ║");     ///// TO BUILD THIS  !!!!!!!
                        Console.WriteLine($"║      [+35 deff]                ║");     ///// TO BUILD THIS  !!!!!!!
                        Console.WriteLine($"╚════════════════════════════════╝");     ///// TO BUILD THIS  !!!!!!!
                        Console.WriteLine($"   [3] - EXIT | [4] - PREV. PAGE                                ");

                        Console.Write(">> ");
                        int order = int.Parse(Console.ReadLine());
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
                            if (PlayerStats.playerCoins >= 150)
                            {
                                PlayerStats.playerCoins -= 150;
                                Console.WriteLine($"You bought an Bronze Armor for 150 Gold " +
                                    $"{Environment.NewLine}You have: +10 deff");
                                PlayerStats.playerDefence += 10;

                                PlayerStats.currentHelmet = PlayerStats.bronzeArmors[0];
                                PlayerStats.currentChestplate = PlayerStats.bronzeArmors[1];
                                PlayerStats.currentPants = PlayerStats.bronzeArmors[2];
                                PlayerStats.currentBoots = PlayerStats.bronzeArmors[3];
                            }
                            else
                            {
                                double neededCoins = Math.Abs(PlayerStats.playerCoins - 150);
                                Console.WriteLine($"Not enough money!" +
                                $"{Environment.NewLine}You need {neededCoins} coins more!");
                            }
                        }
                        else if (order == 1)
                        {
                            if (PlayerStats.playerCoins >= 250)
                            {
                                PlayerStats.playerCoins -= 250;
                                Console.WriteLine($"You bought an Iron Armor for 250 Gold " +
                                    $"{Environment.NewLine}You have: +18 deff");
                                PlayerStats.playerDefence += 18;

                                PlayerStats.currentHelmet = PlayerStats.ironArmors[0];
                                PlayerStats.currentChestplate = PlayerStats.ironArmors[1];
                                PlayerStats.currentPants = PlayerStats.ironArmors[2];
                                PlayerStats.currentBoots = PlayerStats.ironArmors[3];
                            }
                            else
                            {
                                double neededCoins = Math.Abs(PlayerStats.playerCoins - 250);
                                Console.WriteLine($"Not enough money!" +
                                $"{Environment.NewLine}You need {neededCoins} coins more!");
                            }
                        }
                        else if (order == 2)
                        {
                            if (PlayerStats.playerCoins >= 550)
                            {
                                PlayerStats.playerCoins -= 550;
                                Console.WriteLine($"You bought an Obsidian Armor for 550 Gold " +
                                    $"{Environment.NewLine}You have: +35 deff");
                                PlayerStats.playerDefence += 35;

                                PlayerStats.currentHelmet = PlayerStats.obsidianArmors[0];
                                PlayerStats.currentChestplate = PlayerStats.obsidianArmors[1];
                                PlayerStats.currentPants = PlayerStats.obsidianArmors[2];
                                PlayerStats.currentBoots = PlayerStats.obsidianArmors[3];
                            }
                            else
                            {
                                double neededCoins = Math.Abs(PlayerStats.playerCoins - 550);
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
