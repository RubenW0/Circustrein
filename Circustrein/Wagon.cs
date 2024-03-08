using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Circustrein.Animal;

namespace Circustrein
{
    internal class Wagon
    {

        private List<Animal> animals;

        public Wagon()
        {
            animals = new List<Animal>();
        }

        public void AddAnimal(Animal animal)
        {
            animals.Add(animal);
        }

        public List<Animal> GetAnimals()
        {
            return animals;
        }

        public int GetTotalPoints()
        {
            int totalPoints = 0;
            foreach (var animal in animals)
            {
                totalPoints += animal.GetPoints();
            }
            return totalPoints;
        }

        public bool CanAddAnimal(Animal animal)
        {
            if (GetTotalPoints() + animal.GetPoints() > 10)
            {
                return false;
            }

            for (int i = 0; i < animals.Count; i++)
            {
                if (animals[i].GetDiet() == Animal.Diet.Carnivore && (int)animals[i].GetSize() >= (int)animal.GetSize())
                {
                    return false;
                }

                if (animal.GetDiet() == Animal.Diet.Carnivore && (int)animals[i].GetSize() <= (int)animal.GetSize())
                {
                    return false;
                }
            }
            return true;

            

        }
    }
}
