using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IST.BL.Domain
{
    public class Vraag
    {
        public int VraagId { get; set; }

        //kernteksten voor evt in cirkels weer te geven?
        public string VraagKernTekst { get; set; }

        public string VraagTekst { get; set; }
        public string VraagImageUrl { get; set; }

        public ICollection<Antwoord> Antwoorden { get; set; }
        public ICollection<VraagVoorwaarde> Voorwaarden { get; set; }
        public Thema Thema { get; set; }
    }
}
