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
            public Person(string name)
            {
                Name = name;
            }
            public string Name {get;set;}
            public string Test(string str) {
                WriteLine("Test\n");
                return "return from Test";
            }
        }
        public delegate string GetResult(string arg1);

        static void Main(string[] args)
        {
            Person person;
            person = new Person("Alex");
            
            GetResult functions = null;


            functions += (string a) =>
            {
                WriteLine("Лямбда\n");
                return "return from Лямбда";
            };
            //functions += person.Test;
            //functions += person.Test;
            functions += person.Test;
            functions += person.Test;
            functions += person.Test;
            functions += person.Test;
            //functions -= person.Test;
            foreach (var func in functions.GetInvocationList()) { 
                WriteLine((func as GetResult)?.Invoke("Вызов"));
            }
            //WriteLine(functions?.Invoke("Вызов"));
            //WriteLine(functions("Вызов"));
            //if (functions != null)
            //{
            //    WriteLine(functions("Вызов"));
            //}
            //else {
            //    WriteLine("null");
            //}

            ReadKey();
        }

    }
}
