using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Book
    {
        private int Year;
        public int GeYear
        {
            get
            {
                return Year;
            }
            set
            {
                if (value > 1940 && value < 2020)
                    Console.WriteLine("Год выпуска  в диапозоне  от 1940 до 2020, выпуск: " + value);
                else
                    Console.WriteLine("Год выпуска не в диапозоне  от 1940 до 2020");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите год в  диапозоне от 1940 до 2020");
            int YearBook = Convert.ToInt32(Console.ReadLine());
            Book Booknew = new Book();
            Booknew.GeYear = YearBook;
            Console.ReadLine();
        }
    }
}
