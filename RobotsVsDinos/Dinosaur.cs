using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinos
{
    public class Dinosaur
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

        public void DinosaurAttack(Robot robotBeingAttacked)
        {
            //WriteLine that will display which dino is attacking which robot
            Console.WriteLine(typeOfDino + " has an ATK POWER of " + dinoAttackPower + " and ATTACKS " + robotBeingAttacked.nameOfRobot + ", who has " + robotBeingAttacked.robotHealth + " HP.");
            if (dinoAttackPower < robotBeingAttacked.robotHealth)
            {
                robotBeingAttacked.robotHealth -= dinoAttackPower;
                Console.WriteLine(typeOfDino + "'s attack successfully hits " + robotBeingAttacked.nameOfRobot + "!!!  " + robotBeingAttacked.nameOfRobot + " only has " + robotBeingAttacked.robotHealth + " HP left.");
            }
            else if (dinoAttackPower >= robotBeingAttacked.robotHealth)
            {
                robotBeingAttacked.robotHealth = 0;
                 
                Console.WriteLine(robotBeingAttacked.nameOfRobot + " is KO'd!!!");
            }
        }
    }
}
