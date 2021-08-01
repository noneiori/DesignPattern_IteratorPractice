using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_IteratorPractice
{
    class ListBooks : IMenu
    {
        List<Book> books;

        public ListBooks()
        {
            books = new List<Book>();

            AddBook("PostgreSQL using", (decimal)23.5);
            AddBook("CCNA Learning", (decimal)50.3);
        }

        private void AddBook(string v1, decimal v2)
        {
            var book = new Book(v1,v2);
            books.Add(book);
        }

        public Iterator GetIterator()
        {
            return new ListIterator(this.books);
        }
    }
}
