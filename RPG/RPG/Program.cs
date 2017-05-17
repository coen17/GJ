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

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to your adventure, hero. \nBefore we continue, what is your name?");
            playerStat.playerName = Console.ReadLine();
            Console.WriteLine("Hello, adventurer {0}", playerStat.playerName);
            Console.WriteLine("What type of adventurer would you like to be?\n");
            Console.WriteLine("(1): {0} || Health: {1} Damage: {2} Defence: {3} ''{4}''", warrior.heroClassName, warrior.heroClassHealth, warrior.heroClassAttackDamage, warrior.heroClassDefense, warrior.heroClassDescription);
            Console.WriteLine("(2): {0} || Health: {1} Damage: {2} Defence: {3} ''{4}''", mage.heroClassName, mage.heroClassHealth, mage.heroClassAttackDamage, mage.heroClassDefense, mage.heroClassDescription);
            Console.WriteLine("(3): {0} || Health: {1} Damage: {2} Defence: {3} ''{4}''", rogue.heroClassName, rogue.heroClassHealth, rogue.heroClassAttackDamage, rogue.heroClassDefense, rogue.heroClassDescription);

            string playerClassChoice = Console.ReadLine();

            bool characterClassChoice = false;
            while (characterClassChoice == false)
            {
                if (playerClassChoice == "Warrior")
                {
                    Console.WriteLine("You have chosen the Warrior class.");
                    playerStat.playerClassName = "Warrior"; 
                    playerStat.playerHealth = warrior.heroClassHealth;
                    playerStat.playerAttackDamage = warrior.heroClassAttackDamage;
                    playerStat.playerDefense = warrior.heroClassDefense;
                    characterClassChoice = true;
                }
                else if (playerClassChoice == "Mage")
                {
                    Console.WriteLine("You have chosen the Mage class.");
                    playerStat.playerClassName = "Mage";
                    playerStat.playerHealth = mage.heroClassHealth;
                    playerStat.playerAttackDamage = mage.heroClassAttackDamage;
                    playerStat.playerDefense = mage.heroClassDefense;
                    characterClassChoice = true;
                }
                else if (playerClassChoice == "Rogue")
                {
                    Console.WriteLine("You have chosen the Rogue class.");
                    playerStat.playerClassName = "Rogue";
                    playerStat.playerHealth = rogue.heroClassHealth;
                    playerStat.playerAttackDamage = rogue.heroClassAttackDamage;
                    playerStat.playerDefense = rogue.heroClassDefense;
                    characterClassChoice = true;
                }
                else
                {
                    Console.WriteLine("You must choose a class...");
                    continue;
                }
                Console.WriteLine(playerStat.playerClassName);
                Console.WriteLine("So... You wish to be a {0}?", playerStat.playerClassName);
                Console.ReadLine();
            }
        }

        public class BasePlayer
        {
            public HeroClassAttributes playerClass { get; set; }
            public string playerName;
            public string playerClassName { get; set; }
            public int playerLevel { get; set; }
            public int heroClassHealth { get; set; }
            public int heroClassAttackDamage { get; set; }
            public int heroClassDefense { get; set; }

        }

        public class playerStatsCurrent
        {
            public HeroClassAttributes playerClass;
            public string playerName;
            public string playerClassName;
            public int playerLevel;
            public int playerExperience;
            public int playerAttackDamage;
            public int playerHealth;
            public int playerDefense;
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

    }
}
