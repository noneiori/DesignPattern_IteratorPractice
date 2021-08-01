using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_IteratorPractice
{
    class BookSeller
    {
        IMenu arrayBooks;
        IMenu listBooks;

        public BookSeller(IMenu arrayBooks, IMenu listBooks)
        {
            this.arrayBooks = arrayBooks;
            this.listBooks = listBooks;
        }

        public void PrintMenu()
        {
            Iterator listIterator = this.arrayBooks.GetIterator();
            Iterator arrayIterator = this.listBooks.GetIterator();

            Console.WriteLine("--- Menu From Array Books---");
            PrintMenu(listIterator);

            Console.WriteLine("--- Menu From List Books---");
            PrintMenu(arrayIterator);
        }

        private void PrintMenu(Iterator listIterator)
        {
            while (listIterator.hasNext())
            {
                Book book = (Book)listIterator.next();
                Console.WriteLine(book.ToString());                
            }
        }
    }
}
