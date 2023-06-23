using System.Diagnostics;

namespace _02._Space_Travel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split("||")
                .ToList();

            int fuel = int.Parse(Console.ReadLine());
            int ammunition = int.Parse(Console.ReadLine());

            for (int i = 0; i < input.Count; i++)
            {
                List<string> command = input[i]
                    .Split()
                    .ToList();
                switch (command[0])
                {
                    case "Travel":
                        int distance = int.Parse(command[1]);
                        if (fuel - distance >= 0)
                        {
                            fuel -= distance;
                            Console.WriteLine($"The spaceship travelled {distance} light-years.");
                        }
                        else
                        {
                            Console.WriteLine("Mission failed.");
                            return;
                        }
                        break;
                    case "Enemy":
                        int enemyArmor = int.Parse(command[1]);
                        if (ammunition >= enemyArmor)
                        {
                            ammunition -= enemyArmor;
                            Console.WriteLine($"An enemy with {enemyArmor} armour is defeated.");
                        }
                        else 
                        {
                            if (fuel >= enemyArmor*2) 
                            {
                                fuel -= enemyArmor*2;
                                Console.WriteLine($"An enemy with {enemyArmor} armour is outmaneuvered.");
                            }
                            else
                            {
                                Console.WriteLine("Mission failed.");
                                return;
                            }
                        }
                        break;
                    case "Repair":
                        int amount = int.Parse(command[1]);
                        ammunition += amount * 2;
                        fuel += amount;
                        Console.WriteLine($"Ammunitions added: {amount*2}.");
                        Console.WriteLine($"Fuel added: {amount}.");
                        break;
                    case "Titan":
                        Console.WriteLine("You have reached Titan, all passengers are safe.");
                        return;
                        
                }
            }

        }
    }
}