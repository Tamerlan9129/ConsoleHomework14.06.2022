using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHomework14._06._2022
{
    class Human
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        private List<Student> myStudent;
        private List<Employe> myEmploee;
        public Human() 
        { 
        
        }
        public Human(string name)
        {
            Name = name;
        }

    }
}
