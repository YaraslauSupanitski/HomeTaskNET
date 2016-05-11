using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace IntroductionSamples.MyWorkSpace
{
    [Serializable]
    [XmlRoot("catalog", Namespace = "http://library.by/catalog")]
    public class Catalog
    {
        [XmlElement("book", typeof(Book))]
        public List<Book> list { get; set; }
        [XmlAttribute("date")]
        DateTime Date { get; set; }


        public Catalog()
        {
            list = new List<Book>();
        }
    } 
}
