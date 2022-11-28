using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_HW34
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Random rand = new Random();
            
            void PrintArray(int[] arr)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(arr[i] + " ");
                }
            }

            void FillArray(int[] arr)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                   arr[i] = rand.Next(100, 1000);
                }
                
            }

            void Even(int[] arr)
            {
                int n = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 == 0)
                    {
                        n++;
                    }
                }
                Console.WriteLine($"\nКоличество четных чисел: {n}");
            }


            FillArray(array);
            PrintArray(array);
            Even(array);
            
        }
    }
}
