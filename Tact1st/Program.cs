using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tact1st
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("enter a string");
            string mainstr = Console.ReadLine();
            string copyed = copymethod(mainstr);
            Console.WriteLine("original:"+mainstr);
            Console.WriteLine("copyed:"+copyed);

        }
        static string copymethod(string mystr)
        {
            string copystr = string.Copy(mystr);    
            return copystr;
        }
    }
}
