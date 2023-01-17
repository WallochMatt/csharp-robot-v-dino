using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rvd_csharp
{
    internal class Robot
    {
        //members
        public string name;

        public int health;

        public Weapon activeWeapon;

        //constructor
        public Robot(string name, Weapon activeWeapon)
        {
            this.name = name;
            health = 100;
            this.activeWeapon = activeWeapon;
        }

        //methods
        public void attack(Dinosaur dinosaur)
        {
            dinosaur.health = dinosaur.health - activeWeapon.attackPower;
        }
    }
}
