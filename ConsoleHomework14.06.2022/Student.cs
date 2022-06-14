using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHomework14._06._2022
{
    class Student : Human
    {


        public int Grade { get; set; }

        public Student()
        {

        }
        public Student(string name,int grade) : base(name)
        {
            Name = name;
            Grade = grade;
        }

    }
}