// See https://aka.ms/new-console-template for more information
using System;
using System.Threading;
using Microsoft.Extensions.CommandLineUtils;
using stCoff;
using liCoff;
using CoffeeSizeEnum;
using System.Security.Cryptography;
using System.Globalization;


Console.WriteLine("\t\t\t\t*******************************************************************");
Console.WriteLine("\t\t\t\t\t\t\tWELCOME TO STARBUCKS");
Console.WriteLine("\t\t\t\t*******************************************************************");
Console.WriteLine("\t\t\t\t  Ready to brew your perfect cup! What can I make for you today?");
Console.WriteLine("\n\t\t\t\t\t\t\t    ( (     ");
Console.WriteLine("\t\t\t\t\t\t\t     ) )    ");
Console.WriteLine("\t\t\t\t\t\t\t  ........ ");
Console.WriteLine("\t\t\t\t\t\t\t  |      |]");
Console.WriteLine("\t\t\t\t\t\t\t  \\      / ");
Console.WriteLine("\t\t\t\t\t\t\t   `----'  ");

Console.WriteLine("\n\n\t\t\t\t\t\t\tOUR COFFEE MENU");
Console.WriteLine("\t\t\t\t\t\t\t1. Expresso");
Console.WriteLine("\t\t\t\t\t\t\t2. Latte");
Console.Write("\t\t\t\t\t\t\tEnter a number: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num==1)
{ string coffeeName = "Expresso";}
else if(num==2)
{ string coffeeName = "Latte"; }
else
{ Console.WriteLine("Enter valid Input >_< "); Environment.Exit(0); }

Console.Write("\t\t\t\t  Would you like a Tall, Grand or Venti Size (Tall/Grande/Venti): ");
 string s = Console.ReadLine().ToUpper();

Console.Write("\t\t\t\t\t\tWould you like your coffee strong (Y/N): ");
char ch = Convert.ToChar(Console.ReadLine());

Size s1 = Size.TALL;
Console.WriteLine(s);
float total_price = 0, coffee_cost = 0, add_cost = 0;

if (ch == 'Y' || ch == 'y')
{
    StrongCoffee coffee = new StrongCoffee(coffee_cost);
    if (num == 1)
        coffee.addExpresso();

    else if (num == 2)
        coffee.addLatte();
    else
        Console.WriteLine("Enter valid Input >_< ");
}
else if (ch == 'N' || ch == 'n')
{
    LightCoffee coffee = new LightCoffee();
    coffee.addExpresso();
    if (num == 1)
        coffee.addExpresso();

    else if (num == 2)
        coffee.addLatte();
    else
        Console.WriteLine("Enter valid Input >_< ");
}
else
{
    Console.WriteLine("Enter valid Input >_< ");
}



