using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        class Buyer
        {
            public string Name;
            public string Surname;
            public string Patronymic;
            internal string Address;
        }
        static void Main(string[] args)
        {
            Buyer Buyer1 = new Buyer();
            Console.Write("Введите Имя: ");
            Buyer1.Name = Convert.ToString(Console.ReadLine());

            Console.Write("Введите фамилию: ");
            Buyer1.Surname = Convert.ToString(Console.ReadLine());

            Console.Write("Введите отчество: ");
            Buyer1.Patronymic = Convert.ToString(Console.ReadLine());

            Console.Write("Введите адрес: ");
            Buyer1.Address = Convert.ToString(Console.ReadLine());
            Console.WriteLine(Buyer1.Name + " " + Buyer1.Surname + " " + Buyer1.Patronymic + " " + Buyer1.Address);
            Console.ReadLine();
        }
    }
}
