using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookCatalogue.Models
{
    public class Books
    {
        
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        [ForeignKey("Categories")]
        public string Category { get; set; }

        public virtual Category Categories { get; set; }
    }
}
