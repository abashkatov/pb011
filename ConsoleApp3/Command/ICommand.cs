using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Command
{
    interface ICommand
    {
        string GetMenuRow();
        bool Run();
    }
}
