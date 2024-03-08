using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein
{
    internal class SortAnimals
    {
        private List<Animal> animals;

        public (List<Animal> descendingList, List<Animal> ascendingList) SortAnimalsList()
        {
            var animalsCopy = animals.ToList();

            var descendingList = animalsCopy.OrderByDescending(animal => (int)animal.GetSize()).ToList();

            var ascendingList = animalsCopy.OrderBy(animal =>
            {
                int dietValue = animal.GetDiet() == Animal.Diet.Carnivore ? 0 : 1;
                return (int)animal.GetSize() * 10 + dietValue;
            }).ToList();

            return (descendingList, ascendingList);
        }


    }
}
