using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    /// <summary>
    /// 正規表現の確認
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var s1 = "{AAA}{BBB}";

            var r1 = Regex.Matches(s1, @"(?<={)[^}]+");
            
            foreach (Match s in r1)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();
        }
    }
}
