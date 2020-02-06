using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcBooks.Models
{
    public class Books
    {
        //This is the layout for the "BOOK" object in the database

        public int ID { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public Boolean read { get; set; }
    }
}
