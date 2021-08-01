using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_IteratorPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            ListBooks listBooks = new ListBooks();
            ArrayBooks arrayBooks = new ArrayBooks();
            BookSeller seller = new BookSeller(arrayBooks, listBooks);
            seller.PrintMenu();
            Console.Read();
        }
    }
}
