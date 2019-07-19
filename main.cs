using System;
using System.Collections.Generic;
using userPlant;


namespace adventureGame
{
    class program
    {
        public static void Main()
        {
            Console.WriteLine("--------------");
            Console.WriteLine("Welcome to my plant game");
            Console.WriteLine("press 'enter' to start taking care of your own plant");
            Console.WriteLine("what would you like to name your plant?");
            string plantName = Console.ReadLine();
            Console.WriteLine("Which of these options would you like to do?");
              Console.WriteLine("-------------------");
            Console.WriteLine("type 1 if you want to  water your plant. \ntype 2 if you want to feed your plant. \ntype 3 if you want  your to have some SUN.");
           string listen = Console.ReadLine();
            myPlant NewPlant = new myPlant(plantName, 50,30,10);
            Start:
            switch(listen)
                {
                case "1":
                    NewPlant.Water();
                    break;
                        case "2":
                    NewPlant.Feed();
                    break;
                        case "3":
                    NewPlant.giveSunshine();
                    break;
                    default: 
                    Console.WriteLine("YOU CANT DO THAT");
                    break;
                   goto Start;
                }
                   

            
            int giveWater = NewPlant.getWater();
            int giveFood = NewPlant.getfood();
            int giveSun = NewPlant.getgiveSunshine();
           
            Console.WriteLine("your name is " + plantName + "\nyour initial water level is: '50' \nyour inital food level is '30' \nyour inital sun level is '10' ");
            Console.WriteLine("-----------------");
            Console.WriteLine("\nyour name is: " + plantName + "\nyour new water level is: " + giveWater+ "\nyour new food level is: " + giveFood + "\nyour newsun level is: " + giveSun + " ");
            // instance of the class which contains the plants name, inital water level, inital food level, and initial sun level.
            

           
        }
    }
}