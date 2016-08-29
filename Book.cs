using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardCatalog
{
    [Serializable]
    public class Book
    {
        public string IBSN { get; set; }
        public string Title { get; set; }
        public string YearPublished { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public string CallNum { get; set; }

        //constructor
        public Book(string a, string b, string c, string d, string e, string f)
        {
            //asks for user to enter data
            Console.Write("IBSN: ");
            a = Console.ReadLine();

            Console.Write("Title: ");
            b = Console.ReadLine();

            Console.Write("Year Published: ");
            c = Console.ReadLine();

            Console.Write("Author: ");
            d = Console.ReadLine();

            Console.Write("Genre: ");
            e = Console.ReadLine();

            Console.Write("Call Number: ");
            f = Console.ReadLine();
        }

        public Book()
        {
            //asks for user to enter data
            Console.Write("IBSN: ");
            IBSN = Console.ReadLine();

            Console.Write("Title: ");
            Title = Console.ReadLine();

            Console.Write("Year Published: ");
            YearPublished = Console.ReadLine();

            Console.Write("Author: ");
            Author = Console.ReadLine();

            Console.Write("Genre: ");
            Genre = Console.ReadLine();

            Console.Write("Call Number: ");
            CallNum = Console.ReadLine();

        }
    }
}
