using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Reflection.Emit;
using System.Transactions;

namespace Task3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            task4();
        }






        static void task1()
        {
            //a massivinin(a[0], a[1] ....a[n])  | a[i] | < c sertini odeyen elementlerini cap etmek
            //(c deyisheninin qiymeti istifadeciden sorushulur, hemcinin a massivinin elementleri de)
            Console.WriteLine("                 Programa xosh gelmisiniz ");
            Console.Write("Massivin uzunlugu :");
            int size = yoxlama();
            Console.WriteLine("Ededler");
            int[] arr1 = new int[size];
            for (int i = 0; i < arr1.Length; i++)
            {

                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("c ededini daxil edin :");
            int c= yoxlama();
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i]<c)
                {
                    Console.Write("c- den kicik eded :");
                    Console.WriteLine(arr1[i]);
                }
            }

            
           

        }
        static void task2()
        {
            //2.  a massivinin (a[0],a[1] .... a[n])  |a[i]| < c sertini odeyen elementlerinin ededi ortasini tapmaq
            Console.WriteLine("                 Programa xosh gelmisiniz ");
            Console.Write("Massivin uzunlugu :");
            int size = yoxlama();
            Console.WriteLine("Ededler");
            int[] arr1 = new int[size];
          
            for (int i = 0; i < arr1.Length; i++)
            {

                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("c ededini daxil edin :");
            int c = yoxlama();
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] < c)
                {
                    Console.Write("c- den kicik eded :");
                    Console.WriteLine(arr1[i]);
                }   
            }
          
        }
        static void task3()
        {

        }
        static void task4()
        {
            // a massivinin (a[0],a[1] .... a[n])  |a[i]| > c sertini odeyen elementlerini coxdan aza dogru siralamaq
            Console.WriteLine("               Programa xosh gelmisiniz");
            Console.Write("Massivin uzunlugu :");
            int size = yoxlama();
            Console.WriteLine("Ededler");
            int[] arr2 = new int[size];
            int b = 0;

            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("C ededini daxil edin");
            int c = yoxlama();
            for (int i = 0; i < arr2.Length; i++)
            {
                if (arr2[i] > c)
                {
                    Console.WriteLine("C-den boyuk ededler :" + arr2[i]);
                }
            }





























        }




        static double avarage(int[]massiv)
        {
            int sum = 0;
            for (int i = 0; i < massiv.Length; i++)
            {
                sum = sum + massiv[i];
            }
            double avarage = (double)(sum / massiv.Length);
            return avarage;


 
        }
        static int yoxlama()
        {
            int a;
            Label1:
            string inputvalue = Console.ReadLine();
            int.TryParse(inputvalue, out a);
            if (int.TryParse(inputvalue, out a) != true)
            {
                Console.WriteLine("Tam ededi daxil edin");
                goto Label1;
            }
            else
            {
                return a;
            }
        }
    }
}














