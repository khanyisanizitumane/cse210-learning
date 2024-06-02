using System;
using System.Collections.Generic;

namespace MindfulnessApp
{
    class ListingActivity : MindfulnessActivity
    {
        private static List<string> prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        public ListingActivity()
        {
            ActivityName = "Listing Exercise";
            Description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        }

        protected override void RunActivity()
        {
            Random random = new Random();
            string prompt = prompts[random.Next(prompts.Count)];
            Console.WriteLine(prompt);
            PauseWithSpinner(3);

            Console.WriteLine("Start listing items...");
            PauseWithSpinner(3);

            List<string> items = new List<string>();
            DateTime endTime = DateTime.Now.AddSeconds(Duration);
            while (DateTime.Now < endTime)
            {
                Console.Write("Item: ");
                string item = Console.ReadLine();
                items.Add(item);
            }

            Console.WriteLine($"You listed {items.Count} items.");
        }
    }
}
