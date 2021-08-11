using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Xml.Serialization;
using static System.Console;

namespace ConsoleApp1
{
    public class Program
    {
        [Serializable]
        public class Person {
            public Person()
            { }
            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }
            public string Name { get; set; }
            public int Age { get; set; }
            [NonSerialized]
            public List<Person> People  = new List<Person>();
        }

        static void Main(string[] args)
        {
            Person
                p1 = new Person("Name1", 33),
                p2 = new Person("Name2", 44),
                p3 = new Person("Name3", 55),
                p4 = new Person("Name4", 66),
                p5 = new Person("Name5", 77);
            p1.People.Add(p2);
            p1.People.Add(p3);
            p2.People.Add(p4);
            p2.People.Add(p5);
            List<Person> Persons = new List<Person>() { p1 , p2 , p3 , p4 , p5 };
            List<Person> Persons2;
            // Json
            // XML
            // SOAP

            // Бинарный

            // Yaml

            // Перерыв до 20-54

            IFormatter formatter = new BinaryFormatter();
            formatter = new SoapFormatter();
            String fileName = "data.soap";

            JsonSerializer jsonSerializer = new JsonSerializer();
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Person>));

            using (Stream fs = new FileStream("data.json", FileMode.OpenOrCreate))
            {
                using(JsonWriter jsonWriter = new JsonTextWriter(new StreamWriter(fs)))
                {
                    jsonSerializer.Serialize(jsonWriter, Persons);
                }
            }
            using (Stream fs = new FileStream("data.xml", FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(fs, Persons);
            }
            Persons = null;
            using (Stream fs = new FileStream("data.json", FileMode.Open))
            {
                using (JsonReader jsonReader = new JsonTextReader(new StreamReader(fs)))
                {
                    Persons = jsonSerializer.Deserialize(jsonReader, typeof(List<Person>)) as List<Person>;
                }
            }
            using (Stream fs = new FileStream("data.xml", FileMode.Open))
            {
                Persons2 = xmlSerializer.Deserialize(fs) as List<Person>;
            }

            ReadKey();
        }
    }
}
