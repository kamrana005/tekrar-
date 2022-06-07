using System;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student
            {
                FullName = "Kamran",
                GroupNo = "P230",
                
            };
            Student student2 = new Student
            {
                FullName = "Pasa",
                GroupNo = "P220",

            }; 
            Student student3 = new Student
            {
                FullName = "Yasin",
                GroupNo = "P210",

            };
            Console.WriteLine(student1);
            Console.WriteLine("Total Students:" +Student.TotalCount);
        }
    }
}
