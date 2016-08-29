using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CardCatalog
{
    class CardCatalog
    {
        private string _filename;

        private List<Book> library;

        public void Menu()
        {
            Console.WriteLine("Welcome to the Card Catalog menu.");

            Console.Write("Please enter a file name: ");
            _filename = Console.ReadLine();

            //menu choices
            Console.WriteLine("1. List all books");
            Console.WriteLine("2. Add a book");
            Console.WriteLine("3. Save and exit");
            
            string userInput = (Console.ReadLine());
            int choice = int.Parse(userInput);

            while (choice != 3)
            {
                switch (choice)
                {
                    case 1:
                        ListBooks(library);
                        break;
                    case 2:
                        AddBook(library);
                        break;
                    case 3:
                        Save(library,_filename);
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please enter 1, 2, or 3.");
                        break;
                }
            }
        }



        public void Catalog(string fileName)
        {
            fileName = _filename;
        }



        public void ListBooks(List<Book> library)
        {
            //prints list of books from collection
            foreach (var book in library)
            {
                // !!!!! - still need to work on this part...
                Console.Write("\n");
            }

        }



        public void AddBook(List<Book> library)
        {
            //new instance of book, asks for user input from Book class
            Book myBook = new Book();

            //adds new myBook to library
            library.Add(myBook);

            //Menu();

        }


        public void Save(List<Book> library, string _filename)
        {
            XmlSerializer x = new XmlSerializer(library.GetType());
            TextWriter writer = new StreamWriter(_filename);
            x.Serialize(writer, x);
            writer.Close();

            //System.IO.File.WriteAllLines(@"C:\Users\Daniela\Documents\CardCatalog.txt", bookArray);

            Console.WriteLine("{0} has been saved to {1}.", library, _filename);
        }
    }
}
