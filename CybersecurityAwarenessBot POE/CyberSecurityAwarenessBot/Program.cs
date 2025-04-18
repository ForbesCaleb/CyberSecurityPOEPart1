// Required Namespaces
using System;
using System.Media;
using System.Threading;
using System.IO;

namespace CyberSecurityAwarenessBot
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Voice Greeting
            PlayVoiceGreeting();

            // 2. Image Display (ASCII Art)
            DisplayAsciiArt();

            // 3. Text-Based Greeting and User Interaction
            Console.Write("\nPlease enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine($"\nWelcome, {name}! I'm your Cybersecurity Awareness Bot.");

            // 4. Basic Response System
            BasicResponseSystem();
        }

        static void PlayVoiceGreeting()
        {
            try
            {
                SoundPlayer player = new SoundPlayer("greeting.wav");
                player.Load();
                player.PlaySync();
            }
            catch (Exception e)
            {
                Console.WriteLine("[Error] Unable to play voice greeting: " + e.Message);
            }
        }
        static void DisplayAsciiArt()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n=============================");
            Console.WriteLine("   CYBERSECURITY AWARENESS   ");
            Console.WriteLine("         BOT ONLINE         ");
            Console.WriteLine("=============================");
            Console.ResetColor();
        }
    }
}




