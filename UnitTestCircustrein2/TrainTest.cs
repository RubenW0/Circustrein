using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Circustrein;

namespace UnitTestCicrustrein2
{
    [TestClass]
    public class TrainTest
    {
        [TestMethod]
        public void NumberofWagonsScenario1()
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
            Assert.AreEqual(expectedWagonCount, train.NumberOfWagons, "The number of wagons should be exactly two.");
        }

        [TestMethod]
        public void NumberofWagonsScenario2()
        {
            // Arrange
            Train train = new Train();
            int numberSmallCarnivores = 1;
            int numberMediumCarnivores = 0;
            int numberLargeCarnivores = 0;
            int numberSmallHerbivores = 5;
            int numberMediumHerbivores = 2;
            int numberLargeHerbivores = 1;

            // Act
            train.CreateAnimals(numberSmallCarnivores, numberMediumCarnivores, numberLargeCarnivores,
                                numberSmallHerbivores, numberMediumHerbivores, numberLargeHerbivores);

            train.CreateAnimalsDescending(numberSmallCarnivores, numberMediumCarnivores, numberLargeCarnivores,
                                numberSmallHerbivores, numberMediumHerbivores, numberLargeHerbivores);
            train.PlaceAnimalsInWagonsByOrderAndChooseTheMostEfficient();

            // Assert
            int expectedWagonCount = 2;
            Assert.AreEqual(expectedWagonCount, train.NumberOfWagons, "The number of wagons should be exactly two.");
        }

        [TestMethod]
        public void NumberofWagonsScenario3()
        {
            // Arrange
            Train train = new Train();
            int numberSmallCarnivores = 1;
            int numberMediumCarnivores = 1;
            int numberLargeCarnivores = 1;
            int numberSmallHerbivores = 1;
            int numberMediumHerbivores = 1;
            int numberLargeHerbivores = 1;

            // Act
            train.CreateAnimals(numberSmallCarnivores, numberMediumCarnivores, numberLargeCarnivores,
                                numberSmallHerbivores, numberMediumHerbivores, numberLargeHerbivores);

            train.CreateAnimalsDescending(numberSmallCarnivores, numberMediumCarnivores, numberLargeCarnivores,
                                numberSmallHerbivores, numberMediumHerbivores, numberLargeHerbivores);
            train.PlaceAnimalsInWagonsByOrderAndChooseTheMostEfficient();

            // Assert
            int expectedWagonCount = 4;
            Assert.AreEqual(expectedWagonCount, train.NumberOfWagons, "The number of wagons should be exactly four.");
        }

        [TestMethod]
        public void NumberofWagonsScenario4()
        {
            // Arrange
            Train train = new Train();
            int numberSmallCarnivores = 2;
            int numberMediumCarnivores = 1;
            int numberLargeCarnivores = 1;
            int numberSmallHerbivores = 1;
            int numberMediumHerbivores = 5;
            int numberLargeHerbivores = 1;

            // Act
            train.CreateAnimals(numberSmallCarnivores, numberMediumCarnivores, numberLargeCarnivores,
                                numberSmallHerbivores, numberMediumHerbivores, numberLargeHerbivores);

            train.CreateAnimalsDescending(numberSmallCarnivores, numberMediumCarnivores, numberLargeCarnivores,
                                numberSmallHerbivores, numberMediumHerbivores, numberLargeHerbivores);
            train.PlaceAnimalsInWagonsByOrderAndChooseTheMostEfficient();

            // Assert
            int expectedWagonCount = 5;
            Assert.AreEqual(expectedWagonCount, train.NumberOfWagons, "The number of wagons should be exactly five.");
        }

        [TestMethod]
        public void NumberofWagonsScenario5()
        {
            // Arrange
            Train train = new Train();
            int numberSmallCarnivores = 1;
            int numberMediumCarnivores = 0;
            int numberLargeCarnivores = 0;
            int numberSmallHerbivores = 1;
            int numberMediumHerbivores = 1;
            int numberLargeHerbivores = 2;

            // Act
            train.CreateAnimals(numberSmallCarnivores, numberMediumCarnivores, numberLargeCarnivores,
                                numberSmallHerbivores, numberMediumHerbivores, numberLargeHerbivores);

            train.CreateAnimalsDescending(numberSmallCarnivores, numberMediumCarnivores, numberLargeCarnivores,
                                numberSmallHerbivores, numberMediumHerbivores, numberLargeHerbivores);
            train.PlaceAnimalsInWagonsByOrderAndChooseTheMostEfficient();

            // Assert
            int expectedWagonCount = 2;
            Assert.AreEqual(expectedWagonCount, train.NumberOfWagons, "The number of wagons should be exactly two.");
        }

        [TestMethod]
        public void NumberofWagonsScenario6()
        {
            // Arrange
            Train train = new Train();
            int numberSmallCarnivores = 3;
            int numberMediumCarnivores = 0;
            int numberLargeCarnivores = 0;
            int numberSmallHerbivores = 0;
            int numberMediumHerbivores = 2;
            int numberLargeHerbivores = 3;

            // Act
            train.CreateAnimals(numberSmallCarnivores, numberMediumCarnivores, numberLargeCarnivores,
                                numberSmallHerbivores, numberMediumHerbivores, numberLargeHerbivores);

            train.CreateAnimalsDescending(numberSmallCarnivores, numberMediumCarnivores, numberLargeCarnivores,
                                numberSmallHerbivores, numberMediumHerbivores, numberLargeHerbivores);
            train.PlaceAnimalsInWagonsByOrderAndChooseTheMostEfficient();

            // Assert
            int expectedWagonCount = 3;
            Assert.AreEqual(expectedWagonCount, train.NumberOfWagons, "The number of wagons should be exactly three.");
        }

        [TestMethod]
        public void NumberofWagonsScenario7()
        {
            // Arrange
            Train train = new Train();
            int numberSmallCarnivores = 7;
            int numberMediumCarnivores = 3;
            int numberLargeCarnivores = 3;
            int numberSmallHerbivores = 0;
            int numberMediumHerbivores = 5;
            int numberLargeHerbivores = 6;

            // Act
            train.CreateAnimals(numberSmallCarnivores, numberMediumCarnivores, numberLargeCarnivores,
                                numberSmallHerbivores, numberMediumHerbivores, numberLargeHerbivores);

            train.CreateAnimalsDescending(numberSmallCarnivores, numberMediumCarnivores, numberLargeCarnivores,
                                numberSmallHerbivores, numberMediumHerbivores, numberLargeHerbivores);
            train.PlaceAnimalsInWagonsByOrderAndChooseTheMostEfficient();

            // Assert
            int expectedWagonCount = 13;
            Assert.AreEqual(expectedWagonCount, train.NumberOfWagons, "The number of wagons should be exactly thirteen.");
        }

        [TestMethod]
        public void NumberofWagonsScenario8()
        {
            // Arrange
            Train train = new Train();
            int numberSmallCarnivores = 0;
            int numberMediumCarnivores = 0;
            int numberLargeCarnivores = 0;
            int numberSmallHerbivores = 0;
            int numberMediumHerbivores = 0;
            int numberLargeHerbivores = 0;

            // Act
            train.CreateAnimals(numberSmallCarnivores, numberMediumCarnivores, numberLargeCarnivores,
                                numberSmallHerbivores, numberMediumHerbivores, numberLargeHerbivores);

            train.CreateAnimalsDescending(numberSmallCarnivores, numberMediumCarnivores, numberLargeCarnivores,
                                numberSmallHerbivores, numberMediumHerbivores, numberLargeHerbivores);
            train.PlaceAnimalsInWagonsByOrderAndChooseTheMostEfficient();

            // Assert
            int expectedWagonCount = 0;
            Assert.AreEqual(expectedWagonCount, train.NumberOfWagons, "The number of wagons should NULL.");
        }
    }
}
