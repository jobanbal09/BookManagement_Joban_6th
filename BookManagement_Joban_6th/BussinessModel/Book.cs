using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookManagement_Joban_6th.BussinessModel
{
    public class Book
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int AuthorID { get; set; }
        public int PriceID { get; set; }
        public Author Author { get; set; }
        public Price Price { get; set; }
    }
}
