using System;
using System.Collections.Generic;
using System.Text;
using BookManagement_Joban_6th.BussinessModel;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BookManagement_Joban_6th.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Price> Prices { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}
