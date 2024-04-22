using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    internal class Student
    {
        public int id;
        public string name;
        public int marks1;
        public int marks2;
        public int marks3;
        double percentage;

        public void DisplayStudentDetails()
        {
            Console.WriteLine("Student Id " + id);
            Console.WriteLine("Name " + name);
            Console.WriteLine("Marks of First Subject : " + marks1);
            Console.WriteLine("Marks of First Subject : " + marks2);
            Console.WriteLine("Marks of First Subject : " + marks3);
        }
        public void ClculatePercentage()
        {
            double totalmarks = marks1 + marks2 + marks3;
            percentage = (totalmarks / 300) * 100;
            Console.WriteLine("Percentage of Student = " + percentage);
        }
        public void ShowAllDetails()
        {
            Console.WriteLine("Student Id = " + id);
            Console.WriteLine("Name = " + name);
            Console.WriteLine("Percentage of Student =" + percentage);
        }
    }
}
