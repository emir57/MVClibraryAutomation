using System.Collections.Generic;
using libraryMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace libraryMVC_.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        public DbSet<Kitap> Kitaplar{get;set;}
        public DbSet<Uye> Uyeler{get;set;}
        public DbSet<Emanet> Emanetler{get;set;}
        
    }
}