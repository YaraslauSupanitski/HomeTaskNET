using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace IntroductionSamples.MyWorkSpace
{
    public class XMLForBook
    {
        //hardcode
        string FileToDeser = Environment.CurrentDirectory + @"\..\..\..\..\books.xml";

        string FileToSer = Environment.CurrentDirectory + @"\..\..\..\..\bookSer.xml";


        /* Book
        public void Deserialize()
        {
            var serializer = new XmlSerializer(typeof(Book));
            var book = serializer.Deserialize(new FileStream(FileName1, FileMode.Open)) as Book;
            Console.WriteLine(book);
        }
        */
        public Catalog DesToList()
        {
            var xmlSerializer = new XmlSerializer(typeof(Catalog));

            var catalog = xmlSerializer.Deserialize(new FileStream(FileToDeser, FileMode.Open)) as Catalog;
            return catalog;

        }

        public void Serial()
        {
            //Book b1 = new Book("1", "1-1-1111-1", "Autor1_1", "Tiфывtle1", Genre.Computer, "Publisher1", "01.01.2001", "Des1", "01.01.2001");
            //Book b2 = new Book("2", "2-2-2222-2", "Autor2", "Title2", Genre.Computer, "Publisher2", "02.02.2002", "Des2", "02.02.2002");
            Catalog cat = DesToList();
            //cat.list = new List<Book>() { b1, b2 };
            var serializer = new XmlSerializer(typeof(Catalog));
            var fs = new StreamWriter(
                new FileStream(FileToSer, FileMode.Create), Encoding.UTF8);


            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
            ns.Add("", "http://library.by/catalog");

            serializer.Serialize(fs, cat, ns);
        }

    } 
}


