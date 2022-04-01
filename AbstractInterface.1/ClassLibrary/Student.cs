using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Student : Person
    {
        public Student(double iqRank, double languageRank, string name, string surname, byte age):base(name,surname,age)
        {
            Age = age;
            this.LanguageRank = languageRank;
            this.IQRank = iqRank;
        }
        public double IQRank { get; set; }
        public double LanguageRank { get; set; }

        byte _age;
        public override byte Age { get => _age; set { if (6 <= value && value <= 20) this._age = value; } }

        public void ExamResult()
        {
            if((IQRank+LanguageRank)>120)
                Console.WriteLine("Ugurlar");
            else
                Console.WriteLine("Sinifde qaldiniz!");
        }
    }
}
