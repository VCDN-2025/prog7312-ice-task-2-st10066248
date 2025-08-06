using System;

namespace TravelItineraryPlanner
{
    class Program
    {
        static void Main(string[] args)
        {
            var itinerary = new CustomArray<Destination>();

            // Add destinations
            itinerary.Add(new Destination("Paris", "France", "City of Light"));
            itinerary.Add(new Destination("Tokyo", "Japan", "Land of the Rising Sun"));
            itinerary.Add(new Destination("Sydney", "Australia", "Harbour City"));

            // Print all
            Console.WriteLine("All destinations:");
            itinerary.PrintAll();

            // Search
            var searchDest = new Destination("Tokyo", "Japan", "Land of the Rising Sun");
            Console.WriteLine($"\nContains Tokyo? {itinerary.Contains(searchDest)}");

            // Remove and reprint
            itinerary.Remove(searchDest);
            Console.WriteLine("\nAfter removal of Tokyo:");
            itinerary.PrintAll();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
