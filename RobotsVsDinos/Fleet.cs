using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinos
{
    public class Fleet
    {
        //member variable (HAVE A)
        public List<Robot> robots;
        

        //constuctor (SPAWNER)
        public Fleet()
        {
            robots = new List<Robot>();
            

            Robot atom = new Robot("Atom", "Iron Fists", 60);
            Robot optimusPrime = new Robot("Optimus Prime", "Blaster", 75);
            Robot baymax = new Robot("Baymax", "Rocket Fists", 50);

            robots.Add(atom);
            robots.Add(optimusPrime);
            robots.Add(baymax);

        }

        


        //member method (CAN DO)


    }
}
