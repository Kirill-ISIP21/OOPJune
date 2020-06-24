using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        class Zoo
        {
            internal int Quantity;
            public string Name;
            public int Cost;
            public string Sex;
            public string Animals;
        }
        static void Main(string[] args)
        {
            Zoo ZooShop = new Zoo();
            Console.Write("Введите  кол-во животных: ");
            ZooShop.Quantity = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите Имя животного: ");
            ZooShop.Name = Convert.ToString(Console.ReadLine());
            Console.Write("Введите цену животного: ");
            ZooShop.Cost = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите возраст животного: ");
            ZooShop.Sex = Convert.ToString(Console.ReadLine());
            Console.Write("Введите животное: ");
            ZooShop.Animals = Convert.ToString(Console.ReadLine());
            Console.WriteLine(ZooShop.Quantity + " " + ZooShop.Name + " " + ZooShop.Cost + " " + ZooShop.Sex + " " + ZooShop.Animals);
            Console.ReadLine();
        }
    }
}
