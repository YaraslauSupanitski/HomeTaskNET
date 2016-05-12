using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace IntroductionSamples.MyWorkSpace
{

    public enum Genre
    {
        [XmlEnum("Computer")]
        Computer,
        [XmlEnum("Fantasy")]
        Fantasy,
        [XmlEnum("Romance")]
        Romance,
        [XmlEnum("Horror")]
        Horror,
        [XmlEnum("Science Fiction")]
        ScienceFiction
    }

    [Serializable]
    public class Book
    {
        [XmlAttribute("id")]
        public string Id { get; set; }
        [XmlElement("isbn")]
        public string IsBn { get; set; }
        [XmlElement("author")]
        public string Author { get; set; }
        [XmlElement("title")]
        public string Title { get; set; }
        [XmlElement("genre")]
        public Genre Genre { get; set; }
        [XmlElement("publisher")]
        public string Publisher { get; set; }
        [XmlElement("publish_date", DataType = "date")]
        public DateTime Publish_date { get; set; }
        [XmlElement("description")]
        public string Description { get; set; }
        [XmlElement("registration_date", DataType = "date")]
        public DateTime Registration_date { get; set; }

        public Book()
        {

        }

        public Book(string v1, string v2, string v3, string v4, Genre v5, string v6, string v7, string v8, string v9)
        {
            this.Id = v1;
            this.IsBn = v2;
            this.Author = v3;
            this.Title = v4;
            this.Genre = v5;
            this.Publisher = v6;
            this.Publish_date = DateTime.Parse(v7);
            this.Description = v8;
            this.Registration_date = DateTime.Parse(v9);
        }


        public override string ToString()
        {
            return string.Format($"Id = {Id}\n\tIsBn = {IsBn}\n\tAuthor = {Author}\n\tTitle = {Title}\n\t" +
                $"Gender = {Genre}\n\tPublisher = {Publisher}\n\tPublish_date = {Publish_date.ToString("MMMM-dd-yyyy")}\n\t" +
                $"\n\tRegistration_date = {Registration_date.ToString("MMMM-dd-yyyy")}\n\tDescription: {Description.Replace("\n","\n\t\t")}");
        }

    }
}
