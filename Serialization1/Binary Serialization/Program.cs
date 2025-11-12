using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
namespace Json_Serialization
{
    internal class Program
    {
        [Serializable]
        public class Person
        {

            public string FirstName { get; set; }
            public string LastName { get; set; }

            public int Age { get; set; }

        }
        static void Main(string[] args)
        {

            Person person = new Person { FirstName = "Khalide", LastName = "Elmandour", Age = 19 };
            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream stream = new FileStream("Person.bin", FileMode.Create))
            {
                formatter.Serialize(stream, person);
            }

            using (FileStream stream = new FileStream("Person.bin", FileMode.Open))
            {

               Person deserializedPerson = (Person)formatter.Deserialize(stream);
                Console.WriteLine($"FullName : {deserializedPerson.FirstName + deserializedPerson.LastName}, Age: {deserializedPerson.Age}");

            }

        }
    }
}
