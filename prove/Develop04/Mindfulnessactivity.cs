using System;
using System.Collections.Generic;
using System.Threading;

namespace MindfulnessApp
{
    abstract class MindfulnessActivity
    {
        protected int Duration { get; set; }
        protected string ActivityName { get; set; }
        protected string Description { get; set; }

        public void StartActivity()
        {
            Console.Clear();
            Console.WriteLine($"Starting {ActivityName}");
            Console.WriteLine(Description);
            Console.Write("Enter the duration of the activity in seconds: ");
            Duration = int.Parse(Console.ReadLine());
            Console.WriteLine("Prepare to begin...");
            PauseWithSpinner(3);
            RunActivity();
            Console.WriteLine($"You have completed the {ActivityName} activity for {Duration} seconds.");
            PauseWithSpinner(3);
        }

        protected void PauseWithSpinner(int seconds)
        {
            for (int i = 0; i < seconds; i++)
            {
                Console.Write(".");
                Thread.Sleep(1000);
            }
            Console.WriteLine();
        }

        protected abstract void RunActivity();
    }
}
