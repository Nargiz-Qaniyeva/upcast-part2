using System;
using System.Collections.Generic;
using System.Text;

namespace UpCasting_part2.Models
{
    public class Student
    {
        public int Id { get; }
        //static int IdCounter = 0;
        private double v;
        private static int _id;
        private string v1;
        private string v2;
        private int v3;

        // public int Id { get; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public double Point { get; set; }

        public Student(string name, string surname, int age, double point)
        {
            _id++;
            Id = _id;
            Name = name;
            Surname = surname;
            Point = point;
            Age = age;
        }
        
        
        public void ShowInfo()
        {
            Console.WriteLine($"Name:{Name}\nSurname:{Surname}\nAge:{Age}\nPoint{Point}");
        }
        public static bool operator <(Student student, Student student1)
        {
            Console.WriteLine("Student!");
            return false;
        }
        public static bool operator >(Student student, Student student1)
        {
            return student.Point < student1.Point ;
        } 
        

        public Student(double v)
        {
            this.v = v;
        }

        public Student(string v1, string v2, int v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }
    }
}
 