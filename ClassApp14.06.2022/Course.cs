using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassApp14._06._2022
{
    class Course
    {
        public List<Group> Group;
        public string Name { get; set; }

        public Course() 
        {
            Group = new List<Group>();
            
        }

    }
}
