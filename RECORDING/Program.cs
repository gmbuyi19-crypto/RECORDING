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

            Response_Sytem responseSystem1 = new Response_Sytem();
            // The constructor already runs the response system, no need to call it again
            // responseSystem1.Response_Sytem();            

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Welcome to the Cybersecurity AwarenessBot!");
            Console.ResetColor();
            Console.ReadLine();
        }
    }

    
    }

