using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinos
{
    public class Robot
    {
        //member variable (HAVE A)
        public string nameOfRobot;
        public int robotHealth;
        public Weapon weapon;

        //constuctor (SPAWNER)
        public Robot(string nameOfRobot, string robotWeapon, int robotAttackPower)
        {
            this.nameOfRobot = nameOfRobot;
            robotHealth = 100;
            this.weapon = new Weapon(robotWeapon, robotAttackPower);
        }

        //member method (CAN DO)

        //robots have the ability to attack a dinosaur
        //each time a robot attacks a dinosaur, minus the robot's attack from the dino's health
        //

        public void RobotAttack(Dinosaur dinoBeingAttacked)
        {
            //Create a WriteLine that will display which dino is attacking which robot
            Console.WriteLine(nameOfRobot + " has an ATK POWER of " + weapon.weaponPower + " and is attacking " + dinoBeingAttacked.typeOfDino + " with his " + weapon.weaponType + ", who has " + dinoBeingAttacked.dinoHealth + " HP");

            if (weapon.weaponPower < dinoBeingAttacked.dinoHealth)
            {
                dinoBeingAttacked.dinoHealth -= weapon.weaponPower;
                Console.WriteLine(dinoBeingAttacked.typeOfDino + " has " + dinoBeingAttacked.dinoHealth + " HP left");
            }
            else if (weapon.weaponPower >= dinoBeingAttacked.dinoHealth)
            {
                dinoBeingAttacked.dinoHealth = 0;
                Console.WriteLine(dinoBeingAttacked.typeOfDino + " is KO'd.");
            }     
        }
    }
}
