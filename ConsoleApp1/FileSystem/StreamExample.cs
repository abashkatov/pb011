using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.IO;

namespace ConsoleApp1.FileSystem
{
    class StreamExample
    {
        public void Run() 
        {
            using (Stream stream = new FileStream("./test.txt", FileMode.Truncate))
            {
                using (StreamWriter sw = new StreamWriter(stream)) { 
                    string Test = "вапрвапвап";
                    sw.Write(Test);
                }
            }
            using (Stream stream = new FileStream("./test.txt", FileMode.Open))
            {
                using (StreamReader sr = new StreamReader(stream))
                {
                    string Test = sr.ReadLine();
                    WriteLine(Test);
                }
            }
        }
    }
}
