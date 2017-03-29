using System.Collections.Generic;

namespace IST.BL.Domain
{
    //Domain class Eigenschap
    //bv gezinssituatie:kinderen/geen kinderen ; geslacht:man/vrouw;...
    public class Eigenschap
    {
        public int EigenschapId { get; set; }
        public string EigenschapNaam { get; set; }
        public string Value { get; set; }


        //noodzakelijk?? zie Voorwaarde-klasse // correct?? Voorwaarde abstract?  // mss beter 3 lijsten met subklassen?
        public ICollection<Voorwaarde> Voorwaarden { get; set; }
    }
}