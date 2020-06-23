using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Tracing;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Breakfast
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Coffee coffee = Breakfast.PourCoffee();
            Console.WriteLine("Coffee is ready.");

            var eggsTask = Breakfast.FryEggsAsync(5);
            var baconTask = Breakfast.FryBaconAsync(3);
            var toastTask = Breakfast.ToastBreadAsync(3);

            var breakfastTask = new List<Task> { eggsTask, baconTask, toastTask };

            while (breakfastTask.Count > 0)
            {
                Task finishedTask = await Task.WhenAny(breakfastTask);
                if(finishedTask == eggsTask)
                {
                    Console.WriteLine("Eggs are ready.");
                }
                else if(finishedTask == baconTask)
                {
                    Console.WriteLine("Bacon is ready.");
                }
                else if(finishedTask == toastTask)
                {
                    Console.WriteLine("Toast is ready.");
                }
                breakfastTask.Remove(finishedTask);

            }

            ToastBread[] toasts = await toastTask;
            
            for(int i = 1; i < toasts.Length; i++)
            {
                Breakfast.ApplyButter(toasts[i]);
                Breakfast.ApplyJam(toasts[i]);
                Console.WriteLine("Toast " + i + " with Butter and Jam.");
                
            }
            Console.WriteLine("Butter and Jam are on your Toast. Enjoy it.");

            Breakfast.PourJuice("orange");
            Console.WriteLine("You can enjoy your Juice now.");
            stopwatch.Stop();

            Console.WriteLine(stopwatch.ElapsedMilliseconds / 1000 + " Seconds needed for preparing breakfast.");

        }
    }
}
