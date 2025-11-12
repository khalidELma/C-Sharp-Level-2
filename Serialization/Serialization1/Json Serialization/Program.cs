using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
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

            Person person = new Person { FirstName = "Khalide" ,LastName = "Elmandour",Age =19};
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Person));

            using (MemoryStream stream = new MemoryStream())
            {
                serializer.WriteObject(stream, person);
                string jsonString = System.Text.Encoding.UTF8.GetString(stream.ToArray());

                File.WriteAllText("Person.json", jsonString);

            }

            using (FileStream stream = new FileStream("Person.json", FileMode.Open))
            {

                Person deserializedPerson = (Person)serializer.ReadObject(stream);

                Console.WriteLine($"FullName: {deserializedPerson.FirstName + deserializedPerson.LastName} , Age: {deserializedPerson.Age}");


            }

        }
    }
}
