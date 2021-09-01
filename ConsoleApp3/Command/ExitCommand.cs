using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Command
{
    class ExitCommand: ICommand
    {
        public string GetMenuRow()
        {
            return "Выход";
        }
        public bool Run()
        {
            return true;
        }
    }
}
