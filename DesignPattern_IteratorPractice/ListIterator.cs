using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_IteratorPractice
{
    class ListIterator : Iterator
    {
        private List<Book> books;
        int position = 0;

        public ListIterator(List<Book> books)
        {
            this.books = books;
        }

        public bool hasNext()
        {
            return position < books.Count();
        }

        public object next()
        {
            var result= books[position];
            position++;
            return result;
        }

        public void remove()
        {
            throw new NotImplementedException();
        }
    }
}
