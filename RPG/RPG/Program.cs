using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class MainProgram
    {
        public static HeroClassAttributes warrior = new BaseWarriorClass();
        public static HeroClassAttributes mage = new BaseMageClass();
        public static BasePlayer basePlayerStat = new BasePlayer();
        public static playerStatsCurrent playerStat = new playerStats();

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to your adventure, hero. \nBefore we continue, what is your name?");
            playerStat.playerName = Console.ReadLine();
            Console.WriteLine("Hello, adventurer {0}", playerStat.playerName);
            Console.WriteLine("What type of adventurer would you like to be?\n(1): {0} || Hlth: {1} Dmg: {2} Dfnc: {3} ''{4}''\n(2): {5} || Hlth: {6} Dmg: {7} Dfnc: {8} ''{9}''", warrior.heroClassName, warrior.heroClassHealth, warrior.heroClassAttackDamage, warrior.heroClassDefense, warrior.heroClassDescription, mage.heroClassName, mage.heroClassHealth, mage.heroClassAttackDamage, mage.heroClassDefense, mage.heroClassDescription);
            
            string playerClassChoice = Console.ReadLine();

            bool characterClassChoice = false;
            while (characterClassChoice == false)
            {
                if (playerClassChoice == "Warrior")
                {
                    Console.WriteLine("You have chosen the Warrior class.");
                    playerStat.heroClassAttackDamage = warrior.heroClassAttackDamage;
                    playerStat.heroClassHealth = warrior.heroClassHealth;
                    playerStat.heroClassDefense = warrior.heroClassDefense;
                    characterClassChoice = true;
                }
                else if (playerClassChoice == "Mage")
                {
                    Console.WriteLine("You have chosen the Mage class.");
                    playerStat.playerClass = mage;
                    playerStat.heroClassAttackDamage = mage.heroClassAttackDamage;
                    playerStat.heroClassHealth = mage.heroClassHealth;
                    playerStat.heroClassDefense = mage.heroClassDefense;
                    characterClassChoice = true;
                }
                else
                {
                    Console.WriteLine("You must choose a class...");
                    continue;
                }

                Console.WriteLine("So...\nYou have chosen the {} class.", playerStat.playerClass);
                Console.ReadLine();
            }
        }
    }

    public class playerStatsCurrent
    {
        public string playerName;
        public HeroClassAttributes playerClass;
        public int playerLevel;
        public int playerExperience;
        public int playerAttackDamage;
        public int playerHealth;
        public int playerDefense;
    }

    public class BasePlayer
    {
        public HeroClassAttributes playerClass { get; set; }
        public string playerName { get; set; }
        public string playerClassName { get; set; }
        public int playerLevel { get; set; }
        public int heroClassHealth { get; set; }
        public int heroClassAttackDamage { get; set; }
        public int heroClassDefense { get; set; }

    }

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
            heroClassAttackDamage = 3;
            heroClassHealth = 11;
            heroClassDefense = 1;
        }
    }

    public class BaseMageClass : HeroClassAttributes
    {
        public BaseMageClass()
        {
            heroClassName = "Mage";
            heroClassDescription = "A wise hero.";
            heroClassAttackDamage = 3;
            heroClassHealth = 9;
            heroClassDefense = 2;
        }
    }
}
