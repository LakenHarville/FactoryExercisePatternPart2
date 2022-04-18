using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryExercisePatternPart2
{
    class ListDataAccess : IDataAccess
    {
        public static List<Product> Products = new List<Product>
        {
            new Product(){Name = "Shoes", Price = 250},
            new Product(){Name = "Shirt", Price = 20},
            new Product(){Name = "Pants", Price = 50},
            new Product(){Name = "Belt", Price = 34},
        };
        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from List Data Access.");

                return Products;
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data from a List Data Access");
        }
    }
}
