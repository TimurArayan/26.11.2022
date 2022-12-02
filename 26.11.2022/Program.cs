using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1; ///////////////Подключил другой наймспейс из библиотеки

namespace _26._11._2022
{

    public enum AccountType
    {
        Накопительный, Кредитный
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Factory x = new Factory();
            x.CreateAccount();
            x.CreateAccount();
            x.CreateAccount();
            x.ShowTable();

        }
    }
}
