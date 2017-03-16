using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IST.BL.Domain
{
    public class Personage
    {
        public int PersonageId { get; set; }
        public string PersonageImageUrl { get; set; }
        public int Score { get; set; }
        public ICollection<PersonageVoorwaarde> Voorwaarden { get; set; }
    }
}
