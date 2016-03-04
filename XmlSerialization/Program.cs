using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XmlSerialization
{
    class Program
    {
        static void Main(string[] args)
        {

            SerializeAndDeserializeUsingXmlSerializer();

            SerializeAndDeserializeUsingBinaryFormatter();

            SerializeAndDeserializeUsingDataContractSerializer();

            SerializeAndDeserializeUsingDataContractJsonSerializer();

            Console.ReadLine();
        }

        private static void SerializeAndDeserializeUsingDataContractJsonSerializer()
        {
            Person p = new Person
            {
                Id = 28,
                FirstName = "Mohamed",
                LastName = "Ahmed",
                Age = 25,
            };

            using (MemoryStream stream = new MemoryStream())
            {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Person));
                ser.WriteObject(stream, p);
                stream.Position = 0;
                StreamReader streamReader = new StreamReader(stream);
                Console.WriteLine(streamReader.ReadToEnd()); // Displays {“Id”:1,”Name”:”John Doe”}
                stream.Position = 0;
                Person result = (Person)ser.ReadObject(stream);
            }
        }

        private static void SerializeAndDeserializeUsingBinaryFormatter()
        {
            Person p1 = new Person
            {
                Id = 28,
                FirstName = "Mohamed",
                LastName = "Ahmed",
                Age = 25,
            };

            // binary serialization 
            IFormatter formatter = new BinaryFormatter();
            using (Stream stream = new FileStream("data.bin", FileMode.Create))
            {
                formatter.Serialize(stream, p1);
            }

            // binary deserialization
            using (Stream stream = new FileStream("data.bin", FileMode.Open))
            {
                Person dp = (Person)formatter.Deserialize(stream);
            }
        }

        private static void SerializeAndDeserializeUsingXmlSerializer()
        {
            Person p1 = new Person
            {
                Id = 28,
                FirstName = "Mohamed",
                LastName = "Ahmed",
                Age = 25,
            };

            // serialization
            XmlSerializer serializer = new XmlSerializer(typeof(Person));
            string xml;
            using (StringWriter stringWriter = new StringWriter())
            {

                serializer.Serialize(stringWriter, p1);
                xml = stringWriter.ToString();
            }
            Console.WriteLine(xml);

            // deserialization
            using (StringReader stringReader = new StringReader(xml))
            {

                Person p2 = (Person)serializer.Deserialize(stringReader);
                Console.WriteLine("{0} {1} is {2} years old", p2.FirstName, p2.LastName, p2.Age);
            }
        }

        private static void SerializeAndDeserializeUsingDataContractSerializer()
        {

            PersonDataContract p = new PersonDataContract
            {
                Id = 1,
                Name = "John Doe"
            };

            using (Stream stream = new FileStream("data.xml", FileMode.Create))
            {
                DataContractSerializer ser = new DataContractSerializer(typeof(PersonDataContract));
                ser.WriteObject(stream, p);
            }

            using (Stream stream = new FileStream("data.xml", FileMode.Open))
            {
                DataContractSerializer ser = new DataContractSerializer(typeof(PersonDataContract));
                PersonDataContract result = (PersonDataContract)ser.ReadObject(stream);
            }
        }
    }
}
