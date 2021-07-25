using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        
        static void Main(string[] args)
        {            
            // Task 2 Asseessment 3 of 3
            string[] Room = { "Single", "Double", "Luxury", "Penhouse" }; // create array and assign values for room
            Double[] Rates = { 45.50, 99.99, 165.25, 1095.50 }; // create array and assign value for room rate
            Console.WriteLine(" Room Types ");

            for (int i = 0; i < Room.Length; i++) // display room type and rate per night
            {
                Console.WriteLine($"{i + 1}.{Room[i]} {Rates[i]:c} per night");
            }

            // Prompt user to enter the room type
            Console.WriteLine("Please select the room type 1, 2, 3 or 4 :");
            int RoomType = int.Parse(Console.ReadLine());

            // Prompt user to enter the number of nights
            Console.WriteLine("Please enter the number of nights :");
            int NoNights = int.Parse(Console.ReadLine());

            RoomType = RoomType - 1; // to get the index for that particular room type
                                     //NoNights = NoNights - 1; // to get the index for the number of nights

            //for(int i = 0; i <RoomType; i++)

            Console.WriteLine($"Thank you, the total cost for staying in the {Room[RoomType]} for {NoNights} nigh is {Rates[RoomType] * NoNights:c}");

        }
    }
}
