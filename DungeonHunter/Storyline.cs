using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DungeonHunter
{
    public class Storyline
    {
        public void Story()
        {
            Console.CursorVisible = false;
            Console.Write("                                            ");
            for (int i = 0; i < GameStatistics.hello.Length; i++)
            {
                Console.Write($"{GameStatistics.hello[i]}");
                Thread.Sleep(350);
            }
            Thread.Sleep(500);
            Console.Clear();

            Console.WriteLine("         Hello traveller!");
            Console.WriteLine("        [DungeonHunter v1.0]");
            Console.WriteLine($"{ Environment.NewLine}" +
                $"Im Steve , nice to meet you, son :) ! " +
                $"{Environment.NewLine}Welcome to the DungeonHunter 1.0 - " +
                $"[{System.Environment.MachineName}]");

            Thread.Sleep(7000);
            Console.Clear();

            Console.WriteLine($"Lets talk 'bout myself sir! " +
                $"{Environment.NewLine}...and your mission of course! ");
            Thread.Sleep(5000);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(">> STORY: ");                                                                                           
            Console.WriteLine();                                                                                                       
            Thread.Sleep(4000);                                                                                                        
            Console.WriteLine($"In a many many years ago , there had an young magician.");                                             
            Thread.Sleep(4000);                                                                                                        
            Console.WriteLine($"He was one of the greatest tallens of the Arthur's Castle.");                                          
            Thread.Sleep(4000);                                                                                                        
            Console.WriteLine("He's name was ... Chuakhua.");                                                                          
            Thread.Sleep(4000);                                                                                                        
            Console.WriteLine($"He wanted to become a greatest magician of all the times ,and he searched for ways to become.");       
            Thread.Sleep(4000);                                                                                                        
            Console.WriteLine($"When he was Sixteen years old ,");                                                                     
            Thread.Sleep(4000);                                                                                                        
            Console.WriteLine($"one evil magician from the mountains came to the castle.");                                            
            Thread.Sleep(4000);

            Console.WriteLine();
            Console.Write("Press any key to continue: ");
            Console.ReadKey();
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.CursorVisible = true;
        }
    }
}
