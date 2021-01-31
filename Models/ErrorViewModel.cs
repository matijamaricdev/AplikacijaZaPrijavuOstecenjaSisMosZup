using System;

namespace AplikacijaZaPrijavuOstecenjaSisMosZup.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
