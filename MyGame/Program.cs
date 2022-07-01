using System;

namespace MyGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Enemy trump = new Enemy("               Trump   ");
            trump.SetName("   Donald    Trump   ");        

            System.Console.WriteLine($"Name is {trump.GetName()} and HP is {trump.GetHealth()}");
        }
    }
}
