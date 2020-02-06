using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcBooks.Models;

namespace MvcBooks.Data
{
    //Context for the DB
    public class MvcBookContext : DbContext
    {
        public MvcBookContext(DbContextOptions<MvcBookContext> options)
            : base(options)
        {
        }

        public DbSet<Books> Books { get; set; }
    }
}
