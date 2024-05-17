using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Circustrein.Animal;

namespace Circustrein
{
    public class Wagon
    {

        private List<Animal> animalsInWagon;

        public Wagon()
        {
            animalsInWagon = new List<Animal>();
        }

        public void AddAnimal(Animal animal)
        {
            animalsInWagon.Add(animal);
        }

        public List<Animal> GetAnimals()
        {
            return animalsInWagon;
        }

        public int GetTotalPoints()
        {
            int totalPoints = 0;
            foreach (var animal in animalsInWagon)
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

            for (int i = 0; i < animalsInWagon.Count; i++)
            {
                if (animalsInWagon[i].GetDiet() == Animal.Diet.Carnivore && (int)animalsInWagon[i].GetSize() >= (int)animal.GetSize())
                {
                    return false;
                }

                if (animal.GetDiet() == Animal.Diet.Carnivore && (int)animalsInWagon[i].GetSize() <= (int)animal.GetSize())
                {
                    return false;
                }
            }
            animalsInWagon.Add(animal);
            return true;



        }



    }
}
