using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XmlSerialization
{
    [Serializable]
    public class Person
    {

        [XmlIgnore]
        public int Id { get; set; }

        [XmlAttribute]
        public string FirstName { get; set; }

        [XmlElement("FullName", Order = 2)]
        public string LastName { get; set; }

        [XmlElement("Age", Order = 1)]
        public int Age { get; set; }
    }
}
