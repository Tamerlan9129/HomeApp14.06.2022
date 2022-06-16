using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassApp14._06._2022
{
    class Group
    {
        public List<Student> Students;
        public string Name { get; set; }

        public Group() 
        {
            
        }
        public Group(string name) :this()
        {
            Name = name;
            Students = new List<Student>();
        }
    }
}
