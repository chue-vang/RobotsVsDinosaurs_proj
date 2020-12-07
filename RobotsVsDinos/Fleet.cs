using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinos
{
    class Fleet
    {
        //member variable (HAVE A)







        //constuctor (SPAWNER)
        public Fleet()
        {
            Robot optimusPrime = new Robot("Optimus Prime", "Blaster", 90);
            Robot atom = new Robot("Atom", "Iron Fists", 70);
            Robot baymax = new Robot("Baymax", "Rocket Fists", 80);




        }






        //member method (CAN DO)
        //public Robot CreateRobot(string nameOfRobot, int robotHealth, string robotWeapon, int robotAttackPower)
        //{
        //    Robot Robot = new Robot(nameOfRobot, robotHealth, robotWeapon, robotAttackPower);
        //    Robot.nameOfRobot = "OptimusPrime";
        //    Robot.robotHealth = 100;
        //    Robot.robotWeapon = "Blaster";
        //    Robot.robotAttackPower = 75;
        //    return Robot;
        //}
    }
}
