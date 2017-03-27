using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IST.BL.Domain;
using IST.DAL;

namespace IST.BL
{
    public class GebruikerManager : IGebruikerManager
    {
        private readonly IGebruikerRepository repo;

        public GebruikerManager()
        {
            repo = new GebruikerRepository();
        }

        public Partij AddPartij(int partijId, string partijNaam, string partijLogoUrl, ICollection<PartijStandpunt> partijStandpunten, Gemeente gemeente)
        {
            Partij p = new Partij()
            {
                PartijId = partijId,
                PartijNaam = partijNaam,
                PartijLogoUrl = partijLogoUrl,
                PartijStandpunten = partijStandpunten,
                Gemeente = gemeente
            };

            return repo.CreatePartij(p);
        }

        public Personage AddPersonage(int personageId, string personageImageUrl, int score, ICollection<PersonageVoorwaarde> voorwaarden)
        {
            Personage p = new Personage()
            {
                PersonageId = personageId,
                PersonageImageUrl = personageImageUrl,
                Score = score,
                Voorwaarden = voorwaarden
            };

            return repo.CreatePersonage(p);
        }
    }
}
