using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Person

    {
        private string Name;
        private string SurName;
        public Person()
        {
            Name = "And";
        }
        public Person(string Name, string Surname)
        {
            Name = Name;
            SurName = Surname;
        }
        public string FirstName
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }
        public string LastName
        {
            get
            {
                return SurName;
            }
            set
            {
                SurName = value;
            }
        }
        public void Display()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }
    class Employee : Person
    {
        private string Compa;
        public Employee(string name, string surname, string company) : base(name, surname)
        {
            Company = company;
        }
        public string Company
        {
            get { return Compa; }
            set { Compa = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person Pers = new Person("Чухарев", "Кирилл");
            Employee Empl = new Employee("Эдуардов", "Эдуард", "Яндекс");
            Pers.Display();
            Empl.Display();
            Console.ReadLine();
        }
    }
}
