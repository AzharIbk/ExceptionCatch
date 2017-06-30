using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionCatch
{
    class MyClass
    {
        public void GetMas(int el)
        {
            //case3
           
            int[] mas = new int[el];
            Random rnd = new Random();

            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = i;
            }

            Console.WriteLine("Vvedite nomer elementa massiva");

            string num = Console.ReadLine();
            try
            {
                Console.WriteLine(mas[Int32.Parse(num)]);
            }
            catch (IndexOutOfRangeException i)
            {
                Console.WriteLine("Такого элемента в массиве нет");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void Mas()
        {
            Console.WriteLine("Vvedite nomer elementa massiva");
            string num = Console.ReadLine();
            int el = Int32.Parse(num);
            Console.WriteLine(mas[el]);


        }
    }
    class Program
    {
  
        static void Main(string[] args)
        {
            //Case1
            //string res = "test";
            //try
            //{
            //  WebRequest WR =WebRequest.Create(res);

            //}
            //catch(Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}


            //Case2

            //int n = Int32.Parse(Console.ReadLine());
            //int[] mas = new int[n];
            //Random rnd = new Random();

            //for (int i = 0; i < mas.Length; i++)
            //{
            //    mas[i] = i;
            //}

            //Console.WriteLine("Vvedite nomer elementa massiva");

            //string num = Console.ReadLine();
            //try
            //{
            //    Console.WriteLine(mas[Int32.Parse(num)]);
            //}
            //catch (IndexOutOfRangeException i)
            //{
            //    Console.WriteLine("Такого элемента в массиве нет");
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e);
            //}



            //case3
            MyClass m = new MyClass();
            try
            {
                m.GetMas();
            }
            catch(IndexOutOfRangeException i)
            {
                Console.WriteLine("Такого элемента  в массиве нет");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            Console.ReadKey();

        }
    }
}
