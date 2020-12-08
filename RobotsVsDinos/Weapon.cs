using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinos
{
    public class Weapon
    {
        //member variable (HAVE A)
        public string weaponType;
        public int weaponPower;

        //constuctor (SPAWNER)
        public Weapon(string weaponType, int weaponPower)
        {
            this.weaponType = weaponType;
            this.weaponPower = weaponPower;
        }

        //member method (CAN DO)
    }
}
