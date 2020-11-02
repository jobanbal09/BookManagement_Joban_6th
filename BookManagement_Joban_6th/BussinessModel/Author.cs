using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookManagement_Joban_6th.BussinessModel
{
    public class Author
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Book> Books { get; set; }

    }
}
