using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    public class SearchElement
    {
        static int Search(int[]arr,int num)
        {
           for(int i = 0; i < num; i++)
            {
                if (arr[i] == num)
                {
                    return i;
                }
                
            }
         return -1;
        }
       /* static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, };
            int num = 5;
             int index =Search(arr,num);
            if(index != -1)
            {
                Console.WriteLine("Element find at index  " + index +" is equal to "+num);
            }
            else
            {
                Console.WriteLine("Element not found in an array");
            }
        }*/

    }
}
