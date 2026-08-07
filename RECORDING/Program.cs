using System;
using RECORDING;
using System.Media;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RECORDING
{
   
    internal class Program
    {
        static void Main(string[] args)
        {
            SoundPlayer player = new SoundPlayer("C:\\Users\\Student\\source\\repos\\RECORDING\\RECORDING\\Properties\\voice\\chatbot_recording.wav");
            player.PlaySync();

            Console.WriteLine("Voice played successfully!");
            //Console.ReadLine();

            //ASCII LOGO

            logo logo1 = new logo();

            logo1.DisplayLogo();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Welcome to the Cybersecurity AwarenessBot!");
            Console.ResetColor();
            Console.ReadLine();
        }
    }
}
