using System;
using System.Collections.Generic;

namespace TreeOption
{
    public class Resultaat
    {
        public int ResultaatId { get; set; }

        public string ResultaatTekst { get; set; }
        public string ResultaatImageUrl { get; set; }
        //todo: waarde tussen o-1 // of vervangen door int tussen 0-100?
        public int Kans { get; set; }

        public Antwoord Antwoord { get; set; }

        public ICollection<Voorwaarde> Voorwaarden { get; set; }
        public Voorwaarde ConditionSetter { get; set; }
        public Boolean IsEindResultaat { get; set; }

    }
}