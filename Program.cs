using System;
using System.Threading;

namespace FactoryExercisePatternPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            bool correctInput;
            do {
                Console.Clear();
                correctInput = true;

                Console.WriteLine("Pick a data base.");
                Console.WriteLine("Type in sql, mongo, or list.");


                userInput = Console.ReadLine();

                if(userInput != "sql" && userInput != "mongo" && userInput != "list")
                {
                    correctInput = false;
                    Console.WriteLine("Invalid input.");
                    Thread.Sleep(1000);
                }
            } while (!correctInput);
            IDataAccess db = DataAccessFactory.GetDataAccessType(userInput);
            var products = db.LoadData();
            db.SaveData();

            foreach(var item in products)
            {
                Console.WriteLine($"Name: {item.Name}. Price: {item.Price}");
            }
        }
    }
}
