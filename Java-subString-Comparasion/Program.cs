using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Java_subString_Comparasion
{
    class Program
    {
        static String primerYultimo(String s,int n)
        {
            String primero, ultimo;
            ultimo = s.Substring((s.Length-n));
            char[] first = s.ToCharArray();
            Array.Reverse(first);
            String m = new string(first);
            primero = m.Substring((m.Length-n));
            return primero + "\n"+ultimo;
        }
        static void Main(string[] args)
        {
           Console.WriteLine( primerYultimo("welcometojava",3));
        }
    }
}
