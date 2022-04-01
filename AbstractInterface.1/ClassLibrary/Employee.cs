using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Employee : Person
    {
        public Employee(double salaryOfHour, double workingHour, string name, string surname, byte age):base(name,surname,age)
        {
            Age = age;
            this.SalaryOfHour = salaryOfHour;
            this.WorkingHour = workingHour;
        }
        public double SalaryOfHour { get; set; }

        double _workingHour;
        public double WorkingHour { get => _workingHour; set { if (value <= 8) this._workingHour = value; else Console.WriteLine("max 8 saat islemek olar!"); ; } }

        byte _age;
        public override byte Age { get => _age; set { if (value >= 18) this._age = value; else Console.WriteLine("Isleme huququnuz yoxdur!"); } }

        public double CalculateSalary()
        {

            if (SalaryOfHour * WorkingHour * 30 >= 250)
            {
                Console.WriteLine(SalaryOfHour * WorkingHour * 30);
                return SalaryOfHour * WorkingHour * 30;
            }
            Console.WriteLine(SalaryOfHour * WorkingHour * 30);
            Console.WriteLine("Ayliq maasiniz 250den asagi ola bilmez!");
            return -1;
        }
    }
}
