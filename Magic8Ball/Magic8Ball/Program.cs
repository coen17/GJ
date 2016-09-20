using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Magic8Ball
{
    /// <summary>
    /// Entry point for Magic 8 Ball program
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Preserve default console text colour
            ConsoleColor oldColor = Console.ForegroundColor;

            // Creating a random object
            Random randomObject = new Random();

            // Change console text color
            Console.ForegroundColor = ConsoleColor.Magenta;
            programName();
            Console.ForegroundColor = oldColor;

            // Loop forever
            while (true)
            {
                // Runs the asking ffunction
                string question = getQuestionFromUser();

                // Sleep for a random amount of time
                int secToSleep = randomObject.Next(5) + 1;
                Thread.Sleep(secToSleep * 500);

                //Checks if the question is about the 8Ball
                if (question.Contains(question.ToLower()))
                {
                    question.Contains("you");
                    Console.WriteLine("That is an invalid question.");
                    continue;
                }

                // Checks if question is a legitimate question
                if (question.Length <= 1)
                {
                    Console.WriteLine("You need to type a question.");
                    continue;
                }

                // See if user typed quit as question
                if(question.ToLower() == "quit")
                {
                    break;
                }

                // Get a random #
                int randomNumber = randomObject.Next(4);

                // Use rand number to determine response
                switch (randomNumber)
                {
                    case 0:
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Yes!");
                            Console.ForegroundColor = oldColor;
                            break;
                        }
                    case 1:
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("No!");
                            Console.ForegroundColor = oldColor;
                            break;
                        }
                    case 2:
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Probably");
                            Console.ForegroundColor = oldColor;
                            break;
                        }
                    case 3:
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("We think so...");
                            Console.ForegroundColor = oldColor;
                            break;
                        }
                }
            }

            // Cleaning up
            // Console.ForegroundColor = oldColor;
            Console.ReadLine();
        }

        // Program name and creator to console
        static void programName()
        {
            Console.WriteLine("Magic 8 Ball (By: Evoked)");
        }

        // Function will request the text the user types
        static string getQuestionFromUser()
        {
            // Will ask a question the store the question in a string called question
            string questionAsk = "Ask a question: ";
            Console.Write("\n" + questionAsk);
            string question = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(question + "...");
            Console.ForegroundColor = ConsoleColor.Gray;
            return question;
        }

    }
}
