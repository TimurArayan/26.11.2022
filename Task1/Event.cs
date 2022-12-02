using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Event
    {
        string name;
        DateTime data;
        int people_need;

        public Event(string name, DateTime data, int people_need)
        {
            this.name = name;
            this.data = data;
            this.people_need = people_need;
        }

        public void TakeStudents(List<Student> students)
        {
            StreamWriter idut = new StreamWriter("1.txt", true);
            int z = people_need;
            List < Student > going_to_event = new List < Student >(z);
            List<Student> a = new List<Student>();
            List<Student> b = new List<Student>();
            foreach (Student student in students)
            {
                if (student.lastevent == false)
                {
                    going_to_event.Add(student);
                    a.Add(student);
                }
            }
            foreach(Student f in a)
            {
                students.Remove(f);
            }

            if (going_to_event.Count < z)
            {
                foreach (Student student in students)
                {
                    going_to_event.Add(student);
                }
            }
            if (going_to_event.Count < z)
            {
                idut.WriteLine($"ВСего только {going_to_event.Count} студентов");
            }
            else
            {
                idut.WriteLine($"Нашлось столь, сколько надо");

            }

            foreach (Student student in going_to_event)
            {
                idut.WriteLine($"Имя - {student.name}, группа - {student.group}");
                
            }
            idut.Close();
        }
    }
}
