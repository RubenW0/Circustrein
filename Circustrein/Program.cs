// See https://aka.ms/new-console-template for more information


using Circustrein;
using System.Globalization;

class Program
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

        //sort1
        //sort2
        //2x met beide sort
        //vergelijken
        // Step 3: Fill wagons


        train.FillWagons();

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
