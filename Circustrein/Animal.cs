﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein
{
    public class Animal
    {
        public enum Diet
        {
            Carnivore,
            Herbivore
        }

        public enum Size
        {
            Small=1,
            Medium=3,
            Large=5
        }

        private Diet AnimalDiet { get; set; }
        private Size AnimalSize { get; set; }

        public Animal(Diet diet, Size size)
        {
            AnimalDiet = diet;
            AnimalSize = size;
        }

        public Diet GetDiet()
        {
            return AnimalDiet;
        }

        public Size GetSize()
        {
            return AnimalSize;
        }


        public int GetPoints()
        {
            return (int)AnimalSize;
        }




    }
}
