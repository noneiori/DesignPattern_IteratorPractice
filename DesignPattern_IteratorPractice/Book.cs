using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_IteratorPractice
{
    class Book
    {
        

        public Book(string v1, decimal v2)
        {
            this.Name = v1;
            this.Price = v2;
        }

        string Name { get; set; }
        decimal Price { get; set; }

        public override string ToString()
        {
            return "Name:" + this.Name + ",Price:" + this.Price;
        }
    }
}
