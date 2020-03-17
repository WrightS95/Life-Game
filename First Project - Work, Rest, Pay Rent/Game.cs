using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace First_Project___Work__Rest__Pay_Rent
{
    public class Game
    {
        private int day = 1;
        private int energy = 5;
        private int money = 0;

        private Random random = new Random();
        private List<WorkScenario> scenarios = new List<WorkScenario>();

        private string msg = " ";
        public void PrintMenu() 
        {
            Console.Clear();

            Console.WriteLine($"Day: {day} | Money: {money} / $1000 | Energy: {energy}");
            Console.WriteLine("1. Work");
            Console.WriteLine("2. Rest");
            Console.WriteLine("3. Pay Rent");
            Console.WriteLine(" ");
            Console.WriteLine("Select an option");
            Console.WriteLine(msg);
        }
        public void Work()
        {
            var scenarioNumber = random.Next(scenarios.Count);
            var scenario = scenarios[scenarioNumber];

            if (energy <= 0)
            {
                Console.WriteLine("Energy too low for work!"); Thread.Sleep(300);                
                return;               
            }
            day += scenario.Days;
            energy -= scenario.Energy;
            money += scenario.Money;
            msg = scenario.Message;           
        }

        public void Rest()
        {
            msg = "You have selected to Rest, +1 Day, +1 Energy!";
            day += 1;
            energy += 1;
        }
        public void PayRent()
        {
            if (money < 1000)
            {
                Console.WriteLine("Invalid Command");
            }
            else if (money >= 1000)
            {
                Console.WriteLine("Congrats! You won!");
            }
        }
        public void Run()
        {
            scenarios.Add(new WorkScenario(1, 100, 1, "One day went by, you earned $100, yay!"));
            scenarios.Add(new WorkScenario(1, 100, 1, "You had a productive day! Everyone likes you! Yay! +$100"));
            scenarios.Add(new WorkScenario(1, -50, 1, "Your car broke down! You had to pay $50 to fix it! -$50"));
            scenarios.Add(new WorkScenario(2, 0, 2, "You got abducted by aliens, but managed to excape after 2 days!"));
            scenarios.Add(new WorkScenario(1, 175, 3, "You won a marathon! The prize money was $175, but you are exhausted! -3 Energy"));
           
            bool running = true;         
            while (running)
            {
                PrintMenu();
                var input = Console.ReadKey(true);
                switch (input.Key)
                {
                    case ConsoleKey.D1:
                        Work();                            
                        break;
                    case ConsoleKey.D2:
                        Rest();
                        break;
                    case ConsoleKey.D3:
                        PayRent();
                        break;
                }
                Thread.Sleep(300);
                              
                if (day >= 31 && money < 1000)
                {
                    running = false;
                    Console.WriteLine("Game Over! You lost!");
                    return;
                }
                else if (day <= 31 && money >= 1000)
                {
                    running = false; 
                    Console.WriteLine("You won! Congrats!");
                    return;
                }
            }
        }
    }
}
