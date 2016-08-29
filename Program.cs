using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardCatalog
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CardCatalog myCatalog = new CardCatalog();

            myCatalog.Menu();

            Console.ReadLine();

        }

    }
}
