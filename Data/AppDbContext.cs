using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CineTurbo.Models;
using Microsoft.EntityFrameworkCore;

namespace CineTurbo.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options){}

        public DbSet<Filme> CineTurboDB { get; set; }
    }
}