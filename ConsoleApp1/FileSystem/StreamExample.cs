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
                string Test = "вапрвапвап"; // windows-1251
                // utf-8
                byte[] Bytes = Encoding.Unicode.GetBytes(Test);
                //byte[] BadBytes = { 250 };
                //stream.Write(BadBytes, 0, 1);
                stream.Write(Bytes, 0, Bytes.Length);
            }
            using (Stream stream = new FileStream("./test.txt", FileMode.Open))
            {
                long len = stream.Length;
                byte[] Bytes = new byte[len];
                int readed = stream.Read(Bytes, 0, Bytes.Length);

                //WriteLine(Encoding.Unicode.GetString(Bytes));
                WriteLine(Encoding.Unicode.GetString(Bytes, 0, readed));
            }
        }
    }
}
