using System.Collections.Generic;
using libraryMVC.Entities;
using libraryMVC.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace libraryMVC_.Data
{
    public class AppDbContext : IdentityDbContext<Uye>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        public DbSet<Kitap> Kitaplar{get;set;}
        public DbSet<Emanet> Emanetler{get;set;}
        
    }
}