using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookCatalogue.Models
{
    public class Category
    {
        [Key]
        public string NameToken { get; set; }
        public string Description { get; set; }
        [ForeignKey("CategoryType")]
        public string Type { get; set; }

        public virtual CategoryType CategoryType { get; set; }
    }
}
