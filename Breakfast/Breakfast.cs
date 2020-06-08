using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Breakfast
{
    public class Breakfast
    {
        public static Coffee PourCoffee()
        {
            Coffee coffee = new Coffee();
            return coffee;  
        }
        public static Egg[] FryEggs(int amount)
        {
            Egg[] eggs = new Egg[amount];
            for(int i = 0; i < amount; i++)
            {
                Egg egg = new Egg();
                eggs[i] = egg;
            }          
            return eggs;

        }
        public static Bacon[] FryBacon(int amount)
        {
            Bacon[] lotsOfBacon = new Bacon[amount];
            for(int i = 0; i < amount; i++)
            {
                Bacon bacon = new Bacon();
                lotsOfBacon[i] = bacon;
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
                for (int i = 0; i < baconArray.Length; i++)
                {
                    baconArray[i] = new Bacon();
                }
            }
            //return baconArray;
            
        }
        public static ToastBread[] ToastBread(int amount)
        {
            ToastBread[] toasts = new ToastBread[amount];
            for(int i = 0; i < amount; i++)
            {
                toasts[i] = new ToastBread();
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
    }
}
