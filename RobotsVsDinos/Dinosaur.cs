using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinos
{
    class Dinosaur
    {
        //member variable (HAVE A)
        public string typeOfDino;
        public int dinoHealth;
        public int dinoEnergy;
        public int dinoAttackPower;

        //constuctor (SPAWNER)
        public Dinosaur(string typeOfDino, int dinoEnergy, int dinoAttackPower)
        {
            this.typeOfDino = typeOfDino;
            dinoHealth = 100;
            this.dinoEnergy = dinoEnergy;
            this.dinoAttackPower = dinoAttackPower;
        }

        //member method (CAN DO)


        //dinosaur have the ability to attack a robot
        //each time a dinosaur attacks a robot, minus the attack from the robot's health point

        public void DinosaurAttack(Robot robotBeingAttacked)
        {
            if (dinoAttackPower < robotBeingAttacked.robotHealth)
            {
                robotBeingAttacked.robotHealth -= dinoAttackPower;
            }
            else if (dinoAttackPower > robotBeingAttacked.robotHealth)
            {
                robotBeingAttacked.robotHealth = 0;
                Console.WriteLine(robotBeingAttacked.nameOfRobot + " is KO'd.");
            }
        }
    }
}
