using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace gd6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input text");
            string s = Console.ReadLine();
            Console.WriteLine(Regex.Replace(s, "[ауоиюяеёыэ]", ""));
        }
    }
}
