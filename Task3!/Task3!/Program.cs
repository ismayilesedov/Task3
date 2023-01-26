using System;
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
            Console.ForegroundColor = ConsoleColor.Red;
           
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
            int c = yoxlama();
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] < c)
                {
                    Console.Write("c- den kicik eded :");
                    Console.WriteLine(arr1[i]);
                }
            }




        }//++
        static void task2()
        {
            //2.  a massivinin (a[0],a[1] .... a[n])  |a[i]| < c sertini odeyen elementlerinin ededi ortasini tapmaq
            Console.WriteLine("         Programa xosh gelmisiniz");
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
            double sum = 0;
            int count = 0;
            double ave;
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] < c)
                {
                    Console.WriteLine("C-den kicik ededler :" + arr1[i]);

                    sum += arr1[i];
                    count++;
                }
                
            }
            ave = (double)sum / count;
            Console.WriteLine($"ededi orta = {ave}");

        }//++
        static void task3()
        {
            // a massivinin (a[0],a[1] .... a[n])  |a[i]| > c sertini odeyen elementlerinin hendesi ortasini tapmaq
            Console.WriteLine("      Programa xosh gelmisiniz");
            Console.Write("Massivin uzunlugu : ");
            int a = yoxlama();
            Console.WriteLine("Ededler");
            int[] arr1 = new int[a];
            for (int i = 0; i < arr1.Length; i++)
            {

                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("C ededini daxil edin");
            int c=yoxlama();
            double math = 1;
            int count = 0;
            foreach (var item in arr1)
            {
                if (item>c)
                {
                    math *= item;
                    count++;
                }
            }
            math = Math.Pow(math, 1 / count);
            Console.WriteLine($"{c} boyuk ededlerin "+$"{count} dereceden koku ={math}");








        }//++
        static void task4()
        {
            // a massivinin (a[0],a[1] .... a[n])  |a[i]| > c sertini odeyen elementlerini coxdan aza dogru siralamaq
            Console.WriteLine("               Programa xosh gelmisiniz");
            Console.Write("Massivin uzunlugu: ");
            int size = yoxlama();
            Console.WriteLine("Ededler");
            int[] arr2 = new int[size];
            

            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("C ededini daxil edin");
            int c = yoxlama();
            for (int i = 0; i < arr2.Length; i++)
            {
                int j = i - 1;
                int temp = arr2[i];
                while (j >= 0 && arr2[j]<temp)
                {
                    arr2[j + 1] = arr2[j];
                    j--;
                }
                arr2[j + 1] = temp;
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                if (arr2[i]>c)
                {
                    Console.WriteLine(arr2[i]);
                }
            }
        }//++
        static void task5()
        {
            // a massivinin (a[0],a[1] .... a[n])  |a[i]| < c sertini odeyen elementler icinden maximum elementi tapmaq
            Console.WriteLine("          Programa xosh gelmisiniz");
            Console.Write("Massivin olcusu :");
            int size = yoxlama();
            Console.WriteLine("Ededler");
            int[] arr1 = new int[size];
            int b=0;
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("c ededini daxil edin :");
            int c = yoxlama();
            int max = 0;
           
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i]<c)
                {
                    max = arr1[i];
                }               
            }
            Console.WriteLine("max eded :"+max);
            
            

           
        }//++
        static void task6()
        {
            // X(n) ve Y(n) deye 2 massiv verilmishdir/Ele x[i] elementi tapmaq lazimdir ki x[i] = y[i] ^ 2 
            Console.WriteLine("massivin uzunlugu");
            int n = yoxlama();
            int[]y=new int[n];
            int[]x=new int[n];
            for (int i = 0; i < y.Length; i++)
            {
                Console.Write($"a[{i}]=");
                y[i]=int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < y.Length; i++)
            {
                x[i] = y[i] * y[i];
                Console.WriteLine($"{x[i]}  ");
            }
        }//++
        static void task7()
        {
            Console.WriteLine("massivin uzunlugu");
            int n = yoxlama();
            int[] array = arraymaker(n);
            Array.Sort(array);
            double ArrMin = array[0];
            Console.WriteLine($"en kicik element={ArrMin}");
            int Arrmax = array[array.Length-1];
            Console.WriteLine($"en boyuk element={Arrmax}");
            double edediorta=(ArrMin+Arrmax)/2;
            Console.WriteLine($"ededi orta={edediorta:0###}");
            double hendesiorta = Math.Sqrt(ArrMin * Arrmax);
            Console.WriteLine($"hendesi orta={hendesiorta:###}");

        }//++
        static void task8()
        {
            //Heriri 14 elementli 2 massivin uygun elementlerini bir birine vurub?alinan musbet hasillerden  yeni massiv duzeltmeli
            int[] y = { 3, 9, 11, 12, 75, 10, 5, 20, 31, 3, 1, 2, 6, 10 };
            int[] x = { 5, 7, 6, 10, 30, 21, 11, 33, 7, 8, 4, 5, 6, 4};
            int[] z = new int[14];
            for (int i = 0; i < 14; i++)
            {
                z[i] = x[i] * y[i];
            }
            foreach (var item in z)
            {
                Console.WriteLine($"{item}");
            }
        }//++
        static void task9()
        {
            //25 elementli massivin ilk 8 elementini kvadrata yukseltmeli,qalanini ise 4-e bolub,yeni iki massiv duzeltmeli
            int[] y = { 1, 4, 6, 14, 20, 15, 16, 10, 1, 12, 8, 9, 7, 13, 14, 3, 9, 2, 1, 23, 11, 18, 3, 8, 14 };
            int[] z = new int[8];
            double[]x=new double[17];
            for (int i = 0; i < 8; i++)
            {
                z[i] = y[i] * y[i];
            }
            for (int i = 0; i < 17; i++)
            {
                x[i] = (double) y[i + 8] / 4;
            }
            foreach (var item in z)
            {
                Console.WriteLine("1 ci massiv  :"+item);
            }
            Console.WriteLine("--------------------------------------------------");
            foreach (var item in x)
            {
                Console.WriteLine("2 ci massiv :"+item);
            }
        }//++
        static void task10()
        {
            //X(n) massivinden ancaq menfi elementlerin maximum elementi tapin
            Console.WriteLine("Massivin uzunlugu");
            int lenght = yoxlama();
            Console.WriteLine("massivin elementlerini daxil edin");
            int[]array=arraymaker(lenght);
            int answer = int.MinValue;
            foreach (var item in array)
            {
                if (item<0&&item>answer)
                {
                    answer = item;
                }
            }
            Console.WriteLine($"massivin en boyuk menfi elementi={answer}");   
        }//++
        static void task11()
        {
           // X(n) massivinin elementlerini random olaraq 0 - 100 arasi ededlerle doldurub,sonra ise azalma sirasina gore duzmeli
            Console.WriteLine( "            Programa xosh gelmisiniz");
            Random  random=new Random();
            int size = random.Next(0, 100);
            int[]arr1=new int[10];
            for (int i = 0; i < arr1.Length; i++)
            {
                int a = random.Next(0, 100);
                arr1[i]=a;
            }
            foreach (var item in arr1)
            {
                Console.WriteLine(item);
            }
            int temp;
            for (int i = 0; i < arr1.Length-1; i++)
            {
                for (int j = i+1; j < arr1.Length; j++)
                {
                    if (arr1[i] < arr1[j])
                    {
                        temp = arr1[j];
                        arr1[j] = arr1[i];
                        arr1[i] = temp;
                        
                    }
                }
            }
            foreach (var item in arr1)
            {
                Console.WriteLine("Sira ile duzulus :"+item);
            }

        }//++
        static void task12()
        {
            //(20) massivinin ilk yarisinin ededi ortasini ikinci yarisinin hendesi ortasini tapmaq
            Console.WriteLine("20 element daxil edin");
            int[] arr = arraymaker(20);
            double ededi = 0;
            double hendesi = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i<10)
                {
                    ededi += arr[i];
                   
                }
                else
                {
                    hendesi *= arr[i];
                }
            }
            ededi /= 10;
            hendesi = Math.Pow(10, 1 / 10);
            Console.WriteLine($"Ededi orta ={ededi},Hendesi orta ={hendesi:0.###}");
        }//++








        static double avarage(int[] massiv)
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
        static int[] arraymaker(int size)
        {
            int[] arr1 = new int[size];
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine($"{i+1}. elementi daxil edin");
                arr1[i] = yoxlama();
            }
            return arr1;
        }
    }
}

















