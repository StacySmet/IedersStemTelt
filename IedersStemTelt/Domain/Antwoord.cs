using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IST.BL.Domain
{

    //domain class Antwoord : bij personavragen de gewone antwoordklasse gebruiken, bij keuzevragen de afgeleide klassen KeuzeAntwoord
    public class Antwoord
    {
        public int AntwoordId { get; set; }

        //kernteksten voor evt in cirkels weer te geven?
        public string AntwoordKernTekst { get; set; }

        public string AntwoordTekst { get; set; }

        public Vraag Vraag { get; set; }
        
    }


    //subclass: om voor- en nadelen en resultaten toe te voegen bij de keuzevragen
    public class KeuzeAntwoord : Antwoord
    {
        public string Voordelen { get; set; }
        public string Nadelen { get; set; }

        public ICollection<Resultaat> Resultaten { get; set; }
    }

}
