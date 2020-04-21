using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DungeonHunter
{
    public class Game
    {
        public static int typeOfTheMonster;
        public static double monsterAttack;
        public static double monsterHealth;
        public static string monsterName;
        public static bool isWinner;
        public static int typeOfTheRoom;
        public static int operationType;
        public static int criticalStrike;
        public static int coinsCount;
        public static int chestType;
        public static int bricks;
        public static int counter;
        public static int passOrNot;
        public static int howMuchDmg;
        public static int trapType;
        public static int slimesCount;
        public static int chestWithCoins;
        public static int typePotion;
        public static int hiding;
        public static int dmgOrNot;
        public static double took;
       
        public void GameLogic()
        {
            while (GameStatistics.isAlive)
            {
                // Increasing of rooms count:
                GameStatistics.roomsCount++;
                if (GameStatistics.roomsCount % 3 == 0)
                {
                    Shop shop = new Shop();
                    shop.ShopImplementation();
                    Console.WriteLine();
                }

                Console.WriteLine($"#=# Room: {GameStatistics.roomsCount} #=#"); // message which room is it

                typeOfTheRoom = new Random().Next(1, 10); // picking random room

                // switching rooms:
                switch (typeOfTheRoom)
                {
                    case 1:  //
                    case 2:  //
                    case 3:  // here you will meet a random monster
                    case 4:  //
                    case 5:  //
                        typeOfTheMonster = new Random().Next(1, 5);
                        monsterAttack = 0;
                        monsterHealth = 0;
                        monsterName = string.Empty;
                        isWinner = false;
                        switch (typeOfTheMonster)
                        {
                            case 1:
                                monsterName = "Little Dark Spider";
                                monsterAttack = 6;
                                monsterHealth = 30;
                                break;
                            case 2:
                                monsterName = "Dark Spider";
                                monsterAttack = 10;
                                monsterHealth = 60;
                                break;
                            case 3:
                                monsterName = "Giant";
                                monsterAttack = 13;
                                monsterHealth = 80;
                                break;
                            case 4:
                                monsterName = "Dark Warlock";
                                monsterAttack = 15;
                                monsterHealth = 95;
                                break;
                            case 5:
                                monsterName = "Big Goblin [BOSS]";
                                monsterAttack = 20;
                                monsterHealth = 115;
                                break;
                        }

                        // message what monster you met
                        Console.WriteLine($"You've met a " +
                            $"[{monsterName}] " +
                            $"with [{monsterAttack}] attack damage " +
                            $"and [{monsterHealth}] health.");

                        Console.SetCursorPosition(0, Console.CursorTop - 1);
                        Thread.Sleep(4500);
                        Console.Write(new string(' ', Console.BufferWidth));
                        Console.SetCursorPosition(0, Console.CursorTop);
                        Console.WriteLine();

                        // while player is alive 
                        // and he is not a winner 
                        while (!isWinner && GameStatistics.isAlive)
                        {
                            // current armors
                            Console.WriteLine($"Sword: [{GameStatistics.currentSword}] | " +
                                              $"{ Environment.NewLine}" +
                                              $"Helmet: [{GameStatistics.currentHelmet}] | " +
                                              $"Chestplate: [{GameStatistics.currentChestplate}] | " +
                                              $"Pants: [{GameStatistics.currentPants}] | " +
                                              $"Boots: [{GameStatistics.currentBoots}]");

                            Console.WriteLine();

                            // operation choose                                            // current GameStatistics
                            Console.WriteLine($" Player LVL: [{GameStatistics.playerLevel}]  -  EXP: [{GameStatistics.playerExp}/100]                                                            ");
                            Console.WriteLine($"╔════════════════════════════════╗           ║Current Health: [{GameStatistics.playerHealth}]      ");
                            Console.WriteLine($"║  #=# Choose an operation: #=#  ║           ║Current Deffence: [{GameStatistics.playerDefence}]   ");
                            Console.WriteLine($"║════════════════════════════════║           ║Current Damage: [{GameStatistics.playerAttack}]      ");
                            Console.WriteLine($"║  [0]-Fight with the monster.   ║           ║Current Coins: [{GameStatistics.playerCoins}]        ");
                            Console.WriteLine($"║  [1]-Run Away from the monster.║           ║Monster Name : [{monsterName}]        ");
                            Console.WriteLine($"║  [2]-Hide somewhere.           ║           ║Monster HP: [{monsterHealth}]         ");
                            Console.WriteLine($"╚════════════════════════════════╝           ║Monster Attack: [{monsterAttack}]     ");

                            // choosing the operation
                            Console.Write(">> ");
                            operationType = int.Parse(Console.ReadLine());

                            //re-typing the operation if its invalid
                            while (operationType < 0 || operationType > 2)
                            {
                                Console.Clear();
                                Console.WriteLine("                     Please enter an valid operation!");
                                Console.WriteLine();
                                // operation choose                                            // current GameStatistics
                                Console.WriteLine($" Player LVL: [{GameStatistics.playerLevel}]  -  EXP: [{GameStatistics.playerExp}/100]                                                            ");
                                Console.WriteLine($"╔════════════════════════════════╗           ║Current Health: [{GameStatistics.playerHealth}]      ");
                                Console.WriteLine($"║  #=# Choose an operation: #=#  ║           ║Current Deffence: [{GameStatistics.playerDefence}]   ");
                                Console.WriteLine($"║════════════════════════════════║           ║Current Damage: [{GameStatistics.playerAttack}]      ");
                                Console.WriteLine($"║  [0]-Fight with the monster.   ║           ║Current Coins: [{GameStatistics.playerCoins}]        ");
                                Console.WriteLine($"║  [1]-Run Away from the monster.║           ║Monster Name : [{monsterName}]        ");
                                Console.WriteLine($"║  [2]-Hide somewhere.           ║           ║Monster HP: [{monsterHealth}]         ");
                                Console.WriteLine($"╚════════════════════════════════╝           ║Monster Attack: [{monsterAttack}]     ");

                                operationType = int.Parse(Console.ReadLine());
                            }
                            // fighting
                            if (operationType == 0)
                            {
                                while (GameStatistics.isAlive && !isWinner)
                                {
                                    criticalStrike = new Random().Next(1, 4);
                                    if (criticalStrike == 1 || criticalStrike == 2) // he have critical strike
                                    {
                                        if (GameStatistics.playerAttack >= monsterHealth)
                                        {
                                            GameStatistics.damageDealt += monsterHealth;
                                        }
                                        else if (monsterHealth > GameStatistics.playerAttack)
                                        {
                                            GameStatistics.damageDealt += GameStatistics.playerAttack;
                                        }

                                        if (monsterAttack >= GameStatistics.playerHealth)
                                        {
                                            GameStatistics.damageTook += GameStatistics.playerHealth;
                                        }
                                        else if (GameStatistics.playerHealth > monsterAttack)
                                        {
                                            GameStatistics.damageTook += monsterAttack;
                                        }

                                        monsterHealth -= GameStatistics.playerAttack * 3; // CRITICAL STRIKE (triple damage)
                                        if (GameStatistics.playerDefence >= monsterAttack)
                                        {
                                            GameStatistics.playerDefence -= monsterAttack;
                                        }
                                        else if (monsterAttack > GameStatistics.playerDefence)
                                        {
                                            GameStatistics.playerHealth -= monsterAttack - GameStatistics.playerDefence;
                                            GameStatistics.playerDefence -= monsterAttack;
                                        }

                                        if (GameStatistics.playerDefence < 0)
                                        {
                                            GameStatistics.playerDefence = 0;
                                        }
                                    }
                                    else if (criticalStrike == 3 || criticalStrike == 4) // he dont have critical strike
                                    {
                                        if (GameStatistics.playerAttack >= monsterHealth)
                                        {
                                            GameStatistics.damageDealt += monsterHealth;
                                        }
                                        else if (monsterHealth > GameStatistics.playerAttack)
                                        {
                                            GameStatistics.damageDealt += GameStatistics.playerAttack;
                                        }

                                        if (monsterAttack >= GameStatistics.playerHealth)
                                        {
                                            GameStatistics.damageTook += GameStatistics.playerHealth;
                                        }
                                        else if (GameStatistics.playerHealth > monsterAttack)
                                        {
                                            GameStatistics.damageTook += monsterAttack;
                                        }
                                        monsterHealth -= GameStatistics.playerAttack;

                                        if (GameStatistics.playerDefence >= monsterAttack)
                                        {
                                            GameStatistics.playerDefence -= monsterAttack;
                                        }
                                        else if (monsterAttack > GameStatistics.playerDefence)
                                        {
                                            GameStatistics.playerHealth -= monsterAttack - GameStatistics.playerDefence;
                                            GameStatistics.playerDefence -= monsterAttack;
                                        }

                                        if (GameStatistics.playerDefence < 0)
                                        {
                                            GameStatistics.playerDefence = 0;
                                        }
                                    }

                                    if (monsterHealth <= 0)
                                    {
                                        Console.WriteLine($"You killed [{monsterName}]!");

                                        if (GameStatistics.playerExp >= 100) // lvl up
                                        {
                                            string[] lvlUp = { "Y", "O", "U", " ", "L", "E", "V", "E", "L", "E", "D", " ", "U", "P", " ", "C", "O", "N", "G", "R", "A", "T", "S", "!"};

                                            Console.WriteLine();
                                            for (int i = 0; i < lvlUp.Length; i++)
                                            {

                                                Console.Write($"{lvlUp[i]}");
                                                Thread.Sleep(300);
                                            }
                                            Console.WriteLine();

                                            GameStatistics.playerLevel++;           //

                                            GameStatistics.playerAttack += 5;       // some GameStatistics added to the 
                                            GameStatistics.playerHealth += 10;      // player when he level up !
                                            GameStatistics.playerExp -= 100;        //
                                            GameStatistics.playerDefence += 10;
                                            GameStatistics.playerCoins += 10;

                                            //Console.WriteLine($"New Level : {currLvl} -> {GameStatistics.playerLevel}");
                                            //currLvl = GameStatistics.playerLevel;
                                        }

                                        isWinner = true;
                                        if (monsterName == "Little Dark Spider")
                                        {
                                            GameStatistics.isLittleDarkSpiderBeaten = true;
                                        }
                                        else if (monsterName == "Dark Spider")
                                        {
                                            GameStatistics.isDarkSpiderBeaten = true;
                                        }
                                        else if (monsterName == "Giant")
                                        {
                                            GameStatistics.isGiantBeaten = true;
                                        }
                                        else if (monsterName == "Dark Warlock")
                                        {
                                            GameStatistics.isDarkWarlockBeaten = true;
                                        }
                                        else if (monsterName == "Big Goblin [BOSS]")
                                        {
                                            GameStatistics.isBigGoblinBeaten = true;
                                        }

                                        if (isWinner)
                                        {
                                            GameStatistics.playerExp += 25;
                                            GameStatistics.playerCoins += 15;
                                            GameStatistics.playerDefence += 5;
                                            GameStatistics.playerAttack += 5;
                                            Console.WriteLine($"You are rewarded with: " +
                                                $"{Environment.NewLine}25 EXP , 15 COINS , 5 DEFF and 5 ATTACK");
                                            GameStatistics.winsCount++;
                                        }
                                    }

                                    if (GameStatistics.dmgReducer == true) // card of reducing damage
                                    {
                                        GameStatistics.playerHealth = GameStatistics.playerHealth + (GameStatistics.playerHealth * 0.20);
                                        GameStatistics.dmgReducer = false;
                                    }

                                    if (GameStatistics.playerHealth <= 0)
                                    {
                                        if (GameStatistics.reviveCard == true)
                                        {
                                            GameStatistics.isAlive = true;
                                            Console.WriteLine("You died.. " +
                                                "BUT you have an revive card!");

                                            GameStatistics.reviveCard = false;
                                            GameStatistics.playerHealth = 100;
                                        }
                                        else if (GameStatistics.reviveCard == false)
                                        {
                                            Console.WriteLine($"Sorry but you are out of HP." +
                                                $"{Environment.NewLine} " +
                                                $"You lost that.. :(");
                                            GameStatistics.isAlive = false;
                                            break;
                                        }
                                        
                                    }
                                }
                            }
                            else if (operationType == 1) // running away
                            {
                                dmgOrNot = new Random().Next(1, 4);
                                if (dmgOrNot == 1 || dmgOrNot == 2)
                                {
                                    Console.WriteLine("You ran away successfully " +
                                        "without taking a damage!");
                                    break;
                                }
                                else if (dmgOrNot == 3 || dmgOrNot == 4)
                                {
                                    GameStatistics.playerHealth -= monsterAttack / 2;
                                    took = monsterAttack / 2;

                                    if (GameStatistics.playerHealth <= 0)
                                    {
                                        GameStatistics.isAlive = false;
                                        break;
                                    }

                                    Console.WriteLine($"Awghhh.... you were too slow..");
                                    Console.WriteLine($"You took [{took}] damage.");
                                }
                                break;
                            }
                            else if (operationType == 2) // hiding
                            {
                                hiding = new Random().Next(1, 4);
                                if (hiding == 1 || hiding == 2)
                                {
                                    Console.WriteLine("you hided yourself successfully in the bushes" +
                                        "without taking a damage!");
                                }
                                else if (hiding == 3 || hiding == 4)
                                {
                                    GameStatistics.playerHealth -= monsterAttack / 2;

                                    took = monsterAttack / 2;
                                    if (GameStatistics.playerHealth <= 0)
                                    {
                                        GameStatistics.isAlive = false;
                                        break;
                                    }

                                    Console.WriteLine($"Arghhh.... you were too slow..");
                                    Console.WriteLine($"You took [{took}] damage.");
                                }
                                break;
                            }
                        }
                        break;
                    case 6: // ROOM THAT HAVE A CHEST WITH COINS
                        chestWithCoins = new Random().Next(50, 150);
                        GameStatistics.playerCoins += chestWithCoins;
                        Console.WriteLine($"You have found a chest with {chestWithCoins} coins," +
                            $"now you have {GameStatistics.playerCoins}!");
                        Thread.Sleep(2000);
                        break;
                    case 7: // ROOM WITH HEALTH POTION
                        typePotion = new Random().Next(1, 3);
                        if (typePotion == 1)
                        {
                            Console.WriteLine("You have found a small health potion" +
                                "that brings to you [10] healt.");
                            GameStatistics.playerHealth += 10;
                        }
                        else if (typePotion == 2)
                        {
                            Console.WriteLine("You have found a medium health potion" +
                                "that brings to you [15] healt.");
                            GameStatistics.playerHealth += 15;
                        }
                        else if (typePotion == 3)
                        {
                            Console.WriteLine("You have found a large health potion" +
                                "that brings to you [25] healt regenerated.");
                            GameStatistics.playerHealth += 25;
                        }
                        Thread.Sleep(2000);
                        break;
                    case 8: // TRAP ROOMS
                        trapType = new Random().Next(1, 5);
                        Console.WriteLine("You got an trap...");
                        if (trapType == 1)
                        {
                            Console.WriteLine("Some arrows in your body...");
                            GameStatistics.playerHealth -= 3;
                        }
                        else if (trapType == 2)
                        {
                            slimesCount = new Random().Next(1, 10);
                            Console.WriteLine("Arghh... a couple of" +
                                "slimes has jumped from the roof to your head.");
                            GameStatistics.playerHealth -= slimesCount * 2;
                        }
                        else if (trapType == 3)
                        {
                            Console.WriteLine("FASTTT... TSUNAMI IS COMING...");
                            howMuchDmg = new Random().Next(1, 6);
                            if (howMuchDmg == 1)
                            {
                                Console.WriteLine("30 seconds under water...");
                                GameStatistics.playerHealth -= 2;
                            }
                            else if (howMuchDmg == 2)
                            {
                                Console.WriteLine("45 seconds under water...");
                                GameStatistics.playerHealth -= 3;
                            }
                            else if (howMuchDmg == 3)
                            {
                                Console.WriteLine("60 seconds under water...");
                                GameStatistics.playerHealth -= 5;
                            }
                            else if (howMuchDmg == 4)
                            {
                                Console.WriteLine("70 seconds under water...");
                                GameStatistics.playerHealth -= 7;
                            }
                            else if (howMuchDmg == 5)
                            {
                                Console.WriteLine("90 seconds under water...");
                                GameStatistics.playerHealth -= 9;
                            }
                        }
                        else if (trapType == 4)
                        {
                            Console.WriteLine($"Damn.. you have lava and bricks.." +
                                $"{Environment.NewLine}" +
                                $"can you pass through this lava?");

                            bricks = 10;
                            counter = 0;
                            while (counter < bricks)
                            {
                                passOrNot = new Random().Next(1, 4);
                                if (passOrNot == 1 || passOrNot == 2)
                                {
                                    Console.WriteLine($"You've passed the " +
                                        $"{GameStatistics.bricksCounting[counter]} brick. " +
                                        $"C'mon i believe in you boy!");
                                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                                    Thread.Sleep(2000);
                                    Console.Write(new string(' ', Console.BufferWidth));
                                    Console.SetCursorPosition(0, Console.CursorTop);

                                }
                                else if (passOrNot == 3 || passOrNot == 4)
                                {
                                    Console.WriteLine("Fire..fire..fireee [-5 HP]");
                                    GameStatistics.playerHealth -= 5;
                                    if (GameStatistics.playerHealth <= 0)
                                    {
                                        GameStatistics.isAlive = false;
                                        break;
                                    }
                                }
                                counter++;
                            }
                        }
                        else if (trapType == 5)
                        {
                            Console.WriteLine("Someone is throwing a Potions with poison to you...");
                            GameStatistics.playerHealth -= 5;
                        }

                        if (GameStatistics.playerHealth <= 0)
                        {
                            Console.WriteLine("You died...");
                            GameStatistics.isAlive = false;
                        }
                        Thread.Sleep(2000);
                        break;
                    case 9: // AN CHEST WITH ITEM
                        Console.WriteLine("You found an chest with item!");

                        chestType = new Random().Next(1, 7);
                        if (chestType == 1)
                        {
                            Console.WriteLine(":O You've found an Obsidian Sword!!!");
                            GameStatistics.playerAttack += 10;
                            Console.WriteLine("Gained [10] Attack Damage!");
                        }
                        else if (chestType == 2)
                        {
                            Console.WriteLine("You've found an Health Booster!");
                            GameStatistics.playerHealth += 5;
                        }
                        else if (chestType == 3)
                        {
                            Console.WriteLine("You've found an Level Card!");
                            GameStatistics.playerLevel += 1;
                            GameStatistics.playerAttack += 10;
                        }
                        else if (chestType == 4)
                        {
                            Console.WriteLine($"You've found some coins!! " +
                                $"{Environment.NewLine}lets count them!");
                            coinsCount = new Random().Next(1, 11);
                            switch (coinsCount)
                            {
                                case 1:
                                    GameStatistics.playerCoins += 2;
                                    Console.WriteLine(
                                        "You got an " +
                                        "2 coins!");
                                    break;
                                case 2:
                                    GameStatistics.playerCoins += 4;
                                    Console.WriteLine(
                                        "You got an " +
                                        "4 coins!");
                                    break;
                                case 3:
                                    GameStatistics.playerCoins += 6;
                                    Console.WriteLine(
                                        "You got an " +
                                        "6 coins!");
                                    break;
                                case 4:
                                    GameStatistics.playerCoins += 8;
                                    Console.WriteLine(
                                        "You got an " +
                                        "8 coins!");
                                    break;
                                case 5:
                                    GameStatistics.playerCoins += 10;
                                    Console.WriteLine(
                                        "You got an " +
                                        "10 coins!");
                                    break;
                                case 6:
                                    GameStatistics.playerCoins += 12;
                                    Console.WriteLine(
                                        "You got an " +
                                        "12 coins!");
                                    break;
                                case 7:
                                    GameStatistics.playerCoins += 14;
                                    Console.WriteLine(
                                        "You got an " +
                                        "14 coins!");
                                    break;
                                case 8:
                                    GameStatistics.playerCoins += 16;
                                    Console.WriteLine(
                                        "You got an " +
                                        "16 coins!");
                                    break;
                                case 9:
                                    GameStatistics.playerCoins += 18;
                                    Console.WriteLine(
                                        "You got an " +
                                        "18 coins!");
                                    break;
                                case 10:
                                    GameStatistics.playerCoins += 20;
                                    Console.WriteLine(
                                        "You got an " +
                                        "20 coins!");
                                    break;
                            }
                        }
                        else if (chestType == 5)
                        {
                            Console.WriteLine($"You've found an 20% Damage Reduce Potion!" +
                                $"{Environment.NewLine}You can use it only in fight with monster!");
                            GameStatistics.dmgReducer = true;
                        }
                        else if (chestType == 6)
                        {
                            Console.WriteLine($"You've found a REVIVE CARD!!!" +
                                $"{Environment.NewLine}" +
                                $"It will revive you automatically when you die!!!");
                            GameStatistics.reviveCard = true;
                        }
                        Thread.Sleep(2000);
                        break;
                }
            }
        }
    }
}
