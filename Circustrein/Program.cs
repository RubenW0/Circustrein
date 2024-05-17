using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Circustrein;

namespace Circustrein
{
    internal class Program
    {
        static void Main()
        {
            Train train = new Train();

            Console.WriteLine("How many small carnivores?");
            int numberSmallCarnivores = GetIntInput();
            Console.WriteLine("How many medium carnivores?");
            int numberMediumCarnivores = GetIntInput();
            Console.WriteLine("How many large carnivores?");
            int numberLargeCarnivores = GetIntInput();
            Console.WriteLine("How many small herbivores?");
            int numberSmallHerbivores = GetIntInput();
            Console.WriteLine("How many medium herbivores?");
            int numberMediumHerbivores = GetIntInput();
            Console.WriteLine("How many large herbivores?");
            int numberLargeHerbivores = GetIntInput();

            Console.WriteLine($"Number of small carnivores: {numberSmallCarnivores}");
            Console.WriteLine($"Number of medium carnivores: {numberMediumCarnivores}");
            Console.WriteLine($"Number of large carnivores: {numberLargeCarnivores}");
            Console.WriteLine($"Number of small herbivores: {numberSmallHerbivores}");
            Console.WriteLine($"Number of medium herbivores: {numberMediumHerbivores}");
            Console.WriteLine($"Number of large herbivores: {numberLargeHerbivores}");

            train.CreateAnimals(numberSmallCarnivores, numberMediumCarnivores, numberLargeCarnivores,
                            numberSmallHerbivores, numberMediumHerbivores, numberLargeHerbivores);

            train.CreateAnimalsDescending(numberSmallCarnivores, numberMediumCarnivores, numberLargeCarnivores,
                            numberSmallHerbivores, numberMediumHerbivores, numberLargeHerbivores);

            train.PlaceAnimalsInWagonsByOrderAndChooseTheMostEfficient();

            train.PrintDistribution();

            static int GetIntInput()
            {
                while (true)
                {
                    string input = Console.ReadLine();
                    if (int.TryParse(input, out int result))
                    {
                        return result;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                    }
                }
            }

        }
    }

}

