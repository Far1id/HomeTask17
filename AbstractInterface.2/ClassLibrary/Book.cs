using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Book : Product
    {
        public string Author;
        public string Genre;

        public override void GetInfo()
        {
            Console.WriteLine($"Author : {Author} Genre : {Genre}");
        }

    }
}
