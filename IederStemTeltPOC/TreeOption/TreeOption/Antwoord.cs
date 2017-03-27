using System.Collections.Generic;

namespace TreeOption
{
    public class Antwoord
    {
        public int AntwoordId { get; set; }

        //kernteksten voor evt in cirkels weer te geven?
        public string AntwoordKernTekst { get; set; }

        public string AntwoordTekst { get; set; }

        public Vraag Vraag { get; set; }

        public IList<Resultaat> Resultaten { get; set; }
    }
}