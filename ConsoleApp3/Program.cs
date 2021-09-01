using ConsoleApp3.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {           
            List<ICommand> commands = new List<ICommand>();
            commands.Add(new LoadFromFileCommand());
            commands.Add(new SaveToFileCommand());
            commands.Add(new ExitCommand());

            MenuRunner menuRunner = new MenuRunner(commands);
            menuRunner.MenuRun();
        }
    }
}
