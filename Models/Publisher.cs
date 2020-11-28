using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asaftei_Nicoleta_Lab8.Models
{
    public class Publisher
    {
        public int Id { get; set; }
        public string PublisherName { get; set;}
        public ICollection<Book> Books { get; set; }
    }
}
