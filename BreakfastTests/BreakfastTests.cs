using System;
using Xunit;
using System.Threading;
using Breakfast;

namespace BreakfastTests
{
    public class BreakfastTests
    {

        [Fact]
        public void TestPouringCoffee()
        {
            var coffee = Breakfast.Breakfast.PourCoffee();
            Assert.True(typeof(Coffee) == coffee.GetType());

        }

        [Fact]
        public void TestCoffeeTemperature()
        {
            var coffee = Breakfast.Breakfast.PourCoffee();
            Assert.Equal("Hot", coffee.Temperature);
            Thread.Sleep(500);
            Assert.Equal("Quite hot", coffee.Temperature);
            Thread.Sleep(500);
            Assert.Equal("Not so hot", coffee.Temperature);
            Thread.Sleep(500);
            Assert.Equal("Cold", coffee.Temperature);
        }

        [Fact]
        public async void TestFryingEggsLength()
        {
            var eggs = await Breakfast.Breakfast.FryEggsAsync(2);
            Assert.Equal(2, eggs.Length);
            Assert.Equal("2 eggs", eggs.Print());
        }

        [Fact]
        public async void TestFryingBaconLength()
        {
            
            Bacon[] bacon = await Breakfast.Breakfast.FryBaconAsync(4);
            Assert.Equal(4, bacon.Length);
            Breakfast.Breakfast.EatBacon(ref bacon, 2);
            Assert.Equal(2, bacon.Length);
        }

        [Fact]
        public async void TestToastingBreadLength()
        {
            var toasts = await Breakfast.Breakfast.ToastBreadAsync(2);
            Assert.Equal(2, toasts.Length);
        }

        [Fact]
        public async void TestApplyingToToast()
        {
            var toasts = await Breakfast.Breakfast.ToastBreadAsync(2);

            Breakfast.Breakfast.ApplyButter(toasts[0]);
            Breakfast.Breakfast.ApplyJam(toasts[1]);

            Assert.False(toasts[0].JamApplied);
            Assert.False(toasts[1].ButterApplied);
            Assert.True(toasts[1].JamApplied);
            Assert.True(toasts[0].ButterApplied);
        }
    }
}

