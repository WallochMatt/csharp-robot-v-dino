using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rvd_csharp
{
    internal class Dinosaur
    {
        //members
        public string name;

        public int health;

        public int attackPower;

        //constructor
        public Dinosaur(string name, int attackPower)
        {
            this.name = name;
            health = 100;
            this.attackPower = attackPower;
        }

        //methods
        public void attack(Robot robot)
        {
            robot.health = robot.health - attackPower;
        }
    }
}
