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
        const string FileToDeser = @"C:\Users\Yaraslau_Supanitski@epam.com\Desktop\Presentations\C&NET\Serialization\books.xml";
        const string FileToSer = @"C:\Users\Yaraslau_Supanitski@epam.com\Desktop\Presentations\C&NET\Serialization\bookSer.xml";


        /* Book
        public void Deserialize()
        {
            var serializer = new XmlSerializer(typeof(Book));
            var book = serializer.Deserialize(new FileStream(FileName1, FileMode.Open)) as Book;
            Console.WriteLine(book);
        }
        */
        public void DesToList()
        {

            var xmlSerializer = new XmlSerializer(typeof(Catalog));

            var catalog = xmlSerializer.Deserialize(new FileStream(FileToDeser, FileMode.Open)) as Catalog;
            
        }

        public void Serial()
        {
            Book b1 = new Book("1", "1-1-1111-1","Autor1","Title1", Genre.Computer, "Publisher1", "01.01.2001","Des1", "01.01.2001");
            Book b2 = new Book("2", "2-2-2222-2", "Autor2", "Title2", Genre.Computer, "Publisher2", "02.02.2002", "Des2", "02.02.2002");
            Catalog cat = new Catalog();
            cat.list = new List<Book>() {b1,b2};

            var serializer = new XmlSerializer(typeof(Catalog));
            var fs = new FileStream(FileToSer, FileMode.Create);
            serializer.Serialize(fs, cat);
            fs.Close();
        }
    }
}

