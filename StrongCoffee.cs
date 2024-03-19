using System;
using System.ComponentModel;
using CoffeeMachine;

namespace stCoff
{
    public class StrongCoffee : ICoffee
    {
        float price {  get; set; }
        protected StrongCoffee()
        {
            price = 0;
        }
        internal StrongCoffee(float price)
        {
            this.price = price;
        }

        public void addExpresso()
        {   
            price += 30;
            Console.Write("\nBrewing Strong Expresso...");
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i + "... ");
                Thread.Sleep(500);
            }
            Console.WriteLine("\nBrewing Successful Enjoy!");
        }

        public void addLatte()
        {
            price += 35;
            Console.Write("Brewing Strong Latte...");
            for (int i = 1; i <= 5; i++)
            {
                Console.Write(i + "...");
                Thread.Sleep(500);
            }
            Console.WriteLine("\nBrewing Successful Enjoy!");
        }
    }
}
