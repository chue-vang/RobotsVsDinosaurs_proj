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
            this.dinoAttackPower = dinoAttackPower
        }






        //member method (CAN DO)
    }
}
