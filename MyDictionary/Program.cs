using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myListem = new MyDictionary<int, string>();
            myListem.Add(1, "kadir");
            myListem.Add(2, "sezer");
            myListem.Add(3,"türker");

            myListem.UrunListele();

        }
    }
}
