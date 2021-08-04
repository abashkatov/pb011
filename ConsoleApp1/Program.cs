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
            public delegate void OnPropertyChanged<T>(T oldValue, T newValue);
            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }
            public event OnPropertyChanged<string> onNameChanged = null;
            public event OnPropertyChanged<int> onAgeChanged = null;
            private string _name;
            private int _age;
            public string Name {
                get => _name;
                set
                {
                    string oldName = _name;
                    _name = value;
                    onNameChanged?.Invoke(oldName, value);
                }
            }
            public int Age
            {
                get => _age;
                set
                {
                    int oldAge = _age;
                    _age = value;
                    onAgeChanged?.Invoke(oldAge, value);
                }
            }
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
