using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AplikacijaZaPrijavuOstecenjaSisMosZup.Models
{
    public class Prijavitelj
    {
        //Unique Id
        [Key]
        public int Id { get; set; } 
        public string Ime { get; set; } // Name
        public string Prezime { get; set; } // Surname
        public short Broj_Godina { get; set; } // How many years person have
        public double OIB { get; set; } // Personal ID number
        public string Selo_Grad { get; set; } // Village or city
        public string Adresa { get; set; } // Address
        public RazinaOstecenja RazinaOstecenja { get; set; } // Level of damage
        public int RazinaOstecenjaId { get; set; } // Level of damage Id
        public string Email { get; set; } // Email
        public int Kontakt_Broj { get; set; } // Contact number
    }
}
