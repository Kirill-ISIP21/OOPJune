using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        class TV
        {
            public int currentchannel = 0;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Перелючение канала + либо - ");
            TV Channel = new TV();
            bool tv = true;
            while (tv)
            {
                string Switch = Console.ReadLine();
                if (Switch == "+")
                {
                    Channel.currentchannel++;
                }
                else if (Channel.currentchannel == 100)
                {
                    Channel.currentchannel = 0;
                }
                else if (Switch == "-" && Channel.currentchannel == 0)
                {
                    Channel.currentchannel = 100;
                }
                else if (Switch == "-")
                {
                    Channel.currentchannel--;
                }
                Console.WriteLine("Выбран канал " + Channel.currentchannel);
            }
            Console.ReadLine();
        }
    }
}
