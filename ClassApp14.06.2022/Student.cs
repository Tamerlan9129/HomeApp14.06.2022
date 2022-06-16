using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassApp14._06._2022
{
    class Student
    {
        public string Name { get; set; }

        public string Surname { get; set; }
        public int Age { get; set; }

        public double Grade { get; set; }

        public int Id { get; }

        public int _id;

        public Student() 
        {
             
        }
        public Student(string name,string surname, int age,double grade): this()
        {
            Name = name;
            Surname = surname;
            Age = age;
            Grade = grade;
            Id = ++_id;
        }
    }
}
