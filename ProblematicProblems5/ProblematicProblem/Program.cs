using System;
using System.Collections.Generic;
using System.Threading;

namespace ProblematicProblem
{
    class Program
    {
       
        public static bool cont = true;
        public static List<string> activities = new List<string>() { "Movies", "Paintball", "Bowling", "Lazer Tag", "LAN Party", "Hiking", "Axe Throwing", "Wine Tasting" };
        public static void Main(string[] args)
        { 
            Random rng = new Random();
            Console.Write("Hello, welcome to the random activity generator! \nWould you like to generate a random activity? yes/no: ");


            string contResponse = Console.ReadLine().ToLower();
            if (contResponse == "yes")
            {
                cont = true;
            }




            Console.WriteLine();
            Console.Write("We are going to need your information first! What is your name? ");
            string userName = Console.ReadLine();

            Console.WriteLine();
            Console.Write("What is your age? ");
            int userAge = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.Write("Would you like to see the current list of activities? Sure/No thanks: ");
            bool seeList;

            var contResponse2 = Console.ReadLine().ToLower();
            if(contResponse2 == "yes")
            {
                seeList = true;
            }
            else
            {
                seeList = false;
            }

            if (seeList)
            {
                foreach (string activity in activities)
                {
                    Console.Write($"{activity} ");
                    Thread.Sleep(250);
                }
                Console.WriteLine();
                Console.Write("Would you like to add any activities before we generate one? yes/no: ");
                bool addToList;

                var contResponse3 = Console.ReadLine().ToLower();
                if(contResponse3 == "yes")
                {
                    addToList = true;
                }
                else
                {
                    addToList = false;
                }

                Console.WriteLine();
                while (addToList)
                {
                    Console.Write("What would you like to add? ");
                    string userAddition = Console.ReadLine();
                    activities.Add(userAddition);
                    foreach (string activity in activities)
                    {
                        Console.Write($"{activity} ");
                        Thread.Sleep(250);
                    }
                    Console.WriteLine();
                    Console.WriteLine("Would you like to add more? yes/no: ");
                    addToList = bool.Parse(Console.ReadLine());
                    var contResponse4 = (Console.ReadLine().ToLower());
                    if(contResponse4 == "yes")
                    {
                        addToList = true;
                    }
                    else
                    {
                        addToList = false;
                    }
                    

                    
                    

                    
                }
            }

            while (cont)
            {
                Console.Write("Connecting to the database");
                for (int i = 0; i < 10; i++)
                {
                    Console.Write(". ");
                    Thread.Sleep(500);
                }
                Console.WriteLine();
                Console.Write("Choosing your random activity");
                for (int i = 0; i < 9; i++)
                {
                    Console.Write(". ");
                    Thread.Sleep(500);
                }
                Console.WriteLine();

                int randomNumber = rng.Next(activities.Count);
                string  randomActivity = activities[randomNumber];



                if (userAge < 21 && randomActivity == "Wine Tasting")
                {
                    //Console.WriteLine($"Oh no! Looks like you are too young to do {randomActivity}");
                    //Console.WriteLine("Pick something else!");
                    //activities.Remove(randomActivity);
                    //int randomNumber = rng.Next(activities.Count);
                    //string randomActivity = activities[randomNumber];
                
                
                    Console.WriteLine($"oh no! looks like you are too young to do {randomActivity}");
                    Console.WriteLine("pick something else!");
                    //activities.Remove(randomActivity);
                    //int randomNumber = rng.Next(activities.Count);
                    //string randomActivity = activities[randomNumber];

                    Console.WriteLine($"ah got it! {randomActivity}, your random activity is: {userName}! is this ok or do you want to grab another activity? keep/redo: ");
                    Console.WriteLine();
                    //cont = bool.Parse(Console.ReadLine());

                    bool cont = Console.ReadLine().ToLower() == "redo"; true : false;



                }
            }
        }

    }
}
