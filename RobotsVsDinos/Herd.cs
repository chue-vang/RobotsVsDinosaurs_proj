﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinos
{
    public class Herd
    {
        //member variable (HAVE A)
        public List<Dinosaur> dinosaurs;


        //constuctor (SPAWNER)
        public Herd()
        {
            dinosaurs = new List<Dinosaur>();




            Dinosaur tRex = new Dinosaur("TRex", 75, 90);
            Dinosaur velociraptor = new Dinosaur("Velociraptor", 90, 70);
            Dinosaur spinosaurus = new Dinosaur("Spinosaurus", 80, 80);

            dinosaurs.Add(tRex);
            dinosaurs.Add(velociraptor);
            dinosaurs.Add(spinosaurus);
        }






        //member method (CAN DO)
        

    }
}
