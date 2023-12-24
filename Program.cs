using System;
using System.Collections.Generic;
using sdc1_knowledge_check_2.Models;

namespace sdc1_knowledge_check_2
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("How many records do you want to add? ");
            var numberOfRecords = int.Parse(Console.ReadLine());

            var recordList = new List<Food>();
            for (int i = 0; i < numberOfRecords; i++)
            {
	            // In this loop, populate the object's properties using Console.ReadLine()
	            var food = new Food();

                Console.WriteLine($"Enter the Name: ({i + 1} of {numberOfRecords})");
                food.Name = Console.ReadLine();
                Console.WriteLine($"Enter the Description of {food.Name}: ({i + 1} of {numberOfRecords})");
                food.Description = Console.ReadLine();
                Console.WriteLine($"Enter the Quantity of {food.Name}: ({i + 1} of {numberOfRecords})");
                var readQuantity = Console.ReadLine();
                if (int.TryParse(readQuantity, out int validQuantity))
                {
                    food.Quantity = int.Parse(readQuantity);
                }
                else
                {
                    throw new Exception($"{readQuantity} is not a valid Quantity.");
                }
                Console.WriteLine($"Enter the UPC of {food.Name}: ({i + 1} of {numberOfRecords})");
                food.UPC = Console.ReadLine();
                Console.WriteLine($"Enter the Location of {food.Name}: ({i + 1} of {numberOfRecords})");
                food.Location = Console.ReadLine();
                Console.WriteLine($"Enter the Price of {food.Name}: ({i + 1} of {numberOfRecords})");
                var readPrice = Console.ReadLine();
                if (decimal.TryParse(readPrice, out decimal validPrice))
                {
                    food.Price = decimal.Parse(readPrice);
                }
                else
                {
                    throw new Exception($"{readPrice} is not a valid Price.");
                }

                recordList.Add(food);
                Console.Clear();
            }

            // Print out the list of records using Console.WriteLine()
            Console.WriteLine($"food.Id,food.Name,food.Description,food.Quantity,food.UPC,food.Location,food.Price");
            foreach (var food in recordList)
            {
                Console.WriteLine($"{food.Id},{food.Name},{food.Description},{food.Quantity},{food.UPC},{food.Location},{food.Price}");
            }
        }
    }
}