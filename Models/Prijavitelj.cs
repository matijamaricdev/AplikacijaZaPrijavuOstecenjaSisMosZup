using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AplikacijaZaPrijavuOstecenjaSisMosZup.Models
{
    public class Prijavitelj
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public short Broj_Godina { get; set; }
        public double OIB { get; set; }
        public string Selo_Grad { get; set; }
        public string Adresa { get; set; }
        public RazinaOstecenja RazinaOstecenja { get; set; }
        public int RazinaOstecenjaId { get; set; }
        public string Email { get; set; }
        public int Kontakt_Broj { get; set; }
    }
}
