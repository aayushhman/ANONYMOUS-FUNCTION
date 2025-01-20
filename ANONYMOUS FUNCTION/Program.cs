using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANONYMOUS_FUNCTION
{
    class Program
    {
        static void Main(string[] args)
        {


            program.MyMethod(delegate (int b) { b += 10; Console.WriteLine(b); }, 5);
          //  mydelegate obj = delegate (int a)
            // {
              //   a += 10;
                // Console.WriteLine(a);
             //};
            //obj.Invoke(5);
            Console.ReadLine();
        }
    }
}
