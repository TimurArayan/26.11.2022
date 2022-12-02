using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryFroTooMuch11_2;
using LibraryFroTooMucj11_2;

namespace Tumakov11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Creator x = new Creator(9, 5);
            x.CreateBuild();
            x.CreateBuild();
            x.ShowTable();

        }
    }
}
