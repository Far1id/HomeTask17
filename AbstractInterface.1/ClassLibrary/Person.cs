using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public abstract class Person
    {
        public Person(string name, string surname, byte age)
        {
            this.Age = age;
            this.Name = name;
            this.Surname = surname;
        }
        public string Name { get; set; }
        public string Surname { get; set; }
        public abstract byte Age { get; set; }

       

    }
}
