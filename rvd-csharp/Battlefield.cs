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
            Console.WriteLine($"Robot name: {robot.name} " +
                $"Robot weapon: {robot.activeWeapon.name}" +
                $"Dinosaur name: {dinosaur.name}");
            Console.ReadLine();
        }
    }
}
