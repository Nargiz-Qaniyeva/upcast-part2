using FakeItEasy;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace UpCasting_part2.Models
{
    public class Group
    {
        public int No { get; }

        public Student Students { get; private set; }
        private Student[] students;

        private static int _NoAvto = 200;
        private object _students;
        private object[] massiv;

        public Group(double v)
        {
            No++;
            No = _NoAvto;

        }

        public Group()
        {
            _NoAvto++;
            //No = "AP" + _NoAvto;
            students = new Student[1];
        }

        internal void AddStudent(Student student1)
        {
            studnet studnet1 = new studnet();
            Array.Resize(ref massiv, massiv.Length + 1);
            massiv[massiv.Length - 1] = Students;

        }
        public Student[] GetAllStudents()
        {
            return (Student[])students;
        }

        internal IEnumerable<Student> Sort()
        {
            throw new NotImplementedException();
        }

        public Student[] Sort(Student[] massiv)
        {
            Student[] massivss = new Student[massiv.Length];
            Array.Copy(massiv, massivss, massivss.Length);
            for (int i = 0; i < massivss.Length - 1; i++)
            {
                for (int j = 0; j < massivss.Length - 1; j++)
                {
                    if (massivss[j] > massivss[i + 1])
                    {
                        Student temp = massivss[j];
                        massivss[j] = massivss[j + 1];
                        massivss[j + 1] = temp;
                    }
                }

            }
            return massivss;

            #region Sort
            //Student student = new Student(20);
            //Array.Sort(students);
            //foreach (var item in students)
            //{
            //    Console.WriteLine(student);
            //}
            //Student student1 = new Student(21);
            //Array.Sort(students);
            //foreach (var item in students)
            //{
            //    Console.WriteLine(student1);
            //}
            //Student student2 = new Student(22);
            //Array.Sort(students);
            //foreach (var item in students)
            //{
            //    Console.WriteLine(student2);
            //}
            //Student student3 = new Student( 23);
            //Array.Sort(students);
            //foreach (var item in students)
            //{
            //    Console.WriteLine(student3);
            //}
            #endregion
            #region.
            //if (Point < massiv.Length)
            //{
            //    Array.Resize(ref massiv, massiv.Length + 1);
            //    massiv[massiv.Length - 1] = Students;
            //}
            //Student student2 = new Student("Eyyub", "Ehmedov", 22);
            //Array.Sort(students);
            //foreach (var item in students)
            //{
            //    Console.WriteLine(student2);
            //}

            //static void sort(int[] arr)
            //{
            //    int n = arr.Length;

            //    // One by one move boundary of unsorted subarray
            //    for (int i = 0; i < n - 1; i++)
            //    {
            //        // Find the minimum element in unsorted array
            //        int min_idx = i;
            //        for (int j = i + 1; j < n; j++)
            //            if (arr[j] < arr[min_idx])
            //                min_idx = j;

            //        // Swap the found minimum element with the first
            //        // element
            //        int temp = arr[min_idx];
            //        arr[min_idx] = arr[i];
            //        arr[i] = temp;
            //    }
            //}
            #endregion


        }

    }

}

