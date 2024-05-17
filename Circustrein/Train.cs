using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein
{
    public class Train
    {
        
        private List<Wagon> wagonList;

        private List<Animal> animals;
        private List<Animal> animalsAscending;
        private List<Animal> animalsDescending;

        public int NumberOfWagons { get { return wagonList.Count; } }

        public Train()
        {
            wagonList = new List<Wagon>();
            animals = new List<Animal>();
            animalsAscending = new List<Animal>(); // Initialize the list
            animalsDescending = new List<Animal>(); // Initialize the list

        }

        public void CreateAnimals(int numberSmallCarnivores, int numberMediumCarnivores, int numberLargeCarnivores, int numberSmallHerbivores, int numberMediumHerbivores, int numberLargeHerbivores)
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


            animalsAscending = animals.OrderBy(animal =>
            {
                int dietValue = animal.GetDiet() == Animal.Diet.Carnivore ? 0 : 1;
                return (int)animal.GetSize() + dietValue;
            }).ToList();


        }

        public void CreateAnimalsDescending(int numberSmallCarnivores, int numberMediumCarnivores, int numberLargeCarnivores, int numberSmallHerbivores, int numberMediumHerbivores, int numberLargeHerbivores)
        {

            for (int i = 0; i < numberSmallCarnivores; i++)
            {
                animalsDescending.Add(new Animal(Animal.Diet.Carnivore, Animal.Size.Small));
            }

            for (int i = 0; i < numberMediumCarnivores; i++)
            {
                animalsDescending.Add(new Animal(Animal.Diet.Carnivore, Animal.Size.Medium));
            }

            for (int i = 0; i < numberLargeCarnivores; i++)
            {
                animalsDescending.Add(new Animal(Animal.Diet.Carnivore, Animal.Size.Large));
            }

            for (int i = 0; i < numberLargeHerbivores; i++)
            {
                animalsDescending.Add(new Animal(Animal.Diet.Herbivore, Animal.Size.Large));
            }

            for (int i = 0; i < numberMediumHerbivores; i++)
            {
                animalsDescending.Add(new Animal(Animal.Diet.Herbivore, Animal.Size.Medium));
            }


            for (int i = 0; i < numberSmallHerbivores; i++)
            {
                animalsDescending.Add(new Animal(Animal.Diet.Herbivore, Animal.Size.Small));
            }



        }

        public void PlaceAnimalsInWagonsByOrderAndChooseTheMostEfficient()
        {


            if (PlaceAnimalsInWagons(animalsAscending) <= PlaceAnimalsInWagons(animalsDescending))
            {
                PlaceAnimalsInWagons(animalsAscending);
            }
            else
            {
                PlaceAnimalsInWagons(animalsDescending);
            }
        }
        private int PlaceAnimalsInWagons(List<Animal> animals)
        {
            wagonList.Clear();
            foreach (var animal in animals)
            {
                if (!TryToAddAnimalToExistingWagons(animal))
                {
                    AddAnimalToNewWagon(animal);
                }
            }
            return wagonList.Count;
        }

        private void AddAnimalToNewWagon(Animal animal)
        {
            Wagon wagon = new Wagon();
            wagonList.Add(wagon);
            wagon.CanAddAnimal(animal);
        }

        private bool TryToAddAnimalToExistingWagons(Animal animal)
        {
            foreach (var wagon in wagonList)
            {
                if (wagon.CanAddAnimal(animal))
                {
                    return true;
                }
            }
            return false;
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
