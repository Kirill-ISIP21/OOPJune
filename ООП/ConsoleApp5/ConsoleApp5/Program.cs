using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Book
    {
        private string Avtor;
        private string Title;
        private int Quantity;
        private bool Collection;
        public Book(string Avtor, bool Collection)
        {
            this.Avtor = Avtor;
            this.Collection = Collection;
        }
        public Book(string Avtor, string Title, int Quantity, bool Collection)
        {
            this.Avtor = Avtor;
            this.Title = Title;
            this.Quantity = Quantity;
            this.Collection = Collection;
        }
        public void Printout
            ()
        {
            Console.WriteLine("Автор - " + Avtor);
            Console.WriteLine("Название книги - " + Title);
            Console.WriteLine("Кол-во страниц - " + Quantity);
            Console.WriteLine("Коллекционное издание - " + Collection);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 - Только автор и коллекционное ли?\n2 -Заполнить всё");
            int Num = Convert.ToInt32(Console.ReadLine());
            if (Num == 1)
            {
                Book newBook1 = new Book("Автор", true);
                newBook1.Printout();
            }
            else if (Num == 2)
            {
                Book newBook2 = new Book("Автор", "какое-либо название", 10, true);
                newBook2.Printout();
            }
            Console.ReadLine();
        }
    }
}
