using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_IteratorPractice
{
    interface Iterator
    {
        bool hasNext();
        object next();

        void remove();
    }
}
