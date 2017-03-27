using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace IST.BL.Domain
{
    public class Resultaat
    {
        public int ResultaatId { get; set; }

        public string ResultaatTekst { get; set; }
        public string ResultaatImageUrl { get; set; }

        //waarde tussen 0-100: percentage
        [Range(0,100)]
        public short Kans { get; set; }

        public Antwoord Antwoord { get; set; }

        public ICollection<ResultaatVoorwaarde> Voorwaarden { get; set; }

    }
}