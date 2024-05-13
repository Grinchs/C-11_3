using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_11_3
{
    internal class Program
    {
        class Konstruktors
        {
            public Konstruktors()
            {
                Console.WriteLine("Default konstruktors");
            }
            public Konstruktors(int i)
            {
                Console.WriteLine($"int tipa parametrs:{i}");  
            }
            public Konstruktors(double d)
            {
                Console.WriteLine($"double tipa parametrs: {d}");
            }
            public Konstruktors(string s)
            {
                Console.WriteLine($"string tipa parametrs: {s}");
            }
        }
        static void Main(string[] args)
        {
            Konstruktors konstruktors = new Konstruktors();    
            Konstruktors i = new Konstruktors(3);
            Konstruktors d = new Konstruktors(1.1);
            Konstruktors s = new Konstruktors("h");    
        }
    }
}
