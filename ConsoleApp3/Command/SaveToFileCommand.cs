using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp3.Command
{
    class SaveToFileCommand : ICommand
    {
        public string GetMenuRow()
        {
            return "Сохранить в файл";
        }
        public bool Run()
        {
            List<ICommand> commands = new List<ICommand>();
            commands.Add(new ExitCommand());
            commands.Add(new ExitCommand());
            commands.Add(new ExitCommand());
            commands.Add(new ExitCommand());
            commands.Add(new ExitCommand());
            commands.Add(new ExitCommand());
            commands.Add(new ExitCommand());
            MenuRunner menuRunner = new MenuRunner(commands);
            menuRunner.MenuRun();
            WriteLine("Сохранили");
            return false;
        }
    }
}
