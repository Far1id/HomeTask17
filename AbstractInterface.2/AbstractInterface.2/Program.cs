using System;
using ClassLibrary;

namespace AbstractInterface._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            library.AddProduct (new Book()
            {
                Author = "Elxan",
                Name = "Kitab1",
                Genre = "Dram",
                Price = 20
            });
            library.AddProduct (new Journal()
            {
                Company = "Ferid mmc",
                Name = "jurnal1",
                Price = 15
            });
            library.GetInfo();
        }
    }
}
