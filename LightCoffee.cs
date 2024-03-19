using System;
using CoffeeMachine;
using System.Threading;

namespace liCoff
{
    public class LightCoffee : ICoffee
    {   
        float price {  get; set; }
        public LightCoffee() 
        { 
            price = 0;
        }
        public LightCoffee(float price)
        {
            this.price = price;
        }

        public void addExpresso()
        {
            Console.Write("Brewing Light Expresso...");
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i + "...");
                Thread.Sleep(500);
            }
            Console.WriteLine("\nBrewing Successful Enjoy!");
        }

        public void addLatte()
        {
            Console.Write("Brewing Strong Latte...");
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i + "...");
                Thread.Sleep(500);
            }
            Console.WriteLine("\nBrewing Successful Enjoy!");
        }
    }
}
