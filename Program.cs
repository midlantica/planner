using System;
using System.Collections.Generic;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("woohoo!");

            List<string> inventory = new List<string>();
            inventory.Add("batteries");
            inventory.Add("golf tees");
            inventory.Add("zippers");
            inventory.Add("cabin accessories");

            // Make a new instance of a Store
            Store myStore = new Store("Stuff 'n' Things", inventory);
            Console.WriteLine($"ssssssssssssssss" + myStore);

        }

    }

}
