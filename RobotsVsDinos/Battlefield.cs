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

        //robots have the ability to attack a dinosaur on the battlefield
        //dinosaurs have the ability to attack a robot on the battlefield
        //if a robot attacks a dinosaur, the dinosaur will lose HP equivalent to the attack, and vice versa
        //when a robot or dinosaur loses all their HP, they will be KO'd
        //if a Herd of dinosaurs, or a Fleet of robots loses all their HP, the game is over

        public void RunBattle()
        {

            Welcome();

            while (fleet.robots[0].robotHealth > 0 && herd.dinosaurs[0].dinoHealth > 0)
            {
                //dinosaur and robot at index 0 attacking
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


                //dinosaur and robot at index 1 attacking 
                //herd.dinosaurs[1].DinosaurAttack(fleet.robots[1]);
                //fleet.robots[1].RobotAttack(herd.dinosaurs[1]);

                //dinosaur and robot at index 2 attacking 
                //herd.dinosaurs[2].DinosaurAttack(fleet.robots[2]);
                //fleet.robots[2].RobotAttack(herd.dinosaurs[2]);

               // Console.WriteLine("");

            }
        }

        public void Welcome()
        {
            Console.WriteLine("Welcome to the World of ROBOTS vs DINOSAURS!");

        }



        
    }
}
