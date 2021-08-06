using System.Collections.Generic;
using static System.Console;

namespace ConsoleApp1
{
    class Program
    {
        class Person {
            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }
            public string Name { get; set; }
            public int Age { get; set; }
        }

        static void Main(string[] args)
        {
            Person
                p1 = new Person("Name1", 33),
                p2 = new Person("Name2", 43);
            // Name1;33
            // Name2;44
            var text = $"{p1.Name};{p1.Age}\n{p2.Name};{p2.Age}";

            WriteLine(text);
            string[] rows = text.Split('\n');
            List<Person> persons = new List<Person>();
            foreach (string row in rows) 
            {
                // Из строки создать сотрудника:
                // 1. Извлечь из строки данные о сотруднике
                string[] props = row.Split(';');
                //props[0]
                //props[1]
                // 2. Person person = new Person(...);
                Person person = new Person(props[0], int.Parse(props[1]));
                // 3. persons.Add(person);
                persons.Add(person);
                WriteLine($"Сотрудник: {row}");
            }
            // Передать данные:
            // 1. Сериализация (конвертация данных в байты или в текст)
            // 2. Отправляем байты/текст в поток
            // Получить данные:
            // 1. Получаем байты/текст
            // 2. Десериализация (конвертация из байтов или текста в данные)

            //var Example = new StreamExample();
            //Example.Run();

            ReadKey();
        }
    }
}
