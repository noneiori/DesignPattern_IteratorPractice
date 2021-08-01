using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_IteratorPractice
{
    class ArrayBooks : IMenu
    {
        const int MAX_NUMS = 2;
        private int NumberOfItems = 0;
        public Book[] books;

        public ArrayBooks()
        {
            books =  new Book[MAX_NUMS];

            AddItem("Machine Learning", (decimal)47.6);

            AddItem("Data Struct", (decimal)30);
        }

        private void AddItem(string v1, decimal v2)
        {
            var book = new Book(v1, v2);
            if (NumberOfItems >= MAX_NUMS)
            {
                Console.WriteLine("Error!! Max items!");
            }
            else
            {
                books[NumberOfItems] = book;
                NumberOfItems++;
            }
        }

        public Iterator GetIterator()
        {
            return new ArrayIterator(books);
        }
    }
}
