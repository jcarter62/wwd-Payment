using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using classLib;

namespace ConsTest {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Hello");

            NtGroups g = new NtGroups();
            Console.WriteLine(g.ToString() );

            Console.ReadLine();
        }
    }
}
