using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rvd_csharp
{
    internal class Battlefield
    {
        //members
        public Robot robot;

        public Dinosaur dinosaur;

        //constructor
        public Battlefield(Robot robot, Dinosaur dinosaur)
        {
            this.robot = robot;
            this.dinosaur = dinosaur;
        }

        //methods
       public void runGame()
        {
            greeting();
            battlePhase(robot, dinosaur);
        }

        public void greeting()
        {
            Console.WriteLine("Welcome to Dinosaur Laser Fight!");
            Console.ReadLine();

            Console.WriteLine("Feel free to instatiate your own objects in the Program.cs file! \n");
            Console.ReadLine();

        }

        public void battlePhase(Robot robot, Dinosaur dinosaur) 
        {
            while(robot.health > 0 && dinosaur.health > 0)
            {
                robot.attack(dinosaur);
                Console.WriteLine($"{robot.name} attacks with it's {robot.activeWeapon.name}! \n" +
                    $"{dinosaur.name} took {robot.activeWeapon.attackPower} damage! \n" +
                    $"{dinosaur.name} has {dinosaur.health} health remaining!");

                Console.ReadLine();

                if(dinosaur.health != 0 )
                {
                    dinosaur.attack(robot);
                    Console.WriteLine($"{dinosaur.name} attacks! \n" +
                        $"{robot.name} took {dinosaur.attackPower} damage! \n" +
                        $"{robot.name} has {robot.health} health remaining!");

                    Console.ReadLine();
                }

                if(dinosaur.health <= 0) 
                {
                    Console.WriteLine($"{robot.name} wins!");
                    Console.ReadLine();
                }

                if(robot.health <= 0)
                {
                    Console.WriteLine($"{dinosaur.name} wins!");
                    Console.ReadLine();
                }
            }
        }
    }
}
