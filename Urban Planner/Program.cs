using System;

namespace Urban_Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            Building FiveOneTwo = new Building("512 Green Blvd");
            FiveOneTwo.Width = 50;
            FiveOneTwo.Depth = 10;
            FiveOneTwo.Stories = 2;
            Building EighteenHundred = new Building("1800 Mountain Road");
            EighteenHundred.Width = 60;
            EighteenHundred.Depth = 12;
            EighteenHundred.Stories = 9;
            Building OneOhOne = new Building("101 Nature Trail Bend");
            OneOhOne.Width = 10;
            OneOhOne.Depth = 30;
            OneOhOne.Stories = 4;

            FiveOneTwo.Construct();
            EighteenHundred.Construct();
            OneOhOne.Construct();

            FiveOneTwo.Purchase("Fred Rogers");
            EighteenHundred.Purchase("Anon");
            OneOhOne.Purchase("John Wark");

        }
    }
}
