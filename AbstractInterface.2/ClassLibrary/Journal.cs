using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Journal : Product
    {
        public string Company;

        public override void GetInfo()
        {
            Console.WriteLine($"Company : {Company} ");
        }

    }
}
