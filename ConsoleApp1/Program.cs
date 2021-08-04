using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp1
{
    class Program
    {
        class Person {
            public delegate void OnNameChanged(string oldName, string newName);
            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }

            public OnNameChanged onNameChanged = null;
            private string _name;
            public string Name {
                get => _name;
                set
                {
                    string oldName = _name;
                    _name = value;
                    onNameChanged?.Invoke(oldName, value);
                }
            }
            public int Age {get;set;}
        }

        static void Main(string[] args)
        {
            Person person;
            person = new Person("Alex", 33);
            person.Name = "Butch";
            person.onNameChanged += (string oldName, string newName) => {
                WriteLine($"Имя изменилось: {oldName} => {newName}");
            };
            person.Name = "John";

            ReadKey();
        }

    }
}
