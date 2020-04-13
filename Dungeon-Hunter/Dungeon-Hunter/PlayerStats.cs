using System;
using System.Threading;

namespace rpg
{
    public class PlayerStats
    {
          //WELCOME MESSAGE
        public string[] hello = {
                 "H","e","l","l","o",
                 " ",
                 "t","r","a","v","e","l","l","e","r",
                 "!"};
        // PLAYER STATISTICS
        public double playerHealth = 10;
        public double playerExp = 10;
        public double playerLevel = 10;
        public double playerCoins = 10;
        public double playerAttack = 25;
        public double playerDefence = 0;
        public double damageDealt = 0;
        public double damageTook = 0;

            // ARMOR STATISTICS
        public string currentHelmet = "NaN";
        public string currentChestplate = "NaN";
        public string currentPants = "NaN";
        public string currentBoots = "NaN";
        public string currentSword = "NaN";

        public bool isLittleDarkSpiderBeaten = false;
        public bool isDarkSpiderBeaten = false;
        public bool isGiantBeaten = false;
        public bool isDarkWarlockBeaten = false;
        public bool isBigGoblinBeaten = false;

                            // TYPES OF ARMOR EQUIPMENT 
        public string[] obsidianArmors = { "Obsidian helmet", "Obsidian chestplate",
                                        "Obsidian pants", "Obsidian boots" };

        public string[] ironArmors ={ "Iron helmet","Iron chestplate",
                                   "Iron pants","Iron boots" };

        public string[] bronzeArmors = { "Bronze helmet", "Bronze chestplate",
                                      "Bronze pants", "Bronze boots", };

        public string[] swords = { "Wood sword", "Iron sword", "Obsidian sword" };

             // REWARD CARDS
        public bool isAlive = true;
        public bool dmgReducer = false;
        public bool reviveCard = false;

          // ROOMS AND WINS 
              // COUNTERS
        public int roomsCount = 0;
        public int winsCount = 0;
    }
}

