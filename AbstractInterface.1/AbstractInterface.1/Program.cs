using System;
using ClassLibrary;

namespace AbstractInterface._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(15, 9, "ferid", "cahangirli", 16);
            employee.CalculateSalary();

            Student student = new Student(70, 60, "ferid", "cahangirli", 21);
            Console.WriteLine(student.Age);
            student.ExamResult();
        }
    }
}
