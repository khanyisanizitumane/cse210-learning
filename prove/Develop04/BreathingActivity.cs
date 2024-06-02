using System;
using System.Threading;

namespace MindfulnessApp
{
    class BreathingActivity : MindfulnessActivity
    {
        public BreathingActivity()
        {
            ActivityName = "Breathing Exercise";
            Description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
        }

        protected override void RunActivity()
        {
            int elapsedTime = 0;
            while (elapsedTime < Duration)
            {
                Console.WriteLine("Breathe in...");
                PauseWithCountdown(3);
                Console.WriteLine("Breathe out...");
                PauseWithCountdown(3);
                elapsedTime += 6; // Each cycle takes 6 seconds
            }
        }

        private void PauseWithCountdown(int seconds)
        {
            for (int i = seconds; i > 0; i--)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
        }
    }
}
