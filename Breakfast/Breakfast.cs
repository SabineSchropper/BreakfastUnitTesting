using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Breakfast
{
    public class Breakfast
    {
        public static Coffee PourCoffee()
        {
            Coffee coffee = new Coffee();
            return coffee;  
        }
        public static async Task<Egg[]> FryEggsAsync(int amount)
        {
            
            Egg[] eggs = new Egg[amount+1];
            for(int i = 1; i <= amount; i++)
            {
                await Task.Delay(3000);
                Egg egg = new Egg();
                eggs[i] = egg;
                Console.WriteLine("Egg " + i + " is fried.");
            }          
            return eggs;

        }
        public static async Task<Bacon[]> FryBaconAsync(int amount)
        {
            
            Bacon[] lotsOfBacon = new Bacon[amount];
            for(int i = 1; i <= amount; i++)
            {
                await Task.Delay(5000);
                Bacon bacon = new Bacon();
                lotsOfBacon[i] = bacon;
                Console.WriteLine("Bacon " + i + " is fried.");
            }
            return lotsOfBacon;
        }
        /// <summary>
        /// ref is important...baconArray is going to be changed 
        /// and then returned without keyword return
        /// </summary>
        /// <param name="baconArray"></param>
        /// <param name="amount"></param>
        public static void EatBacon(ref Bacon[] baconArray, int amount)
        {
            Bacon[] bacon = baconArray;
            int newAmount = baconArray.Length - amount;
            //Bacon[] bacon = new Bacon[newAmount];
            baconArray = new Bacon[newAmount];
            if (amount <= bacon.Length && amount > 0)
            {
                for (int i = 1; i <= baconArray.Length; i++)
                {
                    baconArray[i] = new Bacon();
                }
            }
            //return baconArray;
            
        }
        public static async Task<ToastBread[]> ToastBreadAsync(int amount)
        {
            
            ToastBread[] toasts = new ToastBread[amount+1];
            for(int i = 1; i <= amount; i++)
            {
                toasts[i] = new ToastBread();
                await Task.Delay(5000);
                Console.WriteLine("Toast " + i + " is toasted.");
            }
            return toasts;
        }
        public static void ApplyButter(ToastBread toast)
        {
            toast.ButterApplied = true;

        }
        public static void ApplyJam(ToastBread toast)
        {
            toast.JamApplied = true;
        }
        public static Juice PourJuice(string type)
        {
            Juice juice = new Juice(type);
            return juice;

        }
    }
}
