using System;
using System.Collections.Generic;

namespace MindfulnessApp
{
    class ReflectionActivity : MindfulnessActivity
    {
        private static List<string> prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        private static List<string> questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

        public ReflectionActivity()
        {
            ActivityName = "Reflection Exercise";
            Description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        }

        protected override void RunActivity()
        {
            Random random = new Random();
            string prompt = prompts[random.Next(prompts.Count)];
            Console.WriteLine(prompt);
            PauseWithSpinner(3);

            int elapsedTime = 0;
            while (elapsedTime < Duration)
            {
                string question = questions[random.Next(questions.Count)];
                Console.WriteLine(question);
                PauseWithSpinner(5); // Give time to think about the question
                elapsedTime += 5;
            }
        }
    }
}
