using System.Collections.Generic;

namespace IST.BL.Domain
{
    public class Resultaat
    {
        public int ResultaatId { get; set; }

        public string ResultaatTekst { get; set; }
        public string ResultaatImageUrl { get; set; }
        //todo: waarde tussen o-1 // of vervangen door int tussen 0-100?
        public double Kans { get; set; }

        public Antwoord Antwoord { get; set; }

        public ICollection<ResultaatVoorwaarde> Voorwaarden { get; set; }
    }
}