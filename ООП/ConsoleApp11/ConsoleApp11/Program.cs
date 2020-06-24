using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            Tri trone = new Tri(8, 8, 8);
            trone.Display();
            Tri trtwo = new Tri(7, 9, 5);
            trtwo.Display();
            Tri tr3 = new Tri(30, 5, 14);
            tr3.Display();
            Console.ReadKey();
        }
    }
    class Tri
    {
        private bool Trig;
        private double A;
        private double B;
        private double G;
        public Tri(int l1, int l2, int l3)
        {
            double A = (Math.Acos((Math.Pow(l2, 2) + Math.Pow(l3, 2) - Math.Pow(l3, 2)) / (2 * l1 * l2))) * (180 / Math.PI);
            double B = (Math.Acos((Math.Pow(l1, 2) + Math.Pow(l2, 2) - Math.Pow(l1, 2)) / (2 * l2 * l3))) * (180 / Math.PI);
            double G = (Math.Acos((Math.Pow(l3, 2) + Math.Pow(l1, 2) - Math.Pow(l2, 2)) / (2 * l1 * l3))) * (180 / Math.PI);
            if ((l1 + l2 > l3) && (l2 + l3 > l1) && (l1 + l3 > l2))
            {
                Trig = true;
                A = A;
                B = B;
                G = G;
            }
            else
            {
                Trig = false;
            }
        }
        public void Display()
        {
            if (Trig == true)
            {
                Console.WriteLine($"\nКоординаты треугольника \n\n" +
                                  $"A : {A.ToString("##.#")}" +
                                  $"\nB : {B.ToString("##.#")}" +
                                  $"\nG: {G.ToString("##.#")}");
            }
            else
                Console.WriteLine("\nТреугольник не построить");
        }
    }
}
