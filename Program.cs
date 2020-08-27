using System;
using System.Collections.Generic;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            Building MartinsBBQ = new Building("123 Belmont Ave");
            MartinsBBQ.Width = 3000;
            MartinsBBQ.Depth = 5000;
            MartinsBBQ.Stories = 2;
            MartinsBBQ.Purchase("Martn Barbedude");

            Building EdleysBBQ = new Building("12 South");
            EdleysBBQ.Width = 1400;
            EdleysBBQ.Depth = 1800;
            EdleysBBQ.Stories = 2;
            EdleysBBQ.Purchase("Ed Barby");

            MartinsBBQ.ShowBuilding();
            EdleysBBQ.ShowBuilding();
        }

    }

}
