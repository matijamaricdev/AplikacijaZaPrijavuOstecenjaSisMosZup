using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AplikacijaZaPrijavuOstecenjaSisMosZup.Models
{
    public class RazinaOstecenja
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public ICollection<Prijavitelj> Prijavitelj { get; set; }
    }
}
