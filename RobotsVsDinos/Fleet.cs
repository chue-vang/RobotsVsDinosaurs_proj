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
            

            Robot optimusPrime = new Robot("Optimus Prime", "Blaster", 90);
            Robot atom = new Robot("Atom", "Iron Fists", 100);
            Robot baymax = new Robot("Baymax", "Rocket Fists", 80);

            robots.Add(atom);
            robots.Add(optimusPrime);
            robots.Add(baymax);

        }

        


        //member method (CAN DO)


    }
}
