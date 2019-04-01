using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = "Basic cnBjdXNlcjpON2YwWU9nRHJQOHI=";
            var decodekey = MakeTest.CustomConvert.Base64Encode(key);
            Console.WriteLine(decodekey);

            var encodekey = MakeTest.CustomConvert.Base64Decode(decodekey);
            Console.WriteLine(encodekey);

            Console.ReadKey();
        }
    }
}
