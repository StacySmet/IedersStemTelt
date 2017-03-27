using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IST.BL.Domain
{
    public class Partij
    {
        public int PartijId { get; set; }
        public string PartijNaam { get; set; }
        public string PartijLogoUrl { get; set; }
        public ICollection<PartijStandpunt> PartijStandpunten { get; set; }
        public Gemeente Gemeente { get; set; }

        //todo: Partijgroep uitwerken
        //public Partij PartijGroep { get; set; }
    }
}
