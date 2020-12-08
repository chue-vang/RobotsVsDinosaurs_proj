using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinos
{
    class Battlefield
    {
        //member variable (HAVE A)
        public Herd herd;
        public Fleet fleet;

        //constuctor (SPAWNER)
        public Battlefield()
        {
            herd = new Herd();
            fleet = new Fleet();
        }

        //member method (CAN DO)
        public void Welcome()
        {
            Console.WriteLine("WELCOME TO THE WORLD OF ROBOTS vs DINOSAURS!!");
        }

        //robots and dinosaurs attacking each other
        public void RunBattle()
        {
            Welcome();

            while (fleet.robots[0].robotHealth > 0 && herd.dinosaurs[0].dinoHealth > 0)
            {
                herd.dinosaurs[0].DinosaurAttack(fleet.robots[0]);
                if (fleet.robots[0].robotHealth <= 0)
                {
                    fleet.robots.RemoveAt(0);
                }
                fleet.robots[0].RobotAttack(herd.dinosaurs[0]);
                if (herd.dinosaurs[0].dinoHealth <= 0)
                {
                    herd.dinosaurs.RemoveAt(0);
                }                
            }
        }
    }
}
