using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_dars_CRUD.Models
{
    public class Book
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime PublicationDate { get; set; }
        public string Description { get; set; }
        public int PageNumber { get; set; }
        public int Price { get; set; }
        public string AuthorsName { get; set; }
        public string ReadesrName { get; set; }
    }
}
