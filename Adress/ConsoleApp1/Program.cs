using System;

namespace ConsoleApp1
{
    class Adress
    {
            internal class Address
        {
            public string index;
            public string country;
            public string city;
            public string street;
            public string house;
            public string apartment;

            public void Print()
            {
                Console.WriteLine($"Index: {index};");
                Console.WriteLine($"Country: {country};");
                Console.WriteLine($"City: {city};");
                Console.WriteLine($"Street: {street};");
                Console.WriteLine($"House: {house};");
                Console.WriteLine($"Apartment: {apartment}.");
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Address address = new Address();
                address.index = "02156";
                address.country = "Ukraine";
                address.city = "Kyiv";
                address.street = "Kioto";
                address.house = "19";
                address.apartment = "A";
                address.Print();
            }
        }
        
    }
}
    