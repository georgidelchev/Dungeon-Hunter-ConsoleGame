using System;
using System.Threading;

namespace DungeonHunter
{
    public class GameStatistics
    {
        // WELCOME MESSAGE
        public static string[] hello = {
                 "H","e","l","l","o",
                 " ",
                 "t","r","a","v","e","l","l","e","r",
                 "!"};
        // GAME OVER MESSAGE
        public static string[] gameOver = {
            "G", "A", "M", "E", " ", "O", "V", "E", "R", "!" };

        // COUNTER OF BRICKS
        public static string[] bricksCounting =
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

        // LEVELED UP MESSAGE
        public string[] lvlUp = { "Y", "O", "U ",
        "L", "E", "V", "E", "L", "E", "D ",
        "U","P", ", ", "C", "O", "N", "G", "R","A","T","S",};

        // PLAYER STATISTICS
        public static double playerHealth = 100;
        public static double playerExp = 0;
        public static double playerLevel = 0;
        public static double playerCoins = 50;
        public static double playerAttack = 45;
        public static double playerDefence = 25;
        public static double damageDealt = 0;
        public static double damageTook = 0;

        // ARMOR STATISTICS
        public static string currentHelmet;
        public static string currentChestplate;
        public static string currentPants;
        public static string currentBoots;
        public static string currentSword;

        public static bool isLittleDarkSpiderBeaten = false;
        public static bool isDarkSpiderBeaten = false;
        public static bool isGiantBeaten = false;
        public static bool isDarkWarlockBeaten = false;
        public static bool isBigGoblinBeaten = false;

        // TYPES OF ARMOR EQUIPMENT 
        public static string[] obsidianArmors = { "Obsidian helmet", "Obsidian chestplate",
                                        "Obsidian pants", "Obsidian boots" };

        public static string[] ironArmors ={ "Iron helmet","Iron chestplate",
                                   "Iron pants","Iron boots" };

        public static string[] bronzeArmors = { "Bronze helmet", "Bronze chestplate",
                                      "Bronze pants", "Bronze boots", };

        public static string[] swords = { "Wood sword", "Iron sword", "Obsidian sword" };

        // REWARD CARDS
        public static bool isAlive = true;
        public static bool dmgReducer = false;
        public static bool reviveCard = false;

        // ROOMS AND WINS 
        // COUNTERS
        public static int roomsCount = 0;
        public static int winsCount = 0;
    }
}

