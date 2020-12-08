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

   

            herd.dinosaurs[0].DinosaurAttack(fleet.robots[0]);
            fleet.robots[1].RobotAttack(herd.dinosaurs[0]);
        }

        public void Welcome()
        {
            Console.WriteLine("Welcome to the World of ROBOTS vs DINOSAURS!");

        }



        
    }
}
