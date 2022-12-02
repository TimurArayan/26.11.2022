using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Student
    {
        public string group;
        public string name;
        public bool lastevent;

        public Student(string group, string name, bool lastevent)
        {
            this.group = group;
            this.name = name;
            this.lastevent = lastevent;
        }

    }
}
