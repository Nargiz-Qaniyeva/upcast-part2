using System;
using UpCasting_part2.Models;

namespace UpCasting_part2
{
    internal class Program
    {
        private static Array students;

        static void Main(string[] args)
        {
            Student student = new Student("Nergiz", "Qeniyeva", 20,5.6);
            Student student1 = new Student("Jale", "Quliyeva", 21,3.4);
            Student student2 = new Student("Eyyub", "Ehmedov", 22,4.7);
            Student student3 = new Student("Aslan", "Aslanzade", 23,5.7);

            Group group = new Group();

            group.AddStudent(student);
            group.AddStudent(student1);
            group.AddStudent(student2);
            group.AddStudent(student3);
            

            Console.WriteLine(group.No);
            foreach (var item in group.GetAllStudents())
            {
                Console.WriteLine("-----");

                item.ShowInfo();
            }



            foreach (var item in group.Sort())
            {
                Console.WriteLine("-----");

                item.ShowInfo();
            }
            Group group2 = new Group();

            Student student5 = new Student("Yusif", "Nezerbeyov", 26, 2.3);
            Student student6 = new Student("Kamal ", "Abdullayev", 24, 7.5);
            Student student7 = new Student("Elgun ", "Gojayev", 25, 8.6);
            Student student8 = new Student("Nurlan ", "Hamidov", 28, 9.9);

            group2.AddStudent(student5);
            group2.AddStudent(student6);
            group2.AddStudent(student7);
            group2.AddStudent(student8);

            
            Console.WriteLine("             ");
            


            Console.WriteLine(group2.No);
            foreach (var item in group2.GetAllStudents())
            {
                Console.WriteLine("-----");

                item.ShowInfo();
            }
            foreach (var item in group2.Sort())
            {
                Console.WriteLine("-----");

                item.ShowInfo();
            }
        }

        static string increment_number_at_end_of_string(string AP101)
        {
            string AP = AP101.TrimEnd('0', '1', '2', '3', '4', '5', '6', '7', '8', '9');
            string 101 = AP101.Substring(AP.Length);

            int number = -1;
            if (int.TryParse(101, out number))
            {
                return AP + (number + 1).ToString();
            }
            return AP101;
        }




        #region arr
        //    int[] arr = { 23,21,22,20 };
        //    sort(arr);
        //    Console.WriteLine("Sorted array");

        //}
        //private static void sort(int[] arr)
        //{
        //    Student student = new Student(20);
        //    Array.Sort(students);
        //    foreach (var item in students)
        //    {
        //        Console.WriteLine(student);
        //    }
        //    Student student1 = new Student(21);
        //    Array.Sort(students);
        //    foreach (var item in students)
        //    {
        //        Console.WriteLine(student1);
        //    }
        //    Student student2 = new Student(22);
        //    Array.Sort(students);
        //    foreach (var item in students)
        //    {
        //        Console.WriteLine(student2);
        //    }
        //    Student student3 = new Student(23);
        //    Array.Sort(students);
        //    foreach (var item in students)
        //    {
        //        Console.WriteLine(student3);
        //    }
        //}
        
        #endregion 

    }
}

