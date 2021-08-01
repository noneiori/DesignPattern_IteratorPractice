using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_IteratorPractice
{
    class ArrayIterator : Iterator
    {
        int position = 0;
        private Book[] books;

        public ArrayIterator(Book[] books)
        {
            this.books = books;
        }

        public bool hasNext()
        {
            if (position >= books.Length || books[position] == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public object next()
        {
            var result = books[position];
            position++;
            return result;

        }

        public void remove()
        {
            throw new NotImplementedException();
        }
    }
}
