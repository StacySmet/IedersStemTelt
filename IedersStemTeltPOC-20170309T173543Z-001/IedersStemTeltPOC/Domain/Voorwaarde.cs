using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IST.BL.Domain
{
    //abstract Domain Class Voorwaarde + 3 subclasses: VraagVoorwaarde - ResultaatVoorwaarde - PersonageVoorwaarde
    //Voorwaarde is de intermediërende klasse om veel op veel tss Vraag(/Resultaat/Personage) en Eigenschap op te lossen   
    public abstract class Voorwaarde
    {
        public int VoorwaardeId { get; set; }
        public Eigenschap Eigenschap { get; set; }
        public string Waarde { get; set; }
    }


    public class VraagVoorwaarde : Voorwaarde
    {
        public Vraag Vraag { get; set; }
    }


    public class ResultaatVoorwaarde : Voorwaarde
    {
        public Resultaat Resultaat { get; set; }
    }


    public class PersonageVoorwaarde : Voorwaarde
    {
        public Personage Personage { get; set; }
    }
}
