using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet
{
   
    internal class BubbleSort
    {
       
        public void Sort(int[] arr)
        {
            int n = arr.Length;
            bool swapped;

           
            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;

                
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])  
                    {
                        
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;

                        swapped = true;  
                    }
                }

                
                if (!swapped)
                {
                    break;
                }
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Enter the number of elements in the array:");
            int n = Convert.ToInt32(Console.ReadLine());

            
            int[] arr = new int[n];

            
            Console.WriteLine("Enter the elements of the array:");

            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            
            BubbleSort bubbleSort = new BubbleSort();

           
            Console.WriteLine("\nArray before sorting:");
            PrintArray(arr);

           
            bubbleSort.Sort(arr);

            
            Console.WriteLine("\nArray after sorting:");
            PrintArray(arr);
        }

       
        static void PrintArray(int[] arr)
        {
            foreach (var num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
