using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems2
{
    internal class ArrayDeclaration
    {
        public static void ArrDeclaration()
        {
            //C# program to declare, initialize, input and print array elements

            /* Input array size */
            Console.Write("Enter size of array: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];

            /* Input elements in array */
            Console.WriteLine("Enter {0} elements in the array", size);
            for (int i = 0; i < size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            /*Print all elements of array*/
            Console.Write("\nElements in array are: ");
            for (int i = 0; i < size; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
            Console.ReadLine();
        }

    }
}
