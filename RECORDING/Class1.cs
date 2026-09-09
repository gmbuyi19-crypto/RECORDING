using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace RECORDING
{
    
    // Main chatbot class that handles user interactions and cybersecurity education
    
    public class Response_System

    {
        // Store the user's name for personalized responses throughout the session
        private string userName;

        
        
        public Response_System()
        {
            RunResponseSystem(); // Start the entire chatbot flow
        }

        
        private void RunResponseSystem()
        {
           
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=== Cybersecurity Awareness Chatbot ===");
            Console.ResetColor(); 

           
            GetUserName();            
            ShowWelcome();
            StartChat();
        }

        private void GetUserName()
        {
            // Prompt user for their name
            Console.Write("Kindly enter your name: ");
            userName = Console.ReadLine();

            // Keep asking until a valid name is entered (not empty or just spaces)
            while (string.IsNullOrWhiteSpace(userName))
            {
                // Show error message in red
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input! Username cannot be empty.");
                Console.ResetColor();

                // Ask again
                Console.Write("Please enter a valid username: ");
                userName = Console.ReadLine();
            }

            // Confirm successful input in green
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Username '{userName}' accepted!");
            Console.ResetColor();
        }

       
        private void ShowWelcome()
        {
            
            TypeText($"\nWelcome {userName}!");           
            TypeText("I am your Cybersecurity Awareness Chatbot.");  
            TypeText("Ask me anything about staying safe online.");  
            TypeText("\nType 'help' for topics or 'exit' to quit.");
        }

        
        // Main chat loop that handles all user interactions
       
        private void StartChat()
        {
            bool running = true; 

            while (running)
            {
                // Get user input with a prompt
                Console.Write("\nYou: ");
                string input = Console.ReadLine();

               
                if (string.IsNullOrWhiteSpace(input))
                {
                    // Default response for invalid/unexpected inputs
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("I didn't quite understand that. Could you rephrase?");
                    Console.ResetColor();
                    continue; 
                }

                // Check if user wants to exit the chat
                if (input.ToLower() == "exit" || input.ToLower() == "quit")
                {
                    EndChat(); 
                    running = false; 
                    break;
                }

                // Check if user wants to see help menu
                if (input.ToLower() == "help" || input.ToLower() == "?")
                {
                    ShowHelp(); // Display available topics
                    continue; // Go back to start of loop
                }

                // Process the user's question
                ProcessQuestion(input);
            }
        }

        
        // Displays help menu showing all available topics
        
        private void ShowHelp()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n=== What can I ask you about? ===");
            Console.WriteLine("• Password safety");           
            Console.WriteLine("• Phishing emails");          
            Console.WriteLine("• Safe browsing");           
            Console.WriteLine("• Social media safety");      
            Console.WriteLine("• General cybersecurity");   
            Console.WriteLine("• 'How are you?'");          
            Console.WriteLine("• 'What's your purpose?'");
            Console.ResetColor();
        }

      
        // Processes user questions and provides appropriate cybersecurity responses
       
        /// <param name="question"
        private void ProcessQuestion(string question)
        {
         
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("\n[Cybersecurity Bot]: ");
            Console.ResetColor();

            // Convert to lowercase for easier comparison
            string q = question.ToLower();

            
            if (q.Contains("how are you") || q.Contains("how's it going"))
            {
                TypeText("I'm doing great, thank you! How can I help you stay safe online?");
            }

            
            else if (q.Contains("purpose") || q.Contains("what do you do"))
            {
                TypeText("My purpose is to educate people about cybersecurity and help them stay safe online!");
            }

            
            else if (q.Contains("what can i ask") || q.Contains("questions"))
            {
                TypeText("You can ask me about passwords, phishing, safe browsing, social media safety, and general cybersecurity tips!");
            }

         
            else if (q.Contains("password") || q.Contains("passcode"))
            {
                TypeText("Use strong passwords with at least 12 characters, including uppercase, lowercase, numbers, and symbols. Never reuse passwords!");
            }

           
            else if (q.Contains("phishing") || q.Contains("email") || q.Contains("scam"))
            {
                TypeText("Never click on suspicious links or download attachments from unknown senders. Always check the sender's email address carefully!");
            }

           
            else if (q.Contains("browsing") || q.Contains("website") || q.Contains("browser"))
            {
                TypeText("Look for 'https://' in URLs, use ad-blockers, and keep your browser updated to the latest version!");
            }

            else if (q.Contains("social media") || q.Contains("facebook") || q.Contains("privacy"))
            {
                TypeText("Limit what personal information you share, use strict privacy settings, and be careful about what you post online!");
            }

            
            else if (q.Contains("security") || q.Contains("cyber") || q.Contains("protect"))
            {
                TypeText("Keep your software updated, use antivirus protection, backup your data regularly, and always be cautious online!");
            }

            else
            {
                // This handles any question that doesn't match the above topics
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                TypeText("I didn't quite understand that. Could you rephrase?");
                TypeText("Try asking about passwords, phishing, safe browsing, or type 'help' for more options.");
                Console.ResetColor();
            }
        }

        
        //Displays goodbye message when user exits the chat
        
        private void EndChat()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n========================================");
            TypeText("Thank you for using the Cybersecurity Awareness Chatbot!");
            TypeText($"Stay safe online, {userName}!"); // Personalized goodbye
            Console.WriteLine("========================================");
            Console.ResetColor();
        }

        
        public void TypeText(string message)
        {
            // Loop through each character in the message
            foreach (char letter in message)
            {
                Console.Write(letter);      // Print one character
                Thread.Sleep(20);          // Wait 20 milliseconds before next character
            }
            Console.WriteLine(); // Add a new line after the message is complete
        }
    }
}
