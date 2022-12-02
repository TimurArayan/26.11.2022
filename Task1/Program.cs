using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student a = new Student("14", "Алекснадр", true);
            Student b = new Student("14", "Николай", false);
            Student c = new Student("12", "Сергей", true);
            Student d = new Student("12", "Дмитрий", false);
            Student e = new Student("13", "Валентин", false);
            Student f = new Student("13", "Вячеслав", true);
            Student g = new Student("12", "Ярослав", false);
            Student h = new Student("13", "Владимир", true);
            Student i = new Student("12", "Анатолий", false);
            Student j = new Student("14", "Виктор", false);

            List<Student> x = new List<Student> { a, b, c, d };


            StreamReader info = new StreamReader("1.txt");
            string info2 = info.ReadLine();
            info.Close();
            string[] info3 = info2.Split(' ');

            Event z = new Event(info3[0], DateTime.Parse(info3[1]), int.Parse(info3[2]));
            z.TakeStudents(x);




        }
    }
}
