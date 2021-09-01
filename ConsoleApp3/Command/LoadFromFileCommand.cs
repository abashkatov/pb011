using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp3.Command
{
    class LoadFromFileCommand : ICommand
    {
        public string GetMenuRow()
        {
            return "Загрузить из файла";
        }
        public bool Run()
        {
            WriteLine("Загрузили");
            return false;
        }
    }
}
