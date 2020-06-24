using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        class Health
        {
            private int Temp;
            public int Temperature
            {
                get
                {
                    return Temp;
                }
                set
                {
                    if (value < 34 || value > 41)
                        Console.WriteLine("Такой температуры не бывает ");
                    else
                        Console.WriteLine("Ваша температура составляет  " + value);
                }
            }
        }
        static void Main(string[] args)
        {
                Console.WriteLine("Введите температуру не  меньше 34 или не больше 41 ");
                int NumTemp = Convert.ToInt32(Console.ReadLine());
                Health newTem = new Health();
                newTem.Temperature = NumTemp;
                Console.ReadLine();
        }
    }
}
