using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein
{
    internal class Train
    {
        private List<Wagon> wagonList;
        private List<Animal> animals;

        public Train()
        {
            wagonList = new List<Wagon>();
            animals = new List<Animal>();
        }

        public void CreateAnimals(int numberSmallCarnivores, int numberMediumCarnivores, int numberLargeCarnivores, int numberSmallHerbivores,int numberMediumHerbivores, int numberLargeHerbivores)
        {

            for (int i = 0; i < numberSmallCarnivores; i++)
            {
                animals.Add(new Animal(Animal.Diet.Carnivore, Animal.Size.Small));
            }

            for (int i = 0; i < numberMediumCarnivores; i++)
            {
                animals.Add(new Animal(Animal.Diet.Carnivore, Animal.Size.Medium));
            }

            for (int i = 0; i < numberLargeCarnivores; i++)
            {
                animals.Add(new Animal(Animal.Diet.Carnivore, Animal.Size.Large));
            }

            for (int i = 0; i < numberSmallHerbivores; i++)
            {
                 animals.Add(new Animal(Animal.Diet.Herbivore, Animal.Size.Small));
            }

            for (int i = 0; i < numberMediumHerbivores; i++)
            {
                animals.Add(new Animal(Animal.Diet.Herbivore, Animal.Size.Medium));
            }

            for (int i = 0; i < numberLargeHerbivores; i++)
            {
                animals.Add(new Animal(Animal.Diet.Herbivore, Animal.Size.Large));
            }
            

        }

        public void FillWagons()
        {
            foreach (var animal in animals)
            {
                bool addedToExistingWagon = false;

                foreach (var wagon in wagonList)
                {
                    if (wagon.CanAddAnimal(animal))
                    {
                        wagon.AddAnimal(animal);
                        addedToExistingWagon = true;
                        break;
                    }
                }

                if (addedToExistingWagon == false)
                {
                    var newWagon = new Wagon();
                    newWagon.AddAnimal(animal);
                    wagonList.Add(newWagon);
                }
            }
        }

        public void PrintDistribution()
        {
            for (int i = 0; i < wagonList.Count; i++)
            {
                Console.WriteLine($"Wagon {i + 1}:");
                foreach (var animal in wagonList[i].GetAnimals())
                {
                    Console.WriteLine($"- {animal.GetDiet()} {animal.GetSize()}");
                }
                Console.WriteLine();
            }
        }



    } 
}
