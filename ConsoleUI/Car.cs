using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    class Car : Vehicle
    {
        public string HasTrunk { get; set; }
        public override void DriveAbstract()
        {
            Console.WriteLine($"I am driving my car.");
        }

        //public virtual void DriveVirtual()
        //{
            //base.DriveVirtual();
            
        //}

    }
}
