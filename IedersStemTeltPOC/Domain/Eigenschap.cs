using System.Collections.Generic;

namespace IST.BL.Domain
{
    //Domain class Eigenschap
    //bv gezinssituatie:kinderen/geen kinderen ; geslacht:man/vrouw;...
    public class Eigenschap
    {
        public int EigenschapId { get; set; }
        public string EigenschapNaam { get; set; }
        public ICollection<string> Mogelijkheden { get; set; }


        //noodzakelijk?? zie Voorwaarde-klasse // correct?? Voorwaarde abstract?
        public ICollection<Voorwaarde> Voorwaarden { get; set; }
    }
}