using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    public class Program

    {

        static void Main(string[] args)
        {
            /* Shoping s1 = new Shoping(1, "Laptop", 45000, 2);
             s1.ShowShoppingDetails();*/

            /* Student student = new Student();
             student .id = 1;
             student.name = "Rahul namekar";
             student.marks1 = 50;
             student.marks2 = 50;
             student.marks3 = 50;
             student.DisplayStudentDetails();
             student.ClculatePercentage();
             student.ShowAllDetails();*/


            /*  Circle c1 = new Circle(5);
              c1.CalculateArea();
              Console.WriteLine(c1.Print());

              Rectangle r1 = new  Rectangle(8,5);
              r1.CalculateArea();
              Console.WriteLine(r1.Print());*/

            /* OverloadindCalculate o1 = new OverloadindCalculate();
             o1.Calculate(14.5);
             o1.Calculate(12, 15);
             o1.Calculate(12.4, 12.5);
             o1.Calculate(12.5f);*/

            /* job j1= new job();
             Console.WriteLine( "Tax for job="+(j1.PayTax()));

             Buisiness b1 = new Buisiness();
             Console.WriteLine("Tax for Buisiness=" + (b1.PayTax()));*/

            // working with explict interface implemenation

            /* ICustomer c1 = new Trasaction();

             Console.WriteLine(c1.Print()); // customer 

             IOrder o1 = new Trasaction();
             Console.WriteLine(o1.Print()); // order*/

            /* Calc c1 = new Calc();
             c1.Sub(30, 20);
             c1.Add(30, 20);
             c1.Mul(30, 20);
             c1.Div(30, 20);
             Console.WriteLine("Addition is = "+(c1.Add(20, 60)));*/

            // product array


            /*  Product[] products = new Product[]
              {
              new Product { Id = 1 , Name =  "Laptop", Price = 999.99 },
              new Product { Id = 2 ,Name = "Phone", Price = 699.99  },
              new Product { Id = 3 ,Name = "Headphones", Price = 149.99 }
              };


              foreach (Product product in products)
              {
                  Console.WriteLine("Id: " + product.Id);
                  Console.WriteLine("Name: " + product.Name);
                  Console.WriteLine("Price: " + product.Price);

                  Console.WriteLine();
              }*/

            /* int[] arr = new int[] { 80, 45, 12, 78, 1 };
             int[] arr1 = new int[3];
             foreach (int i in arr)
             {
                 console.writeline(i);


             }

             array.sort(arr);
             console.writeline("----sort----");
                 foreach (int i in arr)
             {
                 console.writeline(i);


             }
             array.reverse(arr);
             console.writeline("----reverse----");
             foreach (int i in arr)
             {
                 console.writeline(i);


             }
             array.copy(arr,2 ,arr1,0,3);
             console.writeline("----copy arr elements in arr1----");
             foreach (int i in arr1)
             {
                 console.writeline(i);
             }

             array.clear(arr, 1, 1);
             console.writeline("----clear arr elements at index 1----");
             foreach (int i in arr)
             {
                 console.writeline(i);
             }*/
            //___________________________________________________________________//
            /*string [] arr = new string[] {"rahul", "rushikesh", "onkar", "shreyash", "pravin" };
            string[] arr1 = new string[3];
            foreach (string i in arr)
            {
                Console.WriteLine(i);


            }

            Array.Sort(arr);
            Console.WriteLine("----sort----");
            foreach (string i in arr)
            {
                Console.WriteLine(i);


            }
            Array.Reverse(arr);
            Console.WriteLine("----Reverse----");
            foreach (string i in arr)
            {
                Console.WriteLine(i);


            }
            Array.Copy(arr, 2, arr1, 0, 3);
            Console.WriteLine("----Copy arr elements in arr1----");
            foreach (string i in arr1)
            {
                Console.WriteLine(i);
            }

            Array.Clear(arr, 1, 1);
            Console.WriteLine("----Clear arr elements at index 1----");
            foreach (string i in arr)
            {
                Console.WriteLine(i);
            }*/


            //--------------------------------------------------------------------------------//

            /* int[,] arr = new int[3, 3];
             int[,] arr1 = new int[3, 3];

             Console.WriteLine("Enter elements of the first arr :");
             InputElements(arr);

             Console.WriteLine("Enter elements of the second arr2 :");
             InputElements(arr1);

             int[,] result = new int[3, 3];

             for (int i = 0; i < 3; i++)
             {
                 for (int j = 0; j < 3; j++)
                 {
                     result[i, j] = arr[i, j] + arr1[i, j];
                 }
             }

             Console.WriteLine("Result:");
             PrintElements(result);
         }

         static void InputElements(int[,] arr)
         {
             for (int i = 0; i < 3; i++)
             {
                 for (int j = 0; j < 3; j++)
                 {

                     arr[i, j] = Convert.ToInt32(Console.ReadLine());
                 }
             }
         }
         static void PrintElements(int[,] arr)
         {
             for (int i = 0; i < 3; i++)
             {
                 for (int j = 0; j < 3; j++)
                 {
                     Console.Write(arr[i, j] + " ");
                 }
                 Console.WriteLine();
             }
         }*/

            // jagged array

            /*  int[][] arr = new int[4][];
              arr[0] =new int []{ 1,2,3,4,5,6};
              arr[1] = new int[] { 10, 20, 30, 40 };
              arr[2] = new int[] { 11, 22, 33, 44, 55 };
              arr[3] = new int[] { 1, 3, 5, };

              for(int i = 0; i < arr.Length; i++)

              {
                  for(int j=0; j < arr[i].Length;j++)
                  {
                      Console.Write(arr[i][j]);
                  }
                  Console.WriteLine();
              }
              foreach(int[] i in arr)
              {
                  foreach(int j in i)
                  {
                      Console.Write(j);
                  }
                  Console.WriteLine() ;
              }*/


            //  Crude OperTion On Movie Class 




        

    
        }
    }
}

