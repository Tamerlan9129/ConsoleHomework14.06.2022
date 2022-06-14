using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHomework14._06._2022
{
    class Employe : Human
    {
        public string Position { get; set; }

        public Employe()
        {

        }
        public Employe(string name, string surname, int age, string position) : base(name) 
        {
            
            Position = position;
        
        }
    }
}
