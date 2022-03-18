using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Calculator";

            Console.WriteLine("Pilih menu calculator : ");
            Console.WriteLine("\n1. Penambahan");
            Console.WriteLine("\n2. Pengurangan");
            Console.WriteLine("\n3. Perkalian");
            Console.WriteLine("\n4. Pembagian");

            Console.WriteLine("\nInput nomor menu [1 - 4] : ");
            int menu = int.Parse(Console.ReadLine());


            if(menu == 1)
            {
                Console.WriteLine("Inputkan nilai a = ");
                float a = float.Parse(Console.ReadLine());

                Console.WriteLine("Inputkan nilai b = ");
                float b = float.Parse(Console.ReadLine());

                Console.WriteLine("Hasil Penambahan {0} + {1} = {2}", a, b, penambahan(a, b));
            }
            
            else if(menu == 2)
            {
                Console.WriteLine("Inputkan nilai a = ");
                float a = float.Parse(Console.ReadLine());

                Console.WriteLine("Inputkan nilai b = ");
                float b = float.Parse(Console.ReadLine());

                Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}", a, b, pengurangan(a,b));
            }
            

            else if(menu == 3)
            {
                Console.WriteLine("Inputkan nilai a = ");
                float a = float.Parse(Console.ReadLine());

                Console.WriteLine("Inputkan nilai b = ");
                float b = float.Parse(Console.ReadLine());

                Console.WriteLine("Hasil Perkalian {0} * {1} = {2}", a, b, perkalian(a,b));
            }
            
            else if(menu == 4)
            {
                Console.WriteLine("Inputkan nilai a = ");
                float a = float.Parse(Console.ReadLine());

                Console.WriteLine("Inputkan nilai b = ");
                float b = float.Parse(Console.ReadLine());

                Console.WriteLine("Hasil Pembagian {0} / {1} = {2}", a, b, pembagian(a,b));
            }

            else
            {
                Console.WriteLine("Perintah tidak diketahui");
            }
           

            Console.WriteLine("\nTekan sembarang key untuk keluar");
            Console.ReadKey();
        }
        static float penambahan(float a, float b)
        {
            return a + b;
        }

        static float pengurangan(float a, float b)
        {
            return a - b;
        }

        static float perkalian(float a, float b)
        {
            return a * b;
        }

        static float pembagian(float a, float b)
        {
            return a / b;
        }
    }
}
