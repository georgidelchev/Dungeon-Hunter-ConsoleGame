using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace rpg
{
    public class Calculations
    {
        public void Calcs()
        {
            PlayerStats playerStats = new PlayerStats();
            int roomsCount = 0;
            while (playerStats.isAlive)
            {
                // Increasing of rooms count:
                roomsCount++;
                if (roomsCount % 3 == 0)
                {
                    Shop shop = new Shop();
                    shop.ShopImplementation();
                }
                Console.WriteLine();
                Console.WriteLine($"#=# Room: {roomsCount} #=#"); // message which room is it

                int typeOfTheRoom = new Random().Next(1, 10); // picking random room

                // switching rooms:
                switch (typeOfTheRoom)
                {
                    case 1:  //
                    case 2:  //
                    case 3:  // here you will meet a random monster
                    case 4:  //
                    case 5:  //
                        int typeOfTheMonster = new Random().Next(1, 5);
                        double monsterAttack = 0;
                        double monsterHealth = 0;
                        string monsterName = string.Empty;
                        bool isWinner = false;
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
                        while (!isWinner && playerStats.isAlive)
                        {
                            // current armors
                            Console.WriteLine($"Sword: [{playerStats.currentSword}] | " +
                                              $"{ Environment.NewLine}" +
                                              $"Helmet: [{playerStats.currentHelmet}] | " +
                                              $"Chestplate: [{playerStats.currentChestplate}] | " +
                                              $"Pants: [{playerStats.currentPants}] | " +
                                              $"Boots: [{playerStats.currentBoots}]");

                            Console.WriteLine();

                            // operation choose                                            // current stats
                            Console.WriteLine($" Player LVL: [{playerStats.playerLevel}]  -  EXP: [{playerStats.playerExp}/100]                                                            ");
                            Console.WriteLine($"╔════════════════════════════════╗           ║Current Health: [{playerStats.playerHealth}]      ");
                            Console.WriteLine($"║  #=# Choose an operation: #=#  ║           ║Current Deffence: [{playerStats.playerDefence}]   ");
                            Console.WriteLine($"║════════════════════════════════║           ║Current Damage: [{playerStats.playerAttack}]      ");
                            Console.WriteLine($"║  [0]-Fight with the monster.   ║           ║Current Coins: [{playerStats.playerCoins}]        ");
                            Console.WriteLine($"║  [1]-Run Away from the monster.║           ║Monster Name : [{monsterName}]        ");
                            Console.WriteLine($"║  [2]-Hide somewhere.           ║           ║Monster HP: [{monsterHealth}]         ");
                            Console.WriteLine($"╚════════════════════════════════╝           ║Monster Attack: [{monsterAttack}]     ");

                            // choosing the operation
                            Console.Write(">> ");
                            int operationType = int.Parse(Console.ReadLine());

                            //re-typing the operation if its invalid
                            while (operationType < 0 || operationType > 2)
                            {
                                Console.Clear();
                                Console.WriteLine("                     Please enter an valid operation!");
                                Console.WriteLine();
                                // operation choose                                            // current stats
                                Console.WriteLine($" Player LVL: [{playerStats.playerLevel}]  -  EXP: [{playerStats.playerExp}/100]                                                            ");
                                Console.WriteLine($"╔════════════════════════════════╗           ║Current Health: [{playerStats.playerHealth}]      ");
                                Console.WriteLine($"║  #=# Choose an operation: #=#  ║           ║Current Deffence: [{playerStats.playerDefence}]   ");
                                Console.WriteLine($"║════════════════════════════════║           ║Current Damage: [{playerStats.playerAttack}]      ");
                                Console.WriteLine($"║  [0]-Fight with the monster.   ║           ║Current Coins: [{playerStats.playerCoins}]        ");
                                Console.WriteLine($"║  [1]-Run Away from the monster.║           ║Monster Name : [{monsterName}]        ");
                                Console.WriteLine($"║  [2]-Hide somewhere.           ║           ║Monster HP: [{monsterHealth}]         ");
                                Console.WriteLine($"╚════════════════════════════════╝           ║Monster Attack: [{monsterAttack}]     ");

                                operationType = int.Parse(Console.ReadLine());
                            }
                            // fighting
                            if (operationType == 0)
                            {
                                while (playerStats.isAlive && !isWinner)
                                {
                                    int criticalStrike = new Random().Next(1, 4);
                                    if (criticalStrike == 1 || criticalStrike == 2) // he have critical strike
                                    {
                                        if (playerStats.playerAttack >= monsterHealth)
                                        {
                                            playerStats.damageDealt += monsterHealth;
                                        }
                                        else if (monsterHealth > playerStats.playerAttack)
                                        {
                                            playerStats.damageDealt += playerStats.playerAttack;
                                        }

                                        if (monsterAttack >= playerStats.playerHealth)
                                        {
                                            playerStats.damageTook += playerStats.playerHealth;
                                        }
                                        else if (playerStats.playerHealth > monsterAttack)
                                        {
                                            playerStats.damageTook += monsterAttack;
                                        }

                                        monsterHealth -= playerStats.playerAttack * 3; // CRITICAL STRIKE (triple damage)
                                        if (playerStats.playerDefence >= monsterAttack)
                                        {
                                            playerStats.playerDefence -= monsterAttack;
                                        }
                                        else if (monsterAttack > playerStats.playerDefence)
                                        {
                                            playerStats.playerHealth -= monsterAttack - playerStats.playerDefence;
                                            playerStats.playerDefence -= monsterAttack;
                                        }

                                        if (playerStats.playerDefence < 0)
                                        {
                                            playerStats.playerDefence = 0;
                                        }
                                    }
                                    else if (criticalStrike == 3 || criticalStrike == 4) // he dont have critical strike
                                    {
                                        if (playerStats.playerAttack >= monsterHealth)
                                        {
                                            playerStats.damageDealt += monsterHealth;
                                        }
                                        else if (monsterHealth > playerStats.playerAttack)
                                        {
                                            playerStats.damageDealt += playerStats.playerAttack;
                                        }

                                        if (monsterAttack >= playerStats.playerHealth)
                                        {
                                            playerStats.damageTook += playerStats.playerHealth;
                                        }
                                        else if (playerStats.playerHealth > monsterAttack)
                                        {
                                            playerStats.damageTook += monsterAttack;
                                        }
                                        monsterHealth -= playerStats.playerAttack;

                                        if (playerStats.playerDefence >= monsterAttack)
                                        {
                                            playerStats.playerDefence -= monsterAttack;
                                        }
                                        else if (monsterAttack > playerStats.playerDefence)
                                        {
                                            playerStats.playerHealth -= monsterAttack - playerStats.playerDefence;
                                            playerStats.playerDefence -= monsterAttack;
                                        }

                                        if (playerStats.playerDefence < 0)
                                        {
                                            playerStats.playerDefence = 0;
                                        }
                                    }

                                    if (monsterHealth <= 0)
                                    {
                                        Console.WriteLine($"You killed [{monsterName}]!");

                                        if (playerStats.playerExp >= 100) // lvl up
                                        {
                                            string[] lvlUp = { "Y", "O", "U ",
                                                "L", "E", "V", "E", "L", "E", "D ",
                                                "U","P", ", ", "C", "O", "N", "G", "R","A","T","S",};

                                            Console.WriteLine();
                                            for (int i = 0; i < lvlUp.Length; i++)
                                            {

                                                Console.Write($"{lvlUp[i]}");
                                                Thread.Sleep(300);
                                            }
                                            Console.WriteLine();

                                            playerStats.playerLevel++;           //

                                            playerStats.playerAttack += 5;       // some stats added to the 
                                            playerStats.playerHealth += 10;      // player when he level up !
                                            playerStats.playerExp -= 100;        //
                                            playerStats.playerDefence += 10;
                                            playerStats.playerCoins += 10;

                                            //Console.WriteLine($"New Level : {currLvl} -> {playerStats.playerLevel}");
                                            //currLvl = playerStats.playerLevel;
                                        }

                                        isWinner = true;
                                        if (monsterName == "Little Dark Spider")
                                        {
                                            playerStats.isLittleDarkSpiderBeaten = true;
                                        }
                                        else if (monsterName == "Dark Spider")
                                        {
                                            playerStats.isDarkSpiderBeaten = true;
                                        }
                                        else if (monsterName == "Giant")
                                        {
                                            playerStats.isGiantBeaten = true;
                                        }
                                        else if (monsterName == "Dark Warlock")
                                        {
                                            playerStats.isDarkWarlockBeaten = true;
                                        }
                                        else if (monsterName == "Big Goblin [BOSS]")
                                        {
                                            playerStats.isBigGoblinBeaten = true;
                                        }

                                        if (isWinner)
                                        {
                                            playerStats.playerExp += 25;
                                            playerStats.playerCoins += 15;
                                            playerStats.playerDefence += 5;
                                            playerStats.playerAttack += 5;
                                            Console.WriteLine($"You are rewarded with: " +
                                                $"{Environment.NewLine}25 EXP , 15 COINS , 5 DEFF and 5 ATTACK");
                                            playerStats.winsCount++;
                                        }
                                    }

                                    if (playerStats.dmgReducer == true) // card of reducing damage
                                    {
                                        playerStats.playerHealth = playerStats.playerHealth + (playerStats.playerHealth * 0.20);
                                        playerStats.dmgReducer = false;
                                    }

                                    if (playerStats.playerHealth <= 0)
                                    {
                                        if (playerStats.reviveCard == true)
                                        {
                                            playerStats.isAlive = true;
                                            Console.WriteLine("You died.. " +
                                                "BUT you have an revive card!");

                                            playerStats.reviveCard = false;
                                            playerStats.playerHealth = 100;
                                        }
                                        else if (playerStats.reviveCard == false)
                                        {
                                            Console.WriteLine($"Sorry but you are out of HP." +
                                                $"{Environment.NewLine} " +
                                                $"You lost that.. :(");
                                            playerStats.isAlive = false;

                                        }
                                        break;
                                    }
                                }
                            }
                            else if (operationType == 1) // running away
                            {
                                int dmgOrNot = new Random().Next(1, 4);
                                if (dmgOrNot == 1 || dmgOrNot == 2)
                                {
                                    Console.WriteLine("You ran away successfully " +
                                        "without taking a damage!");
                                    break;
                                }
                                else if (dmgOrNot == 3 || dmgOrNot == 4)
                                {
                                    playerStats.playerHealth -= monsterAttack / 2;
                                    double took = monsterAttack / 2;
                                    Console.WriteLine($"Awghhh.... you were too slow..");
                                    Console.WriteLine($"You took [{took}] damage.");
                                }
                                break;
                            }
                            else if (operationType == 2) // hiding
                            {
                                int hiding = new Random().Next(1, 4);
                                if (hiding == 1 || hiding == 2)
                                {
                                    Console.WriteLine("you hided yourself successfully in the bushes" +
                                        "without taking a damage!");
                                }
                                else if (hiding == 3 || hiding == 4)
                                {
                                    playerStats.playerHealth -= monsterAttack / 2;
                                    double took = monsterAttack / 2;
                                    Console.WriteLine($"Arghhh.... you were too slow..");
                                    Console.WriteLine($"You took [{took}] damage.");
                                }
                                break;
                            }
                        }
                        break;
                    case 6: // ROOM THAT HAVE A CHEST WITH COINS
                        int chestWithCoins = new Random().Next(50, 150);
                        playerStats.playerCoins += chestWithCoins;
                        Console.WriteLine($"You have found a chest with {chestWithCoins} coins," +
                            $"now you have {playerStats.playerCoins}!");
                        Thread.Sleep(2000);
                        break;
                    case 7: // ROOM WITH HEALTH POTION
                        int typePotion = new Random().Next(1, 3);
                        if (typePotion == 1)
                        {
                            Console.WriteLine("You have found a small health potion" +
                                "that brings to you [10] healt.");
                            playerStats.playerHealth += 10;
                        }
                        else if (typePotion == 2)
                        {
                            Console.WriteLine("You have found a medium health potion" +
                                "that brings to you [15] healt.");
                            playerStats.playerHealth += 15;
                        }
                        else if (typePotion == 3)
                        {
                            Console.WriteLine("You have found a large health potion" +
                                "that brings to you [25] healt regenerated.");
                            playerStats.playerHealth += 25;
                        }
                        Thread.Sleep(2000);
                        break;
                    case 8: // TRAP ROOMS
                        int trapType = new Random().Next(1, 5);
                        Console.WriteLine("You got an trap...");
                        if (trapType == 1)
                        {
                            Console.WriteLine("Some arrows in your body...");
                            playerStats.playerHealth -= 3;
                        }
                        else if (trapType == 2)
                        {
                            int slimesCount = new Random().Next(1, 10);
                            Console.WriteLine("Arghh... a couple of" +
                                "slimes has jumped from the roof to your head.");
                            playerStats.playerHealth -= slimesCount * 2;
                        }
                        else if (trapType == 3)
                        {
                            Console.WriteLine("FASTTT... TSUNAMI IS COMING...");
                            int howMuchDmg = new Random().Next(1, 6);
                            if (howMuchDmg == 1)
                            {
                                Console.WriteLine("30 seconds under water...");
                                playerStats.playerHealth -= 2;
                            }
                            else if (howMuchDmg == 2)
                            {
                                Console.WriteLine("45 seconds under water...");
                                playerStats.playerHealth -= 3;
                            }
                            else if (howMuchDmg == 3)
                            {
                                Console.WriteLine("60 seconds under water...");
                                playerStats.playerHealth -= 5;
                            }
                            else if (howMuchDmg == 4)
                            {
                                Console.WriteLine("70 seconds under water...");
                                playerStats.playerHealth -= 7;
                            }
                            else if (howMuchDmg == 5)
                            {
                                Console.WriteLine("90 seconds under water...");
                                playerStats.playerHealth -= 9;
                            }
                        }
                        else if (trapType == 4)
                        {
                            string[] bricksCounting =
                                {
                                "first",
                                "second",
                                "third",
                                "fourth",
                                "fifth",
                                "sixth",
                                "seventh",
                                "eighth",
                                "ninth",
                                "tenth"
                                };

                            Console.WriteLine($"Damn.. you have lava and bricks.." +
                                $"{Environment.NewLine}" +
                                $"can you pass through this lava?");

                            int bricks = 10;
                            int counter = 0;
                            while (counter < bricks)
                            {
                                int passOrNot = new Random().Next(1, 4);
                                if (passOrNot == 1 || passOrNot == 2)
                                {
                                    Console.WriteLine($"You've passed the " +
                                        $"{bricksCounting[counter]} brick. " +
                                        $"C'mon i believe in you boy!");
                                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                                    Thread.Sleep(2000);
                                    Console.Write(new string(' ', Console.BufferWidth));
                                    Console.SetCursorPosition(0, Console.CursorTop);

                                }
                                else if (passOrNot == 3 || passOrNot == 4)
                                {
                                    Console.WriteLine("Fire..fire..fireee [-5 HP]");
                                    playerStats.playerHealth -= 5;
                                }
                                counter++;
                            }
                        }
                        else if (trapType == 5)
                        {
                            Console.WriteLine("Someone is throwing a Potions with poison to you...");
                            playerStats.playerHealth -= 5;
                        }

                        if (playerStats.playerHealth <= 0)
                        {
                            Console.WriteLine("You died...");
                            playerStats.isAlive = false;
                        }
                        Thread.Sleep(2000);
                        break;
                    case 9: // AN CHEST WITH ITEM
                        Console.WriteLine("You found an chest with item!");

                        int chestType = new Random().Next(1, 7);
                        if (chestType == 1)
                        {
                            Console.WriteLine(":O You've found an Obsidian Sword!!!");
                            playerStats.playerAttack += 10;
                            Console.WriteLine("Gained [10] Attack Damage!");
                        }
                        else if (chestType == 2)
                        {
                            Console.WriteLine("You've found an Health Booster!");
                            playerStats.playerHealth += 5;
                        }
                        else if (chestType == 3)
                        {
                            Console.WriteLine("You've found an Level Card!");
                            playerStats.playerLevel += 1;
                            playerStats.playerAttack += 10;
                        }
                        else if (chestType == 4)
                        {
                            Console.WriteLine($"You've found some coins!! " +
                                $"{Environment.NewLine}lets count them!");
                            int coinsCount = new Random().Next(1, 11);
                            switch (coinsCount)
                            {
                                case 1:
                                    playerStats.playerCoins += 2;
                                    Console.WriteLine(
                                        "You got an " +
                                        "2 coins!");
                                    break;
                                case 2:
                                    playerStats.playerCoins += 4;
                                    Console.WriteLine(
                                        "You got an " +
                                        "4 coins!");
                                    break;
                                case 3:
                                    playerStats.playerCoins += 6;
                                    Console.WriteLine(
                                        "You got an " +
                                        "6 coins!");
                                    break;
                                case 4:
                                    playerStats.playerCoins += 8;
                                    Console.WriteLine(
                                        "You got an " +
                                        "8 coins!");
                                    break;
                                case 5:
                                    playerStats.playerCoins += 10;
                                    Console.WriteLine(
                                        "You got an " +
                                        "10 coins!");
                                    break;
                                case 6:
                                    playerStats.playerCoins += 12;
                                    Console.WriteLine(
                                        "You got an " +
                                        "12 coins!");
                                    break;
                                case 7:
                                    playerStats.playerCoins += 14;
                                    Console.WriteLine(
                                        "You got an " +
                                        "14 coins!");
                                    break;
                                case 8:
                                    playerStats.playerCoins += 16;
                                    Console.WriteLine(
                                        "You got an " +
                                        "16 coins!");
                                    break;
                                case 9:
                                    playerStats.playerCoins += 18;
                                    Console.WriteLine(
                                        "You got an " +
                                        "18 coins!");
                                    break;
                                case 10:
                                    playerStats.playerCoins += 20;
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
                            playerStats.dmgReducer = true;
                        }
                        else if (chestType == 6)
                        {
                            Console.WriteLine($"You've found a REVIVE CARD!!!" +
                                $"{Environment.NewLine}" +
                                $"It will revive you automatically when you die!!!");
                            playerStats.reviveCard = true;
                        }
                        Thread.Sleep(2000);
                        break;
                }
            }
        }
    }
}
