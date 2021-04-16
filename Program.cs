using System;
using System.IO;
namespace Algorithms_and_Complexity
{
    class Program
    {
        static void Main()
        {
            // string road1 = "Road_1_256.txt";
            var road1 = File.ReadAllLines("Road_1_256");

            foreach (var line in road1)
            {
                string[] dataArray = line.Split(',');
            }
            Console.Write(road1);


            // string[] Road_1 = File.ReadAllLines(@"C:\Users\samwa\Documents\Computer Science\algorithms and complexity\Road_1_256");
            // Console.Write(Road_1);
            // Console.WriteLine("Hello World!");
        }
    }
}
