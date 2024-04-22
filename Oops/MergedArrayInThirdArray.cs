using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
     public  class MergedArrayInThirdArray
    {
        static int[] MergeArrays(int[] arr, int[] arr1)
        {
            int[] arr3= new int[arr.Length+arr1.Length] ;
            for(int i = 0; i<arr.Length; i++)
            {
                arr3[i]= arr[i];    
            }
            for(int i = 0;i<arr1.Length; i++)
            {
                arr3[arr1.Length+i]= arr1[i];
            }
            return arr3;
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4 };
            int[]arr1= { 5,6,7,8 };

            int[] arr3= MergeArrays(arr, arr1);
            for(int i = 0;i< arr3.Length; i++)
            {
                Console.WriteLine(arr3[i] + " ");
            }
        }
    }
}
