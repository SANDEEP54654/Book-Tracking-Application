using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookCatalogue.Models
{
    public class BookDbContext : DbContext
    {

        // Configured to Scaffold the Item 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           //optionsBuilder.UseSqlServer(@"Data Source=(localdb)\\v11.0;Initial Catalog=BooksCatalogue;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        public BookDbContext(DbContextOptions<BookDbContext> options)
            : base(options)
        { }
        

        public DbSet<Books> Books { get; set; }
    }
}
