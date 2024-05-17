using Circustrein;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestCircustrein
{
    [TestClass]
    public class WagonTest
    {
        [TestMethod]
        public void CanAddAnimal_ShouldReturnTrue_WhenTotalPointsWithNewAnimalIsLessThanOrEqualTo10()
        {
            // Arrange
            var wagon = new Wagon();
            var animal = new Animal(Animal.Diet.Carnivore, Animal.Size.Large);

            // Act
            bool result = wagon.CanAddAnimal(animal);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanAddAnimal_WhenWagonIsFull_ShouldReturnFalse()
        {
            // Arrange
            var wagon = new Wagon();
            wagon.AddAnimal(new Animal(Animal.Diet.Carnivore, Animal.Size.Large));
            wagon.AddAnimal(new Animal(Animal.Diet.Carnivore, Animal.Size.Large));

            var newAnimal = new Animal(Animal.Diet.Herbivore, Animal.Size.Medium);

            // Act
            bool result = wagon.CanAddAnimal(newAnimal);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CanAddAnimal_WhenAddingHerbivoreWithCarnivore_ShouldReturnFalse()
        {
            // Arrange
            var wagon = new Wagon();
            wagon.AddAnimal(new Animal(Animal.Diet.Carnivore, Animal.Size.Large));

            var newAnimal = new Animal(Animal.Diet.Herbivore, Animal.Size.Large);

            // Act
            bool result = wagon.CanAddAnimal(newAnimal);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CanAddAnimal_WhenAddingSmallerCarnivoreWithLargerCarnivore_ShouldReturnFalse()
        {
            // Arrange
            var wagon = new Wagon();
            wagon.AddAnimal(new Animal(Animal.Diet.Carnivore, Animal.Size.Large));

            var newAnimal = new Animal(Animal.Diet.Carnivore, Animal.Size.Small); 

            // Act
            bool result = wagon.CanAddAnimal(newAnimal);

            // Assert
            Assert.IsFalse(result);
        }



    }
}