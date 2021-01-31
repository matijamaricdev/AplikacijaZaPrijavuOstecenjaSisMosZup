using System;
using System.Collections.Generic;
using System.Text;
using AplikacijaZaPrijavuOstecenjaSisMosZup.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AplikacijaZaPrijavuOstecenjaSisMosZup.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<RazinaOstecenja>().HasData(
                new RazinaOstecenja { Id = 1, Ime = "Krov se pomaknuo" },
                new RazinaOstecenja { Id = 2, Ime = "Crijep se pomaknuo" },
                new RazinaOstecenja { Id = 3, Ime = "Jedan unutarnji zid kuće ili stana je popucao" },
                new RazinaOstecenja { Id = 4, Ime = "Više unutarnjih zidova kuće ili stana je popucano" },
                new RazinaOstecenja { Id = 5, Ime = "Jedan vanjski zid kuće ili stana je popucao" },
                new RazinaOstecenja { Id = 6, Ime = "Više vanjskih zidova kuće ili stana je popucano" },
                new RazinaOstecenja { Id = 7, Ime = "Krov je srušen" },
                new RazinaOstecenja { Id = 8, Ime = "Srušen je krov i četvrtina kuće" },
                new RazinaOstecenja { Id = 9, Ime = "Srušen je krov i pola kuće" },
                new RazinaOstecenja { Id = 10, Ime = "Srušen je krov i cijela kuća" }
            );
        }

        public DbSet<Prijavitelj> Prijavitelj { get; set; }
        public DbSet<RazinaOstecenja> RazinaOstecenja { get; set; }
    }
}
