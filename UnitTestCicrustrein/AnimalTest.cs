using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestCicrustrein
{
    [TestClass]
    public class AnimalTest
    {
        [TestMethod]
        public void PlaceAnimalsInWagonsByOrderAndChooseTheMostEfficient_Should_PlaceCorrectly()
        {
            // Arrange
            Train train = new Train();
            int numberSmallCarnivores = 1;
            int numberMediumCarnivores = 0;
            int numberLargeCarnivores = 0;
            int numberSmallHerbivores = 0;
            int numberMediumHerbivores = 3;
            int numberLargeHerbivores = 2;

            // Act
            train.CreateAnimals(numberSmallCarnivores, numberMediumCarnivores, numberLargeCarnivores,
                                numberSmallHerbivores, numberMediumHerbivores, numberLargeHerbivores);

            train.CreateAnimalsDescending(numberSmallCarnivores, numberMediumCarnivores, numberLargeCarnivores,
                                numberSmallHerbivores, numberMediumHerbivores, numberLargeHerbivores);
            train.PlaceAnimalsInWagonsByOrderAndChooseTheMostEfficient();

            // Assert
            int expectedWagonCount = 2;
            Assert.AreEqual(expectedWagonCount, train.WagonList.Count, "The number of wagons should be exactly two.");
        }

    }
}
