using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XML_Serialization
{
    public class Person
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int Age { get; set; }

    }
    internal class Program
    {

      
        static void Main(string[] args)
        {
            Person person = new Person { FirstName ="Khalid",LastName ="Elmandour",Age =19};

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Person));

            using (TextWriter writer =new StreamWriter("Person.xml"))
            {
                xmlSerializer.Serialize(writer, person);

            }

            using (TextReader reader = new StreamReader("Person.xml"))
            {
                Person deserializedPerson = (Person)xmlSerializer.Deserialize(reader);
                Console.WriteLine($"FullName: {deserializedPerson.FirstName + deserializedPerson.LastName} , Age: {deserializedPerson.Age}");

            }
        }
    }
}
