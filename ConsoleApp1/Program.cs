using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Xml;
using System.Xml.Serialization;
using static System.Console;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (XmlTextReader reader = new XmlTextReader("data.xml")) 
            {
                reader.WhitespaceHandling = WhitespaceHandling.None;
                while (reader.Read()) 
                {
                    WriteLine("LineNumber " + reader.LineNumber);
                    WriteLine("Depth " + reader.Depth);
                    WriteLine("Name " + reader.Name);
                    WriteLine("NodeType " + reader.NodeType);
                    WriteLine("ValueType " + reader.ValueType.Name);
                    WriteLine("Value " + reader.Value);
                    WriteLine("AttributeCount " + reader.AttributeCount);
                    if (reader.AttributeCount > 0) 
                    {
                        while (reader.MoveToNextAttribute()) 
                        {
                            WriteLine($"\t{reader.NodeType}, {reader.Name}, {reader.Value}");
                        }
                    }
                    WriteLine("==================");
                }
            }

            ReadKey();
        }
    }
}
