using System;

namespace Planner
{
    public class Building
    {

        // private
        private string _owner { get; set; }
        private string _designer = "Drew Harper";
        private DateTime _dateConstructed  { get; set; }
        private string _address  { get; set; }

        // public
        public int Stories { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }

        public double Volume
        {
            get
            {
                double Equation = Width * Depth * (3 * Stories);
                double EquationFloored = Math.Floor(Equation);
                return EquationFloored;
                // return Equation;
            }
        }

        public void Construct() => _dateConstructed = DateTime.Now;
        public void Purchase(string nameOfPurchaser) => _owner = nameOfPurchaser;

        public string address { get; set;}

        public Building(string address)
        {
            _address = address;
            Construct();
        }

        // constructor
        public void ShowBuilding()
        {
            Console.WriteLine(_address);
            Console.WriteLine("-----------");
            Console.WriteLine($"Designed by: {_designer}");

            Console.WriteLine($"Constructed on: {_dateConstructed.ToString("F")}");
            Console.WriteLine($"Owned by {_owner}");
            Console.WriteLine($"{Volume} cubed meters of space");
            Console.WriteLine();
        }
    }
}
