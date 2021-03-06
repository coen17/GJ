using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG2
{
    class MainProgram
    {
        public static HeroClassAttributes warrior = new BaseWarriorClass();
        public static HeroClassAttributes mage = new BaseMageClass();
        public static HeroClassAttributes rogue = new BaseRogueClass();
        public static BasePlayer basePlayerStat = new BasePlayer();
        public static playerStatsCurrent playerStat = new playerStatsCurrent();
        public static EnemyGoblin enemyGolbin = new EnemyGoblin();

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to your adventure, hero. \nBefore we continue, what is your name?");
            playerStat.playerName = Console.ReadLine();
            Console.WriteLine("Hello, {0}.", playerStat.playerName);
            Console.Clear();
            Console.WriteLine("What type of adventurer would you like to be?\n");
            Console.WriteLine("(1): {0} || Health: {1} Damage: {2} Defence: {3} ''{4}''", warrior.heroClassName, warrior.heroClassHealth, warrior.heroClassAttackDamage, warrior.heroClassDefense, warrior.heroClassDescription);
            Console.WriteLine("(2): {0} || Health: {1} Damage: {2} Defence: {3} ''{4}''", mage.heroClassName, mage.heroClassHealth, mage.heroClassAttackDamage, mage.heroClassDefense, mage.heroClassDescription);
            Console.WriteLine("(3): {0} || Health: {1} Damage: {2} Defence: {3} ''{4}''", rogue.heroClassName, rogue.heroClassHealth, rogue.heroClassAttackDamage, rogue.heroClassDefense, rogue.heroClassDescription);

            PlayerChoiceStart:
            string playerClassChoice = Console.ReadLine();

            switch (playerClassChoice)
            {
                case "1":
                case "w":
                case "warrior":
                case "Warrior":
                    Console.WriteLine("You have chosen the Warrior class.");
                    playerStat.playerClassName = "Warrior";
                    playerStat.playerHealth = warrior.heroClassHealth;
                    playerStat.playerAttackDamage = warrior.heroClassAttackDamage;
                    playerStat.playerDefense = warrior.heroClassDefense;
                    break;
                case "2":
                case "m":
                case "mage":
                case "Mage":
                    Console.WriteLine("You have chosen the Mage class.");
                    playerStat.playerClassName = "Mage";
                    playerStat.playerHealth = mage.heroClassHealth;
                    playerStat.playerAttackDamage = mage.heroClassAttackDamage;
                    playerStat.playerDefense = mage.heroClassDefense;
                    break;
                case "3":
                case "r":
                case "rogue":
                case "Rogue":
                    Console.WriteLine("You have chosen the Rogue class.");
                    playerStat.playerClassName = "Rogue";
                    playerStat.playerHealth = rogue.heroClassHealth;
                    playerStat.playerAttackDamage = rogue.heroClassAttackDamage;
                    playerStat.playerDefense = rogue.heroClassDefense;
                    break;
                default:
                    Console.WriteLine("Please choose a class from the list.\n (1) Warrior | (2) Mage | (3) Rogue");
                    goto PlayerChoiceStart;
            }
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("So... You wish to be a {0}?\nVery well, {1}. You must travel to the town of ", playerStat.playerClassName, playerStat.playerName);
            Console.WriteLine("**You feel as if your body becomes a blur within the universe, your eyesight becomes blind, and you find yourself on the border of an unfamiliar town.**\n\n**From what you can tell you are wearing unwashed rags, and you feel as if you have some gold in your pocket.**");
            Console.WriteLine("Would you like to count the amount of gold you have?\n(1) Yes | (2) No");

            Random rnd = new Random();
            basePlayerStat.playerBaseGold = rnd.Next(0, 20);
            string wouldLikeToKnowGold = Console.ReadLine();
                        
            // Getting used to switch statements
            switch (wouldLikeToKnowGold)
            {
                case "1":
                case "y":
                case "yes":
                case "Yes":
                    Console.WriteLine("You count that you have {0} gold.",basePlayerStat.playerBaseGold);
                    break;
                case "2":
                case "n":
                case "no":
                case "No":
                    Console.WriteLine("You continue without counting your gold.");
                        break;
                default:
                    Console.WriteLine("You decide to count your gold anyway, you count {0} gold.", basePlayerStat.playerBaseGold);
                    break;
            }
            Console.ReadLine();
        }

        public class BasePlayer
        {
            public HeroClassAttributes playerClass { get; set; }
            public string playerName = "playerName";
            public string playerClassName;
            public int playerLevel;
            public int playerExperience;
            public int playerBaseGold;
            public int heroClassHealth;
            public int heroClassAttackDamage;
            public int heroClassDefense;

        }

        public class playerStatsCurrent
        {
            public HeroClassAttributes playerClass;
            public string playerName;
            public string playerClassName;
            public int playerLevel;
            public int playerExperience;
            public int playerGold;
            public int playerAttackDamage;
            public int playerHealth;
            public int playerDefense;
        }

        public class FightStart
        {
            private static EnemyGoblin enemyGoblin = new EnemyGoblin();
            Random enemyAttack = new Random();

        }

        // ------------------------------------------------
        // ----------------- Hero Classes -----------------
        // ------------------------------------------------

        public class HeroClassAttributes
        {
            public string heroClassName { get; set; }
            public string heroClassDescription { get; set; }
            public int heroClassAttackDamage { get; set; }
            public int heroClassHealth { get; set; }
            public int heroClassDefense { get; set; }

        }

        public class BaseWarriorClass : HeroClassAttributes
        {
            public BaseWarriorClass()
            {
                heroClassName = "Warrior";
                heroClassDescription = "A strong hero.";
                heroClassAttackDamage = 2;
                heroClassHealth = 11;
                heroClassDefense = 3;
            }
        }

        public class BaseMageClass : HeroClassAttributes
        {
            public BaseMageClass()
            {
                heroClassName = "Mage";
                heroClassDescription = "A mystical hero.";
                heroClassAttackDamage = 3;
                heroClassHealth = 10;
                heroClassDefense = 2;
            }
        }

        public class BaseRogueClass : HeroClassAttributes
        {
            public BaseRogueClass()
            {
                heroClassName = "Rogue";
                heroClassDescription = "An agile hero.";
                heroClassAttackDamage = 3;
                heroClassHealth = 9;
                heroClassDefense = 3;
            }
        }

        // ------------------------------------------------
        // ----------------- Enemies ----------------------
        // ------------------------------------------------

        public class EnemyGoblin
        {
            public string goblinName = "Goblin";
            public int goblinHealth = 5;
            public int golbinGold;
        }

    }
}
