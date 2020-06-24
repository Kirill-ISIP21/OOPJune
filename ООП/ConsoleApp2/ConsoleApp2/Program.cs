using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        class Subscriber
        {
            internal int Id;
            public string Name;
            public string Surname;
            public string Patronymic;
            internal string Address;
            internal int Distance;
        }
        static void Main(string[] args)
        {
            Subscriber Subscriber = new Subscriber();
            Console.Write("Введите id абитуриента: ");
            Subscriber.Id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите Имя абитуриента: ");
            Subscriber.Name = Convert.ToString(Console.ReadLine());
            Console.Write("Введите фамилию абитуриента: ");
            Subscriber.Surname = Convert.ToString(Console.ReadLine());
            Console.Write("Введите отчество абитуриента: ");
            Subscriber.Patronymic = Convert.ToString(Console.ReadLine());
            Console.Write("Введите адресс абитуриента: ");
            Subscriber.Address = Convert.ToString(Console.ReadLine());
            Console.Write("Введите расстояние абитуриента: ");
            Subscriber.Distance = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Subscriber.Id + " " + Subscriber.Name + " " + Subscriber.Surname + " " + Subscriber.Patronymic + " " + Subscriber.Address + " " + Subscriber.Distance);
            Console.ReadLine();
        }
    }
}
