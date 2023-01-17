using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rvd_csharp
{
    internal class Weapon
    {
        //members
        public string name;

        public int attackPower;

        //constructor
        public Weapon(string name, int attackPower)
        {
            this.name = name;
            this.attackPower = attackPower;
        }

        //methods
    }
}
