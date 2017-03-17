using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IST.BL.Domain
{
    public class Thema
    {
        public int ThemaId { get; set; }
        public string ThemaNaam { get; set; }
        public string ThemaTekst{ get; set; }
        public string ThemaImageUrl { get; set; }

        public ICollection<Vraag> Vragen { get; set; }
        public ICollection<PartijStandpunt> Standpunten { get; set; }
    }
}
