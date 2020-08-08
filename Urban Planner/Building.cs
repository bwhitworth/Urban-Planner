using System;
using System.Collections.Generic;
using System.Text;

namespace Urban_Planner
{
    class Building
    {
        private string _designer = "Bethany";
        private DateTime _dateConstructed = new DateTime();
        private string _address = "";
        private string _owner = "";

        public int Stories { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        public double Volume { get; private set; }

        public Building(string address)
        {
            _address = address;
        }

        public void Construct()
        {
            _dateConstructed = DateTime.Now;
            Volume = 3 * Stories * Width * Depth;
        }

        public void Purchase(string nameOfOwner)
        {
            _owner = nameOfOwner;
            Console.WriteLine(
                $"{_address}------\n" +
                $"Designed by {_designer}\n" +
                $"Constructed on {_dateConstructed}\n" +
                $"Owned by {_owner}\n" +
                $"{Volume} cubic meters of space\n"
                );
        }
    }
}
