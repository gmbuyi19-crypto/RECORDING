using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RECORDING
{
    public class Response_Sytem

    {
        public Response_Sytem()
        {


            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Kindly enter your name: ");
            Console.ResetColor();

            string name = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(name))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Name cannot be empty. Kindlyenter your name: ");
                Console.ResetColor();

                name = Console.ReadLine();
            }

            Console.ForegroundColor = ConsoleColor.Magenta;
            TypeText("\nWelcome " + name + "!");
            Console.WriteLine();
            TypeText("I am your Cybersecurity Awareness Chatbot.");
            Console.WriteLine();
            TypeText("Ask me anything about staying safe online.");
            Console.ResetColor();

            int response = 1;

            while (response == 1)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("You: ");
                Console.ResetColor();

                string question = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(question))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You didn't enter anything. Please try again.");
                    Console.ResetColor();
                }
                else
                {
                    question = question.ToLower();

                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("Bot: ");
                    Console.ResetColor();

                    if (question.Contains("hello") || question.Contains("hi"))
                    {
                        TypeText("Hello " + name + "! It's nice to meet you.");
                    }
                    else if (question.Contains("how are you"))
                    {


                        TypeText("I'm doing great, thank you for asking! I'm always ready to help you stay safe online.");
                    }
                    else if (question.Contains("purpose"))
                    {
                        TypeText("My purpose is to create awareness about cybersecurity and teach people how to stay safe online.");
                    }
                    else if (question.Contains("what can i ask") || question.Contains("help"))
                    {
                        Console.WriteLine();
                        Console.WriteLine("- Password Safety");
                        Console.WriteLine("- Phishing");
                        Console.WriteLine("- Safe Browsing");
                        Console.WriteLine("- General Cybersecurity");
                    }
                    else if (question.Contains("password"))
                    {
                        TypeText("Always create a strong password using uppercase letters, lowercase letters, numbers and symbols.");
                        Console.WriteLine();
                        TypeText("Never share your password with anyone.");
                    }
                    else if (question.Contains("phishing"))
                    {
                        TypeText("Phishing is when criminals try to trick you into giving away personal information through fake emails, messages or websites.");
                    }
                    else if (question.Contains("safe browsing") || question.Contains("browsing"))
                    {
                        TypeText("Only visit trusted websites, avoid clicking suspicious links and always look for HTTPS when browsing.");
                    }
                    else
                    {
                        TypeText("I didn't quite understand that. Could you rephrase?");
                    }
                }

                Console.WriteLine();
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Enter 1 to ask another question or 0 to exit: ");
                Console.ResetColor();

                response = Convert.ToInt32(Console.ReadLine());
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("=======================================================");
            Console.WriteLine("Thank you for using the Cybersecurity Awareness Chatbot!");
            Console.WriteLine("Stay safe online, " + name + "!");
            Console.WriteLine("=======================================================");
            Console.ResetColor();

        }


        public void TypeText(string message)
        {
            foreach (char letter in message)
            {
                Console.Write(letter);
                Thread.Sleep(20);
            }
        }
    }
}
    

 
