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
            
            System.Console.WriteLine("How many enemies are there?");
            int enemyNum = Int32.Parse(Console.ReadLine());

            Enemy[] enemyArray = new Enemy[enemyNum];

            for(int i = 0; i < enemyNum; i++)
            {
                System.Console.WriteLine($"What is enemy's {i + 1} name?");
                string name = Console.ReadLine();
                Enemy input = new Enemy(name);
                
                enemyArray[i] = input;
            }

            for(int i = 0; i < enemyArray.Length; i++)
            {
                System.Console.WriteLine($"Enemy {i+1}'s name is {enemyArray[i].GetName()}");
            }
            System.Console.WriteLine("Obrigado por usar este programa!");
        }
    }
}
