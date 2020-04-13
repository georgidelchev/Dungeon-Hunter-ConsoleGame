using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace rpg
{
    public class Storyline
    {
        public void Story()
        {
            PlayerStats playerStats = new PlayerStats();
            for (int i = 0; i < playerStats.hello.Length; i++)
            {
                Console.Write($"{playerStats.hello[i]}");
                Thread.Sleep(200);
            }
            Thread.Sleep(300);
            Console.Clear();

            Console.WriteLine("         Hello traveller!");
            Console.WriteLine("        [Maze Runner v1.0]");
            Console.WriteLine($"{ Environment.NewLine}" +
                $"Im Steve , nice to meet you, son :) ! " +
                $"{Environment.NewLine}Welcome to the Maze Runner - " +
                $"[{System.Environment.MachineName}]");
           
            Thread.Sleep(7000);
            Console.Clear();
           
            Console.WriteLine($"Lets talk 'bout myself sir! " +
                $"{Environment.NewLine}...and your mission of course! ");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(">> STORY: ");                                                                                           //  TODO TO FINISH THE STORY!!!!
            Console.WriteLine();                                                                                                       //  TODO TO FINISH THE STORY!!!!
            Thread.Sleep(4000);                                                                                                        //  TODO TO FINISH THE STORY!!!!
            Console.WriteLine($"In a many many years ago , there had an young magician.");                                             //  TODO TO FINISH THE STORY!!!!
            Thread.Sleep(4000);                                                                                                        //  TODO TO FINISH THE STORY!!!!
            Console.WriteLine($"He was one of the greatest tallens of the Arthur's Castle.");                                          //  TODO TO FINISH THE STORY!!!!
            Thread.Sleep(4000);                                                                                                        //  TODO TO FINISH THE STORY!!!!
            Console.WriteLine("He's name was ... Chuakhua.");                                                                          //  TODO TO FINISH THE STORY!!!!
            Thread.Sleep(4000);                                                                                                        //  TODO TO FINISH THE STORY!!!!
            Console.WriteLine($"He wanted to become a greatest magician of all the times ,and he searched for ways to become.");       //  TODO TO FINISH THE STORY!!!!
            Thread.Sleep(4000);                                                                                                        //  TODO TO FINISH THE STORY!!!!
            Console.WriteLine($"When he was Sixteen years old ,");                                                                     //  TODO TO FINISH THE STORY!!!!
            Thread.Sleep(4000);                                                                                                        //  TODO TO FINISH THE STORY!!!!
            Console.WriteLine($"one evil magician from the mountains came to the castle.");                                            //  TODO TO FINISH THE STORY!!!!
            Thread.Sleep(4000);

            Console.WriteLine();
            Console.Write("Press any key to continue: ");
            Console.ReadKey();
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Cyan;
        }
    }
}
