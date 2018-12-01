using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Logic
{
    class BookItem : IItem //Čia yra mūsų modelis
    {
        public String Name { get; set; }
        public String ISBN13 { get; set; }
        public String ISBN10 { get; set; }
        public String Author { get; set; }
        public String Genre { get; set; }
        public String Publisher { get; set; }
        public int Published { get; set; }
        public double ListPrice { get; set; }
        public String CoverLink { get; set; }
        public String TableName()
        {
            return "Books";
        }
        public String TypesInString()
        {
            return "(BookName, ISBN13, ISBN10, Author, Publisher, Published, ListPrice, CoverLink, Genre)";
        }
        public String ValuesInString()
        {
            return String.Format("('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}')",
                                        Name, ISBN13, ISBN10, Author, Publisher, Published, ListPrice, CoverLink, Genre);
        }
    }
}