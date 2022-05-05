using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    class Motorcycle : Vehicle
    {
        public string HasCart { get; set; }
        public override void DriveAbstract()
        {
            Console.WriteLine("I am driving my motorcycle.");
        }

        public override void DriveVirtual()
        {
            //base.DriveVirtual();
            Console.WriteLine("I am driving my motorcycle (virtual).");
        }

    }
}
