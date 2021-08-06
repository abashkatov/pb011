using ConsoleApp1.FileSystem;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {


            var Example = new StreamExample();
            Example.Run();

            ReadKey();
        }
    }
}
