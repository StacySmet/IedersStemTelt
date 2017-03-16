using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IST.BL.Domain;

namespace IST.DAL
{
    public class GebruikerRepository : IGebruikerRepository
    {
        private List<Personage> personages;
        private List<Partij> partijen;

        public Partij CreatePartij(Partij partij)
        {
            partij.PartijId = partijen.Count + 1;
            partijen.Add(partij);
            return partij;
        }

        public Personage CreatePersonage(Personage personage)
        {
            personage.PersonageId = personages.Count + 1;
            personages.Add(personage);
            return personage;
        }
    }
}
